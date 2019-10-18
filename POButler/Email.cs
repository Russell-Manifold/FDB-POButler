using System;
using System.Collections.Generic;

namespace POButler
{
    [Serializable()]
    public class Email
    {
        public Email()
        {
            Attachments = new List<Attachment>();
        }
        public int MessageNumber
        {
            get
            {
                return m_MessageNumber;
            }
            set
            {
                m_MessageNumber = value;
            }
        }
        private int m_MessageNumber;
        public string From
        {
            get
            {
                return m_From;
            }
            set
            {
                m_From = value;
            }
        }
        private string m_From;
        public string Subject
        {
            get
            {
                return m_Subject;
            }
            set
            {
                m_Subject = value;
            }
        }
        private string m_Subject;
        public string Body
        {
            get
            {
                return m_Body;
            }
            set
            {
                m_Body = value;
            }
        }
        private string m_Body;
        public DateTime DateSent
        {
            get
            {
                return m_DateSent;
            }
            set
            {
                m_DateSent = value;
            }
        }
        private DateTime m_DateSent;
        public List<Attachment> Attachments
        {
            get
            {
                return m_Attachments;
            }
            set
            {
                m_Attachments = value;
            }
        }
        private List<Attachment> m_Attachments;
    }

    [Serializable()]
    public class Attachment
    {
        public string FileName
        {
            get
            {
                return m_FileName;
            }
            set
            {
                m_FileName = value;
            }
        }
        private string m_FileName;
        public string ContentType
        {
            get
            {
                return m_ContentType;
            }
            set
            {
                m_ContentType = value;
            }
        }
        private string m_ContentType;
        public byte[] Content
        {
            get
            {
                return m_Content;
            }
            set
            {
                m_Content = value;
            }
        }
        private byte[] m_Content;
    }
}
