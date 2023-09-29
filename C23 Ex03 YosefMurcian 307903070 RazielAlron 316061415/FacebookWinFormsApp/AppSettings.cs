using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public Point LastWindowPoint { get; set; }
        public Size LastWindowSize { get; set; }
        public FormWindowState LastWindowState { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }

        private readonly string sr_FileName;

        public AppSettings()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
        }
        
        public void SaveToFile()
        {
            using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }

        public AppSettings FromFileOrDefault()
        {
            AppSettings loadedThis = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    loadedThis = (AppSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                loadedThis = new AppSettings()
                {
                    RememberUser = false,
                    LastWindowSize = new Size(800, 500),

                    LastWindowState = FormWindowState.Normal
                };
            }

            return loadedThis;
        }
    }

}
