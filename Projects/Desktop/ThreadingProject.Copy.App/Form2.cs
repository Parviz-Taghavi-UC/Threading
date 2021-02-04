using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingProject.Copy.App
{
    public partial class Form2 : Form
    {

        private delegate void SafeCallProgressbar1Delegate(int prc);

        private delegate void SafeCallProgressbar2Delegate(int prc);

        private delegate void SafeCallProgressbar3Delegate(int prc);

        private delegate void SafeCallProgressbar4Delegate(int prc);


        private delegate void SafeCallLabel1Delegate(string prc);

        private delegate void SafeCallLabel2Delegate(string prc);

        private delegate void SafeCallLabel3Delegate(string prc);

        private delegate void SafeCallLabel4Delegate(string prc);


        public string File1 { get; set; }
        public string File2 { get; set; }
        public string File3 { get; set; }
        public string File4 { get; set; }


        public string Folder1 { get; set; }
        public string Folder2 { get; set; }
        public string Folder3 { get; set; }
        public string Folder4 { get; set; }


        public Form2()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            for (int i = 0; i < 4; i++)
            {
                string fileDir = (i == 0 ? File1 : i == 1 ? File2 : i == 2 ? File3 : File4);
                string folderDir = (i == 0 ? Folder1 : i == 1 ? Folder2 : i == 2 ? Folder3 : Folder4);

                Thread thread = new Thread(new ParameterizedThreadStart((obj) =>
                {
                    var parameters = obj as Tuple<int>;
                    using (FileStream file = File.Open(fileDir, FileMode.Open))
                    {
                        file.Seek(0, SeekOrigin.Begin);
                        byte[] buffer = new byte[64];
                        byte[] writeBuffer = new byte[64];
                        using (FileStream toFile = File.Open(Path.Combine(folderDir, new FileInfo(fileDir).Name), FileMode.OpenOrCreate))
                        {
                            while (file.Read(buffer, 0, buffer.Length) > 0)
                            {
                                toFile.Write(buffer, 0, buffer.Length);
                                decimal prc = (decimal)file.Position / (decimal)file.Length * 100;
                                string formattedPrc = prc == 100 ? "100%" : string.Format("{0:F2}%", prc);
                                switch (parameters.Item1)
                                {
                                    case 0:
                                        SetProgressbar1Safe((int)prc);
                                        SetLabel1Safe(formattedPrc);
                                        break;
                                    case 1:
                                        SetProgressbar2Safe((int)prc);
                                        SetLabel2Safe(formattedPrc);
                                        break;
                                    case 2:
                                        SetProgressbar3Safe((int)prc);
                                        SetLabel3Safe(formattedPrc);
                                        break;
                                    case 3:
                                        SetProgressbar4Safe((int)prc);
                                        SetLabel4Safe(formattedPrc);
                                        break;
                                }
                            }
                        }
                    }
                }));
                thread.Start(new Tuple<int>(i));
            }
        }

        #region Progressbar

        private void SetProgressbar1Safe(int prc)
        {
            if (progressBarTo1.InvokeRequired)
            {
                var safeCallDelegate = new SafeCallProgressbar1Delegate(SetProgressbar1Safe);
                progressBarTo1.Invoke(safeCallDelegate, new object[] { prc });
            }
            else
            {
                progressBarTo1.Value = prc;
            }
        }

        private void SetProgressbar2Safe(int prc)
        {
            if (progressBarTo2.InvokeRequired)
            {
                var safeCallDelegate = new SafeCallProgressbar2Delegate(SetProgressbar2Safe);
                progressBarTo2.Invoke(safeCallDelegate, new object[] { prc });
            }
            else
            {
                progressBarTo2.Value = prc;
            }
        }

        private void SetProgressbar3Safe(int prc)
        {
            if (progressBarTo3.InvokeRequired)
            {
                var safeCallDelegate = new SafeCallProgressbar3Delegate(SetProgressbar3Safe);
                progressBarTo3.Invoke(safeCallDelegate, new object[] { prc });
            }
            else
            {
                progressBarTo3.Value = prc;
            }
        }

        private void SetProgressbar4Safe(int prc)
        {
            if (progressBarTo4.InvokeRequired)
            {
                var safeCallDelegate = new SafeCallProgressbar4Delegate(SetProgressbar4Safe);
                progressBarTo4.Invoke(safeCallDelegate, new object[] { prc });
            }
            else
            {
                progressBarTo4.Value = prc;
            }
        }

        #endregion

        #region Label

        private void SetLabel1Safe(string prc)
        {
            if (labelTo1.InvokeRequired)
            {
                var safeCallDelegate = new SafeCallLabel1Delegate(SetLabel1Safe);
                labelTo1.Invoke(safeCallDelegate, new object[] { prc });
            }
            else
            {
                labelTo1.Text = prc;
            }
        }

        private void SetLabel2Safe(string prc)
        {
            if (labelTo2.InvokeRequired)
            {
                var safeCallDelegate = new SafeCallLabel2Delegate(SetLabel2Safe);
                labelTo2.Invoke(safeCallDelegate, new object[] { prc });
            }
            else
            {
                labelTo2.Text = prc;
            }
        }

        private void SetLabel3Safe(string prc)
        {
            if (labelTo3.InvokeRequired)
            {
                var safeCallDelegate = new SafeCallLabel3Delegate(SetLabel3Safe);
                labelTo3.Invoke(safeCallDelegate, new object[] { prc });
            }
            else
            {
                labelTo3.Text = prc;
            }
        }

        private void SetLabel4Safe(string prc)
        {
            if (labelTo3.InvokeRequired)
            {
                var safeCallDelegate = new SafeCallLabel4Delegate(SetLabel4Safe);
                labelTo4.Invoke(safeCallDelegate, new object[] { prc });
            }
            else
            {
                labelTo4.Text = prc;
            }
        }

        #endregion

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
