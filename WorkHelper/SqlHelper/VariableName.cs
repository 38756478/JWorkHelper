
namespace CMS.Utilities
{
    /// <summary>
    /// VariableName ��ժҪ˵����
    /// </summary>
    public class VariableName
    {
        /// <summary>
        /// ���ڶ�WebService���лỰ״̬�����жϵļ�ֵ
        /// </summary>
        public static readonly string WebServiceAuthKey = "RFSYS_WEBSVC_KEY";
        
        /// <summary>
        /// ���������֤���ֵ
        /// </summary>
        public static readonly string AuthKey = "AUTH_KEY";

        public static readonly string SessionIntervalKey = "SESSION_INTERVAL";

        #region ���ڸ�ʽ
        /// <summary>
        /// ���ڸ�ʽ���ַ���"yyyyMMdd"
        /// ��20031206
        /// </summary>
        public static readonly string YYYYMMDD = "yyyyMMdd";

        /// <summary>
        /// ���ڸ�ʽ���ַ���"yyyy-MM-dd"
        /// ��2003-12-06
        /// </summary>
        public static readonly string YYYY_MM_DD = "yyyy-MM-dd";

        /// <summary>
        /// 12Сʱ�����ڸ�ʽ���ַ���"yyyy-MM-dd hh:mm:ss"
        /// ��2003-12-06 08:29:32(���ܱ�ʾ������8ʱ������20ʱ)
        /// </summary>
        public static readonly string YYYY_MM_DD_hh_mm_ss = "yyyy-MM-dd hh:mm:ss";

        /// <summary>
        /// 24Сʱ�����ڸ�ʽ���ַ���"yyyy-MM-dd HH:mm:ss"
        /// ��2003-12-06 15:29:32
        /// </summary>
        public static readonly string YYYY_MM_DD_HH_mm_ss = "yyyy-MM-dd HH:mm:ss";
        #endregion

        #region ���ܽ���
        /// <summary>
        /// ��������㷨Ĭ�ϵ���Կ
        /// </summary>
        public static readonly string DefaultEncryptKey = "TianChi Info Tech 2003-12-23";
        #endregion

        /// <summary>
        /// �����������ļ��й����������ڵļ�ֵ
        /// </summary>
        public static readonly string LimitDate = "LimitDate";

        #region ���ݿ�
        /// <summary>
        /// �����������ļ��й���Access���ݿ�·��
        /// </summary>
        public static readonly string AccessDataBasePathKey = "AccessDataBasePath";
        /// <summary>
        /// �����������ļ��й������ݿ�������͵ļ�ֵ
        /// </summary>
        public static readonly string DBServerTypeKey = "DBType";
        /// <summary>
        /// �����������ļ��й������ݿ�����ַ�ļ�ֵ
        /// </summary>
        public static readonly string DBServerAddressKey = "DBAddress";

        /// <summary>
        /// �����������ļ��й������ݿ�����û����ļ�ֵ
        /// </summary>
        public static readonly string DBServerUserKey = "DBUserName";

        /// <summary>
        /// �����������ļ��й������ݿ��������ļ�ֵ
        /// </summary>
        public static readonly string DBServerPasswordKey = "DBPassword";
        /// <summary>
        /// �����������ļ��й������ݿ����Ƶļ�ֵ
        /// </summary>
        public static readonly string DBCataloglKey = "DBCatalog";
        #endregion

        #region ��־
        /// <summary>
        /// �����������ļ��й�����־Ŀ¼�ļ�ֵ
        /// </summary>
        public static readonly string ServerLogPathKey = "ServerLogPath";

        /// <summary>
        /// �����������ļ��й�����־����ļ�ֵ
        /// </summary>
        public static readonly string ServerLogLevelKey = "ServerLogLevel";

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public static readonly string ProjectName = "ProjectName";
        #endregion

        #region �ļ��ϴ�
        /// <summary>
        /// �ļ��ϴ�Ŀ¼
        /// </summary>
        public static readonly string FileUploadDirectory = "FileUploadDirectory";
        #endregion

        #region �ʼ�
        /// <summary>
        /// SMTP�ʼ���������ַ
        /// </summary>
        public static readonly string SMTPServer = "SMTPServer";
        /// <summary>
        /// SMTP�ʼ��������˿�
        /// </summary>
        public static readonly string SMTPServerPort = "SMTPServerPort";
        /// <summary>
        /// SMTPEnableSsl
        /// ���ʹ��GMail������Ҫ����Ϊtrue 
        /// </summary>
        public static readonly string SMTPEnableSsl = "SMTPEnableSsl";
        /// <summary>
        /// SMTP�ʼ��������û���
        /// </summary>
        public static readonly string SMTPUserID = "SMTPUserID";
        /// <summary>
        /// SMTP�ʼ��������û�����
        /// </summary>
        public static readonly string SMTPPassword = "SMTPPassword";
        /// <summary>
        /// ���󱨸�����
        /// </summary>
        public static readonly string ErrorEmail = "ErrorEmail";
        /// <summary>
        /// ֧������
        /// </summary>
        public static readonly string SupportEmail = "SupportEmail";
        #endregion

        #region WCF����
        /// <summary>
        /// WCFUserName
        /// </summary>
        public static readonly string WCFUserName = "WCFUserName";
        /// <summary>
        /// WCFPassWord
        /// </summary>
        public static readonly string WCFPassWord = "WCFPassWord";
        #endregion
        /// <summary>
        /// WCF��������ַ
        /// </summary>
        public static readonly string ServiceHost = "ServiceHost";
        /// <summary>
        /// �Ƿ����
        /// </summary>
        public static readonly string IsEncrypt = "IsEncrypt";

        #region IGotMessage
        /// <summary>
        /// ������Ƶ�ļ���ַ·��
        /// </summary>
        public static readonly string IAdd = "iAdd";
        public static readonly string IUrl = "iUrl";
        public static readonly string FfmpegExecFile = "ffmpegExecFile";
        public static readonly string ImageDir = "imageDir";
        public static readonly string VideoDir = "videoDir";
        #endregion
    }
}
