using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AutoClickTool
{
    

    public partial class Form1 : Form
    {
        private int pointCount = 1;
        private Form f1; //to get the screen shot
        private Form f2; //to get the click point
        private Point p1; //screen shot point 1
        private Point p2; //screen shot point 2
        private string loc; //image location
        private Point mousePos; //mouse click point

        //mouse input
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        public Form1()
        {
            InitializeComponent();

            f1 = new Form();
            f1.WindowState = FormWindowState.Maximized;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.TopMost = true;
            f1.Opacity = .5;
            f1.MouseUp += GetCoordinates;

            f2 = new Form();
            f2.WindowState = FormWindowState.Maximized;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.TopMost = true;
            f2.Opacity = .5;
            f2.MouseUp += GetClickCoordinates;

            listBoxActions.DisplayMember = "ActionTitle";
            listBoxActions.ValueMember = "ActionTitle";

            string html = "<form action=\"https://www.paypal.com/cgi-bin/webscr\" method=\"post\" target=\"_blank\">"+
                "<input type=\"hidden\" name=\"cmd\" value=\"_s-xclick\">" +
                "<input type=\"hidden\" name=\"hosted_button_id\" value=\"ZR66UR89CM2MJ\">" +
                "<input type=\"image\" src=\"https://www.paypalobjects.com/en_US/i/btn/btn_donate_SM.gif\" border=\"0\" name=\"submit\" alt=\"PayPal - The safer, easier way to pay online!\">" +
                "<img alt=\"\" border=\"0\" src=\"https://www.paypalobjects.com/en_US/i/scr/pixel.gif\" width=\"1\" height=\"1\">" +
                "</form>";
            webBrowser.DocumentText = html;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetMousePoints();
        }

        private void GetMousePoints()
        {
            pointCount = 1;
            f1.ShowDialog();
        }

        private void GetCoordinates(object sender, MouseEventArgs e)
        {
            Point pos = Control.MousePosition;

            switch (pointCount)
            {
                case 1:
                    txtPoint1.Text = pos.ToString();
                    p1 = pos;
                    pointCount++;
                    break;
                case 2: 
                    f1.Hide();
                    txtPoint2.Text = pos.ToString();
                    p2 = pos;
                    pointCount = 1;
                    SaveScreenShot();
                    break;
            }
        }

        private void SaveScreenShot()
        {
            while (f1.Visible)
            {
                //wait for f1 to hide
            }
            lblMessage.Text = "";

            if ((p2.Y < p1.Y) || (p2.X < p1.X))
            {
                lblMessage.Text = "First click the upper left corner then the lower right corner of your screen shot.";
                return;
            }

            if (String.IsNullOrEmpty(txtActionTitle.Text))
            {
                lblMessage.Text = "Fill in a title first.";
                return;
            }

            int height = p2.Y - p1.Y;
            int width = p2.X - p1.X;
            loc = txtSSLoc.Text + txtActionTitle.Text + ".jpg";
            Rectangle rect = new Rectangle(p1, new Size(width, height));
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            
            //if the file already exists, delete it first
            if (System.IO.File.Exists(loc))
            {
                System.IO.File.Delete(loc);
            }
            bmp.Save(loc, ImageFormat.Bmp);

            pictureBox1.ImageLocation = loc;

            mousePos = new Point(p1.X + width/2, p1.Y + height/2);
            txtClickPoint1.Text = mousePos.ToString(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //I accidentally double clicked some label and created an event and now I can't find which label that was to get rid of it :/
        }

        private void btnSetClick_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void GetClickCoordinates(object sender, MouseEventArgs e)
        {
            mousePos = Control.MousePosition;
            txtClickPoint1.Text = mousePos.ToString();
            f2.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtActionTitle.Text) || String.IsNullOrEmpty(txtPoint1.Text) || String.IsNullOrEmpty(txtPoint2.Text)
                || String.IsNullOrEmpty(loc) || String.IsNullOrEmpty(txtClickPoint1.Text))
            {
                lblSaveError.Text = "You must fill in all the fields first";
            }
            else {

                bool update = false;
                int index = 0;
                //create the Action ite
                Action a = new Action
                {
                    ActionTitle = txtActionTitle.Text,
                    ActionPoint1 = p1,
                    ActionPoint2 = p2,
                    ActionScreenShot = loc,
                    ActionMouseClick = mousePos
                };

                for (int i = 0;i<listBoxActions.Items.Count;i++)
                {
                    Action temp = (Action)listBoxActions.Items[i];
                    if (temp.ActionTitle.Equals(txtActionTitle.Text))
                    {
                        update = true;
                        index = i;
                        break;
                    }
                }

                if (update == true)
                {
                    //if this is an update, remove the current item, and add in the new one at the same index
                    listBoxActions.Items.RemoveAt(index);
                    listBoxActions.Items.Insert(index, a);
                }
                else 
                {
                    //if it's not an update, then just add the item to the end of the list
                    listBoxActions.Items.Add(a);
                }

                //clear all the values on the form and the private variables
                txtActionTitle.Clear();
                txtClickPoint1.Clear();
                txtPoint1.Clear();
                txtPoint2.Clear();
                p1 = new Point(0,0);
                p2 = new Point(0, 0);
                loc = "";
                mousePos = new Point(0, 0);
                pictureBox1.ImageLocation = "";
                lblSaveError.Text = "";
            }
        }

        private void btnOpenAction_Click(object sender, EventArgs e)
        {
            if (listBoxActions.SelectedItem != null) { 
                Action selected = (Action)listBoxActions.SelectedItem;

                txtActionTitle.Text = selected.ActionTitle;
                p1 = selected.ActionPoint1;
                txtPoint1.Text = selected.ActionPoint1.ToString();
                p2 = selected.ActionPoint2;
                txtPoint2.Text = selected.ActionPoint2.ToString();
                loc = selected.ActionScreenShot;
                pictureBox1.ImageLocation = selected.ActionScreenShot;
                mousePos = selected.ActionMouseClick;
                txtClickPoint1.Text = selected.ActionMouseClick.ToString();

                tabControl1.SelectedTab = tabAction;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxActions.SelectedItem != null)
            {
                int i = listBoxActions.SelectedIndex;
                listBoxActions.Items.RemoveAt(i);
            }
        }


        public void MoveItem(int direction)
        {
            // Checking selected item
            if (listBoxActions.SelectedItem == null || listBoxActions.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBoxActions.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBoxActions.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBoxActions.SelectedItem;

            // Removing removable element
            listBoxActions.Items.Remove(selected);
            // Insert it in new position
            listBoxActions.Items.Insert(newIndex, selected);
            // Restore selection
            listBoxActions.SetSelected(newIndex, true);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtConfigFile_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConfigFile.Text))
            {
                lblConfigName.Text = "New Configuration";
            }
            else
            {
                lblConfigName.Text = txtConfigFile.Text;
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConfigFile.Text) || String.IsNullOrEmpty(txtSSLoc.Text) 
                || String.IsNullOrEmpty(txtInterval.Text))
            {
                lblConfigError.Text = "All fields must be populated!";
                return;
            }

            //check if interval is a number
            int n; //holds the values of the converted string
            if (!int.TryParse(txtInterval.Text, out n))
            {
                lblConfigError.Text = "The Interval field must be a number!";
                return;
            }

            //no errors so clear the error label and continue
            lblConfigError.Text = "";

            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            //create root element
            XmlNode root = doc.CreateElement("root");
            doc.AppendChild(root);

            //create the config elements
            XmlNode configNode = doc.CreateElement("config");

            XmlAttribute configInterval = doc.CreateAttribute("interval");
            configInterval.Value = txtInterval.Text;
            configNode.Attributes.Append(configInterval);

            XmlAttribute configSaveLocation = doc.CreateAttribute("saveLocation");
            configSaveLocation.Value = txtSSLoc.Text;
            configNode.Attributes.Append(configSaveLocation);

            XmlAttribute configFile = doc.CreateAttribute("configFile");
            configFile.Value = txtConfigFile.Text;
            configNode.Attributes.Append(configFile);

            XmlAttribute configRandom = doc.CreateAttribute("random");
            configRandom.Value = chkboxRandom.Checked.ToString();
            configNode.Attributes.Append(configRandom);

            XmlAttribute configThrottle = doc.CreateAttribute("throttle");
            configThrottle.Value = txtThrottle.Text;
            configNode.Attributes.Append(configThrottle);

            XmlAttribute configThrottleWait = doc.CreateAttribute("throttleWait");
            configThrottleWait.Value = txtThrottleWait.Text;
            configNode.Attributes.Append(configThrottleWait);

            root.AppendChild(configNode);

            //create the action items
            XmlNode actionsNode = doc.CreateElement("actions");
            root.AppendChild(actionsNode);

            //loop through all the actions and add them one at a time
            foreach (Action a in listBoxActions.Items)
            {
                XmlNode actionNode = doc.CreateElement("action");
                
                XmlAttribute actionTitle = doc.CreateAttribute("actionTitle");
                actionTitle.Value = a.ActionTitle;
                actionNode.Attributes.Append(actionTitle);

                XmlAttribute actionPoint1x = doc.CreateAttribute("actionPoint1x");
                actionPoint1x.Value = a.ActionPoint1.X.ToString();
                actionNode.Attributes.Append(actionPoint1x);

                XmlAttribute actionPoint1y = doc.CreateAttribute("actionPoint1y");
                actionPoint1y.Value = a.ActionPoint1.Y.ToString();
                actionNode.Attributes.Append(actionPoint1y);

                XmlAttribute actionPoint2x = doc.CreateAttribute("actionPoint2x");
                actionPoint2x.Value = a.ActionPoint2.X.ToString();
                actionNode.Attributes.Append(actionPoint2x);

                XmlAttribute actionPoint2y = doc.CreateAttribute("actionPoint2y");
                actionPoint2y.Value = a.ActionPoint2.Y.ToString();
                actionNode.Attributes.Append(actionPoint2y);

                XmlAttribute actionScreenShot = doc.CreateAttribute("actionScreenShot");
                actionScreenShot.Value = a.ActionScreenShot.ToString();
                actionNode.Attributes.Append(actionScreenShot);

                XmlAttribute actionMouseClickx = doc.CreateAttribute("actionMouseClickx");
                actionMouseClickx.Value = a.ActionMouseClick.X.ToString();
                actionNode.Attributes.Append(actionMouseClickx);

                XmlAttribute actionMouseClicky = doc.CreateAttribute("actionMouseClicky");
                actionMouseClicky.Value = a.ActionMouseClick.Y.ToString();
                actionNode.Attributes.Append(actionMouseClicky);

                actionsNode.AppendChild(actionNode);

            }

            string path = Path.Combine(txtSSLoc.Text,txtConfigFile.Text + ".xml");
            doc.Save(path);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "XML Files (*.xml)|*.xml";
            browseFile.Title = "Config XML file";

            if (browseFile.ShowDialog() == DialogResult.Cancel) 
            { 
                return;
            }

            try
            {
                //we have the xml file so read the input
                XmlDocument doc = new XmlDocument();
                doc.Load(browseFile.FileName);
                
                //first load up the config file info
                XmlNodeList configList = doc.GetElementsByTagName("config");
                foreach (XmlAttribute att in configList[0].Attributes)
                {
                    if (att.Name.Equals("interval"))
                    {
                        txtInterval.Text = att.Value;
                    }
                    else if (att.Name.Equals("saveLocation"))
                    {
                        txtSSLoc.Text = att.Value;
                    }
                    else if (att.Name.Equals("configFile"))
                    {
                        txtConfigFile.Text = att.Value;
                    }
                    else if (att.Name.Equals("random"))
                    {
                        if (att.Value.Equals("True"))
                        {
                            chkboxRandom.Checked = true;
                        }
                        else
                        {
                            chkboxRandom.Checked = false;
                        }
                    }
                    else if (att.Name.Equals("throttle"))
                    {
                        txtThrottle.Text = att.Value;
                    }
                    else if (att.Name.Equals("throttleWait"))
                    {
                        txtThrottleWait.Text = att.Value;
                    }
                    else
                    {
                        //something went wrong. Dunno what attribute this would be
                    }
                }

                //now load up the actions
                XmlNodeList actionList = doc.GetElementsByTagName("action");
                foreach (XmlNode node in actionList)
                {
                    string title = "";
                    string point1x = "";
                    string point1y = "";
                    string point2x = "";
                    string point2y = "";
                    string ss = "";
                    string mousex = "";
                    string mousey = "";

                    foreach (XmlAttribute att in node.Attributes)
                    {
                        if (att.Name.Equals("actionTitle"))
                        {
                            title = att.Value;
                        }
                        else if (att.Name.Equals("actionPoint1x"))
                        {
                            point1x = att.Value;
                        }
                        else if (att.Name.Equals("actionPoint1y"))
                        {
                            point1y = att.Value;
                        }
                        else if (att.Name.Equals("actionPoint2x"))
                        {
                            point2x = att.Value;
                        }
                        else if (att.Name.Equals("actionPoint2y"))
                        {
                            point2y = att.Value;
                        }
                        else if (att.Name.Equals("actionScreenShot"))
                        {
                            ss = att.Value;
                        }
                        else if (att.Name.Equals("actionMouseClickx"))
                        {
                            mousex = att.Value;
                        }
                        else if (att.Name.Equals("actionMouseClicky"))
                        {
                            mousey = att.Value;
                        }
                        else
                        {
                            //dunno what attribute this would be?
                        }
                    }

                    Action a = new Action
                    {
                        ActionTitle = title,
                        ActionPoint1 = new Point(Convert.ToInt32(point1x),Convert.ToInt32(point1y)),
                        ActionPoint2 = new Point(Convert.ToInt32(point2x), Convert.ToInt32(point2y)),
                        ActionScreenShot = ss,
                        ActionMouseClick = new Point(Convert.ToInt32(mousex), Convert.ToInt32(mousey))
                    };

                    listBoxActions.Items.Add(a);
                }
            }
            catch (Exception)
            {
                lblConfigError.Text = "Error opening XML file";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Started";
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            backgroundLoopWorker.RunWorkerAsync();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            backgroundLoopWorker.CancelAsync();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private bool compare(Bitmap bmp1, Bitmap bmp2)
        {
            bool equals = true;
            bool flag = true;  //Inner loop isn't broken

            //Test to see if we have the same size of image
            if (bmp1.Size == bmp2.Size)
            {
                for (int x = 0; x < bmp1.Width; ++x)
                {
                    for (int y = 0; y < bmp1.Height; ++y)
                    {

                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        {
                            equals = false;
                            flag = false;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            else
            {
                equals = false;
            }
            return equals;
        }

        private void backgroundLoopWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //get the throttle time if it has been set
            bool throttle = false;
            DateTime now = DateTime.Now;
            DateTime throttleDateTime = DateTime.Now; //give this a default value for now
            TimeSpan time = new TimeSpan(0, 0, 0); //give this a default value for now
            int throttleTime = Int32.Parse(txtThrottle.Text);
            if (throttleTime > 0)
            {
                throttle = true;
                time = new TimeSpan(0, 0, throttleTime);
                throttleDateTime = now.Add(time);
            }

            while (true)
            {
                int waitTime = Int32.Parse(txtInterval.Text); //the default wait time is the specified interval but this can change depending on settings

                //check if we are throttling, if so see if it is time to pause for the throttle amount of time
                if (throttle)
                {
                    if (DateTime.Compare(DateTime.Now, throttleDateTime) > 0)
                    {
                        waitTime = Int32.Parse(txtThrottleWait.Text);//pause for the throttle wait time
                        //you also need to reset the throttle time
                        throttleDateTime = DateTime.Now.Add(time);
                    }
                    else
                    {
                        //if we are not throttling, wait for the regular interval period
                        //if the Random checkbox was checked, wait a random amount of time from 1 to the interval time
                        if (chkboxRandom.Checked)
                        {
                            Random random = new Random();
                            waitTime = random.Next(1, waitTime + 1);
                        }
                    }
                }
                else { 
                    //this is a copy paste of the code above, but I'm going to be lazy and just do it
                    //if we are not throttling, wait for the regular interval period
                    //if the Random checkbox was checked, wait a random amount of time from 1 to the interval time
                    if (chkboxRandom.Checked)
                    {
                        Random random = new Random();
                        waitTime = random.Next(1, waitTime + 1);
                    }
                }
                System.Threading.Thread.Sleep(waitTime * 1000); //wait however long is specified

                //check for cancel action
                if (backgroundLoopWorker.CancellationPending)
                {
                    //cancel the loop and break out of the method
                    e.Cancel = true;
                    return;
                }

                foreach (Action a in listBoxActions.Items)
                {
                    //first take a screenshot of what is currently on the screen at the action location
                    int height = a.ActionPoint2.Y - a.ActionPoint1.Y;
                    int width = a.ActionPoint2.X - a.ActionPoint1.X;

                    Rectangle rect = new Rectangle(a.ActionPoint1, new Size(width, height));
                    Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
                    Graphics g = Graphics.FromImage(bmp);
                    g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);

                    //compare the screenshot with the screen shot on file
                    bool same = compare(bmp, new Bitmap(a.ActionScreenShot));
                  
                    //if the two match, click where the mouse pointer is and break
                    if (same)
                    {
                        Cursor.Position = a.ActionMouseClick;
                        mouse_event(MOUSEEVENTF_LEFTDOWN, a.ActionMouseClick.X, a.ActionMouseClick.Y, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, a.ActionMouseClick.X, a.ActionMouseClick.Y, 0, 0);
                        break;
                    }
                    else
                    {
                        //if not, continue through the actions
                    }
                }
            }
        }

        private void backgroundLoopWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Not Started";
        }
    }

    class Action
    {
        public string ActionTitle { get; set; }
        public Point ActionPoint1 { get; set; }
        public Point ActionPoint2 { get; set; }
        public string ActionScreenShot { get; set; }
        public Point ActionMouseClick { get; set; }
    }
}
