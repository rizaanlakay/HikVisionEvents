using System;
using System.Runtime.InteropServices;

namespace HikVision.Event.Service
{
    /// <summary>
    /// CHCNetSDK µÄÕªÒªËµÃ÷¡£
    /// </summary>
    public class CHCNetSDK
    {
        public CHCNetSDK()
        {
            //
            // TODO: ÔÚ´Ë´¦Ìí¼Ó¹¹Ôìº¯ÊýÂß¼­
            //
        }

        //SDKÀàÐÍ
        public const int SDK_PLAYMPEG4 = 1;//²¥·Å¿â
        public const int SDK_HCNETSDK = 2;//ÍøÂç¿â

        public const int NAME_LEN = 32;//ÓÃ»§Ãû³¤¶È
        public const int PASSWD_LEN = 16;//ÃÜÂë³¤¶È
        public const int GUID_LEN = 16;      //GUID³¤¶È
        public const int DEV_TYPE_NAME_LEN = 24;      //Éè±¸ÀàÐÍÃû³Æ³¤¶È
        public const int MAX_NAMELEN = 16;//DVR±¾µØµÇÂ½Ãû
        public const int MAX_RIGHT = 32;//Éè±¸Ö§³ÖµÄÈ¨ÏÞ£¨1-12±íÊ¾±¾µØÈ¨ÏÞ£¬13-32±íÊ¾Ô¶³ÌÈ¨ÏÞ£©
        public const int SERIALNO_LEN = 48;//ÐòÁÐºÅ³¤¶È
        public const int MACADDR_LEN = 6;//macµØÖ·³¤¶È
        public const int MAX_ETHERNET = 2;//Éè±¸¿ÉÅäÒÔÌ«ÍøÂç
        public const int MAX_NETWORK_CARD = 4; //Éè±¸¿ÉÅä×î´óÍø¿¨ÊýÄ¿
        public const int PATHNAME_LEN = 128;//Â·¾¶³¤¶È

        public const int MAX_NUMBER_LEN = 32;	//ºÅÂë×î´ó³¤¶È
        public const int MAX_NAME_LEN = 128; //Éè±¸Ãû³Æ×î´ó³¤¶È

        public const int MAX_TIMESEGMENT_V30 = 8;//9000Éè±¸×î´óÊ±¼ä¶ÎÊý
        public const int MAX_TIMESEGMENT = 4;//8000Éè±¸×î´óÊ±¼ä¶ÎÊý
        public const int MAX_ICR_NUM = 8;   //×¥ÅÄ»úºìÍâÂË¹âÆ¬Ô¤ÖÃµãÊý

        public const int MAX_SHELTERNUM = 4;//8000Éè±¸×î´óÕÚµ²ÇøÓòÊý
        public const int PHONENUMBER_LEN = 32;//pppoe²¦ºÅºÅÂë×î´ó³¤¶È

        public const int MAX_DISKNUM = 16;//8000Éè±¸×î´óÓ²ÅÌÊý
        public const int MAX_DISKNUM_V10 = 8;//1.2°æ±¾Ö®Ç°°æ±¾

        public const int MAX_WINDOW_V30 = 32;//9000Éè±¸±¾µØÏÔÊ¾×î´ó²¥·Å´°¿ÚÊý
        public const int MAX_WINDOW = 16;//8000Éè±¸×î´óÓ²ÅÌÊý
        public const int MAX_VGA_V30 = 4;//9000Éè±¸×î´ó¿É½ÓVGAÊý
        public const int MAX_VGA = 1;//8000Éè±¸×î´ó¿É½ÓVGAÊý

        public const int MAX_USERNUM_V30 = 32;//9000Éè±¸×î´óÓÃ»§Êý
        public const int MAX_USERNUM = 16;//8000Éè±¸×î´óÓÃ»§Êý
        public const int MAX_EXCEPTIONNUM_V30 = 32;//9000Éè±¸×î´óÒì³£´¦ÀíÊý
        public const int MAX_EXCEPTIONNUM = 16;//8000Éè±¸×î´óÒì³£´¦ÀíÊý
        public const int MAX_LINK = 6;//8000Éè±¸µ¥Í¨µÀ×î´óÊÓÆµÁ÷Á¬½ÓÊý
        public const int MAX_ITC_EXCEPTIONOUT = 32;//×¥ÅÄ»ú×î´ó±¨¾¯Êä³ö

        public const int MAX_DECPOOLNUM = 4;//µ¥Â·½âÂëÆ÷Ã¿¸ö½âÂëÍ¨µÀ×î´ó¿ÉÑ­»·½âÂëÊý
        public const int MAX_DECNUM = 4;//µ¥Â·½âÂëÆ÷µÄ×î´ó½âÂëÍ¨µÀÊý£¨Êµ¼ÊÖ»ÓÐÒ»¸ö£¬ÆäËûÈý¸ö±£Áô£©
        public const int MAX_TRANSPARENTNUM = 2;//µ¥Â·½âÂëÆ÷¿ÉÅäÖÃ×î´óÍ¸Ã÷Í¨µÀÊý
        public const int MAX_CYCLE_CHAN = 16; //µ¥Â·½âÂëÆ÷×î´óÂÖÑ­Í¨µÀÊý
        public const int MAX_CYCLE_CHAN_V30 = 64;//×î´óÂÖÑ¯Í¨µÀÊý£¨À©Õ¹£©
        public const int MAX_DIRNAME_LENGTH = 80;//×î´óÄ¿Â¼³¤¶È

        public const int MAX_STRINGNUM_V30 = 8;//9000Éè±¸×î´óOSD×Ö·ûÐÐÊýÊý
        public const int MAX_STRINGNUM = 4;//8000Éè±¸×î´óOSD×Ö·ûÐÐÊýÊý
        public const int MAX_STRINGNUM_EX = 8;//8000¶¨ÖÆÀ©Õ¹
        public const int MAX_AUXOUT_V30 = 16;//9000Éè±¸×î´ó¸¨ÖúÊä³öÊý
        public const int MAX_AUXOUT = 4;//8000Éè±¸×î´ó¸¨ÖúÊä³öÊý
        public const int MAX_HD_GROUP = 16;//9000Éè±¸×î´óÓ²ÅÌ×éÊý
        public const int MAX_NFS_DISK = 8; //8000Éè±¸×î´óNFSÓ²ÅÌÊý

        public const int IW_ESSID_MAX_SIZE = 32;//WIFIµÄSSIDºÅ³¤¶È
        public const int IW_ENCODING_TOKEN_MAX = 32;//WIFIÃÜËø×î´ó×Ö½ÚÊý
        public const int WIFI_WEP_MAX_KEY_COUNT = 4;
        public const int WIFI_WEP_MAX_KEY_LENGTH = 33;
        public const int WIFI_WPA_PSK_MAX_KEY_LENGTH = 63;
        public const int WIFI_WPA_PSK_MIN_KEY_LENGTH = 8;
        public const int WIFI_MAX_AP_COUNT = 20;
        public const int MAX_SERIAL_NUM = 64;//×î¶àÖ§³ÖµÄÍ¸Ã÷Í¨µÀÂ·Êý
        public const int MAX_DDNS_NUMS = 10;//9000Éè±¸×î´ó¿ÉÅäddnsÊý
        public const int MAX_EMAIL_ADDR_LEN = 48;//×î´óemailµØÖ·³¤¶È
        public const int MAX_EMAIL_PWD_LEN = 32;//×î´óemailÃÜÂë³¤¶È

        public const int MAXPROGRESS = 100;//»Ø·ÅÊ±µÄ×î´ó°Ù·ÖÂÊ
        public const int MAX_SERIALNUM = 2;//8000Éè±¸Ö§³ÖµÄ´®¿ÚÊý 1-232£¬ 2-485
        public const int CARDNUM_LEN = 20;//¿¨ºÅ³¤¶È
        public const int CARDNUM_LEN_OUT = 32; //Íâ²¿½á¹¹Ìå¿¨ºÅ³¤¶È
        public const int MAX_VIDEOOUT_V30 = 4;//9000Éè±¸µÄÊÓÆµÊä³öÊý
        public const int MAX_VIDEOOUT = 2;//8000Éè±¸µÄÊÓÆµÊä³öÊý

        public const int MAX_PRESET_V30 = 256;// 9000Éè±¸Ö§³ÖµÄÔÆÌ¨Ô¤ÖÃµãÊý
        public const int MAX_TRACK_V30 = 256;// 9000Éè±¸Ö§³ÖµÄÔÆÌ¨¹ì¼£Êý
        public const int MAX_CRUISE_V30 = 256;// 9000Éè±¸Ö§³ÖµÄÔÆÌ¨Ñ²º½Êý
        public const int MAX_PRESET = 128;// 8000Éè±¸Ö§³ÖµÄÔÆÌ¨Ô¤ÖÃµãÊý 
        public const int MAX_TRACK = 128;// 8000Éè±¸Ö§³ÖµÄÔÆÌ¨¹ì¼£Êý
        public const int MAX_CRUISE = 128;// 8000Éè±¸Ö§³ÖµÄÔÆÌ¨Ñ²º½Êý 

        public const int CRUISE_MAX_PRESET_NUMS = 32;// Ò»ÌõÑ²º½×î¶àµÄÑ²º½µã 

        public const int MAX_SERIAL_PORT = 8;//9000Éè±¸Ö§³Ö232´®¿ÚÊý
        public const int MAX_PREVIEW_MODE = 8;// Éè±¸Ö§³Ö×î´óÔ¤ÀÀÄ£Ê½ÊýÄ¿ 1»­Ãæ,4»­Ãæ,9»­Ãæ,16»­Ãæ.... 
        public const int MAX_MATRIXOUT = 16;// ×î´óÄ£Äâ¾ØÕóÊä³ö¸öÊý 
        public const int LOG_INFO_LEN = 11840; // ÈÕÖ¾¸½¼ÓÐÅÏ¢ 
        public const int DESC_LEN = 16;// ÔÆÌ¨ÃèÊö×Ö·û´®³¤¶È 
        public const int PTZ_PROTOCOL_NUM = 200;// 9000×î´óÖ§³ÖµÄÔÆÌ¨Ð­ÒéÊý 

        public const int MAX_AUDIO = 1;//8000ÓïÒô¶Ô½²Í¨µÀÊý
        public const int MAX_AUDIO_V30 = 2;//9000ÓïÒô¶Ô½²Í¨µÀÊý
        public const int MAX_CHANNUM = 16;//8000Éè±¸×î´óÍ¨µÀÊý
        public const int MAX_ALARMIN = 16;//8000Éè±¸×î´ó±¨¾¯ÊäÈëÊý
        public const int MAX_ALARMOUT = 4;//8000Éè±¸×î´ó±¨¾¯Êä³öÊý
        //9000 IPC½ÓÈë
        public const int MAX_ANALOG_CHANNUM = 32;//×î´ó32¸öÄ£ÄâÍ¨µÀ
        public const int MAX_ANALOG_ALARMOUT = 32; //×î´ó32Â·Ä£Äâ±¨¾¯Êä³ö 
        public const int MAX_ANALOG_ALARMIN = 32;//×î´ó32Â·Ä£Äâ±¨¾¯ÊäÈë

        public const int MAX_IP_DEVICE = 32;//ÔÊÐí½ÓÈëµÄ×î´óIPÉè±¸Êý
        public const int MAX_IP_DEVICE_V40 = 64;//ÔÊÐí½ÓÈëµÄ×î´óIPÉè±¸Êý
        public const int MAX_IP_CHANNEL = 32;//ÔÊÐí¼ÓÈëµÄ×î¶àIPÍ¨µÀÊý
        public const int MAX_IP_ALARMIN = 128;//ÔÊÐí¼ÓÈëµÄ×î¶à±¨¾¯ÊäÈëÊý
        public const int MAX_IP_ALARMOUT = 64;//ÔÊÐí¼ÓÈëµÄ×î¶à±¨¾¯Êä³öÊý
        public const int MAX_IP_ALARMIN_V40 = 4096;    //ÔÊÐí¼ÓÈëµÄ×î¶à±¨¾¯ÊäÈëÊý
        public const int MAX_IP_ALARMOUT_V40 = 4096;    //ÔÊÐí¼ÓÈëµÄ×î¶à±¨¾¯Êä³öÊý

        public const int MAX_RECORD_FILE_NUM = 20;      // Ã¿´ÎÉ¾³ý»òÕß¿ÌÂ¼µÄ×î´óÎÄ¼þÊý

        //SDK_V31 ATM
        public const int MAX_ATM_NUM = 1;
        public const int MAX_ACTION_TYPE = 12;
        public const int ATM_FRAMETYPE_NUM = 4;
        public const int MAX_ATM_PROTOCOL_NUM = 1025;
        public const int ATM_PROTOCOL_SORT = 4;
        public const int ATM_DESC_LEN = 32;
        // SDK_V31 ATM

        /* ×î´óÖ§³ÖµÄÍ¨µÀÊý ×î´óÄ£Äâ¼ÓÉÏ×î´óIPÖ§³Ö */
        public const int MAX_CHANNUM_V30 = MAX_ANALOG_CHANNUM + MAX_IP_CHANNEL;//64
        public const int MAX_ALARMOUT_V30 = MAX_ANALOG_ALARMOUT + MAX_IP_ALARMOUT;//96
        public const int MAX_ALARMIN_V30 = MAX_ANALOG_ALARMIN + MAX_IP_ALARMIN;//160

        public const int MAX_CHANNUM_V40 = 512;
        public const int MAX_ALARMOUT_V40 = MAX_IP_ALARMOUT_V40 + MAX_ANALOG_ALARMOUT;//4128
        public const int MAX_ALARMIN_V40 = MAX_IP_ALARMIN_V40 + MAX_ANALOG_ALARMOUT;//4128

        public const int MAX_HUMAN_PICTURE_NUM = 10;   //×î´óÕÕÆ¬Êý
        public const int MAX_HUMAN_BIRTHDATE_LEN = 10;

        public const int MAX_LAYERNUMS = 32;

        public const int MAX_ROIDETECT_NUM = 8;    //Ö§³ÖµÄROIÇøÓòÊý
        public const int MAX_LANERECT_NUM = 5;    //×î´ó³µÅÆÊ¶±ðÇøÓòÊý
        public const int MAX_FORTIFY_NUM = 10;   //×î´ó²¼·À¸öÊý
        public const int MAX_INTERVAL_NUM = 4;    //×î´óÊ±¼ä¼ä¸ô¸öÊý
        public const int MAX_CHJC_NUM = 3;    //×î´ó³µÁ¾Ê¡·Ý¼ò³Æ×Ö·û¸öÊý
        public const int MAX_VL_NUM = 5;    //×î´óÐéÄâÏßÈ¦¸öÊý
        public const int MAX_DRIVECHAN_NUM = 16;   //×î´ó³µµÀÊý
        public const int MAX_COIL_NUM = 3;    //×î´óÏßÈ¦¸öÊý
        public const int MAX_SIGNALLIGHT_NUM = 6;   //×î´óÐÅºÅµÆ¸öÊý
        public const int LEN_32 = 32;
        public const int LEN_31 = 31;
        public const int MAX_CABINET_COUNT = 8;    //×î´óÖ§³Ö»ú¹ñÊýÁ¿
        public const int MAX_ID_LEN = 48;
        public const int MAX_PARKNO_LEN = 16;
        public const int MAX_ALARMREASON_LEN = 32;
        public const int MAX_UPGRADE_INFO_LEN = 48; //»ñÈ¡Éý¼¶ÎÄ¼þÆ¥ÅäÐÅÏ¢(Ä£ºýÉý¼¶)
        public const int MAX_CUSTOMDIR_LEN = 32; //×Ô¶¨ÒåÄ¿Â¼³¤¶È

        public const int MAX_TRANSPARENT_CHAN_NUM = 4;   //Ã¿¸ö´®¿ÚÔÊÐí½¨Á¢µÄ×î´óÍ¸Ã÷Í¨µÀÊý
        public const int MAX_TRANSPARENT_ACCESS_NUM = 4;   //Ã¿¸ö¼àÌý¶Ë¿ÚÔÊÐí½ÓÈëµÄ×î´óÖ÷»úÊý

        //ITS
        public const int MAX_PARKING_STATUS = 8;    //³µÎ»×´Ì¬ 0´ú±íÎÞ³µ£¬1´ú±íÓÐ³µ£¬2´ú±íÑ¹Ïß(ÓÅÏÈ¼¶×î¸ß), 3ÌØÊâ³µÎ» 
        public const int MAX_PARKING_NUM = 4;    //Ò»¸öÍ¨µÀ×î´ó4¸ö³µÎ» (´Ó×óµ½ÓÒ³µÎ» Êý×é0¡«3)

        public const int MAX_ITS_SCENE_NUM = 16;   //×î´ó³¡¾°ÊýÁ¿
        public const int MAX_SCENE_TIMESEG_NUM = 16;   //×î´ó³¡¾°Ê±¼ä¶ÎÊýÁ¿
        public const int MAX_IVMS_IP_CHANNEL = 128;  //×î´óIPÍ¨µÀÊý
        public const int DEVICE_ID_LEN = 48;   //Éè±¸±àºÅ³¤¶È
        public const int MONITORSITE_ID_LEN = 48;   //¼à²âµã±àºÅ³¤¶È
        public const int MAX_AUXAREA_NUM = 16;   //¸¨ÖúÇøÓò×î´óÊýÄ¿
        public const int MAX_SLAVE_CHANNEL_NUM = 16;   //×î´ó´ÓÍ¨µÀÊýÁ¿

        public const int MAX_SCH_TASKS_NUM = 10;

        public const int MAX_SERVERID_LEN = 64; //×î´ó·þÎñÆ÷IDµÄ³¤¶È
        public const int MAX_SERVERDOMAIN_LEN = 128; //·þÎñÆ÷ÓòÃû×î´ó³¤¶È
        public const int MAX_AUTHENTICATEID_LEN = 64; //ÈÏÖ¤ID×î´ó³¤¶È
        public const int MAX_AUTHENTICATEPASSWD_LEN = 32; //ÈÏÖ¤ÃÜÂë×î´ó³¤¶È
        public const int MAX_SERVERNAME_LEN = 64; //×î´ó·þÎñÆ÷ÓÃ»§Ãû 
        public const int MAX_COMPRESSIONID_LEN = 64; //±àÂëIDµÄ×î´ó³¤¶È
        public const int MAX_SIPSERVER_ADDRESS_LEN = 128; //SIP·þÎñÆ÷µØÖ·Ö§³ÖÓòÃûºÍIPµØÖ·
        //Ñ¹Ïß±¨¾¯
        public const int MAX_PlATE_NO_LEN = 32;   //³µÅÆºÅÂë×î´ó³¤¶È 2013-09-27
        public const int UPNP_PORT_NUM = 12;      //upnp¶Ë¿ÚÓ³Éä¶Ë¿ÚÊýÄ¿


        public const int MAX_LOCAL_ADDR_LEN = 96;		//SOCKS×î´ó±¾µØÍø¶Î¸öÊý
        public const int MAX_COUNTRY_NAME_LEN = 4;		//¹ú¼Ò¼òÐ´Ãû³Æ³¤¶È

        //ÂëÁ÷Á¬½Ó·½Ê½
        public const int NORMALCONNECT = 1;
        public const int MEDIACONNECT = 2;

        //Éè±¸ÐÍºÅ(´óÀà)
        public const int HCDVR = 1;
        public const int MEDVR = 2;
        public const int PCDVR = 3;
        public const int HC_9000 = 4;
        public const int HF_I = 5;
        public const int PCNVR = 6;
        public const int HC_76NVR = 8;

        //NVRÀàÐÍ
        public const int DS8000HC_NVR = 0;
        public const int DS9000HC_NVR = 1;
        public const int DS8000ME_NVR = 2;

        /*******************È«¾Ö´íÎóÂë begin**********************/
        public const int NET_DVR_NOERROR = 0;//Ã»ÓÐ´íÎó
        public const int NET_DVR_PASSWORD_ERROR = 1;//ÓÃ»§ÃûÃÜÂë´íÎó
        public const int NET_DVR_NOENOUGHPRI = 2;//È¨ÏÞ²»×ã
        public const int NET_DVR_NOINIT = 3;//Ã»ÓÐ³õÊ¼»¯
        public const int NET_DVR_CHANNEL_ERROR = 4;//Í¨µÀºÅ´íÎó
        public const int NET_DVR_OVER_MAXLINK = 5;//Á¬½Óµ½DVRµÄ¿Í»§¶Ë¸öÊý³¬¹ý×î´ó
        public const int NET_DVR_VERSIONNOMATCH = 6;//°æ±¾²»Æ¥Åä
        public const int NET_DVR_NETWORK_FAIL_CONNECT = 7;//Á¬½Ó·þÎñÆ÷Ê§°Ü
        public const int NET_DVR_NETWORK_SEND_ERROR = 8;//Ïò·þÎñÆ÷·¢ËÍÊ§°Ü
        public const int NET_DVR_NETWORK_RECV_ERROR = 9;//´Ó·þÎñÆ÷½ÓÊÕÊý¾ÝÊ§°Ü
        public const int NET_DVR_NETWORK_RECV_TIMEOUT = 10;//´Ó·þÎñÆ÷½ÓÊÕÊý¾Ý³¬Ê±
        public const int NET_DVR_NETWORK_ERRORDATA = 11;//´«ËÍµÄÊý¾ÝÓÐÎó
        public const int NET_DVR_ORDER_ERROR = 12;//µ÷ÓÃ´ÎÐò´íÎó
        public const int NET_DVR_OPERNOPERMIT = 13;//ÎÞ´ËÈ¨ÏÞ
        public const int NET_DVR_COMMANDTIMEOUT = 14;//DVRÃüÁîÖ´ÐÐ³¬Ê±
        public const int NET_DVR_ERRORSERIALPORT = 15;//´®¿ÚºÅ´íÎó
        public const int NET_DVR_ERRORALARMPORT = 16;//±¨¾¯¶Ë¿Ú´íÎó
        public const int NET_DVR_PARAMETER_ERROR = 17;//²ÎÊý´íÎó
        public const int NET_DVR_CHAN_EXCEPTION = 18;//·þÎñÆ÷Í¨µÀ´¦ÓÚ´íÎó×´Ì¬
        public const int NET_DVR_NODISK = 19;//Ã»ÓÐÓ²ÅÌ
        public const int NET_DVR_ERRORDISKNUM = 20;//Ó²ÅÌºÅ´íÎó
        public const int NET_DVR_DISK_FULL = 21;//·þÎñÆ÷Ó²ÅÌÂú
        public const int NET_DVR_DISK_ERROR = 22;//·þÎñÆ÷Ó²ÅÌ³ö´í
        public const int NET_DVR_NOSUPPORT = 23;//·þÎñÆ÷²»Ö§³Ö
        public const int NET_DVR_BUSY = 24;//·þÎñÆ÷Ã¦
        public const int NET_DVR_MODIFY_FAIL = 25;//·þÎñÆ÷ÐÞ¸Ä²»³É¹¦
        public const int NET_DVR_PASSWORD_FORMAT_ERROR = 26;//ÃÜÂëÊäÈë¸ñÊ½²»ÕýÈ·
        public const int NET_DVR_DISK_FORMATING = 27;//Ó²ÅÌÕýÔÚ¸ñÊ½»¯£¬²»ÄÜÆô¶¯²Ù×÷
        public const int NET_DVR_DVRNORESOURCE = 28;//DVR×ÊÔ´²»×ã
        public const int NET_DVR_DVROPRATEFAILED = 29;//DVR²Ù×÷Ê§°Ü
        public const int NET_DVR_OPENHOSTSOUND_FAIL = 30;//´ò¿ªPCÉùÒôÊ§°Ü
        public const int NET_DVR_DVRVOICEOPENED = 31;//·þÎñÆ÷ÓïÒô¶Ô½²±»Õ¼ÓÃ
        public const int NET_DVR_TIMEINPUTERROR = 32;//Ê±¼äÊäÈë²»ÕýÈ·
        public const int NET_DVR_NOSPECFILE = 33;//»Ø·ÅÊ±·þÎñÆ÷Ã»ÓÐÖ¸¶¨µÄÎÄ¼þ
        public const int NET_DVR_CREATEFILE_ERROR = 34;//´´½¨ÎÄ¼þ³ö´í
        public const int NET_DVR_FILEOPENFAIL = 35;//´ò¿ªÎÄ¼þ³ö´í
        public const int NET_DVR_OPERNOTFINISH = 36; //ÉÏ´ÎµÄ²Ù×÷»¹Ã»ÓÐÍê³É
        public const int NET_DVR_GETPLAYTIMEFAIL = 37;//»ñÈ¡µ±Ç°²¥·ÅµÄÊ±¼ä³ö´í
        public const int NET_DVR_PLAYFAIL = 38;//²¥·Å³ö´í
        public const int NET_DVR_FILEFORMAT_ERROR = 39;//ÎÄ¼þ¸ñÊ½²»ÕýÈ·
        public const int NET_DVR_DIR_ERROR = 40;//Â·¾¶´íÎó
        public const int NET_DVR_ALLOC_RESOURCE_ERROR = 41;//×ÊÔ´·ÖÅä´íÎó
        public const int NET_DVR_AUDIO_MODE_ERROR = 42;//Éù¿¨Ä£Ê½´íÎó
        public const int NET_DVR_NOENOUGH_BUF = 43;//»º³åÇøÌ«Ð¡
        public const int NET_DVR_CREATESOCKET_ERROR = 44;//´´½¨SOCKET³ö´í
        public const int NET_DVR_SETSOCKET_ERROR = 45;//ÉèÖÃSOCKET³ö´í
        public const int NET_DVR_MAX_NUM = 46;//¸öÊý´ïµ½×î´ó
        public const int NET_DVR_USERNOTEXIST = 47;//ÓÃ»§²»´æÔÚ
        public const int NET_DVR_WRITEFLASHERROR = 48;//Ð´FLASH³ö´í
        public const int NET_DVR_UPGRADEFAIL = 49;//DVRÉý¼¶Ê§°Ü
        public const int NET_DVR_CARDHAVEINIT = 50;//½âÂë¿¨ÒÑ¾­³õÊ¼»¯¹ý
        public const int NET_DVR_PLAYERFAILED = 51;//µ÷ÓÃ²¥·Å¿âÖÐÄ³¸öº¯ÊýÊ§°Ü
        public const int NET_DVR_MAX_USERNUM = 52;//Éè±¸¶ËÓÃ»§Êý´ïµ½×î´ó
        public const int NET_DVR_GETLOCALIPANDMACFAIL = 53;//»ñµÃ¿Í»§¶ËµÄIPµØÖ·»òÎïÀíµØÖ·Ê§°Ü
        public const int NET_DVR_NOENCODEING = 54;//¸ÃÍ¨µÀÃ»ÓÐ±àÂë
        public const int NET_DVR_IPMISMATCH = 55;//IPµØÖ·²»Æ¥Åä
        public const int NET_DVR_MACMISMATCH = 56;//MACµØÖ·²»Æ¥Åä
        public const int NET_DVR_UPGRADELANGMISMATCH = 57;//Éý¼¶ÎÄ¼þÓïÑÔ²»Æ¥Åä
        public const int NET_DVR_MAX_PLAYERPORT = 58;//²¥·ÅÆ÷Â·Êý´ïµ½×î´ó
        public const int NET_DVR_NOSPACEBACKUP = 59;//±¸·ÝÉè±¸ÖÐÃ»ÓÐ×ã¹»¿Õ¼ä½øÐÐ±¸·Ý
        public const int NET_DVR_NODEVICEBACKUP = 60;//Ã»ÓÐÕÒµ½Ö¸¶¨µÄ±¸·ÝÉè±¸
        public const int NET_DVR_PICTURE_BITS_ERROR = 61;//Í¼ÏñËØÎ»Êý²»·û£¬ÏÞ24É«
        public const int NET_DVR_PICTURE_DIMENSION_ERROR = 62;//Í¼Æ¬¸ß*¿í³¬ÏÞ£¬ ÏÞ128*256
        public const int NET_DVR_PICTURE_SIZ_ERROR = 63;//Í¼Æ¬´óÐ¡³¬ÏÞ£¬ÏÞ100K
        public const int NET_DVR_LOADPLAYERSDKFAILED = 64;//ÔØÈëµ±Ç°Ä¿Â¼ÏÂPlayer Sdk³ö´í
        public const int NET_DVR_LOADPLAYERSDKPROC_ERROR = 65;//ÕÒ²»µ½Player SdkÖÐÄ³¸öº¯ÊýÈë¿Ú
        public const int NET_DVR_LOADDSSDKFAILED = 66;//ÔØÈëµ±Ç°Ä¿Â¼ÏÂDSsdk³ö´í
        public const int NET_DVR_LOADDSSDKPROC_ERROR = 67;//ÕÒ²»µ½DsSdkÖÐÄ³¸öº¯ÊýÈë¿Ú
        public const int NET_DVR_DSSDK_ERROR = 68;//µ÷ÓÃÓ²½âÂë¿âDsSdkÖÐÄ³¸öº¯ÊýÊ§°Ü
        public const int NET_DVR_VOICEMONOPOLIZE = 69;//Éù¿¨±»¶ÀÕ¼
        public const int NET_DVR_JOINMULTICASTFAILED = 70;//¼ÓÈë¶à²¥×éÊ§°Ü
        public const int NET_DVR_CREATEDIR_ERROR = 71;//½¨Á¢ÈÕÖ¾ÎÄ¼þÄ¿Â¼Ê§°Ü
        public const int NET_DVR_BINDSOCKET_ERROR = 72;//°ó¶¨Ì×½Ó×ÖÊ§°Ü
        public const int NET_DVR_SOCKETCLOSE_ERROR = 73;//socketÁ¬½ÓÖÐ¶Ï£¬´Ë´íÎóÍ¨³£ÊÇÓÉÓÚÁ¬½ÓÖÐ¶Ï»òÄ¿µÄµØ²»¿É´ï
        public const int NET_DVR_USERID_ISUSING = 74;//×¢ÏúÊ±ÓÃ»§IDÕýÔÚ½øÐÐÄ³²Ù×÷
        public const int NET_DVR_SOCKETLISTEN_ERROR = 75;//¼àÌýÊ§°Ü
        public const int NET_DVR_PROGRAM_EXCEPTION = 76;//³ÌÐòÒì³£
        public const int NET_DVR_WRITEFILE_FAILED = 77;//Ð´ÎÄ¼þÊ§°Ü
        public const int NET_DVR_FORMAT_READONLY = 78;//½ûÖ¹¸ñÊ½»¯Ö»¶ÁÓ²ÅÌ
        public const int NET_DVR_WITHSAMEUSERNAME = 79;//ÓÃ»§ÅäÖÃ½á¹¹ÖÐ´æÔÚÏàÍ¬µÄÓÃ»§Ãû
        public const int NET_DVR_DEVICETYPE_ERROR = 80;//µ¼Èë²ÎÊýÊ±Éè±¸ÐÍºÅ²»Æ¥Åä
        public const int NET_DVR_LANGUAGE_ERROR = 81;//µ¼Èë²ÎÊýÊ±ÓïÑÔ²»Æ¥Åä
        public const int NET_DVR_PARAVERSION_ERROR = 82;//µ¼Èë²ÎÊýÊ±Èí¼þ°æ±¾²»Æ¥Åä
        public const int NET_DVR_IPCHAN_NOTALIVE = 83; //Ô¤ÀÀÊ±Íâ½ÓIPÍ¨µÀ²»ÔÚÏß
        public const int NET_DVR_RTSP_SDK_ERROR = 84;//¼ÓÔØ¸ßÇåIPCÍ¨Ñ¶¿âStreamTransClient.dllÊ§°Ü
        public const int NET_DVR_CONVERT_SDK_ERROR = 85;//¼ÓÔØ×ªÂë¿âÊ§°Ü
        public const int NET_DVR_IPC_COUNT_OVERFLOW = 86;//³¬³ö×î´óµÄip½ÓÈëÍ¨µÀÊý

        public const int NET_PLAYM4_NOERROR = 500;//no error
        public const int NET_PLAYM4_PARA_OVER = 501;//input parameter is invalid
        public const int NET_PLAYM4_ORDER_ERROR = 502;//The order of the function to be called is error
        public const int NET_PLAYM4_TIMER_ERROR = 503;//Create multimedia clock failed
        public const int NET_PLAYM4_DEC_VIDEO_ERROR = 504;//Decode video data failed
        public const int NET_PLAYM4_DEC_AUDIO_ERROR = 505;//Decode audio data failed
        public const int NET_PLAYM4_ALLOC_MEMORY_ERROR = 506;//Allocate memory failed
        public const int NET_PLAYM4_OPEN_FILE_ERROR = 507;//Open the file failed
        public const int NET_PLAYM4_CREATE_OBJ_ERROR = 508;//Create thread or event failed
        public const int NET_PLAYM4_CREATE_DDRAW_ERROR = 509;//Create DirectDraw object failed
        public const int NET_PLAYM4_CREATE_OFFSCREEN_ERROR = 510;//failed when creating off-screen surface
        public const int NET_PLAYM4_BUF_OVER = 511;//buffer is overflow
        public const int NET_PLAYM4_CREATE_SOUND_ERROR = 512;//failed when creating audio device
        public const int NET_PLAYM4_SET_VOLUME_ERROR = 513;//Set volume failed
        public const int NET_PLAYM4_SUPPORT_FILE_ONLY = 514;//The function only support play file
        public const int NET_PLAYM4_SUPPORT_STREAM_ONLY = 515;//The function only support play stream
        public const int NET_PLAYM4_SYS_NOT_SUPPORT = 516;//System not support
        public const int NET_PLAYM4_FILEHEADER_UNKNOWN = 517;//No file header
        public const int NET_PLAYM4_VERSION_INCORRECT = 518;//The version of decoder and encoder is not adapted
        public const int NET_PALYM4_INIT_DECODER_ERROR = 519;//Initialize decoder failed
        public const int NET_PLAYM4_CHECK_FILE_ERROR = 520;//The file data is unknown
        public const int NET_PLAYM4_INIT_TIMER_ERROR = 521;//Initialize multimedia clock failed
        public const int NET_PLAYM4_BLT_ERROR = 522;//Blt failed
        public const int NET_PLAYM4_UPDATE_ERROR = 523;//Update failed
        public const int NET_PLAYM4_OPEN_FILE_ERROR_MULTI = 524;//openfile error, streamtype is multi
        public const int NET_PLAYM4_OPEN_FILE_ERROR_VIDEO = 525;//openfile error, streamtype is video
        public const int NET_PLAYM4_JPEG_COMPRESS_ERROR = 526;//JPEG compress error
        public const int NET_PLAYM4_EXTRACT_NOT_SUPPORT = 527;//Don't support the version of this file
        public const int NET_PLAYM4_EXTRACT_DATA_ERROR = 528;//extract video data failed
        /*******************È«¾Ö´íÎóÂë end**********************/

        /*************************************************
        NET_DVR_IsSupport()·µ»ØÖµ
        1£­9Î»·Ö±ð±íÊ¾ÒÔÏÂÐÅÏ¢£¨Î»ÓëÊÇTRUE)±íÊ¾Ö§³Ö£»
        **************************************************/
        public const int NET_DVR_SUPPORT_DDRAW = 1;//Ö§³ÖDIRECTDRAW£¬Èç¹û²»Ö§³Ö£¬Ôò²¥·ÅÆ÷²»ÄÜ¹¤×÷
        public const int NET_DVR_SUPPORT_BLT = 2;//ÏÔ¿¨Ö§³ÖBLT²Ù×÷£¬Èç¹û²»Ö§³Ö£¬Ôò²¥·ÅÆ÷²»ÄÜ¹¤×÷
        public const int NET_DVR_SUPPORT_BLTFOURCC = 4;//ÏÔ¿¨BLTÖ§³ÖÑÕÉ«×ª»»£¬Èç¹û²»Ö§³Ö£¬²¥·ÅÆ÷»áÓÃÈí¼þ·½·¨×÷RGB×ª»»
        public const int NET_DVR_SUPPORT_BLTSHRINKX = 8;//ÏÔ¿¨BLTÖ§³ÖXÖáËõÐ¡£»Èç¹û²»Ö§³Ö£¬ÏµÍ³»áÓÃÈí¼þ·½·¨×ª»»
        public const int NET_DVR_SUPPORT_BLTSHRINKY = 16;//ÏÔ¿¨BLTÖ§³ÖYÖáËõÐ¡£»Èç¹û²»Ö§³Ö£¬ÏµÍ³»áÓÃÈí¼þ·½·¨×ª»»
        public const int NET_DVR_SUPPORT_BLTSTRETCHX = 32;//ÏÔ¿¨BLTÖ§³ÖXÖá·Å´ó£»Èç¹û²»Ö§³Ö£¬ÏµÍ³»áÓÃÈí¼þ·½·¨×ª»»
        public const int NET_DVR_SUPPORT_BLTSTRETCHY = 64;//ÏÔ¿¨BLTÖ§³ÖYÖá·Å´ó£»Èç¹û²»Ö§³Ö£¬ÏµÍ³»áÓÃÈí¼þ·½·¨×ª»»
        public const int NET_DVR_SUPPORT_SSE = 128;//CPUÖ§³ÖSSEÖ¸Áî£¬Intel Pentium3ÒÔÉÏÖ§³ÖSSEÖ¸Áî
        public const int NET_DVR_SUPPORT_MMX = 256;//CPUÖ§³ÖMMXÖ¸Áî¼¯£¬Intel Pentium3ÒÔÉÏÖ§³ÖSSEÖ¸Áî

        /**********************ÔÆÌ¨¿ØÖÆÃüÁî begin*************************/
        public const int LIGHT_PWRON = 2;// ½ÓÍ¨µÆ¹âµçÔ´
        public const int WIPER_PWRON = 3;// ½ÓÍ¨ÓêË¢¿ª¹Ø 
        public const int FAN_PWRON = 4;// ½ÓÍ¨·çÉÈ¿ª¹Ø
        public const int HEATER_PWRON = 5;// ½ÓÍ¨¼ÓÈÈÆ÷¿ª¹Ø
        public const int AUX_PWRON1 = 6;// ½ÓÍ¨¸¨ÖúÉè±¸¿ª¹Ø
        public const int AUX_PWRON2 = 7;// ½ÓÍ¨¸¨ÖúÉè±¸¿ª¹Ø 
        public const int SET_PRESET = 8;// ÉèÖÃÔ¤ÖÃµã 
        public const int CLE_PRESET = 9;// Çå³ýÔ¤ÖÃµã 

        public const int ZOOM_IN = 11;// ½¹¾àÒÔËÙ¶ÈSS±ä´ó(±¶ÂÊ±ä´ó)
        public const int ZOOM_OUT = 12;// ½¹¾àÒÔËÙ¶ÈSS±äÐ¡(±¶ÂÊ±äÐ¡)
        public const int FOCUS_NEAR = 13;// ½¹µãÒÔËÙ¶ÈSSÇ°µ÷ 
        public const int FOCUS_FAR = 14;// ½¹µãÒÔËÙ¶ÈSSºóµ÷
        public const int IRIS_OPEN = 15;// ¹âÈ¦ÒÔËÙ¶ÈSSÀ©´ó
        public const int IRIS_CLOSE = 16;// ¹âÈ¦ÒÔËÙ¶ÈSSËõÐ¡ 

        public const int TILT_UP = 21;/* ÔÆÌ¨ÒÔSSµÄËÙ¶ÈÉÏÑö */
        public const int TILT_DOWN = 22;/* ÔÆÌ¨ÒÔSSµÄËÙ¶ÈÏÂ¸© */
        public const int PAN_LEFT = 23;/* ÔÆÌ¨ÒÔSSµÄËÙ¶È×ó×ª */
        public const int PAN_RIGHT = 24;/* ÔÆÌ¨ÒÔSSµÄËÙ¶ÈÓÒ×ª */
        public const int UP_LEFT = 25;/* ÔÆÌ¨ÒÔSSµÄËÙ¶ÈÉÏÑöºÍ×ó×ª */
        public const int UP_RIGHT = 26;/* ÔÆÌ¨ÒÔSSµÄËÙ¶ÈÉÏÑöºÍÓÒ×ª */
        public const int DOWN_LEFT = 27;/* ÔÆÌ¨ÒÔSSµÄËÙ¶ÈÏÂ¸©ºÍ×ó×ª */
        public const int DOWN_RIGHT = 28;/* ÔÆÌ¨ÒÔSSµÄËÙ¶ÈÏÂ¸©ºÍÓÒ×ª */
        public const int PAN_AUTO = 29;/* ÔÆÌ¨ÒÔSSµÄËÙ¶È×óÓÒ×Ô¶¯É¨Ãè */

        public const int FILL_PRE_SEQ = 30;/* ½«Ô¤ÖÃµã¼ÓÈëÑ²º½ÐòÁÐ */
        public const int SET_SEQ_DWELL = 31;/* ÉèÖÃÑ²º½µãÍ£¶ÙÊ±¼ä */
        public const int SET_SEQ_SPEED = 32;/* ÉèÖÃÑ²º½ËÙ¶È */
        public const int CLE_PRE_SEQ = 33;/* ½«Ô¤ÖÃµã´ÓÑ²º½ÐòÁÐÖÐÉ¾³ý */
        public const int STA_MEM_CRUISE = 34;/* ¿ªÊ¼¼ÇÂ¼¹ì¼£ */
        public const int STO_MEM_CRUISE = 35;/* Í£Ö¹¼ÇÂ¼¹ì¼£ */
        public const int RUN_CRUISE = 36;/* ¿ªÊ¼¹ì¼£ */
        public const int RUN_SEQ = 37;/* ¿ªÊ¼Ñ²º½ */
        public const int STOP_SEQ = 38;/* Í£Ö¹Ñ²º½ */
        public const int GOTO_PRESET = 39;/* ¿ìÇò×ªµ½Ô¤ÖÃµã */
        /**********************ÔÆÌ¨¿ØÖÆÃüÁî end*************************/

        /*************************************************
        »Ø·ÅÊ±²¥·Å¿ØÖÆÃüÁîºê¶¨Òå 
        NET_DVR_PlayBackControl
        NET_DVR_PlayControlLocDisplay
        NET_DVR_DecPlayBackCtrlµÄºê¶¨Òå
        ¾ßÌåÖ§³Ö²é¿´º¯ÊýËµÃ÷ºÍ´úÂë
        **************************************************/
        public const int NET_DVR_PLAYSTART = 1;//¿ªÊ¼²¥·Å
        public const int NET_DVR_PLAYSTOP = 2;//Í£Ö¹²¥·Å
        public const int NET_DVR_PLAYPAUSE = 3;//ÔÝÍ£²¥·Å
        public const int NET_DVR_PLAYRESTART = 4;//»Ö¸´²¥·Å
        public const int NET_DVR_PLAYFAST = 5;//¿ì·Å
        public const int NET_DVR_PLAYSLOW = 6;//Âý·Å
        public const int NET_DVR_PLAYNORMAL = 7;//Õý³£ËÙ¶È
        public const int NET_DVR_PLAYFRAME = 8;//µ¥Ö¡·Å
        public const int NET_DVR_PLAYSTARTAUDIO = 9;//´ò¿ªÉùÒô
        public const int NET_DVR_PLAYSTOPAUDIO = 10;//¹Ø±ÕÉùÒô
        public const int NET_DVR_PLAYAUDIOVOLUME = 11;//µ÷½ÚÒôÁ¿
        public const int NET_DVR_PLAYSETPOS = 12;//¸Ä±äÎÄ¼þ»Ø·ÅµÄ½ø¶È
        public const int NET_DVR_PLAYGETPOS = 13;//»ñÈ¡ÎÄ¼þ»Ø·ÅµÄ½ø¶È
        public const int NET_DVR_PLAYGETTIME = 14;//»ñÈ¡µ±Ç°ÒÑ¾­²¥·ÅµÄÊ±¼ä(°´ÎÄ¼þ»Ø·ÅµÄÊ±ºòÓÐÐ§)
        public const int NET_DVR_PLAYGETFRAME = 15;//»ñÈ¡µ±Ç°ÒÑ¾­²¥·ÅµÄÖ¡Êý(°´ÎÄ¼þ»Ø·ÅµÄÊ±ºòÓÐÐ§)
        public const int NET_DVR_GETTOTALFRAMES = 16;//»ñÈ¡µ±Ç°²¥·ÅÎÄ¼þ×ÜµÄÖ¡Êý(°´ÎÄ¼þ»Ø·ÅµÄÊ±ºòÓÐÐ§)
        public const int NET_DVR_GETTOTALTIME = 17;//»ñÈ¡µ±Ç°²¥·ÅÎÄ¼þ×ÜµÄÊ±¼ä(°´ÎÄ¼þ»Ø·ÅµÄÊ±ºòÓÐÐ§)
        public const int NET_DVR_THROWBFRAME = 20;//¶ªBÖ¡
        public const int NET_DVR_SETSPEED = 24;//ÉèÖÃÂëÁ÷ËÙ¶È
        public const int NET_DVR_KEEPALIVE = 25;//±£³ÖÓëÉè±¸µÄÐÄÌø(Èç¹û»Øµ÷×èÈû£¬½¨Òé2Ãë·¢ËÍÒ»´Î)
        public const int NET_DVR_PLAYSETTIME = 26;//°´¾ø¶ÔÊ±¼ä¶¨Î»
        public const int NET_DVR_PLAYGETTOTALLEN = 27;//»ñÈ¡°´Ê±¼ä»Ø·Å¶ÔÓ¦Ê±¼ä¶ÎÄÚµÄËùÓÐÎÄ¼þµÄ×Ü³¤¶È
        public const int NET_DVR_PLAY_FORWARD = 29;//µ¹·ÅÇÐ»»ÎªÕý·Å
        public const int NET_DVR_PLAY_REVERSE = 30;//Õý·ÅÇÐ»»Îªµ¹·Å
        public const int NET_DVR_SET_TRANS_TYPE = 32;//ÉèÖÃ×ª·â×°ÀàÐÍ
        public const int NET_DVR_PLAY_CONVERT = 33;//Õý·ÅÇÐ»»Îªµ¹·Å

        //Ô¶³Ì°´¼ü¶¨ÒåÈçÏÂ£º
        /* key value send to CONFIG program */
        public const int KEY_CODE_1 = 1;
        public const int KEY_CODE_2 = 2;
        public const int KEY_CODE_3 = 3;
        public const int KEY_CODE_4 = 4;
        public const int KEY_CODE_5 = 5;
        public const int KEY_CODE_6 = 6;
        public const int KEY_CODE_7 = 7;
        public const int KEY_CODE_8 = 8;
        public const int KEY_CODE_9 = 9;
        public const int KEY_CODE_0 = 10;
        public const int KEY_CODE_POWER = 11;
        public const int KEY_CODE_MENU = 12;
        public const int KEY_CODE_ENTER = 13;
        public const int KEY_CODE_CANCEL = 14;
        public const int KEY_CODE_UP = 15;
        public const int KEY_CODE_DOWN = 16;
        public const int KEY_CODE_LEFT = 17;
        public const int KEY_CODE_RIGHT = 18;
        public const int KEY_CODE_EDIT = 19;
        public const int KEY_CODE_ADD = 20;
        public const int KEY_CODE_MINUS = 21;
        public const int KEY_CODE_PLAY = 22;
        public const int KEY_CODE_REC = 23;
        public const int KEY_CODE_PAN = 24;
        public const int KEY_CODE_M = 25;
        public const int KEY_CODE_A = 26;
        public const int KEY_CODE_F1 = 27;
        public const int KEY_CODE_F2 = 28;

        /* for PTZ control */
        public const int KEY_PTZ_UP_START = KEY_CODE_UP;
        public const int KEY_PTZ_UP_STOP = 32;

        public const int KEY_PTZ_DOWN_START = KEY_CODE_DOWN;
        public const int KEY_PTZ_DOWN_STOP = 33;


        public const int KEY_PTZ_LEFT_START = KEY_CODE_LEFT;
        public const int KEY_PTZ_LEFT_STOP = 34;

        public const int KEY_PTZ_RIGHT_START = KEY_CODE_RIGHT;
        public const int KEY_PTZ_RIGHT_STOP = 35;

        public const int KEY_PTZ_AP1_START = KEY_CODE_EDIT;/* ¹âÈ¦+ */
        public const int KEY_PTZ_AP1_STOP = 36;

        public const int KEY_PTZ_AP2_START = KEY_CODE_PAN;/* ¹âÈ¦- */
        public const int KEY_PTZ_AP2_STOP = 37;

        public const int KEY_PTZ_FOCUS1_START = KEY_CODE_A;/* ¾Û½¹+ */
        public const int KEY_PTZ_FOCUS1_STOP = 38;

        public const int KEY_PTZ_FOCUS2_START = KEY_CODE_M;/* ¾Û½¹- */
        public const int KEY_PTZ_FOCUS2_STOP = 39;

        public const int KEY_PTZ_B1_START = 40;/* ±ä±¶+ */
        public const int KEY_PTZ_B1_STOP = 41;

        public const int KEY_PTZ_B2_START = 42;/* ±ä±¶- */
        public const int KEY_PTZ_B2_STOP = 43;

        //9000ÐÂÔö
        public const int KEY_CODE_11 = 44;
        public const int KEY_CODE_12 = 45;
        public const int KEY_CODE_13 = 46;
        public const int KEY_CODE_14 = 47;
        public const int KEY_CODE_15 = 48;
        public const int KEY_CODE_16 = 49;

        /*************************²ÎÊýÅäÖÃÃüÁî begin*******************************/
        //ÓÃÓÚNET_DVR_SetDVRConfigºÍNET_DVR_GetDVRConfig,×¢ÒâÆä¶ÔÓ¦µÄÅäÖÃ½á¹¹
        public const int NET_DVR_GET_DEVICECFG = 100;//»ñÈ¡Éè±¸²ÎÊý
        public const int NET_DVR_SET_DEVICECFG = 101;//ÉèÖÃÉè±¸²ÎÊý
        public const int NET_DVR_GET_NETCFG = 102;//»ñÈ¡ÍøÂç²ÎÊý
        public const int NET_DVR_SET_NETCFG = 103;//ÉèÖÃÍøÂç²ÎÊý
        public const int NET_DVR_GET_PICCFG = 104;//»ñÈ¡Í¼Ïó²ÎÊý
        public const int NET_DVR_SET_PICCFG = 105;//ÉèÖÃÍ¼Ïó²ÎÊý
        public const int NET_DVR_GET_COMPRESSCFG = 106;//»ñÈ¡Ñ¹Ëõ²ÎÊý
        public const int NET_DVR_SET_COMPRESSCFG = 107;//ÉèÖÃÑ¹Ëõ²ÎÊý
        public const int NET_DVR_GET_RECORDCFG = 108;//»ñÈ¡Â¼ÏñÊ±¼ä²ÎÊý
        public const int NET_DVR_SET_RECORDCFG = 109;//ÉèÖÃÂ¼ÏñÊ±¼ä²ÎÊý
        public const int NET_DVR_GET_DECODERCFG = 110;//»ñÈ¡½âÂëÆ÷²ÎÊý
        public const int NET_DVR_SET_DECODERCFG = 111;//ÉèÖÃ½âÂëÆ÷²ÎÊý
        public const int NET_DVR_GET_RS232CFG = 112;//»ñÈ¡232´®¿Ú²ÎÊý
        public const int NET_DVR_SET_RS232CFG = 113;//ÉèÖÃ232´®¿Ú²ÎÊý
        public const int NET_DVR_GET_ALARMINCFG = 114;//»ñÈ¡±¨¾¯ÊäÈë²ÎÊý
        public const int NET_DVR_SET_ALARMINCFG = 115;//ÉèÖÃ±¨¾¯ÊäÈë²ÎÊý
        public const int NET_DVR_GET_ALARMOUTCFG = 116;//»ñÈ¡±¨¾¯Êä³ö²ÎÊý
        public const int NET_DVR_SET_ALARMOUTCFG = 117;//ÉèÖÃ±¨¾¯Êä³ö²ÎÊý
        public const int NET_DVR_GET_TIMECFG = 118;//»ñÈ¡DVRÊ±¼ä
        public const int NET_DVR_SET_TIMECFG = 119;//ÉèÖÃDVRÊ±¼ä
        public const int NET_DVR_GET_PREVIEWCFG = 120;//»ñÈ¡Ô¤ÀÀ²ÎÊý
        public const int NET_DVR_SET_PREVIEWCFG = 121;//ÉèÖÃÔ¤ÀÀ²ÎÊý
        public const int NET_DVR_GET_VIDEOOUTCFG = 122;//»ñÈ¡ÊÓÆµÊä³ö²ÎÊý
        public const int NET_DVR_SET_VIDEOOUTCFG = 123;//ÉèÖÃÊÓÆµÊä³ö²ÎÊý
        public const int NET_DVR_GET_USERCFG = 124;//»ñÈ¡ÓÃ»§²ÎÊý
        public const int NET_DVR_SET_USERCFG = 125;//ÉèÖÃÓÃ»§²ÎÊý
        public const int NET_DVR_GET_EXCEPTIONCFG = 126;//»ñÈ¡Òì³£²ÎÊý
        public const int NET_DVR_SET_EXCEPTIONCFG = 127;//ÉèÖÃÒì³£²ÎÊý
        public const int NET_DVR_GET_ZONEANDDST = 128;//»ñÈ¡Ê±ÇøºÍÏÄÊ±ÖÆ²ÎÊý
        public const int NET_DVR_SET_ZONEANDDST = 129;//ÉèÖÃÊ±ÇøºÍÏÄÊ±ÖÆ²ÎÊý
        public const int NET_DVR_GET_SHOWSTRING = 130;//»ñÈ¡µþ¼Ó×Ö·û²ÎÊý
        public const int NET_DVR_SET_SHOWSTRING = 131;//ÉèÖÃµþ¼Ó×Ö·û²ÎÊý
        public const int NET_DVR_GET_EVENTCOMPCFG = 132;//»ñÈ¡ÊÂ¼þ´¥·¢Â¼Ïñ²ÎÊý
        public const int NET_DVR_SET_EVENTCOMPCFG = 133;//ÉèÖÃÊÂ¼þ´¥·¢Â¼Ïñ²ÎÊý

        public const int NET_DVR_GET_AUXOUTCFG = 140;//»ñÈ¡±¨¾¯´¥·¢¸¨ÖúÊä³öÉèÖÃ(HSÉè±¸¸¨ÖúÊä³ö2006-02-28)
        public const int NET_DVR_SET_AUXOUTCFG = 141;//ÉèÖÃ±¨¾¯´¥·¢¸¨ÖúÊä³öÉèÖÃ(HSÉè±¸¸¨ÖúÊä³ö2006-02-28)
        public const int NET_DVR_GET_PREVIEWCFG_AUX = 142;//»ñÈ¡-sÏµÁÐË«Êä³öÔ¤ÀÀ²ÎÊý(-sÏµÁÐË«Êä³ö2006-04-13)
        public const int NET_DVR_SET_PREVIEWCFG_AUX = 143;//ÉèÖÃ-sÏµÁÐË«Êä³öÔ¤ÀÀ²ÎÊý(-sÏµÁÐË«Êä³ö2006-04-13)

        public const int NET_DVR_GET_PICCFG_EX = 200;//»ñÈ¡Í¼Ïó²ÎÊý(SDK_V14À©Õ¹ÃüÁî)
        public const int NET_DVR_SET_PICCFG_EX = 201;//ÉèÖÃÍ¼Ïó²ÎÊý(SDK_V14À©Õ¹ÃüÁî)
        public const int NET_DVR_GET_USERCFG_EX = 202;//»ñÈ¡ÓÃ»§²ÎÊý(SDK_V15À©Õ¹ÃüÁî)
        public const int NET_DVR_SET_USERCFG_EX = 203;//ÉèÖÃÓÃ»§²ÎÊý(SDK_V15À©Õ¹ÃüÁî)
        public const int NET_DVR_GET_COMPRESSCFG_EX = 204;//»ñÈ¡Ñ¹Ëõ²ÎÊý(SDK_V15À©Õ¹ÃüÁî2006-05-15)
        public const int NET_DVR_SET_COMPRESSCFG_EX = 205;//ÉèÖÃÑ¹Ëõ²ÎÊý(SDK_V15À©Õ¹ÃüÁî2006-05-15)

        public const int NET_DVR_GET_NETAPPCFG = 222;//»ñÈ¡ÍøÂçÓ¦ÓÃ²ÎÊý NTP/DDNS/EMAIL
        public const int NET_DVR_SET_NETAPPCFG = 223;//ÉèÖÃÍøÂçÓ¦ÓÃ²ÎÊý NTP/DDNS/EMAIL
        public const int NET_DVR_GET_NTPCFG = 224;//»ñÈ¡ÍøÂçÓ¦ÓÃ²ÎÊý NTP
        public const int NET_DVR_SET_NTPCFG = 225;//ÉèÖÃÍøÂçÓ¦ÓÃ²ÎÊý NTP
        public const int NET_DVR_GET_DDNSCFG = 226;//»ñÈ¡ÍøÂçÓ¦ÓÃ²ÎÊý DDNS
        public const int NET_DVR_SET_DDNSCFG = 227;//ÉèÖÃÍøÂçÓ¦ÓÃ²ÎÊý DDNS
        //¶ÔÓ¦NET_DVR_EMAILPARA
        public const int NET_DVR_GET_EMAILCFG = 228;//»ñÈ¡ÍøÂçÓ¦ÓÃ²ÎÊý EMAIL
        public const int NET_DVR_SET_EMAILCFG = 229;//ÉèÖÃÍøÂçÓ¦ÓÃ²ÎÊý EMAIL

        public const int NET_DVR_GET_NFSCFG = 230;/* NFS disk config */
        public const int NET_DVR_SET_NFSCFG = 231;/* NFS disk config */

        public const int NET_DVR_GET_SHOWSTRING_EX = 238;//»ñÈ¡µþ¼Ó×Ö·û²ÎÊýÀ©Õ¹(Ö§³Ö8Ìõ×Ö·û)
        public const int NET_DVR_SET_SHOWSTRING_EX = 239;//ÉèÖÃµþ¼Ó×Ö·û²ÎÊýÀ©Õ¹(Ö§³Ö8Ìõ×Ö·û)
        public const int NET_DVR_GET_NETCFG_OTHER = 244;//»ñÈ¡ÍøÂç²ÎÊý
        public const int NET_DVR_SET_NETCFG_OTHER = 245;//ÉèÖÃÍøÂç²ÎÊý

        //¶ÔÓ¦NET_DVR_EMAILCFG½á¹¹
        public const int NET_DVR_GET_EMAILPARACFG = 250;//Get EMAIL parameters
        public const int NET_DVR_SET_EMAILPARACFG = 251;//Setup EMAIL parameters

        public const int NET_DVR_GET_DDNSCFG_EX = 274;//»ñÈ¡À©Õ¹DDNS²ÎÊý
        public const int NET_DVR_SET_DDNSCFG_EX = 275;//ÉèÖÃÀ©Õ¹DDNS²ÎÊý

        public const int NET_DVR_SET_PTZPOS = 292;//ÔÆÌ¨ÉèÖÃPTZÎ»ÖÃ
        public const int NET_DVR_GET_PTZPOS = 293;//ÔÆÌ¨»ñÈ¡PTZÎ»ÖÃ
        public const int NET_DVR_GET_PTZSCOPE = 294;//ÔÆÌ¨»ñÈ¡PTZ·¶Î§

        public const int NET_DVR_GET_AP_INFO_LIST = 305;//»ñÈ¡ÎÞÏßÍøÂç×ÊÔ´²ÎÊý
        public const int NET_DVR_SET_WIFI_CFG = 306;//ÉèÖÃIP¼à¿ØÉè±¸ÎÞÏß²ÎÊý
        public const int NET_DVR_GET_WIFI_CFG = 307;//»ñÈ¡IP¼à¿ØÉè±¸ÎÞÏß²ÎÊý
        public const int NET_DVR_SET_WIFI_WORKMODE = 308;//ÉèÖÃIP¼à¿ØÉè±¸Íø¿Ú¹¤×÷Ä£Ê½²ÎÊý
        public const int NET_DVR_GET_WIFI_WORKMODE = 309;//»ñÈ¡IP¼à¿ØÉè±¸Íø¿Ú¹¤×÷Ä£Ê½²ÎÊý 
        public const int NET_DVR_GET_WIFI_STATUS = 310;	//»ñÈ¡Éè±¸µ±Ç°wifiÁ¬½Ó×´Ì¬
        /***************************DS9000ÐÂÔöÃüÁî(_V30) begin *****************************/
        //ÍøÂç(NET_DVR_NETCFG_V30½á¹¹)
        public const int NET_DVR_GET_NETCFG_V30 = 1000;//»ñÈ¡ÍøÂç²ÎÊý
        public const int NET_DVR_SET_NETCFG_V30 = 1001;//ÉèÖÃÍøÂç²ÎÊý

        //Í¼Ïó(NET_DVR_PICCFG_V30½á¹¹)
        public const int NET_DVR_GET_PICCFG_V30 = 1002;//»ñÈ¡Í¼Ïó²ÎÊý
        public const int NET_DVR_SET_PICCFG_V30 = 1003;//ÉèÖÃÍ¼Ïó²ÎÊý

        //Â¼ÏñÊ±¼ä(NET_DVR_RECORD_V30½á¹¹)
        public const int NET_DVR_GET_RECORDCFG_V30 = 1004;//»ñÈ¡Â¼Ïñ²ÎÊý
        public const int NET_DVR_SET_RECORDCFG_V30 = 1005;//ÉèÖÃÂ¼Ïñ²ÎÊý

        //ÓÃ»§(NET_DVR_USER_V30½á¹¹)
        public const int NET_DVR_GET_USERCFG_V30 = 1006;//»ñÈ¡ÓÃ»§²ÎÊý
        public const int NET_DVR_SET_USERCFG_V30 = 1007;//ÉèÖÃÓÃ»§²ÎÊý

        //9000DDNS²ÎÊýÅäÖÃ(NET_DVR_DDNSPARA_V30½á¹¹)
        public const int NET_DVR_GET_DDNSCFG_V30 = 1010;//»ñÈ¡DDNS(9000À©Õ¹)
        public const int NET_DVR_SET_DDNSCFG_V30 = 1011;//ÉèÖÃDDNS(9000À©Õ¹)

        //EMAIL¹¦ÄÜ(NET_DVR_EMAILCFG_V30½á¹¹)
        public const int NET_DVR_GET_EMAILCFG_V30 = 1012;//»ñÈ¡EMAIL²ÎÊý 
        public const int NET_DVR_SET_EMAILCFG_V30 = 1013;//ÉèÖÃEMAIL²ÎÊý 

        //Ñ²º½²ÎÊý (NET_DVR_CRUISE_PARA½á¹¹)
        public const int NET_DVR_GET_CRUISE = 1020;
        public const int NET_DVR_SET_CRUISE = 1021;

        //±¨¾¯ÊäÈë½á¹¹²ÎÊý (NET_DVR_ALARMINCFG_V30½á¹¹)
        public const int NET_DVR_GET_ALARMINCFG_V30 = 1024;
        public const int NET_DVR_SET_ALARMINCFG_V30 = 1025;

        //±¨¾¯Êä³ö½á¹¹²ÎÊý (NET_DVR_ALARMOUTCFG_V30½á¹¹)
        public const int NET_DVR_GET_ALARMOUTCFG_V30 = 1026;
        public const int NET_DVR_SET_ALARMOUTCFG_V30 = 1027;

        //ÊÓÆµÊä³ö½á¹¹²ÎÊý (NET_DVR_VIDEOOUT_V30½á¹¹)
        public const int NET_DVR_GET_VIDEOOUTCFG_V30 = 1028;
        public const int NET_DVR_SET_VIDEOOUTCFG_V30 = 1029;

        //µþ¼Ó×Ö·û½á¹¹²ÎÊý (NET_DVR_SHOWSTRING_V30½á¹¹)
        public const int NET_DVR_GET_SHOWSTRING_V30 = 1030;
        public const int NET_DVR_SET_SHOWSTRING_V30 = 1031;

        //Òì³£½á¹¹²ÎÊý (NET_DVR_EXCEPTION_V30½á¹¹)
        public const int NET_DVR_GET_EXCEPTIONCFG_V30 = 1034;
        public const int NET_DVR_SET_EXCEPTIONCFG_V30 = 1035;

        //´®¿Ú232½á¹¹²ÎÊý (NET_DVR_RS232CFG_V30½á¹¹)
        public const int NET_DVR_GET_RS232CFG_V30 = 1036;
        public const int NET_DVR_SET_RS232CFG_V30 = 1037;

        //ÍøÂçÓ²ÅÌ½ÓÈë½á¹¹²ÎÊý (NET_DVR_NET_DISKCFG½á¹¹)
        public const int NET_DVR_GET_NET_DISKCFG = 1038;//ÍøÂçÓ²ÅÌ½ÓÈë»ñÈ¡
        public const int NET_DVR_SET_NET_DISKCFG = 1039;//ÍøÂçÓ²ÅÌ½ÓÈëÉèÖÃ

        //Ñ¹Ëõ²ÎÊý (NET_DVR_COMPRESSIONCFG_V30½á¹¹)
        public const int NET_DVR_GET_COMPRESSCFG_V30 = 1040;
        public const int NET_DVR_SET_COMPRESSCFG_V30 = 1041;

        //»ñÈ¡485½âÂëÆ÷²ÎÊý (NET_DVR_DECODERCFG_V30½á¹¹)
        public const int NET_DVR_GET_DECODERCFG_V30 = 1042;//»ñÈ¡½âÂëÆ÷²ÎÊý
        public const int NET_DVR_SET_DECODERCFG_V30 = 1043;//ÉèÖÃ½âÂëÆ÷²ÎÊý

        //»ñÈ¡Ô¤ÀÀ²ÎÊý (NET_DVR_PREVIEWCFG_V30½á¹¹)
        public const int NET_DVR_GET_PREVIEWCFG_V30 = 1044;//»ñÈ¡Ô¤ÀÀ²ÎÊý
        public const int NET_DVR_SET_PREVIEWCFG_V30 = 1045;//ÉèÖÃÔ¤ÀÀ²ÎÊý

        //¸¨ÖúÔ¤ÀÀ²ÎÊý (NET_DVR_PREVIEWCFG_AUX_V30½á¹¹)
        public const int NET_DVR_GET_PREVIEWCFG_AUX_V30 = 1046;//»ñÈ¡¸¨ÖúÔ¤ÀÀ²ÎÊý
        public const int NET_DVR_SET_PREVIEWCFG_AUX_V30 = 1047;//ÉèÖÃ¸¨ÖúÔ¤ÀÀ²ÎÊý

        //IP½ÓÈëÅäÖÃ²ÎÊý £¨NET_DVR_IPPARACFG½á¹¹£©
        public const int NET_DVR_GET_IPPARACFG = 1048; //»ñÈ¡IP½ÓÈëÅäÖÃÐÅÏ¢ 
        public const int NET_DVR_SET_IPPARACFG = 1049;//ÉèÖÃIP½ÓÈëÅäÖÃÐÅÏ¢

        //IP½ÓÈëÅäÖÃ²ÎÊý £¨NET_DVR_IPPARACFG_V40½á¹¹£©
        public const int NET_DVR_GET_IPPARACFG_V40 = 1062; //»ñÈ¡IP½ÓÈëÅäÖÃÐÅÏ¢ 
        public const int NET_DVR_SET_IPPARACFG_V40 = 1063;//ÉèÖÃIP½ÓÈëÅäÖÃÐÅÏ¢

        //IP±¨¾¯ÊäÈë½ÓÈëÅäÖÃ²ÎÊý £¨NET_DVR_IPALARMINCFG½á¹¹£©
        public const int NET_DVR_GET_IPALARMINCFG = 1050; //»ñÈ¡IP±¨¾¯ÊäÈë½ÓÈëÅäÖÃÐÅÏ¢ 
        public const int NET_DVR_SET_IPALARMINCFG = 1051; //ÉèÖÃIP±¨¾¯ÊäÈë½ÓÈëÅäÖÃÐÅÏ¢

        //IP±¨¾¯Êä³ö½ÓÈëÅäÖÃ²ÎÊý £¨NET_DVR_IPALARMOUTCFG½á¹¹£©
        public const int NET_DVR_GET_IPALARMOUTCFG = 1052;//»ñÈ¡IP±¨¾¯Êä³ö½ÓÈëÅäÖÃÐÅÏ¢ 
        public const int NET_DVR_SET_IPALARMOUTCFG = 1053;//ÉèÖÃIP±¨¾¯Êä³ö½ÓÈëÅäÖÃÐÅÏ¢

        //Ó²ÅÌ¹ÜÀíµÄ²ÎÊý»ñÈ¡ (NET_DVR_HDCFG½á¹¹)
        public const int NET_DVR_GET_HDCFG = 1054;//»ñÈ¡Ó²ÅÌ¹ÜÀíÅäÖÃ²ÎÊý
        public const int NET_DVR_SET_HDCFG = 1055;//ÉèÖÃÓ²ÅÌ¹ÜÀíÅäÖÃ²ÎÊý

        //ÅÌ×é¹ÜÀíµÄ²ÎÊý»ñÈ¡ (NET_DVR_HDGROUP_CFG½á¹¹)
        public const int NET_DVR_GET_HDGROUP_CFG = 1056;//»ñÈ¡ÅÌ×é¹ÜÀíÅäÖÃ²ÎÊý
        public const int NET_DVR_SET_HDGROUP_CFG = 1057;//ÉèÖÃÅÌ×é¹ÜÀíÅäÖÃ²ÎÊý

        //Éè±¸±àÂëÀàÐÍÅäÖÃ(NET_DVR_COMPRESSION_AUDIO½á¹¹)
        public const int NET_DVR_GET_COMPRESSCFG_AUD = 1058;//»ñÈ¡Éè±¸ÓïÒô¶Ô½²±àÂë²ÎÊý
        public const int NET_DVR_SET_COMPRESSCFG_AUD = 1059;//ÉèÖÃÉè±¸ÓïÒô¶Ô½²±àÂë²ÎÊý

        //IP½ÓÈëÅäÖÃ²ÎÊý £¨NET_DVR_IPPARACFG_V31½á¹¹£©
        public const int NET_DVR_GET_IPPARACFG_V31 = 1060;//»ñÈ¡IP½ÓÈëÅäÖÃÐÅÏ¢ 
        public const int NET_DVR_SET_IPPARACFG_V31 = 1061; //ÉèÖÃIP½ÓÈëÅäÖÃÐÅÏ¢

        //Éè±¸²ÎÊýÅäÖÃ £¨NET_DVR_DEVICECFG_V40½á¹¹£©
        public const int NET_DVR_GET_DEVICECFG_V40 = 1100;//»ñÈ¡Éè±¸²ÎÊý
        public const int NET_DVR_SET_DEVICECFG_V40 = 1101;//ÉèÖÃÉè±¸²ÎÊý

        //¶àÍø¿¨ÅäÖÃ(NET_DVR_NETCFG_MULTI½á¹¹)
        public const int NET_DVR_GET_NETCFG_MULTI = 1161;
        public const int NET_DVR_SET_NETCFG_MULTI = 1162;

        //BONDINGÍø¿¨(NET_DVR_NETWORK_BONDING½á¹¹)
        public const int NET_DVR_GET_NETWORK_BONDING = 1254;
        public const int NET_DVR_SET_NETWORK_BONDING = 1255;

        //NATÓ³ÉäÅäÖÃ²ÎÊý £¨NET_DVR_NAT_CFG½á¹¹£©
        public const int NET_DVR_GET_NAT_CFG = 6111;    //»ñÈ¡NATÓ³Éä²ÎÊý
        public const int NET_DVR_SET_NAT_CFG = 6112;    //ÉèÖÃNATÓ³Éä²ÎÊý  
        /*************************²ÎÊýÅäÖÃÃüÁî end*******************************/

        /************************DVRÈÕÖ¾ begin***************************/
        /* ±¨¾¯ */
        //Ö÷ÀàÐÍ
        public const int MAJOR_ALARM = 1;
        //´ÎÀàÐÍ
        public const int MINOR_ALARM_IN = 1;/* ±¨¾¯ÊäÈë */
        public const int MINOR_ALARM_OUT = 2;/* ±¨¾¯Êä³ö */
        public const int MINOR_MOTDET_START = 3; /* ÒÆ¶¯Õì²â±¨¾¯¿ªÊ¼ */
        public const int MINOR_MOTDET_STOP = 4; /* ÒÆ¶¯Õì²â±¨¾¯½áÊø */
        public const int MINOR_HIDE_ALARM_START = 5;/* ÕÚµ²±¨¾¯¿ªÊ¼ */
        public const int MINOR_HIDE_ALARM_STOP = 6;/* ÕÚµ²±¨¾¯½áÊø */
        public const int MINOR_VCA_ALARM_START = 7;/*ÖÇÄÜ±¨¾¯¿ªÊ¼*/
        public const int MINOR_VCA_ALARM_STOP = 8;/*ÖÇÄÜ±¨¾¯Í£Ö¹*/

        /* Òì³£ */
        //Ö÷ÀàÐÍ
        public const int MAJOR_EXCEPTION = 2;
        //´ÎÀàÐÍ
        public const int MINOR_VI_LOST = 33;/* ÊÓÆµÐÅºÅ¶ªÊ§ */
        public const int MINOR_ILLEGAL_ACCESS = 34;/* ·Ç·¨·ÃÎÊ */
        public const int MINOR_HD_FULL = 35;/* Ó²ÅÌÂú */
        public const int MINOR_HD_ERROR = 36;/* Ó²ÅÌ´íÎó */
        public const int MINOR_DCD_LOST = 37;/* MODEM µôÏß(±£Áô²»Ê¹ÓÃ) */
        public const int MINOR_IP_CONFLICT = 38;/* IPµØÖ·³åÍ» */
        public const int MINOR_NET_BROKEN = 39;/* ÍøÂç¶Ï¿ª*/
        public const int MINOR_REC_ERROR = 40;/* Â¼Ïñ³ö´í */
        public const int MINOR_IPC_NO_LINK = 41;/* IPCÁ¬½ÓÒì³£ */
        public const int MINOR_VI_EXCEPTION = 42;/* ÊÓÆµÊäÈëÒì³£(Ö»Õë¶ÔÄ£ÄâÍ¨µÀ) */
        public const int MINOR_IPC_IP_CONFLICT = 43;/*ipc ip µØÖ· ³åÍ»*/

        //ÊÓÆµ×ÛºÏÆ½Ì¨
        public const int MINOR_FANABNORMAL = 49;/* ÊÓÆµ×ÛºÏÆ½Ì¨£º·çÉÈ×´Ì¬Òì³£ */
        public const int MINOR_FANRESUME = 50;/* ÊÓÆµ×ÛºÏÆ½Ì¨£º·çÉÈ×´Ì¬»Ö¸´Õý³£ */
        public const int MINOR_SUBSYSTEM_ABNORMALREBOOT = 51;/* ÊÓÆµ×ÛºÏÆ½Ì¨£º6467Òì³£ÖØÆô */
        public const int MINOR_MATRIX_STARTBUZZER = 52;/* ÊÓÆµ×ÛºÏÆ½Ì¨£ºdm6467Òì³££¬Æô¶¯·äÃùÆ÷ */

        /* ²Ù×÷ */
        //Ö÷ÀàÐÍ
        public const int MAJOR_OPERATION = 3;
        //´ÎÀàÐÍ
        public const int MINOR_START_DVR = 65;/* ¿ª»ú */
        public const int MINOR_STOP_DVR = 66;/* ¹Ø»ú */
        public const int MINOR_STOP_ABNORMAL = 67;/* Òì³£¹Ø»ú */
        public const int MINOR_REBOOT_DVR = 68;/*±¾µØÖØÆôÉè±¸*/

        public const int MINOR_LOCAL_LOGIN = 80;/* ±¾µØµÇÂ½ */
        public const int MINOR_LOCAL_LOGOUT = 81;/* ±¾µØ×¢ÏúµÇÂ½ */
        public const int MINOR_LOCAL_CFG_PARM = 82;/* ±¾µØÅäÖÃ²ÎÊý */
        public const int MINOR_LOCAL_PLAYBYFILE = 83;/* ±¾µØ°´ÎÄ¼þ»Ø·Å»òÏÂÔØ */
        public const int MINOR_LOCAL_PLAYBYTIME = 84;/* ±¾µØ°´Ê±¼ä»Ø·Å»òÏÂÔØ*/
        public const int MINOR_LOCAL_START_REC = 85;/* ±¾µØ¿ªÊ¼Â¼Ïñ */
        public const int MINOR_LOCAL_STOP_REC = 86;/* ±¾µØÍ£Ö¹Â¼Ïñ */
        public const int MINOR_LOCAL_PTZCTRL = 87;/* ±¾µØÔÆÌ¨¿ØÖÆ */
        public const int MINOR_LOCAL_PREVIEW = 88;/* ±¾µØÔ¤ÀÀ (±£Áô²»Ê¹ÓÃ)*/
        public const int MINOR_LOCAL_MODIFY_TIME = 89;/* ±¾µØÐÞ¸ÄÊ±¼ä(±£Áô²»Ê¹ÓÃ) */
        public const int MINOR_LOCAL_UPGRADE = 90;/* ±¾µØÉý¼¶ */
        public const int MINOR_LOCAL_RECFILE_OUTPUT = 91;/* ±¾µØ±¸·ÝÂ¼ÏóÎÄ¼þ */
        public const int MINOR_LOCAL_FORMAT_HDD = 92;/* ±¾µØ³õÊ¼»¯Ó²ÅÌ */
        public const int MINOR_LOCAL_CFGFILE_OUTPUT = 93;/* µ¼³ö±¾µØÅäÖÃÎÄ¼þ */
        public const int MINOR_LOCAL_CFGFILE_INPUT = 94;/* µ¼Èë±¾µØÅäÖÃÎÄ¼þ */
        public const int MINOR_LOCAL_COPYFILE = 95;/* ±¾µØ±¸·ÝÎÄ¼þ */
        public const int MINOR_LOCAL_LOCKFILE = 96;/* ±¾µØËø¶¨Â¼ÏñÎÄ¼þ */
        public const int MINOR_LOCAL_UNLOCKFILE = 97;/* ±¾µØ½âËøÂ¼ÏñÎÄ¼þ */
        public const int MINOR_LOCAL_DVR_ALARM = 98;/* ±¾µØÊÖ¶¯Çå³ýºÍ´¥·¢±¨¾¯*/
        public const int MINOR_IPC_ADD = 99;/* ±¾µØÌí¼ÓIPC */
        public const int MINOR_IPC_DEL = 100;/* ±¾µØÉ¾³ýIPC */
        public const int MINOR_IPC_SET = 101;/* ±¾µØÉèÖÃIPC */
        public const int MINOR_LOCAL_START_BACKUP = 102;/* ±¾µØ¿ªÊ¼±¸·Ý */
        public const int MINOR_LOCAL_STOP_BACKUP = 103;/* ±¾µØÍ£Ö¹±¸·Ý*/
        public const int MINOR_LOCAL_COPYFILE_START_TIME = 104;/* ±¾µØ±¸·Ý¿ªÊ¼Ê±¼ä*/
        public const int MINOR_LOCAL_COPYFILE_END_TIME = 105;/* ±¾µØ±¸·Ý½áÊøÊ±¼ä*/
        public const int MINOR_LOCAL_ADD_NAS = 106;/*±¾µØÌí¼ÓÍøÂçÓ²ÅÌ*/
        public const int MINOR_LOCAL_DEL_NAS = 107;/* ±¾µØÉ¾³ýnasÅÌ*/
        public const int MINOR_LOCAL_SET_NAS = 108;/* ±¾µØÉèÖÃnasÅÌ*/

        public const int MINOR_REMOTE_LOGIN = 112;/* Ô¶³ÌµÇÂ¼ */
        public const int MINOR_REMOTE_LOGOUT = 113;/* Ô¶³Ì×¢ÏúµÇÂ½ */
        public const int MINOR_REMOTE_START_REC = 114;/* Ô¶³Ì¿ªÊ¼Â¼Ïñ */
        public const int MINOR_REMOTE_STOP_REC = 115;/* Ô¶³ÌÍ£Ö¹Â¼Ïñ */
        public const int MINOR_START_TRANS_CHAN = 116;/* ¿ªÊ¼Í¸Ã÷´«Êä */
        public const int MINOR_STOP_TRANS_CHAN = 117;/* Í£Ö¹Í¸Ã÷´«Êä */
        public const int MINOR_REMOTE_GET_PARM = 118;/* Ô¶³Ì»ñÈ¡²ÎÊý */
        public const int MINOR_REMOTE_CFG_PARM = 119;/* Ô¶³ÌÅäÖÃ²ÎÊý */
        public const int MINOR_REMOTE_GET_STATUS = 120;/* Ô¶³Ì»ñÈ¡×´Ì¬ */
        public const int MINOR_REMOTE_ARM = 121;/* Ô¶³Ì²¼·À */
        public const int MINOR_REMOTE_DISARM = 122;/* Ô¶³Ì³··À */
        public const int MINOR_REMOTE_REBOOT = 123;/* Ô¶³ÌÖØÆô */
        public const int MINOR_START_VT = 124;/* ¿ªÊ¼ÓïÒô¶Ô½² */
        public const int MINOR_STOP_VT = 125;/* Í£Ö¹ÓïÒô¶Ô½² */
        public const int MINOR_REMOTE_UPGRADE = 126;/* Ô¶³ÌÉý¼¶ */
        public const int MINOR_REMOTE_PLAYBYFILE = 127;/* Ô¶³Ì°´ÎÄ¼þ»Ø·Å */
        public const int MINOR_REMOTE_PLAYBYTIME = 128;/* Ô¶³Ì°´Ê±¼ä»Ø·Å */
        public const int MINOR_REMOTE_PTZCTRL = 129;/* Ô¶³ÌÔÆÌ¨¿ØÖÆ */
        public const int MINOR_REMOTE_FORMAT_HDD = 130;/* Ô¶³Ì¸ñÊ½»¯Ó²ÅÌ */
        public const int MINOR_REMOTE_STOP = 131;/* Ô¶³Ì¹Ø»ú */
        public const int MINOR_REMOTE_LOCKFILE = 132;/* Ô¶³ÌËø¶¨ÎÄ¼þ */
        public const int MINOR_REMOTE_UNLOCKFILE = 133;/* Ô¶³Ì½âËøÎÄ¼þ */
        public const int MINOR_REMOTE_CFGFILE_OUTPUT = 134;/* Ô¶³Ìµ¼³öÅäÖÃÎÄ¼þ */
        public const int MINOR_REMOTE_CFGFILE_INTPUT = 135;/* Ô¶³Ìµ¼ÈëÅäÖÃÎÄ¼þ */
        public const int MINOR_REMOTE_RECFILE_OUTPUT = 136;/* Ô¶³Ìµ¼³öÂ¼ÏóÎÄ¼þ */
        public const int MINOR_REMOTE_DVR_ALARM = 137;/* Ô¶³ÌÊÖ¶¯Çå³ýºÍ´¥·¢±¨¾¯*/
        public const int MINOR_REMOTE_IPC_ADD = 138;/* Ô¶³ÌÌí¼ÓIPC */
        public const int MINOR_REMOTE_IPC_DEL = 139;/* Ô¶³ÌÉ¾³ýIPC */
        public const int MINOR_REMOTE_IPC_SET = 140;/* Ô¶³ÌÉèÖÃIPC */
        public const int MINOR_REBOOT_VCA_LIB = 141;/*ÖØÆôÖÇÄÜ¿â*/
        public const int MINOR_REMOTE_ADD_NAS = 142;/* Ô¶³ÌÌí¼ÓnasÅÌ*/
        public const int MINOR_REMOTE_DEL_NAS = 143;/* Ô¶³ÌÉ¾³ýnasÅÌ*/
        public const int MINOR_REMOTE_SET_NAS = 144;/* Ô¶³ÌÉèÖÃnasÅÌ*/

        //2009-12-16 Ôö¼ÓÊÓÆµ×ÛºÏÆ½Ì¨ÈÕÖ¾ÀàÐÍ
        public const int MINOR_SUBSYSTEMREBOOT = 160;/*ÊÓÆµ×ÛºÏÆ½Ì¨£ºdm6467 Õý³£ÖØÆô*/
        public const int MINOR_MATRIX_STARTTRANSFERVIDEO = 161;	/*ÊÓÆµ×ÛºÏÆ½Ì¨£º¾ØÕóÇÐ»»¿ªÊ¼´«ÊäÍ¼Ïñ*/
        public const int MINOR_MATRIX_STOPTRANSFERVIDEO = 162;	/*ÊÓÆµ×ÛºÏÆ½Ì¨£º¾ØÕóÇÐ»»Í£Ö¹´«ÊäÍ¼Ïñ*/
        public const int MINOR_REMOTE_SET_ALLSUBSYSTEM = 163;	/*ÊÓÆµ×ÛºÏÆ½Ì¨£ºÉèÖÃËùÓÐ6467×ÓÏµÍ³ÐÅÏ¢*/
        public const int MINOR_REMOTE_GET_ALLSUBSYSTEM = 164;	/*ÊÓÆµ×ÛºÏÆ½Ì¨£º»ñÈ¡ËùÓÐ6467×ÓÏµÍ³ÐÅÏ¢*/
        public const int MINOR_REMOTE_SET_PLANARRAY = 165;	/*ÊÓÆµ×ÛºÏÆ½Ì¨£ºÉèÖÃ¼Æ»®ÂÖÑ¯×é*/
        public const int MINOR_REMOTE_GET_PLANARRAY = 166;	/*ÊÓÆµ×ÛºÏÆ½Ì¨£º»ñÈ¡¼Æ»®ÂÖÑ¯×é*/
        public const int MINOR_MATRIX_STARTTRANSFERAUDIO = 167;	/*ÊÓÆµ×ÛºÏÆ½Ì¨£º¾ØÕóÇÐ»»¿ªÊ¼´«ÊäÒôÆµ*/
        public const int MINOR_MATRIX_STOPRANSFERAUDIO = 168;	/*ÊÓÆµ×ÛºÏÆ½Ì¨£º¾ØÕóÇÐ»»Í£Ö¹´«ÊäÒôÆµ*/
        public const int MINOR_LOGON_CODESPITTER = 169;	/*ÊÓÆµ×ÛºÏÆ½Ì¨£ºµÇÂ½Âë·ÖÆ÷*/
        public const int MINOR_LOGOFF_CODESPITTER = 170;	/*ÊÓÆµ×ÛºÏÆ½Ì¨£ºÍË³öÂë·ÖÆ÷*/

        /*ÈÕÖ¾¸½¼ÓÐÅÏ¢*/
        //Ö÷ÀàÐÍ
        public const int MAJOR_INFORMATION = 4;/*¸½¼ÓÐÅÏ¢*/
        //´ÎÀàÐÍ
        public const int MINOR_HDD_INFO = 161;/*Ó²ÅÌÐÅÏ¢*/
        public const int MINOR_SMART_INFO = 162;/*SMARTÐÅÏ¢*/
        public const int MINOR_REC_START = 163;/*¿ªÊ¼Â¼Ïñ*/
        public const int MINOR_REC_STOP = 164;/*Í£Ö¹Â¼Ïñ*/
        public const int MINOR_REC_OVERDUE = 165;/*¹ýÆÚÂ¼ÏñÉ¾³ý*/
        public const int MINOR_LINK_START = 166;//Á¬½ÓÇ°¶ËÉè±¸
        public const int MINOR_LINK_STOP = 167;//¶Ï¿ªÇ°¶ËÉè±¸¡¡
        public const int MINOR_NET_DISK_INFO = 168;//ÍøÂçÓ²ÅÌÐÅÏ¢

        //µ±ÈÕÖ¾µÄÖ÷ÀàÐÍÎªMAJOR_OPERATION=03£¬´ÎÀàÐÍÎªMINOR_LOCAL_CFG_PARM=0x52»òÕßMINOR_REMOTE_GET_PARM=0x76»òÕßMINOR_REMOTE_CFG_PARM=0x77Ê±£¬dwParaType:²ÎÊýÀàÐÍÓÐÐ§£¬Æäº¬ÒåÈçÏÂ£º
        public const int PARA_VIDEOOUT = 1;
        public const int PARA_IMAGE = 2;
        public const int PARA_ENCODE = 4;
        public const int PARA_NETWORK = 8;
        public const int PARA_ALARM = 16;
        public const int PARA_EXCEPTION = 32;
        public const int PARA_DECODER = 64;/*½âÂëÆ÷*/
        public const int PARA_RS232 = 128;
        public const int PARA_PREVIEW = 256;
        public const int PARA_SECURITY = 512;
        public const int PARA_DATETIME = 1024;
        public const int PARA_FRAMETYPE = 2048;/*Ö¡¸ñÊ½*/
        //vca
        public const int PARA_VCA_RULE = 4096;//ÐÐÎª¹æÔò
        /************************DVRÈÕÖ¾ End***************************/


        /*******************²éÕÒÎÄ¼þºÍÈÕÖ¾º¯Êý·µ»ØÖµ*************************/
        public const int NET_DVR_FILE_SUCCESS = 1000;//»ñµÃÎÄ¼þÐÅÏ¢
        public const int NET_DVR_FILE_NOFIND = 1001;//Ã»ÓÐÎÄ¼þ
        public const int NET_DVR_ISFINDING = 1002;//ÕýÔÚ²éÕÒÎÄ¼þ
        public const int NET_DVR_NOMOREFILE = 1003;//²éÕÒÎÄ¼þÊ±Ã»ÓÐ¸ü¶àµÄÎÄ¼þ
        public const int NET_DVR_FILE_EXCEPTION = 1004;//²éÕÒÎÄ¼þÊ±Òì³£

        /*********************»Øµ÷º¯ÊýÀàÐÍ begin************************/
        public const int COMM_ALARM = 0x1100;//8000±¨¾¯ÐÅÏ¢Ö÷¶¯ÉÏ´«£¬¶ÔÓ¦NET_DVR_ALARMINFO
        public const int COMM_ALARM_RULE = 0x1102;//ÐÐÎª·ÖÎö±¨¾¯ÐÅÏ¢£¬¶ÔÓ¦NET_VCA_RULE_ALARM
        public const int COMM_ALARM_PDC = 0x1103;//ÈËÁ÷Á¿Í³¼Æ±¨¾¯ÉÏ´«£¬¶ÔÓ¦NET_DVR_PDC_ALRAM_INFO
        public const int COMM_ALARM_ALARMHOST = 0x1105;//ÍøÂç±¨¾¯Ö÷»ú±¨¾¯ÉÏ´«£¬¶ÔÓ¦NET_DVR_ALARMHOST_ALARMINFO
        public const int COMM_ALARM_FACE = 0x1106;//ÈËÁ³¼ì²âÊ¶±ð±¨¾¯ÐÅÏ¢£¬¶ÔÓ¦NET_DVR_FACEDETECT_ALARM
        public const int COMM_RULE_INFO_UPLOAD = 0x1107;  // ÊÂ¼þÊý¾ÝÐÅÏ¢ÉÏ´«
        public const int COMM_ALARM_AID = 0x1110;  //½»Í¨ÊÂ¼þ±¨¾¯ÐÅÏ¢
        public const int COMM_ALARM_TPS = 0x1111;  //½»Í¨²ÎÊýÍ³¼Æ±¨¾¯ÐÅÏ¢
        public const int COMM_UPLOAD_FACESNAP_RESULT = 0x1112;  //ÈËÁ³Ê¶±ð½á¹ûÉÏ´«
        public const int COMM_ALARM_FACE_DETECTION = 0x4010; //ÈËÁ³Õì²â±¨¾¯ÐÅÏ¢
        public const int COMM_ALARM_TFS = 0x1113;  //½»Í¨È¡Ö¤±¨¾¯ÐÅÏ¢
        public const int COMM_ALARM_TPS_V41 = 0x1114;  //½»Í¨²ÎÊýÍ³¼Æ±¨¾¯ÐÅÏ¢À©Õ¹
        public const int COMM_ALARM_AID_V41 = 0x1115;  //½»Í¨ÊÂ¼þ±¨¾¯ÐÅÏ¢À©Õ¹
        public const int COMM_ALARM_VQD_EX = 0x1116;	 //ÊÓÆµÖÊÁ¿Õï¶Ï±¨¾¯
        public const int COMM_SENSOR_VALUE_UPLOAD = 0x1120;  //Ä£ÄâÁ¿Êý¾ÝÊµÊ±ÉÏ´«
        public const int COMM_SENSOR_ALARM = 0x1121;  //Ä£ÄâÁ¿±¨¾¯ÉÏ´«
        public const int COMM_SWITCH_ALARM = 0x1122;	 //¿ª¹ØÁ¿±¨¾¯
        public const int COMM_ALARMHOST_EXCEPTION = 0x1123; //±¨¾¯Ö÷»ú¹ÊÕÏ±¨¾¯
        public const int COMM_ALARMHOST_OPERATEEVENT_ALARM = 0x1124;  //²Ù×÷ÊÂ¼þ±¨¾¯ÉÏ´«
        public const int COMM_ALARMHOST_SAFETYCABINSTATE = 0x1125;	 //·À»¤²Õ×´Ì¬
        public const int COMM_ALARMHOST_ALARMOUTSTATUS = 0x1126;	 //±¨¾¯Êä³ö¿Ú/¾¯ºÅ×´Ì¬
        public const int COMM_ALARMHOST_CID_ALARM = 0x1127;	 //CID±¨¸æ±¨¾¯ÉÏ´«
        public const int COMM_ALARMHOST_EXTERNAL_DEVICE_ALARM = 0x1128;	 //±¨¾¯Ö÷»úÍâ½ÓÉè±¸±¨¾¯ÉÏ´«
        public const int COMM_ALARMHOST_DATA_UPLOAD = 0x1129;	 //±¨¾¯Êý¾ÝÉÏ´«
        public const int COMM_ALARM_AUDIOEXCEPTION = 0x1150;	 //ÉùÒô±¨¾¯ÐÅÏ¢
        public const int COMM_ALARM_DEFOCUS = 0x1151;	 //Ðé½¹±¨¾¯ÐÅÏ¢
        public const int COMM_ALARM_BUTTON_DOWN_EXCEPTION = 0x1152;	 //°´Å¥°´ÏÂ±¨¾¯ÐÅÏ¢
        public const int COMM_ALARM_ALARMGPS = 0x1202; //GPS±¨¾¯ÐÅÏ¢ÉÏ´«
        public const int COMM_TRADEINFO = 0x1500;  //ATMDVRÖ÷¶¯ÉÏ´«½»Ò×ÐÅÏ¢
        public const int COMM_UPLOAD_PLATE_RESULT = 0x2800;	 //ÉÏ´«³µÅÆÐÅÏ¢
        public const int COMM_ITC_STATUS_DETECT_RESULT = 0x2810;  //ÊµÊ±×´Ì¬¼ì²â½á¹ûÉÏ´«(ÖÇÄÜ¸ßÇåIPC)
        public const int COMM_IPC_AUXALARM_RESULT = 0x2820;  //PIR±¨¾¯¡¢ÎÞÏß±¨¾¯¡¢ºô¾È±¨¾¯ÉÏ´«
        public const int COMM_UPLOAD_PICTUREINFO = 0x2900;	 //ÉÏ´«Í¼Æ¬ÐÅÏ¢
        public const int COMM_SNAP_MATCH_ALARM = 0x2902;  //ºÚÃûµ¥±È¶Ô½á¹ûÉÏ´«
        public const int COMM_ITS_PLATE_RESULT = 0x3050;  //ÖÕ¶ËÍ¼Æ¬ÉÏ´«
        public const int COMM_ITS_TRAFFIC_COLLECT = 0x3051;  //ÖÕ¶ËÍ³¼ÆÊý¾ÝÉÏ´«
        public const int COMM_ITS_GATE_VEHICLE = 0x3052;  //³öÈë¿Ú³µÁ¾×¥ÅÄÊý¾ÝÉÏ´«
        public const int COMM_ITS_GATE_FACE = 0x3053; //³öÈë¿ÚÈËÁ³×¥ÅÄÊý¾ÝÉÏ´«
        public const int COMM_ITS_GATE_COSTITEM = 0x3054;  //³öÈë¿Ú¹ý³µÊÕ·ÑÃ÷Ï¸ 2013-11-19
        public const int COMM_ITS_GATE_HANDOVER = 0x3055; //³öÈë¿Ú½»½Ó°àÊý¾Ý 2013-11-19
        public const int COMM_ITS_PARK_VEHICLE = 0x3056;  //Í£³µ³¡Êý¾ÝÉÏ´«
        public const int COMM_ITS_BLACKLIST_ALARM = 0x3057;  //ºÚÃûµ¥±¨¾¯ÉÏ´«
        public const int COMM_ALARM_V30 = 0x4000;	 //9000±¨¾¯ÐÅÏ¢Ö÷¶¯ÉÏ´«
        public const int COMM_IPCCFG = 0x4001;	 //9000Éè±¸IPC½ÓÈëÅäÖÃ¸Ä±ä±¨¾¯ÐÅÏ¢Ö÷¶¯ÉÏ´«
        public const int COMM_IPCCFG_V31 = 0x4002;	 //9000Éè±¸IPC½ÓÈëÅäÖÃ¸Ä±ä±¨¾¯ÐÅÏ¢Ö÷¶¯ÉÏ´«À©Õ¹ 9000_1.1
        public const int COMM_IPCCFG_V40 = 0x4003; // IVMS 2000 ±àÂë·þÎñÆ÷ NVR IPC½ÓÈëÅäÖÃ¸Ä±äÊ±±¨¾¯ÐÅÏ¢ÉÏ´«
        public const int COMM_ALARM_DEVICE = 0x4004;  //Éè±¸±¨¾¯ÄÚÈÝ£¬ÓÉÓÚÍ¨µÀÖµ´óÓÚ256¶øÀ©Õ¹
        public const int COMM_ALARM_CVR = 0x4005;  //CVR 2.0.XÍâ²¿±¨¾¯ÀàÐÍ
        public const int COMM_ALARM_HOT_SPARE = 0x4006;  //ÈÈ±¸Òì³£±¨¾¯£¨N+1Ä£Ê½Òì³£±¨¾¯£©
        public const int COMM_ALARM_V40 = 0x4007;	//ÒÆ¶¯Õì²â£¬ÊÓÆµ¶ªÊ§£¬ÕÚµ²£¬IOÐÅºÅÁ¿µÈ±¨¾¯ÐÅÏ¢Ö÷¶¯ÉÏ´«£¬±¨¾¯Êý¾ÝÎª¿É±ä³¤

        public const int COMM_ITS_ROAD_EXCEPTION = 0x4500;	 //Â·¿ÚÉè±¸Òì³£±¨¾¯
        public const int COMM_ITS_EXTERNAL_CONTROL_ALARM = 0x4520;  //Íâ¿Ø±¨¾¯
        public const int COMM_SCREEN_ALARM = 0x5000;  //¶àÆÁ¿ØÖÆÆ÷±¨¾¯ÀàÐÍ
        public const int COMM_DVCS_STATE_ALARM = 0x5001;  //·Ö²¼Ê½´óÆÁ¿ØÖÆÆ÷±¨¾¯ÉÏ´«
        public const int COMM_ALARM_VQD = 0x6000;  //VQDÖ÷¶¯±¨¾¯ÉÏ´« 
        public const int COMM_PUSH_UPDATE_RECORD_INFO = 0x6001;  //ÍÆÄ£Ê½Â¼ÏñÐÅÏ¢ÉÏ´«
        public const int COMM_DIAGNOSIS_UPLOAD = 0x5100;  //Õï¶Ï·þÎñÆ÷VQD±¨¾¯ÉÏ´«
        public const int COMM_ALARM_ACS = 0x5002;  //ÃÅ½ûÖ÷»ú±¨¾¯
        public const int COMM_ID_INFO_ALARM = 0x5200;  //Éí·ÝÖ¤ÐÅÏ¢ÉÏ´«
        public const int COMM_PASSNUM_INFO_ALARM = 0x5201;  //Í¨ÐÐÈËÊýÉÏ±¨

        /*************²Ù×÷Òì³£ÀàÐÍ(ÏûÏ¢·½Ê½, »Øµ÷·½Ê½(±£Áô))****************/
        public const int EXCEPTION_EXCHANGE = 32768;//ÓÃ»§½»»¥Ê±Òì³£
        public const int EXCEPTION_AUDIOEXCHANGE = 32769;//ÓïÒô¶Ô½²Òì³£
        public const int EXCEPTION_ALARM = 32770;//±¨¾¯Òì³£
        public const int EXCEPTION_PREVIEW = 32771;//ÍøÂçÔ¤ÀÀÒì³£
        public const int EXCEPTION_SERIAL = 32772;//Í¸Ã÷Í¨µÀÒì³£
        public const int EXCEPTION_RECONNECT = 32773;//Ô¤ÀÀÊ±ÖØÁ¬
        public const int EXCEPTION_ALARMRECONNECT = 32774;//±¨¾¯Ê±ÖØÁ¬
        public const int EXCEPTION_SERIALRECONNECT = 32775;//Í¸Ã÷Í¨µÀÖØÁ¬
        public const int EXCEPTION_PLAYBACK = 32784;//»Ø·ÅÒì³£
        public const int EXCEPTION_DISKFMT = 32785;//Ó²ÅÌ¸ñÊ½»¯

        /********************Ô¤ÀÀ»Øµ÷º¯Êý*********************/
        public const int NET_DVR_SYSHEAD = 1;//ÏµÍ³Í·Êý¾Ý
        public const int NET_DVR_STREAMDATA = 2;//ÊÓÆµÁ÷Êý¾Ý£¨°üÀ¨¸´ºÏÁ÷ºÍÒôÊÓÆµ·Ö¿ªµÄÊÓÆµÁ÷Êý¾Ý£©
        public const int NET_DVR_AUDIOSTREAMDATA = 3;//ÒôÆµÁ÷Êý¾Ý
        public const int NET_DVR_STD_VIDEODATA = 4;//±ê×¼ÊÓÆµÁ÷Êý¾Ý
        public const int NET_DVR_STD_AUDIODATA = 5;//±ê×¼ÒôÆµÁ÷Êý¾Ý

        //»Øµ÷Ô¤ÀÀÖÐµÄ×´Ì¬ºÍÏûÏ¢
        public const int NET_DVR_REALPLAYEXCEPTION = 111;//Ô¤ÀÀÒì³£
        public const int NET_DVR_REALPLAYNETCLOSE = 112;//Ô¤ÀÀÊ±Á¬½Ó¶Ï¿ª
        public const int NET_DVR_REALPLAY5SNODATA = 113;//Ô¤ÀÀ5sÃ»ÓÐÊÕµ½Êý¾Ý
        public const int NET_DVR_REALPLAYRECONNECT = 114;//Ô¤ÀÀÖØÁ¬

        /********************»Ø·Å»Øµ÷º¯Êý*********************/
        public const int NET_DVR_PLAYBACKOVER = 101;//»Ø·ÅÊý¾Ý²¥·ÅÍê±Ï
        public const int NET_DVR_PLAYBACKEXCEPTION = 102;//»Ø·ÅÒì³£
        public const int NET_DVR_PLAYBACKNETCLOSE = 103;//»Ø·ÅÊ±ºòÁ¬½Ó¶Ï¿ª
        public const int NET_DVR_PLAYBACK5SNODATA = 104;//»Ø·Å5sÃ»ÓÐÊÕµ½Êý¾Ý

        /*********************»Øµ÷º¯ÊýÀàÐÍ end************************/
        //Éè±¸ÐÍºÅ(DVRÀàÐÍ)
        /* Éè±¸ÀàÐÍ */
        public const int DVR = 1;/*¶ÔÉÐÎ´¶¨ÒåµÄdvrÀàÐÍ·µ»ØNETRET_DVR*/
        public const int ATMDVR = 2;/*atm dvr*/
        public const int DVS = 3;/*DVS*/
        public const int DEC = 4;/* 6001D */
        public const int ENC_DEC = 5;/* 6001F */
        public const int DVR_HC = 6;/*8000HC*/
        public const int DVR_HT = 7;/*8000HT*/
        public const int DVR_HF = 8;/*8000HF*/
        public const int DVR_HS = 9;/* 8000HS DVR(no audio) */
        public const int DVR_HTS = 10; /* 8016HTS DVR(no audio) */
        public const int DVR_HB = 11; /* HB DVR(SATA HD) */
        public const int DVR_HCS = 12; /* 8000HCS DVR */
        public const int DVS_A = 13; /* ´øATAÓ²ÅÌµÄDVS */
        public const int DVR_HC_S = 14; /* 8000HC-S */
        public const int DVR_HT_S = 15;/* 8000HT-S */
        public const int DVR_HF_S = 16;/* 8000HF-S */
        public const int DVR_HS_S = 17; /* 8000HS-S */
        public const int ATMDVR_S = 18;/* ATM-S */
        public const int LOWCOST_DVR = 19;/*7000HÏµÁÐ*/
        public const int DEC_MAT = 20; /*¶àÂ·½âÂëÆ÷*/
        public const int DVR_MOBILE = 21;/* mobile DVR */
        public const int DVR_HD_S = 22;   /* 8000HD-S */
        public const int DVR_HD_SL = 23;/* 8000HD-SL */
        public const int DVR_HC_SL = 24;/* 8000HC-SL */
        public const int DVR_HS_ST = 25;/* 8000HS_ST */
        public const int DVS_HW = 26; /* 6000HW */
        public const int DS630X_D = 27; /* ¶àÂ·½âÂëÆ÷ */
        public const int IPCAM = 30;/*IP ÉãÏñ»ú*/
        public const int MEGA_IPCAM = 31;/*X52MFÏµÁÐ,752MF,852MF*/
        public const int IPCAM_X62MF = 32;/*X62MFÏµÁÐ¿É½ÓÈë9000Éè±¸,762MF,862MF*/
        public const int IPDOME = 40; /*IP ±êÇåÇò»ú*/
        public const int IPDOME_MEGA200 = 41;/*IP 200Íò¸ßÇåÇò»ú*/
        public const int IPDOME_MEGA130 = 42;/*IP 130Íò¸ßÇåÇò»ú*/
        public const int IPMOD = 50;/*IP Ä£¿é*/
        public const int DS71XX_H = 71;/* DS71XXH_S */
        public const int DS72XX_H_S = 72;/* DS72XXH_S */
        public const int DS73XX_H_S = 73;/* DS73XXH_S */
        public const int DS76XX_H_S = 76;/* DS76XX_H_S */
        public const int DS81XX_HS_S = 81;/* DS81XX_HS_S */
        public const int DS81XX_HL_S = 82;/* DS81XX_HL_S */
        public const int DS81XX_HC_S = 83;/* DS81XX_HC_S */
        public const int DS81XX_HD_S = 84;/* DS81XX_HD_S */
        public const int DS81XX_HE_S = 85;/* DS81XX_HE_S */
        public const int DS81XX_HF_S = 86;/* DS81XX_HF_S */
        public const int DS81XX_AH_S = 87;/* DS81XX_AH_S */
        public const int DS81XX_AHF_S = 88;/* DS81XX_AHF_S */
        public const int DS90XX_HF_S = 90;  /*DS90XX_HF_S*/
        public const int DS91XX_HF_S = 91;  /*DS91XX_HF_S*/
        public const int DS91XX_HD_S = 92; /*91XXHD-S(MD)*/
        /**********************Éè±¸ÀàÐÍ end***********************/

        /*************************************************
        ²ÎÊýÅäÖÃ½á¹¹¡¢²ÎÊý(ÆäÖÐ_V30Îª9000ÐÂÔö)
        **************************************************/
        //Ð£Ê±½á¹¹²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME
        {
            public uint dwYear;
            public uint dwMonth;
            public uint dwDay;
            public uint dwHour;
            public uint dwMinute;
            public uint dwSecond;
        }

        //Ê±¼ä²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_V30
        {
            public ushort wYear;
            public byte byMonth;
            public byte byDay;
            public byte byHour;
            public byte byMinute;
            public byte bySecond;
            public byte byRes;
            public ushort wMilliSec;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_EX
        {
            public ushort wYear;
            public byte byMonth;
            public byte byDay;
            public byte byHour;
            public byte byMinute;
            public byte bySecond;
            public byte byRes;
        }

        //Ê±¼ä¶Î(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCHEDTIME
        {
            public byte byStartHour;//¿ªÊ¼Ê±¼ä
            public byte byStartMin;//¿ªÊ¼Ê±¼ä
            public byte byStopHour;//½áÊøÊ±¼ä
            public byte byStopMin;//½áÊøÊ±¼ä
        }

        /*Éè±¸±¨¾¯ºÍÒì³£´¦Àí·½Ê½*/
        public const int NOACTION = 0x0;/*ÎÞÏìÓ¦*/
        public const int WARNONMONITOR = 0x1;/*¼àÊÓÆ÷ÉÏ¾¯¸æ*/
        public const int WARNONAUDIOOUT = 0x2;/*ÉùÒô¾¯¸æ*/
        public const int UPTOCENTER = 0x4;/*ÉÏ´«ÖÐÐÄ*/
        public const int TRIGGERALARMOUT = 0x8;/*´¥·¢±¨¾¯Êä³ö*/
        public const int TRIGGERCATPIC = 0x10;/*´¥·¢×¥Í¼²¢ÉÏ´«E-mail*/
        public const int SEND_PIC_FTP = 0x200;  /*×¥Í¼²¢ÉÏ´«ftp*/

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STRUCTHEAD
        {
            public ushort wLength;  //½á¹¹³¤¶È
            public byte byVersion;	/*¸ßµÍ4Î»·Ö±ð´ú±í¸ßµÍ°æ±¾£¬ºóÐø¸ù¾Ý°æ±¾ºÍ³¤¶È½øÐÐÀ©Õ¹£¬²»Í¬µÄ°æ±¾µÄ³¤¶È½øÐÐÏÞÖÆ*/
            public byte byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V41
        {
            public uint dwHandleType;/*´¦Àí·½Ê½,´¦Àí·½Ê½µÄ"»ò"½á¹û*/
            /*0x00: ÎÞÏìÓ¦*/
            /*0x01: ¼àÊÓÆ÷ÉÏ¾¯¸æ*/
            /*0x02: ÉùÒô¾¯¸æ*/
            /*0x04: ÉÏ´«ÖÐÐÄ*/
            /*0x08: ´¥·¢±¨¾¯Êä³ö*/
            /*0x10: ´¥·¢JPRG×¥Í¼²¢ÉÏ´«Email*/
            /*0x20: ÎÞÏßÉù¹â±¨¾¯Æ÷Áª¶¯*/
            /*0x40: Áª¶¯µç×ÓµØÍ¼(Ä¿Ç°Ö»ÓÐPCNVRÖ§³Ö)*/
            /*0x200: ×¥Í¼²¢ÉÏ´«FTP*/
            public uint dwMaxRelAlarmOutChanNum; //´¥·¢µÄ±¨¾¯Êä³öÍ¨µÀÊý£¨Ö»¶Á£©×î´óÖ§³ÖÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //´¥·¢±¨¾¯Í¨µÀ      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V40
        {
            public uint dwHandleType;/*´¦Àí·½Ê½,´¦Àí·½Ê½µÄ"»ò"½á¹û*/
            /*0x00: ÎÞÏìÓ¦*/
            /*0x01: ¼àÊÓÆ÷ÉÏ¾¯¸æ*/
            /*0x02: ÉùÒô¾¯¸æ*/
            /*0x04: ÉÏ´«ÖÐÐÄ*/
            /*0x08: ´¥·¢±¨¾¯Êä³ö*/
            /*0x10: ´¥·¢JPRG×¥Í¼²¢ÉÏ´«Email*/
            /*0x20: ÎÞÏßÉù¹â±¨¾¯Æ÷Áª¶¯*/
            /*0x40: Áª¶¯µç×ÓµØÍ¼(Ä¿Ç°Ö»ÓÐPCNVRÖ§³Ö)*/
            /*0x200: ×¥Í¼²¢ÉÏ´«FTP*/
            public uint dwMaxRelAlarmOutChanNum; //´¥·¢µÄ±¨¾¯Êä³öÍ¨µÀÊý£¨Ö»¶Á£©×î´óÖ§³ÖÊý
            public uint dwRelAlarmOutChanNum; //´¥·¢µÄ±¨¾¯Êä³öÍ¨µÀÊý Êµ¼ÊÖ§³ÖÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //´¥·¢±¨¾¯Í¨µÀ      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±£Áô
        }

        //±¨¾¯ºÍÒì³£´¦Àí½á¹¹(×Ó½á¹¹)(¶à´¦Ê¹ÓÃ)(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V30
        {
            public uint dwHandleType;/*´¦Àí·½Ê½,´¦Àí·½Ê½µÄ"»ò"½á¹û*/
            /*0x00: ÎÞÏìÓ¦*/
            /*0x01: ¼àÊÓÆ÷ÉÏ¾¯¸æ*/
            /*0x02: ÉùÒô¾¯¸æ*/
            /*0x04: ÉÏ´«ÖÐÐÄ*/
            /*0x08: ´¥·¢±¨¾¯Êä³ö*/
            /*0x10: ´¥·¢JPRG×¥Í¼²¢ÉÏ´«Email*/
            /*0x20: ÎÞÏßÉù¹â±¨¾¯Æ÷Áª¶¯*/
            /*0x40: Áª¶¯µç×ÓµØÍ¼(Ä¿Ç°Ö»ÓÐPCNVRÖ§³Ö)*/
            /*0x200: ×¥Í¼²¢ÉÏ´«FTP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelAlarmOut;//±¨¾¯´¥·¢µÄÊä³öÍ¨µÀ,±¨¾¯´¥·¢µÄÊä³ö,Îª1±íÊ¾´¥·¢¸ÃÊä³ö
        }

        //±¨¾¯ºÍÒì³£´¦Àí½á¹¹(×Ó½á¹¹)(¶à´¦Ê¹ÓÃ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION
        {
            public uint dwHandleType;/*´¦Àí·½Ê½,´¦Àí·½Ê½µÄ"»ò"½á¹û*/
            /*0x00: ÎÞÏìÓ¦*/
            /*0x01: ¼àÊÓÆ÷ÉÏ¾¯¸æ*/
            /*0x02: ÉùÒô¾¯¸æ*/
            /*0x04: ÉÏ´«ÖÐÐÄ*/
            /*0x08: ´¥·¢±¨¾¯Êä³ö*/
            /*0x10: Jpeg×¥Í¼²¢ÉÏ´«EMail*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelAlarmOut;//±¨¾¯´¥·¢µÄÊä³öÍ¨µÀ,±¨¾¯´¥·¢µÄÊä³ö,Îª1±íÊ¾´¥·¢¸ÃÊä³ö
        }

        //DVRÉè±¸²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICECFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName;//DVRÃû³Æ
            public uint dwDVRID;//DVR ID,ÓÃÓÚÒ£¿ØÆ÷ //V1.4(0-99), V1.5(0-255)
            public uint dwRecycleRecord;//ÊÇ·ñÑ­»·Â¼Ïñ,0:²»ÊÇ; 1:ÊÇ
            //ÒÔÏÂ²»¿É¸ü¸Ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//ÐòÁÐºÅ
            public uint dwSoftwareVersion;//Èí¼þ°æ±¾ºÅ,¸ß16Î»ÊÇÖ÷°æ±¾,µÍ16Î»ÊÇ´Î°æ±¾
            public uint dwSoftwareBuildDate;//Èí¼þÉú³ÉÈÕÆÚ,0xYYYYMMDD
            public uint dwDSPSoftwareVersion;//DSPÈí¼þ°æ±¾,¸ß16Î»ÊÇÖ÷°æ±¾,µÍ16Î»ÊÇ´Î°æ±¾
            public uint dwDSPSoftwareBuildDate;// DSPÈí¼þÉú³ÉÈÕÆÚ,0xYYYYMMDD
            public uint dwPanelVersion;// Ç°Ãæ°å°æ±¾,¸ß16Î»ÊÇÖ÷°æ±¾,µÍ16Î»ÊÇ´Î°æ±¾
            public uint dwHardwareVersion;// Ó²¼þ°æ±¾,¸ß16Î»ÊÇÖ÷°æ±¾,µÍ16Î»ÊÇ´Î°æ±¾
            public byte byAlarmInPortNum;//DVR±¨¾¯ÊäÈë¸öÊý
            public byte byAlarmOutPortNum;//DVR±¨¾¯Êä³ö¸öÊý
            public byte byRS232Num;//DVR 232´®¿Ú¸öÊý
            public byte byRS485Num;//DVR 485´®¿Ú¸öÊý
            public byte byNetworkPortNum;//ÍøÂç¿Ú¸öÊý
            public byte byDiskCtrlNum;//DVR Ó²ÅÌ¿ØÖÆÆ÷¸öÊý
            public byte byDiskNum;//DVR Ó²ÅÌ¸öÊý
            public byte byDVRType;//DVRÀàÐÍ, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;//DVR Í¨µÀ¸öÊý
            public byte byStartChan;//ÆðÊ¼Í¨µÀºÅ,ÀýÈçDVS-1,DVR - 1
            public byte byDecordChans;//DVR ½âÂëÂ·Êý
            public byte byVGANum;//VGA¿ÚµÄ¸öÊý
            public byte byUSBNum;//USB¿ÚµÄ¸öÊý
            public byte byAuxoutNum;//¸¨¿ÚµÄ¸öÊý
            public byte byAudioNum;//ÓïÒô¿ÚµÄ¸öÊý
            public byte byIPChanNum;//×î´óÊý×ÖÍ¨µÀÊý
        }

        /*IPµØÖ·*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IPADDR
        {

            /// char[16]
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpV4;

            /// BYTE[128]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes = new byte[128];
            }
        }

        /*ÍøÂçÊý¾Ý½á¹¹(×Ó½á¹¹)(9000À©Õ¹)*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ETHERNET_V30
        {
            public NET_DVR_IPADDR struDVRIP;//DVR IPµØÖ·
            public NET_DVR_IPADDR struDVRIPMask;//DVR IPµØÖ·ÑÚÂë
            public uint dwNetInterface;//ÍøÂç½Ó¿Ú£º1-10MBase-T£»2-10MBase-TÈ«Ë«¹¤£»3-100MBase-TX£»4-100MÈ«Ë«¹¤£»5-10M/100M/1000M×ÔÊÊÓ¦£»6-1000MÈ«Ë«¹¤
            public ushort wDVRPort;//¶Ë¿ÚºÅ
            public ushort wMTU;//Ôö¼ÓMTUÉèÖÃ£¬Ä¬ÈÏ1500¡£
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;// ÎïÀíµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*ÍøÂçÊý¾Ý½á¹¹(×Ó½á¹¹)*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ETHERNET
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;//DVR IPµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIPMask;//DVR IPµØÖ·ÑÚÂë
            public uint dwNetInterface;//ÍøÂç½Ó¿Ú 1-10MBase-T 2-10MBase-TÈ«Ë«¹¤ 3-100MBase-TX 4-100MÈ«Ë«¹¤ 5-10M/100M×ÔÊÊÓ¦
            public ushort wDVRPort;//¶Ë¿ÚºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;//·þÎñÆ÷µÄÎïÀíµØÖ·
        }

        //pppoe½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPOECFG
        {
            public uint dwPPPOE;//0-²»ÆôÓÃ,1-ÆôÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPPPoEUser;//PPPoEÓÃ»§Ãû
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPPPoEPassword;// PPPoEÃÜÂë
            public NET_DVR_IPADDR struPPPoEIP;//PPPoE IPµØÖ·
        }

        //ÍøÂçÅäÖÃ½á¹¹(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NETCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ETHERNET, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET_V30[] struEtherNet;//ÒÔÌ«Íø¿Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struRes1;/*±£Áô*/
            public NET_DVR_IPADDR struAlarmHostIpAddr;/* ±¨¾¯Ö÷»úIPµØÖ· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public ushort wAlarmHostIpPort;
            public byte byUseDhcp;
            public byte byRes3;
            public NET_DVR_IPADDR struDnsServer1IpAddr;/* ÓòÃû·þÎñÆ÷1µÄIPµØÖ· */
            public NET_DVR_IPADDR struDnsServer2IpAddr;/* ÓòÃû·þÎñÆ÷2µÄIPµØÖ· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byIpResolver;
            public ushort wIpResolverPort;
            public ushort wHttpPortNo;
            public NET_DVR_IPADDR struMulticastIpAddr;/* ¶à²¥×éµØÖ· */
            public NET_DVR_IPADDR struGatewayIpAddr;/* Íø¹ØµØÖ· */
            public NET_DVR_PPPOECFG struPPPoE;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µ¥¸öÍø¿¨ÅäÖÃÐÅÏ¢½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ETHERNET_MULTI
        {
            public NET_DVR_IPADDR struDVRIP;
            public NET_DVR_IPADDR struDVRIPMask;
            public uint dwNetInterface;
            public byte byCardType;  //Íø¿¨ÀàÐÍ£¬0-ÆÕÍ¨Íø¿¨£¬1-ÄÚÍøÍø¿¨£¬2-ÍâÍøÍø¿¨
            public byte byRes1;
            public ushort wMTU;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public byte byUseDhcp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public NET_DVR_IPADDR struGatewayIpAddr;
            public NET_DVR_IPADDR struDnsServer1IpAddr;
            public NET_DVR_IPADDR struDnsServer2IpAddr;
        }

        //¶àÍø¿¨ÍøÂçÅäÖÃ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NETCFG_MULTI
        {
            public uint dwSize;
            public byte byDefaultRoute;
            public byte byNetworkCardNum;
            public byte byWorkMode;   //0-ÆÕÍ¨¶àÍø¿¨Ä£Ê½£¬1-ÄÚÍâÍø¸ôÀëÄ£Ê½
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NETWORK_CARD, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET_MULTI[] struEtherNet;//ÒÔÌ«Íø¿Ú
            public NET_DVR_IPADDR struManageHost1IpAddr;
            public NET_DVR_IPADDR struManageHost2IpAddr;
            public NET_DVR_IPADDR struAlarmHostIpAddr;
            public ushort wManageHost1Port;
            public ushort wManageHost2Port;
            public ushort wAlarmHostIpPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byIpResolver;
            public ushort wIpResolverPort;
            public ushort wDvrPort;
            public ushort wHttpPortNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_IPADDR struMulticastIpAddr;/* ¶à²¥×éµØÖ· */
            public NET_DVR_PPPOECFG struPPPoE;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        //ÍøÂçÅäÖÃ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ETHERNET, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET[] struEtherNet;/* ÒÔÌ«Íø¿Ú */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sManageHostIP;//Ô¶³Ì¹ÜÀíÖ÷»úµØÖ·
            public ushort wManageHostPort;//Ô¶³Ì¹ÜÀíÖ÷»ú¶Ë¿ÚºÅ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIPServerIP;//IPServer·þÎñÆ÷µØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sMultiCastIP;//¶à²¥×éµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sGatewayIP;//Íø¹ØµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sNFSIP;//NFSÖ÷»úIPµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNFSDirectory;//NFSÄ¿Â¼
            public uint dwPPPOE;//0-²»ÆôÓÃ,1-ÆôÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPPPoEUser;//PPPoEÓÃ»§Ãû
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPPPoEPassword;// PPPoEÃÜÂë
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sPPPoEIP;//PPPoE IPµØÖ·(Ö»¶Á)
            public ushort wHttpPort;//HTTP¶Ë¿ÚºÅ
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SIP_CFG
        {
            public uint dwSize;
            public byte byEnableAutoLogin;    //Ê¹ÄÜ×Ô¶¯×¢²á£¬0-²»Ê¹ÄÜ£¬1-Ê¹ÄÜ
            public byte byLoginStatus;  //×¢²á×´Ì¬£¬0-Î´×¢²á£¬1-ÒÑ×¢²á£¬´Ë²ÎÊýÖ»ÄÜ»ñÈ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR stuServerIP;  //SIP·þÎñÆ÷IP
            public ushort wServerPort;    //SIP·þÎñÆ÷¶Ë¿Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;  //×¢²áÓÃ»§Ãû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassWord; //×¢²áÃÜÂë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDispalyName; //Éè±¸ÏÔÊ¾Ãû³Æ
            public ushort wLocalPort;     //±¾µØ¶Ë¿Ú
            public byte byLoginCycle;   //×¢²áÖÜÆÚ£¬1-99·ÖÖÓ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 129, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IP¿ÉÊÓ¶Ô½²·Ö»úÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_DEVCFG
        {
            public uint dwSize;
            public byte byDefaultRing; //Ä¬ÈÏÁåÒô£¬·¶Î§1-6
            public byte byRingVolume;  //ÁåÒôÒôÁ¿£¬·¶Î§0-9
            public byte byInputVolume; //ÊäÈëÒôÁ¿Öµ£¬·¶Î§0-6
            public byte byOutputVolume; //Êä³öÒôÁ¿Öµ£¬·¶Î§0-9	
            public ushort wRtpPort;  //Rtp¶Ë¿Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPreviewDelayTime; //Ô¤ÀÀÑÓÊ±ÅäÖÃ£¬0-30Ãë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //Ip¿ÉÊÓ¶Ô½²ÒôÆµÏà¹Ø²ÎÊýÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_AUDIO_CFG
        {
            public uint dwSize;
            public byte byAudioEncPri1; //ÒôÆµ±àÂëÓÅÏÈ¼¶1£¬0-OggVorbis£¬1-G711_U£¬2-G711_A£¬ 5-MPEG2,6-G726£¬7-AAC
            public byte byAudioEncPri2; //ÒôÆµ±àÂëÓÅÏÈ¼¶2£¬µ±sip·þÎñÆ÷²»Ö§³ÖÒôÆµ±àÂë1Ê±»áÊ¹ÓÃÒôÆµ±àÂë2£¬0-OggVorbis£¬1-G711_U£¬2-G711_A£¬ 5-MPEG2,6-G726£¬7-AAC
            public ushort wAudioPacketLen1; //ÒôÆµ±àÂë1Êý¾Ý°ü³¤¶È
            public ushort wAudioPacketLen2; //ÒôÆµ±àÂë2Êý¾Ý°ü³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IP·Ö»úºô½Ð¶Ô½²²ÎÊýÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_CALL_CFG
        {
            public uint dwSize;
            public byte byEnableAutoResponse; //Ê¹ÄÜ×Ô¶¯Ó¦´ð,0-²»Ê¹ÄÜ£¬1-Ê¹ÄÜ
            public byte byAudoResponseTime; //×Ô¶¯Ó¦´ðÊ±¼ä£¬0-30Ãë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byEnableAlarmNumber1; //Æô¶¯±¨¾¯ºÅÂë1£¬0-²»Æô¶¯£¬1-Æô¶¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmNumber1; //ºô½ÐºÅÂë1
            public byte byEnableAlarmNumber2; //Æô¶¯±¨¾¯ºÅÂë2£¬0-²»Æô¶¯£¬1-Æô¶¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmNumber2; //ºô½ÐºÅÂë2£¬ºô½ÐºÅÂë1Ê§°Ü»á³¢ÊÔºô½ÐºÅÂë2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
        }

        //Í¨µÀÍ¼Ïó½á¹¹
        //ÒÆ¶¯Õì²â(×Ó½á¹¹)(°´×é·½Ê½À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RECORDCHAN
        {
            public uint dwMaxRecordChanNum;   //Éè±¸Ö§³ÖµÄ×î´ó¹ØÁªÂ¼ÏñÍ¨µÀÊý-Ö»¶Á
            public uint dwCurRecordChanNum;   //µ±Ç°Êµ¼ÊÒÑÅäÖÃµÄ¹ØÁªÂ¼ÏñÍ¨µÀÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint dwRelRecordChan;     /* Êµ¼Ê´¥·¢Â¼ÏñÍ¨µÀ£¬°´Öµ±íÊ¾,²ÉÓÃ½ô´ÕÐÍÅÅÁÐ£¬´ÓÏÂ±ê0 - MAX_CHANNUM_V30-1ÓÐÐ§£¬Èç¹ûÖÐ¼äÓöµ½0xffffffff,ÔòºóÐøÎÞÐ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±£Áô
        }

        //Í¨µÀÍ¼Ïó½á¹¹
        //ÒÆ¶¯Õì²â(×Ó½á¹¹)(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MOTION_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 96 * 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope;/*Õì²âÇøÓò,0-96Î»,±íÊ¾64ÐÐ,¹²ÓÐ96*64¸öÐ¡ºê¿é,Îª1±íÊ¾ÊÇÒÆ¶¯Õì²âÇøÓò,0-±íÊ¾²»ÊÇ*/
            public byte byMotionSensitive;/*ÒÆ¶¯Õì²âÁéÃô¶È, 0 - 5,Ô½¸ßÔ½ÁéÃô,oxff¹Ø±Õ*/
            public byte byEnableHandleMotion;/* ÊÇ·ñ´¦ÀíÒÆ¶¯Õì²â 0£­·ñ 1£­ÊÇ*/
            public byte byEnableDisplay;/* ÆôÓÃÒÆ¶¯Õì²â¸ßÁÁÏÔÊ¾£º0- ·ñ£¬1- ÊÇ */
            public byte reservedData;
            public NET_DVR_HANDLEEXCEPTION_V30 struMotionHandleType;/* ´¦Àí·½Ê½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;/*²¼·ÀÊ±¼ä*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;/* ±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ*/
        }

        //ÒÆ¶¯Õì²â(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 396, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope;/*Õì²âÇøÓò,¹²ÓÐ22*18¸öÐ¡ºê¿é,Îª1±íÊ¾¸Äºê¿éÊÇÒÆ¶¯Õì²âÇøÓò,0-±íÊ¾²»ÊÇ*/
            public byte byMotionSensitive;/*ÒÆ¶¯Õì²âÁéÃô¶È, 0 - 5,Ô½¸ßÔ½ÁéÃô,0xff¹Ø±Õ*/
            public byte byEnableHandleMotion;/* ÊÇ·ñ´¦ÀíÒÆ¶¯Õì²â */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 2)]
            public string reservedData;
            public NET_DVR_HANDLEEXCEPTION strMotionHandleType;/* ´¦Àí·½Ê½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ,Îª1±íÊ¾´¥·¢¸ÃÍ¨µÀ
        }

        //ÕÚµ²±¨¾¯(×Ó½á¹¹)(9000À©Õ¹)  ÇøÓò´óÐ¡704*576
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HIDEALARM_V30
        {
            public uint dwEnableHideAlarm;/* ÊÇ·ñÆô¶¯ÕÚµ²±¨¾¯ ,0-·ñ,1-µÍÁéÃô¶È 2-ÖÐÁéÃô¶È 3-¸ßÁéÃô¶È*/
            public ushort wHideAlarmAreaTopLeftX;/* ÕÚµ²ÇøÓòµÄx×ø±ê */
            public ushort wHideAlarmAreaTopLeftY;/* ÕÚµ²ÇøÓòµÄy×ø±ê */
            public ushort wHideAlarmAreaWidth;/* ÕÚµ²ÇøÓòµÄ¿í */
            public ushort wHideAlarmAreaHeight;/*ÕÚµ²ÇøÓòµÄ¸ß*/
            public NET_DVR_HANDLEEXCEPTION_V30 strHideAlarmHandleType;	/* ´¦Àí·½Ê½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
        }

        //ÕÚµ²±¨¾¯(×Ó½á¹¹)  ÇøÓò´óÐ¡704*576
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HIDEALARM
        {
            public uint dwEnableHideAlarm;/* ÊÇ·ñÆô¶¯ÕÚµ²±¨¾¯ ,0-·ñ,1-µÍÁéÃô¶È 2-ÖÐÁéÃô¶È 3-¸ßÁéÃô¶È*/
            public ushort wHideAlarmAreaTopLeftX;/* ÕÚµ²ÇøÓòµÄx×ø±ê */
            public ushort wHideAlarmAreaTopLeftY;/* ÕÚµ²ÇøÓòµÄy×ø±ê */
            public ushort wHideAlarmAreaWidth;/* ÕÚµ²ÇøÓòµÄ¿í */
            public ushort wHideAlarmAreaHeight;/*ÕÚµ²ÇøÓòµÄ¸ß*/
            public NET_DVR_HANDLEEXCEPTION strHideAlarmHandleType;/* ´¦Àí·½Ê½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
        }

        //ÐÅºÅ¶ªÊ§±¨¾¯(×Ó½á¹¹)(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VILOST_V30
        {
            public byte byEnableHandleVILost;/* ÊÇ·ñ´¦ÀíÐÅºÅ¶ªÊ§±¨¾¯ */
            public NET_DVR_HANDLEEXCEPTION_V30 strVILostHandleType;/* ´¦Àí·½Ê½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
        }

        //ÐÅºÅ¶ªÊ§±¨¾¯(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VILOST
        {
            public byte byEnableHandleVILost;/* ÊÇ·ñ´¦ÀíÐÅºÅ¶ªÊ§±¨¾¯ */
            public NET_DVR_HANDLEEXCEPTION strVILostHandleType;/* ´¦Àí·½Ê½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
        }

        //ÕÚµ²ÇøÓò(×Ó½á¹¹)
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct NET_DVR_SHELTER
        {
            public ushort wHideAreaTopLeftX;/* ÕÚµ²ÇøÓòµÄx×ø±ê */
            public ushort wHideAreaTopLeftY;/* ÕÚµ²ÇøÓòµÄy×ø±ê */
            public ushort wHideAreaWidth;/* ÕÚµ²ÇøÓòµÄ¿í */
            public ushort wHideAreaHeight;/*ÕÚµ²ÇøÓòµÄ¸ß*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COLOR
        {
            public byte byBrightness;/*ÁÁ¶È,0-255*/
            public byte byContrast;/*¶Ô±È¶È,0-255*/
            public byte bySaturation;/*±¥ºÍ¶È,0-255*/
            public byte byHue;/*É«µ÷,0-255*/
        }

        //Í¨µÀÍ¼Ïó½á¹¹(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PICCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* Ö»¶Á ÊÓÆµÖÆÊ½ 1-NTSC 2-PAL*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byReservedData;/*±£Áô*/
            //ÏÔÊ¾Í¨µÀÃû
            public uint dwShowChanName;// Ô¤ÀÀµÄÍ¼ÏóÉÏÊÇ·ñÏÔÊ¾Í¨µÀÃû³Æ,0-²»ÏÔÊ¾,1-ÏÔÊ¾ ÇøÓò´óÐ¡704*576
            public ushort wShowNameTopLeftX;/* Í¨µÀÃû³ÆÏÔÊ¾Î»ÖÃµÄx×ø±ê */
            public ushort wShowNameTopLeftY;/* Í¨µÀÃû³ÆÏÔÊ¾Î»ÖÃµÄy×ø±ê */
            //ÊÓÆµÐÅºÅ¶ªÊ§±¨¾¯
            public NET_DVR_VILOST_V30 struVILost;
            public NET_DVR_VILOST_V30 struRes;/*±£Áô*/
            //ÒÆ¶¯Õì²â
            public NET_DVR_MOTION_V30 struMotion;
            //ÕÚµ²±¨¾¯
            public NET_DVR_HIDEALARM_V30 struHideAlarm;
            //ÕÚµ²  ÇøÓò´óÐ¡704*576
            public uint dwEnableHide;/* ÊÇ·ñÆô¶¯ÕÚµ² ,0-·ñ,1-ÊÇ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// Ô¤ÀÀµÄÍ¼ÏóÉÏÊÇ·ñÏÔÊ¾OSD,0-²»ÏÔÊ¾,1-ÏÔÊ¾ ÇøÓò´óÐ¡704*576
            public ushort wOSDTopLeftX;/* OSDµÄx×ø±ê */
            public ushort wOSDTopLeftY;/* OSDµÄy×ø±ê */
            public byte byOSDType;/* OSDÀàÐÍ(Ö÷ÒªÊÇÄêÔÂÈÕ¸ñÊ½) */
            /* 0: XXXX-XX-XX ÄêÔÂÈÕ */
            /* 1: XX-XX-XXXX ÔÂÈÕÄê */
            /* 2: XXXXÄêXXÔÂXXÈÕ */
            /* 3: XXÔÂXXÈÕXXXXÄê */
            /* 4: XX-XX-XXXX ÈÕÔÂÄê*/
            /* 5: XXÈÕXXÔÂXXXXÄê */
            public byte byDispWeek;/* ÊÇ·ñÏÔÊ¾ÐÇÆÚ */
            public byte byOSDAttrib;/* OSDÊôÐÔ:Í¸Ã÷£¬ÉÁË¸ */
            /* 0: ²»ÏÔÊ¾OSD */
            /* 1: Í¸Ã÷,ÉÁË¸ */
            /* 2: Í¸Ã÷,²»ÉÁË¸ */
            /* 3: ÉÁË¸,²»Í¸Ã÷ */
            /* 4: ²»Í¸Ã÷,²»ÉÁË¸ */
            public byte byHourOSDType;/* OSDÐ¡Ê±ÖÆ:0-24Ð¡Ê±ÖÆ,1-12Ð¡Ê±ÖÆ */
            public byte byFontSize;//×ÖÌå´óÐ¡£¬16*16(ÖÐ)/8*16(Ó¢)£¬1-32*32(ÖÐ)/16*32(Ó¢)£¬2-64*64(ÖÐ)/32*64(Ó¢)  3-48*48(ÖÐ)/24*48(Ó¢) 0xff-×ÔÊÊÓ¦(adaptive)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Í¨µÀÍ¼Ïó½á¹¹SDK_V14À©Õ¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICCFG_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* Ö»¶Á ÊÓÆµÖÆÊ½ 1-NTSC 2-PAL*/
            public byte byBrightness;/*ÁÁ¶È,0-255*/
            public byte byContrast;/*¶Ô±È¶È,0-255*/
            public byte bySaturation;/*±¥ºÍ¶È,0-255 */
            public byte byHue;/*É«µ÷,0-255*/
            //ÏÔÊ¾Í¨µÀÃû
            public uint dwShowChanName;// Ô¤ÀÀµÄÍ¼ÏóÉÏÊÇ·ñÏÔÊ¾Í¨µÀÃû³Æ,0-²»ÏÔÊ¾,1-ÏÔÊ¾ ÇøÓò´óÐ¡704*576
            public ushort wShowNameTopLeftX;/* Í¨µÀÃû³ÆÏÔÊ¾Î»ÖÃµÄx×ø±ê */
            public ushort wShowNameTopLeftY;/* Í¨µÀÃû³ÆÏÔÊ¾Î»ÖÃµÄy×ø±ê */
            //ÐÅºÅ¶ªÊ§±¨¾¯
            public NET_DVR_VILOST struVILost;
            //ÒÆ¶¯Õì²â
            public NET_DVR_MOTION struMotion;
            //ÕÚµ²±¨¾¯
            public NET_DVR_HIDEALARM struHideAlarm;
            //ÕÚµ²  ÇøÓò´óÐ¡704*576
            public uint dwEnableHide;/* ÊÇ·ñÆô¶¯ÕÚµ² ,0-·ñ,1-ÊÇ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// Ô¤ÀÀµÄÍ¼ÏóÉÏÊÇ·ñÏÔÊ¾OSD,0-²»ÏÔÊ¾,1-ÏÔÊ¾ ÇøÓò´óÐ¡704*576
            public ushort wOSDTopLeftX;/* OSDµÄx×ø±ê */
            public ushort wOSDTopLeftY;/* OSDµÄy×ø±ê */
            public byte byOSDType;/* OSDÀàÐÍ(Ö÷ÒªÊÇÄêÔÂÈÕ¸ñÊ½) */
            /* 0: XXXX-XX-XX ÄêÔÂÈÕ */
            /* 1: XX-XX-XXXX ÔÂÈÕÄê */
            /* 2: XXXXÄêXXÔÂXXÈÕ */
            /* 3: XXÔÂXXÈÕXXXXÄê */
            /* 4: XX-XX-XXXX ÈÕÔÂÄê*/
            /* 5: XXÈÕXXÔÂXXXXÄê */
            public byte byDispWeek;/* ÊÇ·ñÏÔÊ¾ÐÇÆÚ */
            public byte byOSDAttrib;/* OSDÊôÐÔ:Í¸Ã÷£¬ÉÁË¸ */
            /* 0: ²»ÏÔÊ¾OSD */
            /* 1: Í¸Ã÷,ÉÁË¸ */
            /* 2: Í¸Ã÷,²»ÉÁË¸ */
            /* 3: ÉÁË¸,²»Í¸Ã÷ */
            /* 4: ²»Í¸Ã÷,²»ÉÁË¸ */
            public byte byHourOsdType;/* OSDÐ¡Ê±ÖÆ:0-24Ð¡Ê±ÖÆ,1-12Ð¡Ê±ÖÆ */
        }

        //Í¨µÀÍ¼Ïó½á¹¹(SDK_V13¼°Ö®Ç°°æ±¾)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* Ö»¶Á ÊÓÆµÖÆÊ½ 1-NTSC 2-PAL*/
            public byte byBrightness;/*ÁÁ¶È,0-255*/
            public byte byContrast;/*¶Ô±È¶È,0-255*/
            public byte bySaturation;/*±¥ºÍ¶È,0-255 */
            public byte byHue;/*É«µ÷,0-255*/
            //ÏÔÊ¾Í¨µÀÃû
            public uint dwShowChanName;// Ô¤ÀÀµÄÍ¼ÏóÉÏÊÇ·ñÏÔÊ¾Í¨µÀÃû³Æ,0-²»ÏÔÊ¾,1-ÏÔÊ¾ ÇøÓò´óÐ¡704*576
            public ushort wShowNameTopLeftX;/* Í¨µÀÃû³ÆÏÔÊ¾Î»ÖÃµÄx×ø±ê */
            public ushort wShowNameTopLeftY;/* Í¨µÀÃû³ÆÏÔÊ¾Î»ÖÃµÄy×ø±ê */
            //ÐÅºÅ¶ªÊ§±¨¾¯
            public NET_DVR_VILOST struVILost;
            //ÒÆ¶¯Õì²â
            public NET_DVR_MOTION struMotion;
            //ÕÚµ²±¨¾¯
            public NET_DVR_HIDEALARM struHideAlarm;
            //ÕÚµ²  ÇøÓò´óÐ¡704*576
            public uint dwEnableHide;/* ÊÇ·ñÆô¶¯ÕÚµ² ,0-·ñ,1-ÊÇ*/
            public ushort wHideAreaTopLeftX;/* ÕÚµ²ÇøÓòµÄx×ø±ê */
            public ushort wHideAreaTopLeftY;/* ÕÚµ²ÇøÓòµÄy×ø±ê */
            public ushort wHideAreaWidth;/* ÕÚµ²ÇøÓòµÄ¿í */
            public ushort wHideAreaHeight;/*ÕÚµ²ÇøÓòµÄ¸ß*/
            //OSD
            public uint dwShowOsd;// Ô¤ÀÀµÄÍ¼ÏóÉÏÊÇ·ñÏÔÊ¾OSD,0-²»ÏÔÊ¾,1-ÏÔÊ¾ ÇøÓò´óÐ¡704*576
            public ushort wOSDTopLeftX;/* OSDµÄx×ø±ê */
            public ushort wOSDTopLeftY;/* OSDµÄy×ø±ê */
            public byte byOSDType;/* OSDÀàÐÍ(Ö÷ÒªÊÇÄêÔÂÈÕ¸ñÊ½) */
            /* 0: XXXX-XX-XX ÄêÔÂÈÕ */
            /* 1: XX-XX-XXXX ÔÂÈÕÄê */
            /* 2: XXXXÄêXXÔÂXXÈÕ */
            /* 3: XXÔÂXXÈÕXXXXÄê */
            /* 4: XX-XX-XXXX ÈÕÔÂÄê*/
            /* 5: XXÈÕXXÔÂXXXXÄê */
            public byte byDispWeek;/* ÊÇ·ñÏÔÊ¾ÐÇÆÚ */
            public byte byOSDAttrib;/* OSDÊôÐÔ:Í¸Ã÷£¬ÉÁË¸ */
            /* 0: ²»ÏÔÊ¾OSD */
            /* 1: Í¸Ã÷,ÉÁË¸ */
            /* 2: Í¸Ã÷,²»ÉÁË¸ */
            /* 3: ÉÁË¸,²»Í¸Ã÷ */
            /* 4: ²»Í¸Ã÷,²»ÉÁË¸ */
            public byte reservedData2;
        }

        //ÂëÁ÷Ñ¹Ëõ²ÎÊý(×Ó½á¹¹)(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO_V30
        {
            public byte byStreamType;//ÂëÁ÷ÀàÐÍ 0-ÊÓÆµÁ÷, 1-¸´ºÏÁ÷, ±íÊ¾ÊÂ¼þÑ¹Ëõ²ÎÊýÊ±×î¸ßÎ»±íÊ¾ÊÇ·ñÆôÓÃÑ¹Ëõ²ÎÊý
            public byte byResolution;//·Ö±æÂÊ0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5£¨±£Áô£©16-VGA£¨640*480£© 17-UXGA£¨1600*1200£© 18-SVGA £¨800*600£©19-HD720p£¨1280*720£©20-XVGA  21-HD900p
            public byte byBitrateType;//ÂëÂÊÀàÐÍ 0:±äÂëÂÊ, 1:¶¨ÂëÂÊ
            public byte byPicQuality;//Í¼ÏóÖÊÁ¿ 0-×îºÃ 1-´ÎºÃ 2-½ÏºÃ 3-Ò»°ã 4-½Ï²î 5-²î
            public uint dwVideoBitrate;//ÊÓÆµÂëÂÊ 0-±£Áô 1-16K 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //×î¸ßÎ»(31Î»)ÖÃ³É1±íÊ¾ÊÇ×Ô¶¨ÒåÂëÁ÷, 0-30Î»±íÊ¾ÂëÁ÷Öµ¡£
            public uint dwVideoFrameRate;//Ö¡ÂÊ 0-È«²¿; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; V2.0°æ±¾ÖÐÐÂ¼Ó14-15; 15-18; 16-22;
            public ushort wIntervalFrameI;//IÖ¡¼ä¸ô
            //2006-08-11 Ôö¼Óµ¥PÖ¡µÄÅäÖÃ½Ó¿Ú£¬¿ÉÒÔ¸ÄÉÆÊµÊ±Á÷ÑÓÊ±ÎÊÌâ
            public byte byIntervalBPFrame;//0-BBPÖ¡; 1-BPÖ¡; 2-µ¥PÖ¡
            public byte byres1; //±£Áô
            public byte byVideoEncType;//ÊÓÆµ±àÂëÀàÐÍ 0 hik264;1±ê×¼h264; 2±ê×¼mpeg4;
            public byte byAudioEncType; //ÒôÆµ±àÂëÀàÐÍ 0£­OggVorbis
            public byte byVideoEncComplexity; //ÊÓÆµ±àÂë¸´ÔÓ¶È£¬0-µÍ£¬1-ÖÐ£¬2¸ß,0xfe:×Ô¶¯£¬ºÍÔ´Ò»ÖÂ
            public byte byEnableSvc; //0 - ²»ÆôÓÃSVC¹¦ÄÜ£»1- ÆôÓÃSVC¹¦ÄÜ
            public byte byFormatType; //·â×°ÀàÐÍ£¬1-ÂãÁ÷£¬2-RTP·â×°£¬3-PS·â×°£¬4-TS·â×°£¬5-Ë½ÓÐ£¬6-FLV£¬7-ASF£¬8-3GP,9-RTP+PS£¨¹ú±ê£ºGB28181£©£¬0xff-ÎÞÐ§
            public byte byAudioBitRate; //ÒôÆµÂëÂÊ0-Ä¬ÈÏ£¬1-8Kbps, 2- 16Kbps, 3-32Kbps£¬4-64Kbps£¬5-128Kbps£¬6-192Kbps£»(IPC5.1.0Ä¬ÈÏ4-64Kbps)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;//ÕâÀï±£ÁôÒôÆµµÄÑ¹Ëõ²ÎÊý
        }

        //Í¨µÀÑ¹Ëõ²ÎÊý(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_V30
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_V30 struNormHighRecordPara;//Â¼Ïñ ¶ÔÓ¦8000µÄÆÕÍ¨
            public NET_DVR_COMPRESSION_INFO_V30 struRes;//±£Áô char reserveData[28];
            public NET_DVR_COMPRESSION_INFO_V30 struEventRecordPara;//ÊÂ¼þ´¥·¢Ñ¹Ëõ²ÎÊý
            public NET_DVR_COMPRESSION_INFO_V30 struNetPara;//Íø´«(×ÓÂëÁ÷)
        }

        //ÂëÁ÷Ñ¹Ëõ²ÎÊý(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO
        {
            public byte byStreamType;//ÂëÁ÷ÀàÐÍ0-ÊÓÆµÁ÷,1-¸´ºÏÁ÷,±íÊ¾Ñ¹Ëõ²ÎÊýÊ±×î¸ßÎ»±íÊ¾ÊÇ·ñÆôÓÃÑ¹Ëõ²ÎÊý
            public byte byResolution;//·Ö±æÂÊ0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(³µÔØ×¨ÓÃ)
            public byte byBitrateType;//ÂëÂÊÀàÐÍ0:±äÂëÂÊ£¬1:¶¨ÂëÂÊ
            public byte byPicQuality;//Í¼ÏóÖÊÁ¿ 0-×îºÃ 1-´ÎºÃ 2-½ÏºÃ 3-Ò»°ã 4-½Ï²î 5-²î
            public uint dwVideoBitrate; //ÊÓÆµÂëÂÊ 0-±£Áô 1-16K(±£Áô) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //×î¸ßÎ»(31Î»)ÖÃ³É1±íÊ¾ÊÇ×Ô¶¨ÒåÂëÁ÷, 0-30Î»±íÊ¾ÂëÁ÷Öµ(MIN-32K MAX-8192K)¡£
            public uint dwVideoFrameRate;//Ö¡ÂÊ 0-È«²¿; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20;
        }

        //Í¨µÀÑ¹Ëõ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO struRecordPara;//Â¼Ïñ/ÊÂ¼þ´¥·¢Â¼Ïñ
            public NET_DVR_COMPRESSION_INFO struNetPara;//Íø´«/±£Áô
        }

        //ÂëÁ÷Ñ¹Ëõ²ÎÊý(×Ó½á¹¹)(À©Õ¹) Ôö¼ÓIÖ¡¼ä¸ô
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO_EX
        {
            public byte byStreamType;//ÂëÁ÷ÀàÐÍ0-ÊÓÆµÁ÷, 1-¸´ºÏÁ÷
            public byte byResolution;//·Ö±æÂÊ0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(³µÔØ×¨ÓÃ)
            public byte byBitrateType;//ÂëÂÊÀàÐÍ0:±äÂëÂÊ£¬1:¶¨ÂëÂÊ
            public byte byPicQuality;//Í¼ÏóÖÊÁ¿ 0-×îºÃ 1-´ÎºÃ 2-½ÏºÃ 3-Ò»°ã 4-½Ï²î 5-²î
            public uint dwVideoBitrate;//ÊÓÆµÂëÂÊ 0-±£Áô 1-16K(±£Áô) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //×î¸ßÎ»(31Î»)ÖÃ³É1±íÊ¾ÊÇ×Ô¶¨ÒåÂëÁ÷, 0-30Î»±íÊ¾ÂëÁ÷Öµ(MIN-32K MAX-8192K)¡£
            public uint dwVideoFrameRate;//Ö¡ÂÊ 0-È«²¿; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, //V2.0Ôö¼Ó14-15, 15-18, 16-22;
            public ushort wIntervalFrameI;//IÖ¡¼ä¸ô
            //2006-08-11 Ôö¼Óµ¥PÖ¡µÄÅäÖÃ½Ó¿Ú£¬¿ÉÒÔ¸ÄÉÆÊµÊ±Á÷ÑÓÊ±ÎÊÌâ
            public byte byIntervalBPFrame;//0-BBPÖ¡; 1-BPÖ¡; 2-µ¥PÖ¡
            public byte byRes;
        }

        //Í¨µÀÑ¹Ëõ²ÎÊý(À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_EX
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_EX struRecordPara;//Â¼Ïñ
            public NET_DVR_COMPRESSION_INFO_EX struNetPara;//Íø´«
        }

        //Ê±¼ä¶ÎÂ¼Ïñ²ÎÊýÅäÖÃ(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RECORDSCHED
        {
            public NET_DVR_SCHEDTIME struRecordTime;
            public byte byRecordType;//0:¶¨Ê±Â¼Ïñ£¬1:ÒÆ¶¯Õì²â£¬2:±¨¾¯Â¼Ïñ£¬3:¶¯²â|±¨¾¯£¬4:¶¯²â&±¨¾¯, 5:ÃüÁî´¥·¢, 6: ÖÇÄÜÂ¼Ïñ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string reservedData;
        }

        //È«ÌìÂ¼Ïñ²ÎÊýÅäÖÃ(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORDDAY
        {
            public ushort wAllDayRecord;/* ÊÇ·ñÈ«ÌìÂ¼Ïñ 0-·ñ 1-ÊÇ*/
            public byte byRecordType;/* Â¼ÏóÀàÐÍ 0:¶¨Ê±Â¼Ïñ£¬1:ÒÆ¶¯Õì²â£¬2:±¨¾¯Â¼Ïñ£¬3:¶¯²â|±¨¾¯£¬4:¶¯²â&±¨¾¯ 5:ÃüÁî´¥·¢, 6: ÖÇÄÜÂ¼Ïñ*/
            public byte reservedData;
        }

        //Í¨µÀÂ¼Ïñ²ÎÊýÅäÖÃ(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_V30
        {
            public uint dwSize;
            public uint dwRecord;/*ÊÇ·ñÂ¼Ïñ 0-·ñ 1-ÊÇ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDDAY[] struRecAllDay;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched;
            public uint dwRecordTime;/* Â¼ÏóÑÓÊ±³¤¶È 0-5Ãë£¬ 1-20Ãë£¬ 2-30Ãë£¬ 3-1·ÖÖÓ£¬ 4-2·ÖÖÓ£¬ 5-5·ÖÖÓ£¬ 6-10·ÖÖÓ*/
            public uint dwPreRecordTime;/* Ô¤Â¼Ê±¼ä 0-²»Ô¤Â¼ 1-5Ãë 2-10Ãë 3-15Ãë 4-20Ãë 5-25Ãë 6-30Ãë 7-0xffffffff(¾¡¿ÉÄÜÔ¤Â¼) */
            public uint dwRecorderDuration;/* Â¼Ïñ±£´æµÄ×î³¤Ê±¼ä */
            public byte byRedundancyRec;/*ÊÇ·ñÈßÓàÂ¼Ïñ,ÖØÒªÊý¾ÝË«±¸·Ý£º0/1*/
            public byte byAudioRec;/*Â¼ÏñÊ±¸´ºÏÁ÷±àÂëÊ±ÊÇ·ñ¼ÇÂ¼ÒôÆµÊý¾Ý£º¹úÍâÓÐ´Ë·¨¹æ*/
            public byte byStreamType;  // 0:Ö÷ÂëÁ÷ 1£º×ÓÂëÁ÷
            public byte byPassbackRecord;  // 0:²»»Ø´«Â¼Ïñ 1£º»Ø´«Â¼Ïñ
            public ushort wLockDuration;  // Â¼ÏñËø¶¨Ê±³¤£¬µ¥Î»Ð¡Ê± 0±íÊ¾²»Ëø¶¨£¬0xffff±íÊ¾ÓÀ¾ÃËø¶¨£¬Â¼Ïñ¶ÎµÄÊ±³¤´óÓÚËø¶¨µÄ³ÖÐøÊ±³¤µÄÂ¼Ïñ£¬½«²»»áËø¶¨
            public byte byRecordBackup;  // 0:Â¼Ïñ²»´æµµ 1£ºÂ¼Ïñ´æµµ
            public byte bySVCLevel;	//SVC³éÖ¡ÀàÐÍ£º0-²»³é£¬1-³é¶þ·ÖÖ®Ò» 2-³éËÄ·ÖÖ®Èý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byReserve;
        }

        //Í¨µÀÂ¼Ïñ²ÎÊýÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD
        {
            public uint dwSize;
            public uint dwRecord;/*ÊÇ·ñÂ¼Ïñ 0-·ñ 1-ÊÇ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDDAY[] struRecAllDay;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched;
            public uint dwRecordTime;/* Â¼ÏóÊ±¼ä³¤¶È */
            public uint dwPreRecordTime;/* Ô¤Â¼Ê±¼ä 0-²»Ô¤Â¼ 1-5Ãë 2-10Ãë 3-15Ãë 4-20Ãë 5-25Ãë 6-30Ãë 7-0xffffffff(¾¡¿ÉÄÜÔ¤Â¼) */
        }

        //ÔÆÌ¨Ð­Òé±í½á¹¹ÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZ_PROTOCOL
        {
            public uint dwType;/*½âÂëÆ÷ÀàÐÍÖµ£¬´Ó1¿ªÊ¼Á¬ÐøµÝÔö*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe;/*½âÂëÆ÷µÄÃèÊö·û£¬ºÍ8000ÖÐµÄÒ»ÖÂ*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PTZ_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PTZ_PROTOCOL[] struPtz;/*×î´ó200ÖÐPTZÐ­Òé*/
            public uint dwPtzNum;/*ÓÐÐ§µÄptzÐ­ÒéÊýÄ¿£¬´Ó0¿ªÊ¼(¼´¼ÆËãÊ±¼Ó1)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /***************************ÔÆÌ¨ÀàÐÍ(end)******************************/

        //Í¨µÀ½âÂëÆ÷(ÔÆÌ¨)²ÎÊýÅäÖÃ(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERCFG_V30
        {
            public uint dwSize;
            public uint dwBaudRate;//²¨ÌØÂÊ(bps)£¬0£­50£¬1£­75£¬2£­110£¬3£­150£¬4£­300£¬5£­600£¬6£­1200£¬7£­2400£¬8£­4800£¬9£­9600£¬10£­19200£¬ 11£­38400£¬12£­57600£¬13£­76800£¬14£­115.2k;
            public byte byDataBit;// Êý¾ÝÓÐ¼¸Î» 0£­5Î»£¬1£­6Î»£¬2£­7Î»£¬3£­8Î»;
            public byte byStopBit;// Í£Ö¹Î» 0£­1Î»£¬1£­2Î»
            public byte byParity;// Ð£Ñé 0£­ÎÞÐ£Ñé£¬1£­ÆæÐ£Ñé£¬2£­Å¼Ð£Ñé;
            public byte byFlowcontrol;// 0£­ÎÞ£¬1£­ÈíÁ÷¿Ø,2-Ó²Á÷¿Ø
            public ushort wDecoderType;//½âÂëÆ÷ÀàÐÍ, ´Ó0¿ªÊ¼£¬¶ÔÓ¦ptzÐ­ÒéÁÐ±í
            public ushort wDecoderAddress;/*½âÂëÆ÷µØÖ·:0 - 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PRESET_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetPreset;/* Ô¤ÖÃµãÊÇ·ñÉèÖÃ,0-Ã»ÓÐÉèÖÃ,1-ÉèÖÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CRUISE_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetCruise;/* Ñ²º½ÊÇ·ñÉèÖÃ: 0-Ã»ÓÐÉèÖÃ,1-ÉèÖÃ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRACK_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetTrack;/* ¹ì¼£ÊÇ·ñÉèÖÃ,0-Ã»ÓÐÉèÖÃ,1-ÉèÖÃ*/
        }

        //Í¨µÀ½âÂëÆ÷(ÔÆÌ¨)²ÎÊýÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERCFG
        {
            public uint dwSize;
            public uint dwBaudRate; //²¨ÌØÂÊ(bps)£¬0£­50£¬1£­75£¬2£­110£¬3£­150£¬4£­300£¬5£­600£¬6£­1200£¬7£­2400£¬8£­4800£¬9£­9600£¬10£­19200£¬ 11£­38400£¬12£­57600£¬13£­76800£¬14£­115.2k;
            public byte byDataBit; // Êý¾ÝÓÐ¼¸Î» 0£­5Î»£¬1£­6Î»£¬2£­7Î»£¬3£­8Î»;
            public byte byStopBit;// Í£Ö¹Î» 0£­1Î»£¬1£­2Î»;
            public byte byParity; // Ð£Ñé 0£­ÎÞÐ£Ñé£¬1£­ÆæÐ£Ñé£¬2£­Å¼Ð£Ñé;
            public byte byFlowcontrol;// 0£­ÎÞ£¬1£­ÈíÁ÷¿Ø,2-Ó²Á÷¿Ø
            public ushort wDecoderType;//½âÂëÆ÷ÀàÐÍ, 0£­YouLi£¬1£­LiLin-1016£¬2£­LiLin-820£¬3£­Pelco-p£¬4£­DM DynaColor£¬5£­HD600£¬6£­JC-4116£¬7£­Pelco-d WX£¬8£­Pelco-d PICO
            public ushort wDecoderAddress;/*½âÂëÆ÷µØÖ·:0 - 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PRESET, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetPreset;/* Ô¤ÖÃµãÊÇ·ñÉèÖÃ,0-Ã»ÓÐÉèÖÃ,1-ÉèÖÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CRUISE, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetCruise;/* Ñ²º½ÊÇ·ñÉèÖÃ: 0-Ã»ÓÐÉèÖÃ,1-ÉèÖÃ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRACK, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetTrack;/* ¹ì¼£ÊÇ·ñÉèÖÃ,0-Ã»ÓÐÉèÖÃ,1-ÉèÖÃ*/
        }

        //ppp²ÎÊýÅäÖÃ(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPCFG_V30
        {
            public NET_DVR_IPADDR struRemoteIP;//Ô¶¶ËIPµØÖ·
            public NET_DVR_IPADDR struLocalIP;//±¾µØIPµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIPMask;//±¾µØIPµØÖ·ÑÚÂë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* ÓÃ»§Ãû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ÃÜÂë */
            public byte byPPPMode;//PPPÄ£Ê½, 0£­Ö÷¶¯£¬1£­±»¶¯
            public byte byRedial;//ÊÇ·ñ»Ø²¦ £º0-·ñ,1-ÊÇ
            public byte byRedialMode;//»Ø²¦Ä£Ê½,0-ÓÉ²¦ÈëÕßÖ¸¶¨,1-Ô¤ÖÃ»Ø²¦ºÅÂë
            public byte byDataEncrypt;//Êý¾Ý¼ÓÃÜ,0-·ñ,1-ÊÇ
            public uint dwMTU;//MTU
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PHONENUMBER_LEN)]
            public string sTelephoneNumber;//µç»°ºÅÂë
        }

        //ppp²ÎÊýÅäÖÃ(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPCFG
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteIP;//Ô¶¶ËIPµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIP;//±¾µØIPµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIPMask;//±¾µØIPµØÖ·ÑÚÂë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* ÓÃ»§Ãû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ÃÜÂë */
            public byte byPPPMode;//PPPÄ£Ê½, 0£­Ö÷¶¯£¬1£­±»¶¯
            public byte byRedial;//ÊÇ·ñ»Ø²¦ £º0-·ñ,1-ÊÇ
            public byte byRedialMode;//»Ø²¦Ä£Ê½,0-ÓÉ²¦ÈëÕßÖ¸¶¨,1-Ô¤ÖÃ»Ø²¦ºÅÂë
            public byte byDataEncrypt;//Êý¾Ý¼ÓÃÜ,0-·ñ,1-ÊÇ
            public uint dwMTU;//MTU
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PHONENUMBER_LEN)]
            public string sTelephoneNumber;//µç»°ºÅÂë
        }

        //RS232´®¿Ú²ÎÊýÅäÖÃ(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_RS232
        {
            public uint dwBaudRate;/*²¨ÌØÂÊ(bps)£¬0£­50£¬1£­75£¬2£­110£¬3£­150£¬4£­300£¬5£­600£¬6£­1200£¬7£­2400£¬8£­4800£¬9£­9600£¬10£­19200£¬ 11£­38400£¬12£­57600£¬13£­76800£¬14£­115.2k;*/
            public byte byDataBit;/* Êý¾ÝÓÐ¼¸Î» 0£­5Î»£¬1£­6Î»£¬2£­7Î»£¬3£­8Î» */
            public byte byStopBit;/* Í£Ö¹Î» 0£­1Î»£¬1£­2Î» */
            public byte byParity;/* Ð£Ñé 0£­ÎÞÐ£Ñé£¬1£­ÆæÐ£Ñé£¬2£­Å¼Ð£Ñé */
            public byte byFlowcontrol;/* 0£­ÎÞ£¬1£­ÈíÁ÷¿Ø,2-Ó²Á÷¿Ø */
            public uint dwWorkMode; /* ¹¤×÷Ä£Ê½£¬0£­232´®¿ÚÓÃÓÚPPP²¦ºÅ£¬1£­232´®¿ÚÓÃÓÚ²ÎÊý¿ØÖÆ£¬2£­Í¸Ã÷Í¨µÀ */
        }

        //RS232´®¿Ú²ÎÊýÅäÖÃ(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RS232CFG_V30
        {
            public uint dwSize;
            public NET_DVR_SINGLE_RS232 struRs232;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 84, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_PPPCFG_V30 struPPPConfig;
        }

        //RS232´®¿Ú²ÎÊýÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RS232CFG
        {
            public uint dwSize;
            public uint dwBaudRate;//²¨ÌØÂÊ(bps)£¬0£­50£¬1£­75£¬2£­110£¬3£­150£¬4£­300£¬5£­600£¬6£­1200£¬7£­2400£¬8£­4800£¬9£­9600£¬10£­19200£¬ 11£­38400£¬12£­57600£¬13£­76800£¬14£­115.2k;
            public byte byDataBit;// Êý¾ÝÓÐ¼¸Î» 0£­5Î»£¬1£­6Î»£¬2£­7Î»£¬3£­8Î»;
            public byte byStopBit;// Í£Ö¹Î» 0£­1Î»£¬1£­2Î»;
            public byte byParity;// Ð£Ñé 0£­ÎÞÐ£Ñé£¬1£­ÆæÐ£Ñé£¬2£­Å¼Ð£Ñé;
            public byte byFlowcontrol;// 0£­ÎÞ£¬1£­ÈíÁ÷¿Ø,2-Ó²Á÷¿Ø
            public uint dwWorkMode;// ¹¤×÷Ä£Ê½£¬0£­Õ­´ø´«Êä(232´®¿ÚÓÃÓÚPPP²¦ºÅ)£¬1£­¿ØÖÆÌ¨(232´®¿ÚÓÃÓÚ²ÎÊý¿ØÖÆ)£¬2£­Í¸Ã÷Í¨µÀ
            public NET_DVR_PPPCFG struPPPConfig;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PRESETCHAN_INFO
        {
            public uint dwEnablePresetChan;	/*ÆôÓÃÔ¤ÖÃµãµÄÍ¨µÀ*/
            public uint dwPresetPointNo;		/*µ÷ÓÃÔ¤ÖÃµãÍ¨µÀ¶ÔÓ¦µÄÔ¤ÖÃµãÐòºÅ, 0xfffffff±íÊ¾²»µ÷ÓÃÔ¤ÖÃµã¡£*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISECHAN_INFO
        {
            public uint dwEnableCruiseChan;	/*ÆôÓÃÑ²º½µÄÍ¨µÀ*/
            public uint dwCruiseNo;		/*Ñ²º½Í¨µÀ¶ÔÓ¦µÄÑ²º½±àºÅ, 0xfffffff±íÊ¾ÎÞÐ§*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZTRACKCHAN_INFO
        {
            public uint dwEnablePtzTrackChan;	/*ÆôÓÃÔÆÌ¨¹ì¼£µÄÍ¨µÀ*/
            public uint dwPtzTrackNo;		/*ÔÆÌ¨¹ì¼£Í¨µÀ¶ÔÓ¦µÄ±àºÅ, 0xfffffff±íÊ¾ÎÞÐ§*/
        }

        //±¨¾¯ÊäÈë²ÎÊýÅäÖÃ(256Â·NVRÀ©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;	/* Ãû³Æ */
            public byte byAlarmType;	            //±¨¾¯Æ÷ÀàÐÍ,0£º³£¿ª,1£º³£±Õ
            public byte byAlarmInHandle;	        /* ÊÇ·ñ´¦Àí 0-²»´¦Àí 1-´¦Àí*/
            public byte byChannel;                 // ±¨¾¯ÊäÈë´¥·¢ÖÇÄÜÊ¶±ðÍ¨µÀ
            public byte byRes1;                    //±£Áô			
            public uint dwHandleType;        //Òì³£´¦Àí,Òì³£´¦Àí·½Ê½µÄ"»ò"½á¹û   
            /*0x00: ÎÞÏìÓ¦*/
            /*0x01: ¼àÊÓÆ÷ÉÏ¾¯¸æ*/
            /*0x02: ÉùÒô¾¯¸æ*/
            /*0x04: ÉÏ´«ÖÐÐÄ*/
            /*0x08: ´¥·¢±¨¾¯Êä³ö*/
            /*0x10: ´¥·¢JPRG×¥Í¼²¢ÉÏ´«Email*/
            /*0x20: ÎÞÏßÉù¹â±¨¾¯Æ÷Áª¶¯*/
            /*0x40: Áª¶¯µç×ÓµØÍ¼(Ä¿Ç°Ö»ÓÐPCNVRÖ§³Ö)*/
            /*0x200: ×¥Í¼²¢ÉÏ´«FTP*/
            public uint dwMaxRelAlarmOutChanNum; //´¥·¢µÄ±¨¾¯Êä³öÍ¨µÀÊý£¨Ö»¶Á£©×î´óÖ§³ÖÊýÁ¿
            public uint dwRelAlarmOutChanNum; //´¥·¢µÄ±¨¾¯Êä³öÍ¨µÀÊý Êµ¼ÊÖ§³ÖÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //´¥·¢±¨¾¯Í¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            /*´¥·¢µÄÂ¼ÏñÍ¨µÀ*/
            public uint dwMaxRecordChanNum;   //Éè±¸Ö§³ÖµÄ×î´ó¹ØÁªÂ¼ÏñÍ¨µÀÊý-Ö»¶Á
            public uint dwCurRecordChanNum;    //µ±Ç°Êµ¼ÊÒÑÅäÖÃµÄ¹ØÁªÂ¼ÏñÍ¨µÀÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;   /* Êµ¼Ê´¥·¢Â¼ÏñÍ¨µÀ£¬°´Öµ±íÊ¾,²ÉÓÃ½ô´ÕÐÍÅÅÁÐ£¬´ÓÏÂ±ê0 - dwCurRecordChanNum -1ÓÐÐ§£¬Èç¹ûÖÐ¼äÓöµ½0xffffffff,ÔòºóÐøÎÞÐ§*/
            public uint dwMaxEnablePtzCtrlNun; //×î´ó¿ÉÆôÓÃµÄÔÆÌ¨¿ØÖÆ×ÜÊý(Ö»¶Á)
            public uint dwEnablePresetChanNum;  //µ±Ç°ÒÑÆôÓÃÔ¤ÖÃµãµÄÊýÄ¿
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PRESETCHAN_INFO[] struPresetChanInfo; //ÆôÓÃµÄÔ¤ÖÃµãÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 516, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;					/*±£Áô*/
            public uint dwEnableCruiseChanNum;  //µ±Ç°ÒÑÆôÓÃÑ²º½µÄÍ¨µÀÊýÄ¿
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CRUISECHAN_INFO[] struCruiseChanInfo; //ÆôÓÃÑ²º½¹¦ÄÜÍ¨µÀµÄÐÅÏ¢
            public uint dwEnablePtzTrackChanNum;  //µ±Ç°ÒÑÆôÓÃÑ²º½µÄÍ¨µÀÊýÄ¿
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PTZTRACKCHAN_INFO[] struPtzTrackInfo; //µ÷ÓÃÔÆÌ¨¹ì¼£µÄÍ¨µÀÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±¨¾¯ÊäÈë²ÎÊýÅäÖÃ(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;/* Ãû³Æ */
            public byte byAlarmType; //±¨¾¯Æ÷ÀàÐÍ,0£º³£¿ª,1£º³£±Õ
            public byte byAlarmInHandle; /* ÊÇ·ñ´¦Àí 0-²»´¦Àí 1-´¦Àí*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType;/* ´¦Àí·½Ê½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ,Îª1±íÊ¾´¥·¢¸ÃÍ¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePreset;/* ÊÇ·ñµ÷ÓÃÔ¤ÖÃµã 0-·ñ,1-ÊÇ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* µ÷ÓÃµÄÔÆÌ¨Ô¤ÖÃµãÐòºÅ,Ò»¸ö±¨¾¯ÊäÈë¿ÉÒÔµ÷ÓÃ¶à¸öÍ¨µÀµÄÔÆÌ¨Ô¤ÖÃµã, 0xff±íÊ¾²»µ÷ÓÃÔ¤ÖÃµã¡£*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 192, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;/*±£Áô*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnableCruise;/* ÊÇ·ñµ÷ÓÃÑ²º½ 0-·ñ,1-ÊÇ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseNo;/* Ñ²º½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePtzTrack;/* ÊÇ·ñµ÷ÓÃ¹ì¼£ 0-·ñ,1-ÊÇ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPTZTrack;/* µ÷ÓÃµÄÔÆÌ¨µÄ¹ì¼£ÐòºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_IO_ALARM
        {
            public uint dwAlarmInputNo;		//·¢Éú±¨¾¯µÄ±¨¾¯ÊäÈëÍ¨µÀºÅ£¬Ò»´ÎÖ»ÓÐÒ»¸ö
            public uint dwTrigerAlarmOutNum;	/*´¥·¢µÄ±¨¾¯Êä³ö¸öÊý£¬ÓÃÓÚºóÃæ¼ÆËã±ä³¤Êý¾Ý²¿·ÖÖÐËùÓÐ´¥·¢µÄ±¨¾¯Êä³öÍ¨µÀºÅ£¬ËÄ×Ö½Ú±íÊ¾Ò»¸ö*/
            public uint dwTrigerRecordChanNum;	/*´¥·¢µÄÂ¼ÏñÍ¨µÀ¸öÊý£¬ÓÃÓÚºóÃæ¼ÆËã±ä³¤Êý¾Ý²¿·ÖÖÐËùÓÐ´¥·¢µÄÂ¼ÏñÍ¨µÀºÅ£¬ËÄ×Ö½Ú±íÊ¾Ò»¸ö*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ALARM_CHANNEL
        {
            public uint dwAlarmChanNum;	/*·¢Éú±¨¾¯Í¨µÀÊý¾Ý¸öÊý£¬ÓÃÓÚºóÃæ¼ÆËã±ä³¤Êý¾Ý²¿·ÖÖÐËùÓÐ·¢ÉúµÄ±¨¾¯Í¨µÀºÅ£¬ËÄ×Ö½Ú±íÊ¾Ò»¸ö*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ALARM_HD
        {
            public uint dwAlarmHardDiskNum;	/*·¢Éú±¨¾¯µÄÓ²ÅÌÊý¾Ý³¤¶È£¬ÓÃÓÚºóÃæ¼ÆËã±ä³¤Êý¾Ý²¿·ÖÖÐËùÓÐ·¢Éú±¨¾¯µÄÓ²ÅÌºÅ£¬ËÄ½Ú±íÊ¾Ò»¸ö*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_ALARMINFO_FIXED
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnionLen;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALRAM_FIXED_HEADER
        {
            public uint dwAlarmType;              /*0-ÐÅºÅÁ¿±¨¾¯,1-Ó²ÅÌÂú,2-ÐÅºÅ¶ªÊ§£¬3£­ÒÆ¶¯Õì²â£¬4£­Ó²ÅÌÎ´¸ñÊ½»¯,5-Ð´Ó²ÅÌ³ö´í,6-ÕÚµ²±¨¾¯£¬7-ÖÆÊ½²»Æ¥Åä, 8-·Ç·¨·ÃÎÊ£¬9-ÊÓÆµÐÅºÅÒì³££¬10-Â¼ÏñÒì³££¬11-ÖÇÄÜ³¡¾°±ä»¯£¬12-ÕóÁÐÒì³££¬13-Ç°¶Ë/Â¼Ïñ·Ö±æÂÊ²»Æ¥Åä*/
            public NET_DVR_TIME_EX struAlarmTime;	//·¢Éú±¨¾¯µÄÊ±¼ä
            public UNION_ALARMINFO_FIXED uStruAlarm;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_V40
        {
            public NET_DVR_ALRAM_FIXED_HEADER struAlarmFixedHeader;	//±¨¾¯¹Ì¶¨²¿·Ö
            public IntPtr pAlarmData;   //±¨¾¯¿É±ä²¿·ÖÄÚÈÝ
        }

        //±¨¾¯ÊäÈë²ÎÊýÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;/* Ãû³Æ */
            public byte byAlarmType;//±¨¾¯Æ÷ÀàÐÍ,0£º³£¿ª,1£º³£±Õ
            public byte byAlarmInHandle;/* ÊÇ·ñ´¦Àí 0-²»´¦Àí 1-´¦Àí*/
            public byte byChannel;     // ±¨¾¯ÊäÈë´¥·¢ÖÇÄÜÊ¶±ðÍ¨µÀ
            public byte byRes;
            public NET_DVR_HANDLEEXCEPTION struAlarmHandleType;/* ´¦Àí·½Ê½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ,Îª1±íÊ¾´¥·¢¸ÃÍ¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePreset;/* ÊÇ·ñµ÷ÓÃÔ¤ÖÃµã 0-·ñ,1-ÊÇ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* µ÷ÓÃµÄÔÆÌ¨Ô¤ÖÃµãÐòºÅ,Ò»¸ö±¨¾¯ÊäÈë¿ÉÒÔµ÷ÓÃ¶à¸öÍ¨µÀµÄÔÆÌ¨Ô¤ÖÃµã, 0xff±íÊ¾²»µ÷ÓÃÔ¤ÖÃµã¡£*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnableCruise;/* ÊÇ·ñµ÷ÓÃÑ²º½ 0-·ñ,1-ÊÇ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseNo;/* Ñ²º½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePtzTrack;/* ÊÇ·ñµ÷ÓÃ¹ì¼£ 0-·ñ,1-ÊÇ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byPTZTrack;/* µ÷ÓÃµÄÔÆÌ¨µÄ¹ì¼£ÐòºÅ */
        }

        //Ä£Äâ±¨¾¯ÊäÈë²ÎÊýÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOG_ALARMINCFG
        {
            public uint dwSize;
            public byte byEnableAlarmHandle; //´¦Àí±¨¾¯ÊäÈë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInName; //Ä£Äâ±¨¾¯ÊäÈëÃû³Æ
            public ushort wAlarmInUpper; //Ä£ÄâÊäÈëµçÑ¹ÉÏÏÞ£¬Êµ¼ÊÖµ³Ë10£¬·¶Î§0~360
            public ushort wAlarmInLower; //Ä£ÄâÊäÈëµçÑ¹ÏÂÏÞ£¬Êµ¼ÊÖµ³Ë10£¬·¶Î§0~360 
            public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType; /* ´¦Àí·½Ê½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±»´¥·¢µÄÂ¼ÏñÍ¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //ÉÏ´«±¨¾¯ÐÅÏ¢(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_V30
        {
            public uint dwAlarmType;/*0-ÐÅºÅÁ¿±¨¾¯,1-Ó²ÅÌÂú,2-ÐÅºÅ¶ªÊ§,3£­ÒÆ¶¯Õì²â,4£­Ó²ÅÌÎ´¸ñÊ½»¯,5-¶ÁÐ´Ó²ÅÌ³ö´í,6-ÕÚµ²±¨¾¯,7-ÖÆÊ½²»Æ¥Åä, 8-·Ç·¨·ÃÎÊ, 0xa-GPS¶¨Î»ÐÅÏ¢(³µÔØ¶¨ÖÆ)*/
            public uint dwAlarmInputNumber;/*±¨¾¯ÊäÈë¶Ë¿Ú*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutputNumber;/*´¥·¢µÄÊä³ö¶Ë¿Ú£¬Îª1±íÊ¾¶ÔÓ¦Êä³ö*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmRelateChannel;/*´¥·¢µÄÂ¼ÏñÍ¨µÀ£¬Îª1±íÊ¾¶ÔÓ¦Â¼Ïñ, dwAlarmRelateChannel[0]¶ÔÓ¦µÚ1¸öÍ¨µÀ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChannel;/*dwAlarmTypeÎª2»ò3,6Ê±£¬±íÊ¾ÄÄ¸öÍ¨µÀ£¬dwChannel[0]¶ÔÓ¦µÚ1¸öÍ¨µÀ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskNumber;/*dwAlarmTypeÎª1,4,5Ê±,±íÊ¾ÄÄ¸öÓ²ÅÌ, dwDiskNumber[0]¶ÔÓ¦µÚ1¸öÓ²ÅÌ*/
            public void Init()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;
                byAlarmRelateChannel = new byte[MAX_CHANNUM_V30];
                byChannel = new byte[MAX_CHANNUM_V30];
                byAlarmOutputNumber = new byte[MAX_ALARMOUT_V30];
                byDiskNumber = new byte[MAX_DISKNUM_V30];
                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    byAlarmRelateChannel[i] = Convert.ToByte(0);
                    byChannel[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_ALARMOUT_V30; i++)
                {
                    byAlarmOutputNumber[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_DISKNUM_V30; i++)
                {
                    byDiskNumber[i] = Convert.ToByte(0);
                }
            }
            public void Reset()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;

                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    byAlarmRelateChannel[i] = Convert.ToByte(0);
                    byChannel[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_ALARMOUT_V30; i++)
                {
                    byAlarmOutputNumber[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_DISKNUM_V30; i++)
                {
                    byDiskNumber[i] = Convert.ToByte(0);
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_HOT_SPARE
        {
            public uint dwSize;   //½á¹¹Ìå
            public uint dwExceptionCase;   //±¨¾¯Ô­Òò   0-ÍøÂçÒì³£
            public NET_DVR_IPADDR struDeviceIP;    //²úÉúÒì³£µÄÉè±¸IPµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO
        {
            public int dwAlarmType;/*0-ÐÅºÅÁ¿±¨¾¯,1-Ó²ÅÌÂú,2-ÐÅºÅ¶ªÊ§,3£­ÒÆ¶¯Õì²â,4£­Ó²ÅÌÎ´¸ñÊ½»¯,5-¶ÁÐ´Ó²ÅÌ³ö´í,6-ÕÚµ²±¨¾¯,7-ÖÆÊ½²»Æ¥Åä, 8-·Ç·¨·ÃÎÊ, 9-´®¿Ú×´Ì¬, 0xa-GPS¶¨Î»ÐÅÏ¢(³µÔØ¶¨ÖÆ)*/
            public int dwAlarmInputNumber;/*±¨¾¯ÊäÈë¶Ë¿Ú, µ±±¨¾¯ÀàÐÍÎª9Ê±¸Ã±äÁ¿±íÊ¾´®¿Ú×´Ì¬0±íÊ¾Õý³££¬ -1±íÊ¾´íÎó*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.U4)]
            public int[] dwAlarmOutputNumber;/*´¥·¢µÄÊä³ö¶Ë¿Ú£¬ÄÄÒ»Î»Îª1±íÊ¾¶ÔÓ¦ÄÄÒ»¸öÊä³ö*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwAlarmRelateChannel;/*´¥·¢µÄÂ¼ÏñÍ¨µÀ£¬ÄÄÒ»Î»Îª1±íÊ¾¶ÔÓ¦ÄÄÒ»Â·Â¼Ïñ, dwAlarmRelateChannel[0]¶ÔÓ¦µÚ1¸öÍ¨µÀ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwChannel;/*dwAlarmTypeÎª2»ò3,6Ê±£¬±íÊ¾ÄÄ¸öÍ¨µÀ£¬dwChannel[0]Î»¶ÔÓ¦µÚ1¸öÍ¨µÀ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwDiskNumber;/*dwAlarmTypeÎª1,4,5Ê±,±íÊ¾ÄÄ¸öÓ²ÅÌ, dwDiskNumber[0]Î»¶ÔÓ¦µÚ1¸öÓ²ÅÌ*/
            public void Init()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;
                dwAlarmOutputNumber = new int[MAX_ALARMOUT];
                dwAlarmRelateChannel = new int[MAX_CHANNUM];
                dwChannel = new int[MAX_CHANNUM];
                dwDiskNumber = new int[MAX_DISKNUM];
                for (int i = 0; i < MAX_ALARMOUT; i++)
                {
                    dwAlarmOutputNumber[i] = 0;
                }
                for (int i = 0; i < MAX_CHANNUM; i++)
                {
                    dwAlarmRelateChannel[i] = 0;
                    dwChannel[i] = 0;
                }
                for (int i = 0; i < MAX_DISKNUM; i++)
                {
                    dwDiskNumber[i] = 0;
                }
            }
            public void Reset()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;

                for (int i = 0; i < MAX_ALARMOUT; i++)
                {
                    dwAlarmOutputNumber[i] = 0;
                }
                for (int i = 0; i < MAX_CHANNUM; i++)
                {
                    dwAlarmRelateChannel[i] = 0;
                    dwChannel[i] = 0;
                }
                for (int i = 0; i < MAX_DISKNUM; i++)
                {
                    dwDiskNumber[i] = 0;
                }
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////
        //IPC½ÓÈë²ÎÊýÅäÖÃ
        /* IPÉè±¸½á¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPDEVINFO
        {
            public uint dwEnable;/* ¸ÃIPÉè±¸ÊÇ·ñÆôÓÃ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* ÓÃ»§Ãû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword; /* ÃÜÂë */
            public NET_DVR_IPADDR struIP;/* IPµØÖ· */
            public ushort wDVRPort;/* ¶Ë¿ÚºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ±£Áô */

            public void Init()
            {
                sUserName = new byte[NAME_LEN];
                sPassword = new byte[PASSWD_LEN];
                byRes = new byte[34];
            }
        }

        //ipc½ÓÈëÉè±¸ÐÅÏ¢À©Õ¹£¬Ö§³ÖipÉè±¸µÄÓòÃûÌí¼Ó
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPDEVINFO_V31
        {
            public byte byEnable;//¸ÃIPÉè±¸ÊÇ·ñÓÐÐ§
            public byte byProType;
            public byte byEnableQuickAdd;
            public byte byRes1;//±£Áô×Ö¶Î£¬ÖÃ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;//ÓÃ»§Ãû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;//ÃÜÂë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byDomain;//Éè±¸ÓòÃû
            public NET_DVR_IPADDR struIP;//IPµØÖ·
            public ushort wDVRPort;// ¶Ë¿ÚºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£Áô×Ö¶Î£¬ÖÃ0

            public void Init()
            {
                sUserName = new byte[NAME_LEN];
                sPassword = new byte[PASSWD_LEN];
                byDomain = new byte[MAX_DOMAIN_NAME];
                byRes2 = new byte[34];
            }
        }

        /* IPÍ¨µÀÆ¥Åä²ÎÊý */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPCHANINFO
        {
            public byte byEnable;/* ¸ÃÍ¨µÀÊÇ·ñÔÚÏß */
            public byte byIPID;/* IPÉè±¸ID È¡Öµ1- MAX_IP_DEVICE */
            public byte byChannel;/* Í¨µÀºÅ */
            public byte byIPIDHigh; // IPÉè±¸IDµÄ¸ß8Î»
            public byte byTransProtocol;//´«ÊäÐ­ÒéÀàÐÍ0-TCP/auto(¾ßÌåÓÐÉè±¸¾ö¶¨)£¬1-UDP 2-¶à²¥ 3-½öTCP 4-auto
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô,ÖÃ0
            public void Init()
            {
                byRes = new byte[31];
            }
        }

        /* IP½ÓÈëÅäÖÃ½á¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG
        {
            public uint dwSize;/* ½á¹¹´óÐ¡ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO[] struIPDevInfo;/* IPÉè±¸ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* Ä£ÄâÍ¨µÀÊÇ·ñÆôÓÃ£¬´ÓµÍµ½¸ß±íÊ¾1-32Í¨µÀ£¬0±íÊ¾ÎÞÐ§ 1ÓÐÐ§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPÍ¨µÀ */

            public void Init()
            {
                int i = 0;
                struIPDevInfo = new NET_DVR_IPDEVINFO[MAX_IP_DEVICE];

                for (i = 0; i < MAX_IP_DEVICE; i++)
                {
                    struIPDevInfo[i].Init();
                }
                byAnalogChanEnable = new byte[MAX_ANALOG_CHANNUM];
                struIPChanInfo = new NET_DVR_IPCHANINFO[MAX_IP_CHANNEL];
                for (i = 0; i < MAX_IP_CHANNEL; i++)
                {
                    struIPChanInfo[i].Init();
                }
            }
        }

        /* À©Õ¹IP½ÓÈëÅäÖÃ½á¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG_V31
        {
            public uint dwSize;/* ½á¹¹´óÐ¡ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IPÉè±¸ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* Ä£ÄâÍ¨µÀÊÇ·ñÆôÓÃ£¬´ÓµÍµ½¸ß±íÊ¾1-32Í¨µÀ£¬0±íÊ¾ÎÞÐ§ 1ÓÐÐ§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPÍ¨µÀ */

            public void Init()
            {
                int i = 0;
                struIPDevInfo = new NET_DVR_IPDEVINFO_V31[MAX_IP_DEVICE];

                for (i = 0; i < MAX_IP_DEVICE; i++)
                {
                    struIPDevInfo[i].Init();
                }
                byAnalogChanEnable = new byte[MAX_ANALOG_CHANNUM];
                struIPChanInfo = new NET_DVR_IPCHANINFO[MAX_IP_CHANNEL];
                for (i = 0; i < MAX_IP_CHANNEL; i++)
                {
                    struIPChanInfo[i].Init();
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSERVER_STREAM
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_IPADDR struIPServer;
            public ushort wPort;
            public ushort wDvrNameLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVRName;
            public ushort wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
            public ushort[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassWord;
            public byte byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public void Init()
            {
                byRes = new byte[3];
                byDVRName = new byte[NAME_LEN];
                byRes1 = new ushort[2];
                byDVRSerialNumber = new byte[SERIALNO_LEN];
                byUserName = new byte[NAME_LEN];
                byPassWord = new byte[PASSWD_LEN];
                byRes2 = new byte[11];
            }
        }

        /*Á÷Ã½Ìå·þÎñÆ÷»ù±¾ÅäÖÃ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MEDIA_SERVER_CFG
        {
            public byte byValid;/*ÊÇ·ñÆôÓÃÁ÷Ã½Ìå·þÎñÆ÷È¡Á÷,0±íÊ¾ÎÞÐ§£¬·Ç0±íÊ¾ÓÐÐ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struDevIP;
            public ushort wDevPort;/*Á÷Ã½Ìå·þÎñÆ÷¶Ë¿Ú*/
            public byte byTransmitType;/*´«ÊäÐ­ÒéÀàÐÍ 0-TCP£¬1-UDP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        //Éè±¸Í¨µÀÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_CHAN_INFO
        {
            public NET_DVR_IPADDR struIP;		    //DVR IPµØÖ·
            public ushort wDVRPort;			 	//¶Ë¿ÚºÅ
            public byte byChannel;				//Í¨µÀºÅ
            public byte byTransProtocol;		//´«ÊäÐ­ÒéÀàÐÍ0-TCP£¬1-UDP
            public byte byTransMode;			//´«ÊäÂëÁ÷Ä£Ê½ 0£­Ö÷ÂëÁ÷ 1£­×ÓÂëÁ÷
            public byte byFactoryType;			/*Ç°¶ËÉè±¸³§¼ÒÀàÐÍ,Í¨¹ý½Ó¿Ú»ñÈ¡*/
            public byte byDeviceType; //Éè±¸ÀàÐÍ(ÊÓÆµ×ÛºÏÆ½Ì¨ÖÇÄÜ°åÊ¹ÓÃ)£¬1-½âÂëÆ÷£¨´ËÊ±¸ù¾ÝÊÓÆµ×ÛºÏÆ½Ì¨ÄÜÁ¦¼¯ÖÐbyVcaSupportChanMode×Ö¶ÎÀ´¾ö¶¨ÊÇÊ¹ÓÃ½âÂëÍ¨µÀ»¹ÊÇÏÔÊ¾Í¨µÀ£©£¬2-±àÂëÆ÷
            public byte byDispChan;//ÏÔÊ¾Í¨µÀºÅ,ÖÇÄÜÅäÖÃÊ¹ÓÃ
            public byte bySubDispChan;//ÏÔÊ¾Í¨µÀ×ÓÍ¨µÀºÅ£¬ÖÇÄÜÅäÖÃÊ±Ê¹ÓÃ
            public byte byResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500w´óÆÁ¿ØÖÆÆ÷Ê¹ÓÃ£¬´óÆÁ¿ØÖÆÆ÷»á¸ù¾Ý¸Ã²ÎÊý·ÖÅä½âÂë×ÊÔ´
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byDomain;	//Éè±¸ÓòÃû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	//¼à¿ØÖ÷»úµÇÂ½ÕÊºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	//¼à¿ØÖ÷»úÃÜÂë
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_CFG
        {
            public uint dwSize;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG struStreamMediaSvrCfg;
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNS_STREAM_CFG
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struStreamServer;
            public ushort wStreamServerPort;
            public byte byStreamServerTransmitType;
            public byte byRes2;
            public NET_DVR_IPADDR struIPServer;
            public ushort wIPServerPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName;
            public ushort wDVRNameLen;
            public ushort wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassWord;
            public ushort wDVRPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
            public byte byChannel;
            public byte byTransProtocol;
            public byte byTransMode;
            public byte byFactoryType;
            public void Init()
            {
                byRes1 = new byte[3];
                byRes3 = new byte[2];
                sDVRName = new byte[NAME_LEN];
                sDVRSerialNumber = new byte[SERIALNO_LEN];
                sUserName = new byte[NAME_LEN];
                sPassWord = new byte[PASSWD_LEN];
                byRes4 = new byte[2];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_URL
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] strURL;
            public byte byTransPortocol;
            public ushort wIPID;
            public byte byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void Init()
            {
                strURL = new byte[240];
                byRes = new byte[7];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HKDDNS_STREAM
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byDDNSDomain;
            public ushort wPort;
            public ushort wAliasLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlias;
            public ushort wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassWord;
            public byte byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public void Init()
            {
                byRes = new byte[3];
                byDDNSDomain = new byte[64];
                byAlias = new byte[NAME_LEN];
                byRes1 = new byte[2];
                byDVRSerialNumber = new byte[SERIALNO_LEN];
                byUserName = new byte[NAME_LEN];
                byPassWord = new byte[PASSWD_LEN];
                byRes2 = new byte[11];
            }
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPCHANINFO_V40
        {
            public byte byEnable;				/* ¸ÃÍ¨µÀÊÇ·ñÔÚÏß */
            public byte byRes1;
            public ushort wIPID;                  //IPÉè±¸ID
            public uint dwChannel;				//Í¨µÀºÅ
            public byte byTransProtocol;		//´«ÊäÐ­ÒéÀàÐÍ0-TCP£¬1-UDP
            public byte byTransMode;			//´«ÊäÂëÁ÷Ä£Ê½ 0£­Ö÷ÂëÁ÷ 1£­×ÓÂëÁ÷
            public byte byFactoryType;			/*Ç°¶ËÉè±¸³§¼ÒÀàÐÍ,Í¨¹ý½Ó¿Ú»ñÈ¡*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 241, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct NET_DVR_GET_STREAM_UNION
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 492, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnion;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MODE
        {
            public byte byGetStreamType;/*È¡Á÷·½Ê½£º0- Ö±½Ó´ÓÉè±¸È¡Á÷£»1- ´ÓÁ÷Ã½ÌåÈ¡Á÷£»2- Í¨¹ýIPServer»ñµÃIPµØÖ·ºóÈ¡Á÷£»
                                          * 3- Í¨¹ýIPServerÕÒµ½Éè±¸£¬ÔÙÍ¨¹ýÁ÷Ã½ÌåÈ¡Éè±¸µÄÁ÷£» 4- Í¨¹ýÁ÷Ã½ÌåÓÉURLÈ¥È¡Á÷£»
                                          * 5- Í¨¹ýhiDDNSÓòÃûÁ¬½ÓÉè±¸È»ºó´ÓÉè±¸È¡Á÷ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_GET_STREAM_UNION uGetStream;
            public void Init()
            {
                byGetStreamType = 0;
                byRes = new byte[3];
                //uGetStream.Init();
            }
        }

        /* V40À©Õ¹IP½ÓÈëÅäÖÃ½á¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG_V40
        {
            public uint dwSize;/* ½á¹¹´óÐ¡ */
            public uint dwGroupNum;
            public uint dwAChanNum;
            public uint dwDChanNum;
            public uint dwStartDChan;

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* Ä£ÄâÍ¨µÀÊÇ·ñÆôÓÃ£¬´ÓµÍµ½¸ß±íÊ¾1-32Í¨µÀ£¬0±íÊ¾ÎÞÐ§ 1ÓÐÐ§ */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IPÉè±¸ */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_STREAM_MODE[] struStreamMode;/* IPÍ¨µÀ */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; /* Ä£ÄâÍ¨µÀÊÇ·ñÆôÓÃ£¬´ÓµÍµ½¸ß±íÊ¾1-32Í¨µÀ£¬0±íÊ¾ÎÞÐ§ 1ÓÐÐ§ */
        }

        //ÎªCVRÀ©Õ¹µÄ±¨¾¯ÀàÐÍ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_DEV
        {
            public uint dwAlarmType;  //0-±àÂëÆ÷(Í¨µÀ)ÐÅºÅÁ¿±¨¾¯£»1-Ë½ÓÐ¾í¶þËð»µ£»2- NVR·þÎñÍË³ö£»
                                      //3-±àÂëÆ÷×´Ì¬Òì³££»4-ÏµÍ³Ê±ÖÓÒì³££»5-Â¼Ïñ¾íÊ£ÓàÈÝÁ¿¹ýµÍ£»
                                      //6-±àÂëÆ÷(Í¨µÀ)ÒÆ¶¯Õì²â±¨¾¯£»7-±àÂëÆ÷(Í¨µÀ)ÕÚµ²±¨¾¯¡£
            public NET_DVR_TIME struTime;     //±¨¾¯Ê±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±£Áô
            public uint dwNumber;     //ÊýÄ¿
            public IntPtr pNO;  //dwNumber¸öWORD; Ã¿¸öWORD±íÊ¾Ò»¸öÍ¨µÀºÅ£¬»òÕß´ÅÅÌºÅ, ÎÞÐ§Ê±Îª0
        }

        /* ±¨¾¯Êä³ö²ÎÊý */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTINFO
        {
            public byte byIPID;/* IPÉè±¸IDÈ¡Öµ1- MAX_IP_DEVICE */
            public byte byAlarmOut;/* ±¨¾¯Êä³öºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ±£Áô */

            public void Init()
            {
                byRes = new byte[18];
            }
        }

        /* IP±¨¾¯Êä³öÅäÖÃ½á¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTCFG
        {
            public uint dwSize; /* ½á¹¹´óÐ¡ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP±¨¾¯Êä³ö */

            public void Init()
            {
                struIPAlarmOutInfo = new NET_DVR_IPALARMOUTINFO[MAX_IP_ALARMOUT];
                for (int i = 0; i < MAX_IP_ALARMOUT; i++)
                {
                    struIPAlarmOutInfo[i].Init();
                }
            }
        }
        /* IP±¨¾¯Êä³ö²ÎÊý */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTINFO_V40
        {
            public uint dwIPID;					/* IPÉè±¸ID */
            public uint dwAlarmOut;				/* IPÉè±¸ID¶ÔÓ¦µÄ±¨¾¯Êä³öºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ±£Áô */
        }

        /*IP±¨¾¯Êä³ö*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTCFG_V40
        {
            public uint dwSize;  //½á¹¹Ìå³¤¶È
            public uint dwCurIPAlarmOutNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO_V40[] struIPAlarmOutInfo;/*IP±¨¾¯Êä³ö*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /* ±¨¾¯ÊäÈë²ÎÊý */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMININFO
        {
            public byte byIPID;/* IPÉè±¸IDÈ¡Öµ1- MAX_IP_DEVICE */
            public byte byAlarmIn;/* ±¨¾¯ÊäÈëºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ±£Áô */
        }

        /* IP±¨¾¯ÊäÈëÅäÖÃ½á¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINCFG
        {
            public uint dwSize;/* ½á¹¹´óÐ¡ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;/* IP±¨¾¯ÊäÈë */
        }
        /* IP±¨¾¯ÊäÈë²ÎÊý */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMININFO_V40
        {
            public uint dwIPID;					/* IPÉè±¸ID */
            public uint dwAlarmIn;				/* IPÉè±¸ID¶ÔÓ¦µÄ±¨¾¯ÊäÈëºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ±£Áô */
        }
        /*IP±¨¾¯ÊäÈë×ÊÔ´*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINCFG_V40
        {
            public uint dwSize;  //½á¹¹Ìå³¤¶È
            public uint dwCurIPAlarmInNum;  //µ±Ç°±¨¾¯ÊäÈë¿ÚÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN_V40, ArraySubType = UnmanagedType.I1)]
            public NET_DVR_IPALARMININFO_V40[] struIPAlarmInInfo;/* IP±¨¾¯ÊäÈë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ipc alarm info
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO[] struIPDevInfo; /* IPÉè±¸ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* Ä£ÄâÍ¨µÀÊÇ·ñÆôÓÃ£¬0-Î´ÆôÓÃ 1-ÆôÓÃ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPÍ¨µÀ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;/* IP±¨¾¯ÊäÈë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP±¨¾¯Êä³ö */
        }

        //ipcÅäÖÃ¸Ä±ä±¨¾¯ÐÅÏ¢À©Õ¹ 9000_1.1
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO_V31
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IPÉè±¸ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable;/* Ä£ÄâÍ¨µÀÊÇ·ñÆôÓÃ£¬0-Î´ÆôÓÃ 1-ÆôÓÃ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPÍ¨µÀ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo; /* IP±¨¾¯ÊäÈë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP±¨¾¯Êä³ö */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo;           // IPÉè±¸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable;           /* Ä£ÄâÍ¨µÀÊÇ·ñÆôÓÃ£¬0-Î´ÆôÓÃ 1-ÆôÓÃ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;	        /* IPÍ¨µÀ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;    /* IP±¨¾¯ÊäÈë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo; /* IP±¨¾¯Êä³ö */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                          // ±£Áô×Ö½Ú
        }

        public enum HD_STAT
        {
            HD_STAT_OK = 0,/* Õý³£ */
            HD_STAT_UNFORMATTED = 1,/* Î´¸ñÊ½»¯ */
            HD_STAT_ERROR = 2,/* ´íÎó */
            HD_STAT_SMART_FAILED = 3,/* SMART×´Ì¬ */
            HD_STAT_MISMATCH = 4,/* ²»Æ¥Åä */
            HD_STAT_IDLE = 5, /* ÐÝÃß*/
            NET_HD_STAT_OFFLINE = 6,/*ÍøÂçÅÌ´¦ÓÚÎ´Á¬½Ó×´Ì¬ */
            HD_RIADVD_EXPAND = 7,    /* ÐéÄâ´ÅÅÌ¿ÉÀ©ÈÝ */
            HD_STAT_REPARING = 10,   /* Ó²ÅÌÕýÔÚÐÞ¸´(9000 2.0) */
            HD_STAT_FORMATING = 11,   /* Ó²ÅÌÕýÔÚ¸ñÊ½»¯(9000 2.0) */
        }

        //±¾µØÓ²ÅÌÐÅÏ¢ÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HD
        {
            public uint dwHDNo;/*Ó²ÅÌºÅ, È¡Öµ0~MAX_DISKNUM_V30-1*/
            public uint dwCapacity;/*Ó²ÅÌÈÝÁ¿(²»¿ÉÉèÖÃ)*/
            public uint dwFreeSpace;/*Ó²ÅÌÊ£Óà¿Õ¼ä(²»¿ÉÉèÖÃ)*/
            public uint dwHdStatus;/*Ó²ÅÌ×´Ì¬(²»¿ÉÉèÖÃ) HD_STAT*/
            public byte byHDAttr;/*0-Ä¬ÈÏ, 1-ÈßÓà; 2-Ö»¶Á*/
            public byte byHDType;/*0-±¾µØÓ²ÅÌ,1-ESATAÓ²ÅÌ,2-NASÓ²ÅÌ*/
            public byte byDiskDriver;   // Öµ ´ú±íÆäASCII×Ö·û 
            public byte byRes1;
            public uint dwHdGroup; /*ÊôÓÚÄÄ¸öÅÌ×é 1-MAX_HD_GROUP*/
            public byte byRecycling;   // ÊÇ·ñÑ­»·ÀûÓÃ 0£º²»Ñ­»·ÀûÓÃ£¬1£ºÑ­»·ÀûÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwStorageType;    //°´Î»±íÊ¾ 0-²»Ö§³Ö ·Ç0-Ö§³Ö
                                          // dwStorageType & 0x1 ±íÊ¾ÊÇ·ñÊÇÆÕÍ¨Â¼Ïñ×¨ÓÃ´æ´¢ÅÌ     
                                          // dwStorageType & 0x2  ±íÊ¾ÊÇ·ñÊÇ³éÖ¡Â¼Ïñ×¨ÓÃ´æ´¢ÅÌ
                                          // dwStorageType & 0x4 ±íÊ¾ÊÇ·ñÊÇÍ¼Æ¬Â¼Ïñ×¨ÓÃ´æ´¢ÅÌ

            public uint dwPictureCapacity; //Ó²ÅÌÍ¼Æ¬ÈÝÁ¿(²»¿ÉÉèÖÃ)£¬µ¥Î»:MB
            public uint dwFreePictureSpace; //Ê£ÓàÍ¼Æ¬¿Õ¼ä(²»¿ÉÉèÖÃ)£¬µ¥Î»:MB
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 104, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDCFG
        {
            public uint dwSize;
            public uint dwHDCount;/*Ó²ÅÌÊý(²»¿ÉÉèÖÃ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HD[] struHDInfo;//Ó²ÅÌÏà¹Ø²Ù×÷¶¼ÐèÒªÖØÆô²ÅÄÜÉúÐ§£»
        }

        //±¾µØÅÌ×éÐÅÏ¢ÅäÖÃÀ©Õ¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HDGROUP_V40
        {
            public uint dwHDGroupNo;       /*ÅÌ×éºÅ(²»¿ÉÉèÖÃ) 1-MAX_HD_GROUP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;  //´¥·¢µÄÂ¼ÏñÍ¨µÀ£¬°´Öµ±íÊ¾£¬Óöµ½0xffffffffÊ±ºóÐøÊÓÎªÎÞÐ§    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ±£Áô */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDGROUP_CFG_V40
        {
            public uint dwSize;                //½á¹¹Ìå´óÐ¡
            public uint dwMaxHDGroupNum; 		  //Éè±¸Ö§³ÖµÄ×î´óÅÌ×éÊý-Ö»¶Á
            public uint dwCurHDGroupNum;       /*µ±Ç°ÅäÖÃµÄÅÌ×éÊý*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HD_GROUP, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HDGROUP_V40[] struHDGroupAttr; //Ó²ÅÌÏà¹Ø²Ù×÷¶¼ÐèÒªÖØÆô²ÅÄÜÉúÐ§£»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }

        //±¾µØÅÌ×éÐÅÏ¢ÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HDGROUP
        {
            public uint dwHDGroupNo;/*ÅÌ×éºÅ(²»¿ÉÉèÖÃ) 1-MAX_HD_GROUP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byHDGroupChans;/*ÅÌ×é¶ÔÓ¦µÄÂ¼ÏñÍ¨µÀ, 0-±íÊ¾¸ÃÍ¨µÀ²»Â¼Ïóµ½¸ÃÅÌ×é£¬1-±íÊ¾Â¼Ïóµ½¸ÃÅÌ×é*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDGROUP_CFG
        {
            public uint dwSize;
            public uint dwHDGroupCount;/*ÅÌ×é×ÜÊý(²»¿ÉÉèÖÃ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HD_GROUP, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HDGROUP[] struHDGroupAttr;//Ó²ÅÌÏà¹Ø²Ù×÷¶¼ÐèÒªÖØÆô²ÅÄÜÉúÐ§
        }

        //ÅäÖÃËõ·Å²ÎÊýµÄ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCALECFG
        {
            public uint dwSize;
            public uint dwMajorScale;/* Ö÷ÏÔÊ¾ 0-²»Ëõ·Å£¬1-Ëõ·Å*/
            public uint dwMinorScale;/* ¸¨ÏÔÊ¾ 0-²»Ëõ·Å£¬1-Ëõ·Å*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //DVR±¨¾¯Êä³ö(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmOutName;/* Ãû³Æ */
            public uint dwAlarmOutDelay;/* Êä³ö±£³ÖÊ±¼ä(-1ÎªÎÞÏÞ£¬ÊÖ¶¯¹Ø±Õ) */
            //0-5Ãë,1-10Ãë,2-30Ãë,3-1·ÖÖÓ,4-2·ÖÖÓ,5-5·ÖÖÓ,6-10·ÖÖÓ,7-ÊÖ¶¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmOutTime;/* ±¨¾¯Êä³ö¼¤»îÊ±¼ä¶Î */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR±¨¾¯Êä³ö
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmOutName;/* Ãû³Æ */
            public uint dwAlarmOutDelay;/* Êä³ö±£³ÖÊ±¼ä(-1ÎªÎÞÏÞ£¬ÊÖ¶¯¹Ø±Õ) */
            //0-5Ãë,1-10Ãë,2-30Ãë,3-1·ÖÖÓ,4-2·ÖÖÓ,5-5·ÖÖÓ,6-10·ÖÖÓ,7-ÊÖ¶¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmOutTime;/* ±¨¾¯Êä³ö¼¤»îÊ±¼ä¶Î */
        }

        //DVR±¾µØÔ¤ÀÀ²ÎÊý(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWCFG_V30
        {
            public uint dwSize;
            public byte byPreviewNumber;//Ô¤ÀÀÊýÄ¿,0-1»­Ãæ,1-4»­Ãæ,2-9»­Ãæ,3-16»­Ãæ,0xff:×î´ó»­Ãæ
            public byte byEnableAudio;//ÊÇ·ñÉùÒôÔ¤ÀÀ,0-²»Ô¤ÀÀ,1-Ô¤ÀÀ
            public ushort wSwitchTime;//ÇÐ»»Ê±¼ä,0-²»ÇÐ»»,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PREVIEW_MODE * MAX_WINDOW_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySwitchSeq;//ÇÐ»»Ë³Ðò,Èç¹ûlSwitchSeq[i]Îª 0xff±íÊ¾²»ÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR±¾µØÔ¤ÀÀ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWCFG
        {
            public uint dwSize;
            public byte byPreviewNumber;//Ô¤ÀÀÊýÄ¿,0-1»­Ãæ,1-4»­Ãæ,2-9»­Ãæ,3-16»­Ãæ,0xff:×î´ó»­Ãæ
            public byte byEnableAudio;//ÊÇ·ñÉùÒôÔ¤ÀÀ,0-²»Ô¤ÀÀ,1-Ô¤ÀÀ
            public ushort wSwitchTime;//ÇÐ»»Ê±¼ä,0-²»ÇÐ»»,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOW, ArraySubType = UnmanagedType.I1)]
            public byte[] bySwitchSeq;//ÇÐ»»Ë³Ðò,Èç¹ûlSwitchSeq[i]Îª 0xff±íÊ¾²»ÓÃ
        }

        //DVRÊÓÆµÊä³ö
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGAPARA
        {
            public ushort wResolution;/* ·Ö±æÂÊ */
            public ushort wFreq;/* Ë¢ÐÂÆµÂÊ */
            public uint dwBrightness;/* ÁÁ¶È */
        }

        //MATRIXÊä³ö²ÎÊý½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXPARA_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wOrder;/* Ô¤ÀÀË³Ðò, 0xff±íÊ¾ÏàÓ¦µÄ´°¿Ú²»Ô¤ÀÀ */
            public ushort wSwitchTime;// Ô¤ÀÀÇÐ»»Ê±¼ä 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXPARA
        {
            public ushort wDisplayLogo;/* ÏÔÊ¾ÊÓÆµÍ¨µÀºÅ */
            public ushort wDisplayOsd;/* ÏÔÊ¾Ê±¼ä */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VOOUT
        {
            public byte byVideoFormat;/* Êä³öÖÆÊ½,0-PAL,1-NTSC */
            public byte byMenuAlphaValue;/* ²Ëµ¥Óë±³¾°Í¼Ïó¶Ô±È¶È */
            public ushort wScreenSaveTime;/* ÆÁÄ»±£»¤Ê±¼ä 0-´Ó²»,1-1·ÖÖÓ,2-2·ÖÖÓ,3-5·ÖÖÓ,4-10·ÖÖÓ,5-20·ÖÖÓ,6-30·ÖÖÓ */
            public ushort wVOffset;/* ÊÓÆµÊä³öÆ«ÒÆ */
            public ushort wBrightness;/* ÊÓÆµÊä³öÁÁ¶È */
            public byte byStartMode;/* Æô¶¯ºóÊÓÆµÊä³öÄ£Ê½(0:²Ëµ¥,1:Ô¤ÀÀ)*/
            public byte byEnableScaler;/* ÊÇ·ñÆô¶¯Ëõ·Å (0-²»Æô¶¯, 1-Æô¶¯)*/
        }

        //DVRÊÓÆµÊä³ö(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOOUT_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VIDEOOUT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VOOUT[] struVOOut;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VGA_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VGAPARA[] struVGAPara;/* VGA²ÎÊý */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MATRIXOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIXPARA_V30[] struMatrixPara;/* MATRIX²ÎÊý */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVRÊÓÆµÊä³ö
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOOUT
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VIDEOOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VOOUT[] struVOOut;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VGA, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VGAPARA[] struVGAPara;	/* VGA²ÎÊý */
            public NET_DVR_MATRIXPARA struMatrixPara;/* MATRIX²ÎÊý */
        }

        //µ¥ÓÃ»§²ÎÊý(×Ó½á¹¹)(À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_INFO_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;			/* ÓÃ»§ÃûÖ»ÄÜÓÃ16×Ö½Ú */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;			/* ÃÜÂë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRight; /* ±¾µØÈ¨ÏÞ */
            /*Êý×é0: ±¾µØ¿ØÖÆÔÆÌ¨*/
            /*Êý×é1: ±¾µØÊÖ¶¯Â¼Ïó*/
            /*Êý×é2: ±¾µØ»Ø·Å*/
            /*Êý×é3: ±¾µØÉèÖÃ²ÎÊý*/
            /*Êý×é4: ±¾µØ²é¿´×´Ì¬¡¢ÈÕÖ¾*/
            /*Êý×é5: ±¾µØ¸ß¼¶²Ù×÷(Éý¼¶£¬¸ñÊ½»¯£¬ÖØÆô£¬¹Ø»ú)*/
            /*Êý×é6: ±¾µØ²é¿´²ÎÊý */
            /*Êý×é7: ±¾µØ¹ÜÀíÄ£ÄâºÍIP camera */
            /*Êý×é8: ±¾µØ±¸·Ý */
            /*Êý×é9: ±¾µØ¹Ø»ú/ÖØÆô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemoteRight;/* Ô¶³ÌÈ¨ÏÞ */
            /*Êý×é0: Ô¶³Ì¿ØÖÆÔÆÌ¨*/
            /*Êý×é1: Ô¶³ÌÊÖ¶¯Â¼Ïó*/
            /*Êý×é2: Ô¶³Ì»Ø·Å */
            /*Êý×é3: Ô¶³ÌÉèÖÃ²ÎÊý*/
            /*Êý×é4: Ô¶³Ì²é¿´×´Ì¬¡¢ÈÕÖ¾*/
            /*Êý×é5: Ô¶³Ì¸ß¼¶²Ù×÷(Éý¼¶£¬¸ñÊ½»¯£¬ÖØÆô£¬¹Ø»ú)*/
            /*Êý×é6: Ô¶³Ì·¢ÆðÓïÒô¶Ô½²*/
            /*Êý×é7: Ô¶³ÌÔ¤ÀÀ*/
            /*Êý×é8: Ô¶³ÌÇëÇó±¨¾¯ÉÏ´«¡¢±¨¾¯Êä³ö*/
            /*Êý×é9: Ô¶³Ì¿ØÖÆ£¬±¾µØÊä³ö*/
            /*Êý×é10: Ô¶³Ì¿ØÖÆ´®¿Ú*/
            /*Êý×é11: Ô¶³Ì²é¿´²ÎÊý */
            /*Êý×é12: Ô¶³Ì¹ÜÀíÄ£ÄâºÍIP camera */
            /*Êý×é13: Ô¶³Ì¹Ø»ú/ÖØÆô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPreviewRight;			/* Ô¶³Ì¿ÉÒÔÔ¤ÀÀµÄÍ¨µÀ£¬´ÓÇ°ÍùºóË³ÐòÅÅÁÐ£¬Óöµ½0xffffffffºóÐø¾ùÎªÎÞÐ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRecordRight;			/* ±¾µØ¿ÉÒÔÂ¼ÏñµÄÍ¨µÀ£¬´ÓÇ°ÍùºóË³ÐòÅÅÁÐ£¬Óöµ½0xffffffffºóÐø¾ùÎªÎÞÐ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetRecordRight;			/* Ô¶³Ì¿ÉÒÔÂ¼ÏñµÄÍ¨µÀ£¬´ÓÇ°ÍùºóË³ÐòÅÅÁÐ£¬Óöµ½0xffffffffºóÐø¾ùÎªÎÞÐ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPlaybackRight;			/* ±¾µØ¿ÉÒÔ»Ø·ÅµÄÍ¨µÀ£¬´ÓÇ°ÍùºóË³ÐòÅÅÁÐ£¬Óöµ½0xffffffffºóÐø¾ùÎªÎÞÐ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPlaybackRight;			/* Ô¶³Ì¿ÉÒÔ»Ø·ÅµÄÍ¨µÀ£¬´ÓÇ°ÍùºóË³ÐòÅÅÁÐ£¬Óöµ½0xffffffffºóÐø¾ùÎªÎÞÐ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPTZRight;				/* ±¾µØ¿ÉÒÔPTZµÄÍ¨µÀ£¬´ÓÇ°ÍùºóË³ÐòÅÅÁÐ£¬Óöµ½0xffffffffºóÐø¾ùÎªÎÞÐ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPTZRight;				/* Ô¶³Ì¿ÉÒÔPTZµÄÍ¨µÀ£¬´ÓÇ°ÍùºóË³ÐòÅÅÁÐ£¬Óöµ½0xffffffffºóÐø¾ùÎªÎÞÐ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalBackupRight;			/* ±¾µØ±¸·ÝÈ¨ÏÞÍ¨µÀ£¬´ÓÇ°ÍùºóË³ÐòÅÅÁÐ£¬Óöµ½0xffffffffºóÐø¾ùÎªÎÞÐ§*/
            public NET_DVR_IPADDR struUserIP;				/* ÓÃ»§IPµØÖ·(Îª0Ê±±íÊ¾ÔÊÐíÈÎºÎµØÖ·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;	/* ÎïÀíµØÖ· */
            public byte byPriority;             /* ÓÅÏÈ¼¶£¬0xff-ÎÞ£¬0--µÍ£¬1--ÖÐ£¬2--¸ß */
            /* ÎÞ¡­¡­±íÊ¾²»Ö§³ÖÓÅÏÈ¼¶µÄÉèÖÃ
            µÍ¡­¡­Ä¬ÈÏÈ¨ÏÞ:°üÀ¨±¾µØºÍÔ¶³Ì»Ø·Å,±¾µØºÍÔ¶³Ì²é¿´ÈÕÖ¾ºÍ×´Ì¬,±¾µØºÍÔ¶³Ì¹Ø»ú/ÖØÆô
            ÖÐ¡­¡­°üÀ¨±¾µØºÍÔ¶³Ì¿ØÖÆÔÆÌ¨,±¾µØºÍÔ¶³ÌÊÖ¶¯Â¼Ïñ,±¾µØºÍÔ¶³Ì»Ø·Å,ÓïÒô¶Ô½²ºÍÔ¶³ÌÔ¤ÀÀ¡¢±¾µØ±¸·Ý,±¾µØ/Ô¶³Ì¹Ø»ú/ÖØÆô
            ¸ß¡­¡­¹ÜÀíÔ± */
            public byte byAlarmOnRight;         // ±¨¾¯ÊäÈë¿Ú²¼·ÀÈ¨ÏÞ 1-ÓÐÈ¨ÏÞ£¬0-ÎÞÈ¨ÏÞ
            public byte byAlarmOffRight;         // ±¨¾¯ÊäÈë¿Ú³··ÀÈ¨ÏÞ 1-ÓÐÈ¨ÏÞ£¬0-ÎÞÈ¨ÏÞ
            public byte byBypassRight;           // ±¨¾¯ÊäÈë¿ÚÅÔÂ·È¨ÏÞ 1-ÓÐÈ¨ÏÞ£¬0-ÎÞÈ¨ÏÞ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 118, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µ¥ÓÃ»§²ÎÊý(×Ó½á¹¹)(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_INFO_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* ÓÃ»§Ãû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ÃÜÂë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRight;/* ±¾µØÈ¨ÏÞ */
            /*Êý×é0: ±¾µØ¿ØÖÆÔÆÌ¨*/
            /*Êý×é1: ±¾µØÊÖ¶¯Â¼Ïó*/
            /*Êý×é2: ±¾µØ»Ø·Å*/
            /*Êý×é3: ±¾µØÉèÖÃ²ÎÊý*/
            /*Êý×é4: ±¾µØ²é¿´×´Ì¬¡¢ÈÕÖ¾*/
            /*Êý×é5: ±¾µØ¸ß¼¶²Ù×÷(Éý¼¶£¬¸ñÊ½»¯£¬ÖØÆô£¬¹Ø»ú)*/
            /*Êý×é6: ±¾µØ²é¿´²ÎÊý */
            /*Êý×é7: ±¾µØ¹ÜÀíÄ£ÄâºÍIP camera */
            /*Êý×é8: ±¾µØ±¸·Ý */
            /*Êý×é9: ±¾µØ¹Ø»ú/ÖØÆô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemoteRight;/* Ô¶³ÌÈ¨ÏÞ */
            /*Êý×é0: Ô¶³Ì¿ØÖÆÔÆÌ¨*/
            /*Êý×é1: Ô¶³ÌÊÖ¶¯Â¼Ïó*/
            /*Êý×é2: Ô¶³Ì»Ø·Å */
            /*Êý×é3: Ô¶³ÌÉèÖÃ²ÎÊý*/
            /*Êý×é4: Ô¶³Ì²é¿´×´Ì¬¡¢ÈÕÖ¾*/
            /*Êý×é5: Ô¶³Ì¸ß¼¶²Ù×÷(Éý¼¶£¬¸ñÊ½»¯£¬ÖØÆô£¬¹Ø»ú)*/
            /*Êý×é6: Ô¶³Ì·¢ÆðÓïÒô¶Ô½²*/
            /*Êý×é7: Ô¶³ÌÔ¤ÀÀ*/
            /*Êý×é8: Ô¶³ÌÇëÇó±¨¾¯ÉÏ´«¡¢±¨¾¯Êä³ö*/
            /*Êý×é9: Ô¶³Ì¿ØÖÆ£¬±¾µØÊä³ö*/
            /*Êý×é10: Ô¶³Ì¿ØÖÆ´®¿Ú*/
            /*Êý×é11: Ô¶³Ì²é¿´²ÎÊý */
            /*Êý×é12: Ô¶³Ì¹ÜÀíÄ£ÄâºÍIP camera */
            /*Êý×é13: Ô¶³Ì¹Ø»ú/ÖØÆô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPreviewRight;/* Ô¶³Ì¿ÉÒÔÔ¤ÀÀµÄÍ¨µÀ 0-ÓÐÈ¨ÏÞ£¬1-ÎÞÈ¨ÏÞ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalPlaybackRight;/* ±¾µØ¿ÉÒÔ»Ø·ÅµÄÍ¨µÀ 0-ÓÐÈ¨ÏÞ£¬1-ÎÞÈ¨ÏÞ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPlaybackRight;/* Ô¶³Ì¿ÉÒÔ»Ø·ÅµÄÍ¨µÀ 0-ÓÐÈ¨ÏÞ£¬1-ÎÞÈ¨ÏÞ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRecordRight;/* ±¾µØ¿ÉÒÔÂ¼ÏñµÄÍ¨µÀ 0-ÓÐÈ¨ÏÞ£¬1-ÎÞÈ¨ÏÞ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetRecordRight;/* Ô¶³Ì¿ÉÒÔÂ¼ÏñµÄÍ¨µÀ 0-ÓÐÈ¨ÏÞ£¬1-ÎÞÈ¨ÏÞ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalPTZRight;/* ±¾µØ¿ÉÒÔPTZµÄÍ¨µÀ 0-ÓÐÈ¨ÏÞ£¬1-ÎÞÈ¨ÏÞ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPTZRight;/* Ô¶³Ì¿ÉÒÔPTZµÄÍ¨µÀ 0-ÓÐÈ¨ÏÞ£¬1-ÎÞÈ¨ÏÞ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalBackupRight;/* ±¾µØ±¸·ÝÈ¨ÏÞÍ¨µÀ 0-ÓÐÈ¨ÏÞ£¬1-ÎÞÈ¨ÏÞ*/
            public NET_DVR_IPADDR struUserIP;/* ÓÃ»§IPµØÖ·(Îª0Ê±±íÊ¾ÔÊÐíÈÎºÎµØÖ·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* ÎïÀíµØÖ· */
            public byte byPriority;/* ÓÅÏÈ¼¶£¬0xff-ÎÞ£¬0--µÍ£¬1--ÖÐ£¬2--¸ß */
            /*
            ÎÞ¡­¡­±íÊ¾²»Ö§³ÖÓÅÏÈ¼¶µÄÉèÖÃ
            µÍ¡­¡­Ä¬ÈÏÈ¨ÏÞ:°üÀ¨±¾µØºÍÔ¶³Ì»Ø·Å,±¾µØºÍÔ¶³Ì²é¿´ÈÕÖ¾ºÍ×´Ì¬,±¾µØºÍÔ¶³Ì¹Ø»ú/ÖØÆô
            ÖÐ¡­¡­°üÀ¨±¾µØºÍÔ¶³Ì¿ØÖÆÔÆÌ¨,±¾µØºÍÔ¶³ÌÊÖ¶¯Â¼Ïñ,±¾µØºÍÔ¶³Ì»Ø·Å,ÓïÒô¶Ô½²ºÍÔ¶³ÌÔ¤ÀÀ
                  ±¾µØ±¸·Ý,±¾µØ/Ô¶³Ì¹Ø»ú/ÖØÆô
            ¸ß¡­¡­¹ÜÀíÔ±
            */
            public byte byAlarmOnRight;         // ±¨¾¯ÊäÈë¿Ú²¼·ÀÈ¨ÏÞ
            public byte byAlarmOffRight;        // ±¨¾¯ÊäÈë¿Ú³··ÀÈ¨ÏÞ
            public byte byBypassRight;          // ±¨¾¯ÊäÈë¿ÚÅÔÂ·È¨ÏÞ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µ¥ÓÃ»§²ÎÊý(SDK_V15À©Õ¹)(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_USER_INFO_EX
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* ÓÃ»§Ãû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ÃÜÂë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRight;/* È¨ÏÞ */
            /*Êý×é0: ±¾µØ¿ØÖÆÔÆÌ¨*/
            /*Êý×é1: ±¾µØÊÖ¶¯Â¼Ïó*/
            /*Êý×é2: ±¾µØ»Ø·Å*/
            /*Êý×é3: ±¾µØÉèÖÃ²ÎÊý*/
            /*Êý×é4: ±¾µØ²é¿´×´Ì¬¡¢ÈÕÖ¾*/
            /*Êý×é5: ±¾µØ¸ß¼¶²Ù×÷(Éý¼¶£¬¸ñÊ½»¯£¬ÖØÆô£¬¹Ø»ú)*/
            public uint dwLocalPlaybackRight;/* ±¾µØ¿ÉÒÔ»Ø·ÅµÄÍ¨µÀ bit0 -- channel 1*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRemoteRight;/* È¨ÏÞ */
            /*Êý×é0: Ô¶³Ì¿ØÖÆÔÆÌ¨*/
            /*Êý×é1: Ô¶³ÌÊÖ¶¯Â¼Ïó*/
            /*Êý×é2: Ô¶³Ì»Ø·Å */
            /*Êý×é3: Ô¶³ÌÉèÖÃ²ÎÊý*/
            /*Êý×é4: Ô¶³Ì²é¿´×´Ì¬¡¢ÈÕÖ¾*/
            /*Êý×é5: Ô¶³Ì¸ß¼¶²Ù×÷(Éý¼¶£¬¸ñÊ½»¯£¬ÖØÆô£¬¹Ø»ú)*/
            /*Êý×é6: Ô¶³Ì·¢ÆðÓïÒô¶Ô½²*/
            /*Êý×é7: Ô¶³ÌÔ¤ÀÀ*/
            /*Êý×é8: Ô¶³ÌÇëÇó±¨¾¯ÉÏ´«¡¢±¨¾¯Êä³ö*/
            /*Êý×é9: Ô¶³Ì¿ØÖÆ£¬±¾µØÊä³ö*/
            /*Êý×é10: Ô¶³Ì¿ØÖÆ´®¿Ú*/
            public uint dwNetPreviewRight;/* Ô¶³Ì¿ÉÒÔÔ¤ÀÀµÄÍ¨µÀ bit0 -- channel 1*/
            public uint dwNetPlaybackRight;/* Ô¶³Ì¿ÉÒÔ»Ø·ÅµÄÍ¨µÀ bit0 -- channel 1*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sUserIP;/* ÓÃ»§IPµØÖ·(Îª0Ê±±íÊ¾ÔÊÐíÈÎºÎµØÖ·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* ÎïÀíµØÖ· */
        }

        //µ¥ÓÃ»§²ÎÊý(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_USER_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* ÓÃ»§Ãû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ÃÜÂë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRight;/* È¨ÏÞ */
            /*Êý×é0: ±¾µØ¿ØÖÆÔÆÌ¨*/
            /*Êý×é1: ±¾µØÊÖ¶¯Â¼Ïó*/
            /*Êý×é2: ±¾µØ»Ø·Å*/
            /*Êý×é3: ±¾µØÉèÖÃ²ÎÊý*/
            /*Êý×é4: ±¾µØ²é¿´×´Ì¬¡¢ÈÕÖ¾*/
            /*Êý×é5: ±¾µØ¸ß¼¶²Ù×÷(Éý¼¶£¬¸ñÊ½»¯£¬ÖØÆô£¬¹Ø»ú)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRemoteRight;/* È¨ÏÞ */
            /*Êý×é0: Ô¶³Ì¿ØÖÆÔÆÌ¨*/
            /*Êý×é1: Ô¶³ÌÊÖ¶¯Â¼Ïó*/
            /*Êý×é2: Ô¶³Ì»Ø·Å */
            /*Êý×é3: Ô¶³ÌÉèÖÃ²ÎÊý*/
            /*Êý×é4: Ô¶³Ì²é¿´×´Ì¬¡¢ÈÕÖ¾*/
            /*Êý×é5: Ô¶³Ì¸ß¼¶²Ù×÷(Éý¼¶£¬¸ñÊ½»¯£¬ÖØÆô£¬¹Ø»ú)*/
            /*Êý×é6: Ô¶³Ì·¢ÆðÓïÒô¶Ô½²*/
            /*Êý×é7: Ô¶³ÌÔ¤ÀÀ*/
            /*Êý×é8: Ô¶³ÌÇëÇó±¨¾¯ÉÏ´«¡¢±¨¾¯Êä³ö*/
            /*Êý×é9: Ô¶³Ì¿ØÖÆ£¬±¾µØÊä³ö*/
            /*Êý×é10: Ô¶³Ì¿ØÖÆ´®¿Ú*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sUserIP;/* ÓÃ»§IPµØÖ·(Îª0Ê±±íÊ¾ÔÊÐíÈÎºÎµØÖ·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* ÎïÀíµØÖ· */
        }

        //DVRÓÃ»§²ÎÊý(À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_V40
        {
            public uint dwSize;  //½á¹¹Ìå´óÐ¡
            public uint dwMaxUserNum; //Éè±¸Ö§³ÖµÄ×î´óÓÃ»§Êý-Ö»¶Á
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_V40[] struUser;  /* ÓÃ»§²ÎÊý */
        }

        //DVRÓÃ»§²ÎÊý(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_V30[] struUser;
        }

        //DVRÓÃ»§²ÎÊý(SDK_V15À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_EX[] struUser;
        }

        //DVRÓÃ»§²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO[] struUser;
        }

        //Òì³£²ÎÊýÅäÖÃÀ©Õ¹½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION_V40
        {
            public uint dwSize;             //½á¹¹Ìå´óÐ¡
            public uint dwMaxGroupNum;    //Éè±¸Ö§³ÖµÄ×î´ó×éÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION_V41[] struExceptionHandle;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±£Áô
        }

        //DVRÒì³£²ÎÊý(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION_V30[] struExceptionHandleType;
            /*Êý×é0-ÅÌÂú,1- Ó²ÅÌ³ö´í,2-ÍøÏß¶Ï,3-¾ÖÓòÍøÄÚIP µØÖ·³åÍ», 4-·Ç·¨·ÃÎÊ, 5-ÊäÈë/Êä³öÊÓÆµÖÆÊ½²»Æ¥Åä, 6-ÊÓÆµÐÅºÅÒì³£, 7-Â¼ÏñÒì³£*/
        }

        //DVRÒì³£²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION[] struExceptionHandleType;
            /*Êý×é0-ÅÌÂú,1- Ó²ÅÌ³ö´í,2-ÍøÏß¶Ï,3-¾ÖÓòÍøÄÚIP µØÖ·³åÍ»,4-·Ç·¨·ÃÎÊ, 5-ÊäÈë/Êä³öÊÓÆµÖÆÊ½²»Æ¥Åä, 6-ÊÓÆµÐÅºÅÒì³£*/
        }

        //Í¨µÀ×´Ì¬(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNELSTATE_V30
        {
            public byte byRecordStatic;//Í¨µÀÊÇ·ñÔÚÂ¼Ïñ,0-²»Â¼Ïñ,1-Â¼Ïñ
            public byte bySignalStatic;//Á¬½ÓµÄÐÅºÅ×´Ì¬,0-Õý³£,1-ÐÅºÅ¶ªÊ§
            public byte byHardwareStatic;//Í¨µÀÓ²¼þ×´Ì¬,0-Õý³£,1-Òì³£,ÀýÈçDSPËÀµô
            public byte byRes1;//±£Áô
            public uint dwBitRate;//Êµ¼ÊÂëÂÊ
            public uint dwLinkNum;//¿Í»§¶ËÁ¬½ÓµÄ¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struClientIP;//¿Í»§¶ËµÄIPµØÖ·
            public uint dwIPLinkNum;//Èç¹û¸ÃÍ¨µÀÎªIP½ÓÈë£¬ÄÇÃ´±íÊ¾IP½ÓÈëµ±Ç°µÄÁ¬½ÓÊý
            public byte byExceedMaxLink;		// ÊÇ·ñ³¬³öÁËµ¥Â·6Â·Á¬½ÓÊý 0 - Î´³¬³ö, 1-³¬³ö
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwChannelNo;    //µ±Ç°µÄÍ¨µÀºÅ£¬0xffffffff±íÊ¾ÎÞÐ§

            public void Init()
            {
                struClientIP = new NET_DVR_IPADDR[MAX_LINK];

                for (int i = 0; i < MAX_LINK; i++)
                {
                    struClientIP[i].Init();
                }
                byRes = new byte[12];
            }
        }

        //Í¨µÀ×´Ì¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNELSTATE
        {
            public byte byRecordStatic;//Í¨µÀÊÇ·ñÔÚÂ¼Ïñ,0-²»Â¼Ïñ,1-Â¼Ïñ
            public byte bySignalStatic;//Á¬½ÓµÄÐÅºÅ×´Ì¬,0-Õý³£,1-ÐÅºÅ¶ªÊ§
            public byte byHardwareStatic;//Í¨µÀÓ²¼þ×´Ì¬,0-Õý³£,1-Òì³£,ÀýÈçDSPËÀµô
            public byte reservedData;//±£Áô
            public uint dwBitRate;//Êµ¼ÊÂëÂÊ
            public uint dwLinkNum;//¿Í»§¶ËÁ¬½ÓµÄ¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.U4)]
            public uint[] dwClientIP;//¿Í»§¶ËµÄIPµØÖ·
        }

        //Ó²ÅÌ×´Ì¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISKSTATE
        {
            public uint dwVolume;//Ó²ÅÌµÄÈÝÁ¿
            public uint dwFreeSpace;//Ó²ÅÌµÄÊ£Óà¿Õ¼ä
            public uint dwHardDiskStatic;//Ó²ÅÌµÄ×´Ì¬,0-»î¶¯,1-ÐÝÃß,2-²»Õý³£
        }

        //Éè±¸¹¤×÷×´Ì¬À©Õ¹½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE_V40
        {
            public uint dwSize;            //½á¹¹Ìå´óÐ¡
            public uint dwDeviceStatic; 	 //Éè±¸µÄ×´Ì¬,0-Õý³£,1-CPUÕ¼ÓÃÂÊÌ«¸ß,³¬¹ý85%,2-Ó²¼þ´íÎó,ÀýÈç´®¿ÚËÀµô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[] struHardDiskStatic;   //Ó²ÅÌ×´Ì¬,Ò»´Î×î¶àÖ»ÄÜ»ñÈ¡33¸öÓ²ÅÌÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE_V30[] struChanStatic;//Í¨µÀµÄ×´Ì¬£¬´ÓÇ°ÍùºóË³ÐòÅÅÁÐ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHasAlarmInStatic; //ÓÐ±¨¾¯µÄ±¨¾¯ÊäÈë¿Ú£¬°´Öµ±íÊ¾£¬°´ÏÂ±êÖµË³ÐòÅÅÁÐ£¬ÖµÎª0xffffffffÊ±µ±Ç°¼°ºóÐøÖµÎÞÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHasAlarmOutStatic; //ÓÐ±¨¾¯Êä³öµÄ±¨¾¯Êä³ö¿Ú£¬°´Öµ±íÊ¾£¬°´ÏÂ±êÖµË³ÐòÅÅÁÐ£¬ÖµÎª0xffffffffÊ±µ±Ç°¼°ºóÐøÖµÎÞÐ§
            public uint dwLocalDisplay;			//±¾µØÏÔÊ¾×´Ì¬,0-Õý³£,1-²»Õý³£
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUDIO_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAudioInChanStatus;		//°´Î»±íÊ¾ÓïÒôÍ¨µÀµÄ×´Ì¬ 0-Î´Ê¹ÓÃ£¬1-Ê¹ÓÃÖÐ£¬µÚ0Î»±íÊ¾µÚ1¸öÓïÒôÍ¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 				//±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GETWORKSTATE_COND
        {
            public uint dwSize;  //½á¹¹Ìå³¤¶È
            public byte byFindHardByCond; /*0-²éÕÒÈ«²¿´ÅÅÌ(µ«Ò»´Î×î¶àÖ»ÄÜ²éÕÒ33¸ö)£¬´ËÊ±dwFindHardStatusNumÎÞÐ§*/
            public byte byFindChanByCond;  /*0-²éÕÒÈ«²¿Í¨µÀ£¬´ËÊ±dwFindChanNumÎÞÐ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£Áô	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwFindHardStatus; /*Òª²éÕÒµÄÓ²ÅÌºÅ£¬°´Öµ±íÊ¾£¬¸ÃÖµ²ÉÓÃË³ÐòÅÅÁÐ£¬ Óöµ½0xffffffffÔòÈÏÎªºóÐøÎÞÐ§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwFindChanNo; /*Òª²éÕÒµÄÍ¨µÀºÅ£¬°´Öµ±íÊ¾£¬¸ÃÖµ²ÉÓÃË³ÐòÅÅÁÐ£¬ Óöµ½0xffffffffÔòÈÏÎªºóÐøÎÞÐ§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }

        //DVR¹¤×÷×´Ì¬(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE_V30
        {
            public uint dwDeviceStatic;//Éè±¸µÄ×´Ì¬,0-Õý³£,1-CPUÕ¼ÓÃÂÊÌ«¸ß,³¬¹ý85%,2-Ó²¼þ´íÎó,ÀýÈç´®¿ÚËÀµô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE_V30[] struChanStatic;//Í¨µÀµÄ×´Ì¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatic;//±¨¾¯¶Ë¿ÚµÄ×´Ì¬,0-Ã»ÓÐ±¨¾¯,1-ÓÐ±¨¾¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatic;//±¨¾¯Êä³ö¶Ë¿ÚµÄ×´Ì¬,0-Ã»ÓÐÊä³ö,1-ÓÐ±¨¾¯Êä³ö
            public uint dwLocalDisplay;//±¾µØÏÔÊ¾×´Ì¬,0-Õý³£,1-²»Õý³£
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUDIO_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAudioChanStatus;//±íÊ¾ÓïÒôÍ¨µÀµÄ×´Ì¬ 0-Î´Ê¹ÓÃ£¬1-Ê¹ÓÃÖÐ, 0xffÎÞÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                struHardDiskStatic = new NET_DVR_DISKSTATE[MAX_DISKNUM_V30];
                struChanStatic = new NET_DVR_CHANNELSTATE_V30[MAX_CHANNUM_V30];
                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    struChanStatic[i].Init();
                }
                byAlarmInStatic = new byte[MAX_ALARMOUT_V30];
                byAlarmOutStatic = new byte[MAX_ALARMOUT_V30];
                byAudioChanStatus = new byte[MAX_AUDIO_V30];
                byRes = new byte[10];
            }
        }

        //DVR¹¤×÷×´Ì¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE
        {
            public uint dwDeviceStatic;//Éè±¸µÄ×´Ì¬,0-Õý³£,1-CPUÕ¼ÓÃÂÊÌ«¸ß,³¬¹ý85%,2-Ó²¼þ´íÎó,ÀýÈç´®¿ÚËÀµô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE[] struChanStatic;//Í¨µÀµÄ×´Ì¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatic;//±¨¾¯¶Ë¿ÚµÄ×´Ì¬,0-Ã»ÓÐ±¨¾¯,1-ÓÐ±¨¾¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatic;//±¨¾¯Êä³ö¶Ë¿ÚµÄ×´Ì¬,0-Ã»ÓÐÊä³ö,1-ÓÐ±¨¾¯Êä³ö
            public uint dwLocalDisplay;//±¾µØÏÔÊ¾×´Ì¬,0-Õý³£,1-²»Õý³£

            public void Init()
            {
                struHardDiskStatic = new NET_DVR_DISKSTATE[MAX_DISKNUM];
                struChanStatic = new NET_DVR_CHANNELSTATE[MAX_CHANNUM];
                byAlarmInStatic = new byte[MAX_ALARMIN];
                byAlarmOutStatic = new byte[MAX_ALARMOUT];
            }
        }

        //ÈÕÖ¾ÐÅÏ¢(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LOG_V30
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;//Ö÷ÀàÐÍ 1-±¨¾¯; 2-Òì³£; 3-²Ù×÷; 0xff-È«²¿
            public uint dwMinorType;//´ÎÀàÐÍ 0-È«²¿;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;//²Ù×÷Ãæ°åµÄÓÃ»§Ãû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//ÍøÂç²Ù×÷µÄÓÃ»§Ãû
            public NET_DVR_IPADDR struRemoteHostAddr;//Ô¶³ÌÖ÷»úµØÖ·
            public uint dwParaType;//²ÎÊýÀàÐÍ
            public uint dwChannel;//Í¨µÀºÅ
            public uint dwDiskNumber;//Ó²ÅÌºÅ
            public uint dwAlarmInPort;//±¨¾¯ÊäÈë¶Ë¿Ú
            public uint dwAlarmOutPort;//±¨¾¯Êä³ö¶Ë¿Ú
            public uint dwInfoLen;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN)]
            public string sInfo;
        }

        //ÈÕÖ¾ÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LOG
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;//Ö÷ÀàÐÍ 1-±¨¾¯; 2-Òì³£; 3-²Ù×÷; 0xff-È«²¿
            public uint dwMinorType;//´ÎÀàÐÍ 0-È«²¿;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;//²Ù×÷Ãæ°åµÄÓÃ»§Ãû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//ÍøÂç²Ù×÷µÄÓÃ»§Ãû
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteHostAddr;//Ô¶³ÌÖ÷»úµØÖ·
            public uint dwParaType;//²ÎÊýÀàÐÍ
            public uint dwChannel;//Í¨µÀºÅ
            public uint dwDiskNumber;//Ó²ÅÌºÅ
            public uint dwAlarmInPort;//±¨¾¯ÊäÈë¶Ë¿Ú
            public uint dwAlarmOutPort;//±¨¾¯Êä³ö¶Ë¿Ú
        }

        /************************¶¯»·±¨¾¯¹ÜÀíÖ÷»úÈÕÖ¾²éÕÒ begin************************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_SEARCH_LOG_PARAM
        {
            public ushort wMajorType;		// Ö÷ÀàÐÍ
            public ushort wMinorType;		// ´ÎÀàÐÍ 
            public NET_DVR_TIME struStartTime;	// ¿ªÊ¼Ê±¼ä 
            public NET_DVR_TIME struEndTime;	// ½áÊøÊ±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_LOG_RET
        {
            public NET_DVR_TIME struLogTime;                //  ÈÕÖ¾Ê±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;     // ²Ù×÷ÓÃ»§
            public NET_DVR_IPADDR struIPAddr;                 // ²Ù×÷IPµØÖ·
            public ushort wMajorType;                 // Ö÷ÀàÐÍ 
            public ushort wMinorType;                 // ´ÎÀàÐÍ
            public ushort wParam;	                    // ²Ù×÷²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwInfoLen;	                // ÃèÊöÐÅÏ¢³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN)]
            public string sInfo;       // ÃèÊöÐÅÏ¢
        }
        /*************************¶¯»·±¨¾¯¹ÜÀíÖ÷»úÈÕÖ¾²éÕÒ end***********************************************/

        //±¨¾¯Êä³ö×´Ì¬(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTSTATUS_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] Output;

            public void Init()
            {
                Output = new byte[MAX_ALARMOUT_V30];
            }
        }

        //±¨¾¯Êä³ö×´Ì¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTSTATUS
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] Output;
        }

        //ATM×¨ÓÃ
        /****************************ATM(begin)***************************/
        public const int NCR = 0;
        public const int DIEBOLD = 1;
        public const int WINCOR_NIXDORF = 2;
        public const int SIEMENS = 3;
        public const int OLIVETTI = 4;
        public const int FUJITSU = 5;
        public const int HITACHI = 6;
        public const int SMI = 7;
        public const int IBM = 8;
        public const int BULL = 9;
        public const int YiHua = 10;
        public const int LiDe = 11;
        public const int GDYT = 12;
        public const int Mini_Banl = 13;
        public const int GuangLi = 14;
        public const int DongXin = 15;
        public const int ChenTong = 16;
        public const int NanTian = 17;
        public const int XiaoXing = 18;
        public const int GZYY = 19;
        public const int QHTLT = 20;
        public const int DRS918 = 21;
        public const int KALATEL = 22;
        public const int NCR_2 = 23;
        public const int NXS = 24;

        //½»Ò×ÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_TRADEINFO
        {
            public ushort m_Year;
            public ushort m_Month;
            public ushort m_Day;
            public ushort m_Hour;
            public ushort m_Minute;
            public ushort m_Second;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] DeviceName;//Éè±¸Ãû³Æ
            public uint dwChannelNumer;//Í¨µÀºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] CardNumber;//¿¨ºÅ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string cTradeType;//½»Ò×ÀàÐÍ
            public uint dwCash;//½»Ò×½ð¶î
        }

        /*Ö¡¸ñÊ½*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FRAMETYPECODE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] code;/* ´úÂë */
        }

        //ATM²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FRAMEFORMAT
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sATMIP;/* ATM IPµØÖ· */
            public uint dwATMType;/* ATMÀàÐÍ */
            public uint dwInputMode;/* ÊäÈë·½Ê½	0-ÍøÂçÕìÌý 1-ÍøÂç½ÓÊÕ 2-´®¿ÚÖ±½ÓÊäÈë 3-´®¿ÚATMÃüÁîÊäÈë*/
            public uint dwFrameSignBeginPos;/* ±¨ÎÄ±êÖ¾Î»µÄÆðÊ¼Î»ÖÃ*/
            public uint dwFrameSignLength;/* ±¨ÎÄ±êÖ¾Î»µÄ³¤¶È */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byFrameSignContent;/* ±¨ÎÄ±êÖ¾Î»µÄÄÚÈÝ */
            public uint dwCardLengthInfoBeginPos;/* ¿¨ºÅ³¤¶ÈÐÅÏ¢µÄÆðÊ¼Î»ÖÃ */
            public uint dwCardLengthInfoLength;/* ¿¨ºÅ³¤¶ÈÐÅÏ¢µÄ³¤¶È */
            public uint dwCardNumberInfoBeginPos;/* ¿¨ºÅÐÅÏ¢µÄÆðÊ¼Î»ÖÃ */
            public uint dwCardNumberInfoLength;/* ¿¨ºÅÐÅÏ¢µÄ³¤¶È */
            public uint dwBusinessTypeBeginPos;/* ½»Ò×ÀàÐÍµÄÆðÊ¼Î»ÖÃ */
            public uint dwBusinessTypeLength;/* ½»Ò×ÀàÐÍµÄ³¤¶È */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FRAMETYPECODE[] frameTypeCode;/* ÀàÐÍ */
        }

        //SDK_V31 ATM
        /*¹ýÂËÉèÖÃ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILTER
        {
            public byte byEnable;/*0,²»ÆôÓÃ;1,ÆôÓÃ*/
            public byte byMode;/*0,ASCII;1,HEX*/
            public byte byFrameBeginPos;// ±¨ÎÄ±êÖ¾Î»µÄÆðÊ¼Î»ÖÃ     
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byFilterText;/*¹ýÂË×Ö·û´®*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*ÆðÊ¼±êÊ¶ÉèÖÃ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IDENTIFICAT
        {
            public byte byStartMode;/*0,ASCII;1,HEX*/
            public byte byEndMode;/*0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_FRAMETYPECODE struStartCode;/*ÆðÊ¼×Ö·û*/
            public NET_DVR_FRAMETYPECODE struEndCode;/*½áÊø×Ö·û*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        /*±¨ÎÄÐÅÏ¢Î»ÖÃ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PACKAGE_LOCATION
        {
            public byte byOffsetMode;/*0,token;1,fix*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwOffsetPos;/*modeÎª1µÄÊ±ºòÊ¹ÓÃ*/
            public NET_DVR_FRAMETYPECODE struTokenCode;/*±êÖ¾Î»*/
            public byte byMultiplierValue;/*±êÖ¾Î»¶àÉÙ´Î³öÏÖ*/
            public byte byEternOffset;/*¸½¼ÓµÄÆ«ÒÆÁ¿*/
            public byte byCodeMode;/*0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*±¨ÎÄÐÅÏ¢³¤¶È*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PACKAGE_LENGTH
        {
            public byte byLengthMode;/*³¤¶ÈÀàÐÍ£¬0,variable;1,fix;2,get from package(ÉèÖÃ¿¨ºÅ³¤¶ÈÊ¹ÓÃ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwFixLength;/*modeÎª1µÄÊ±ºòÊ¹ÓÃ*/
            public uint dwMaxLength;
            public uint dwMinLength;
            public byte byEndMode;/*ÖÕ½á·û0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_FRAMETYPECODE struEndCode;/*ÖÕ½á·û*/
            public uint dwLengthPos;/*lengthModeÎª2µÄÊ±ºòÊ¹ÓÃ£¬¿¨ºÅ³¤¶ÈÔÚ±¨ÎÄÖÐµÄÎ»ÖÃ*/
            public uint dwLengthLen;/*lengthModeÎª2µÄÊ±ºòÊ¹ÓÃ£¬¿¨ºÅ³¤¶ÈµÄ³¤¶È*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        /*OSD µþ¼ÓµÄÎ»ÖÃ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OSD_POSITION
        {
            public byte byPositionMode;/*µþ¼Ó·ç¸ñ£¬¹²2ÖÖ£»0£¬²»ÏÔÊ¾£»1£¬Custom*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPos_x;/*x×ø±ê£¬positionmodeÎªCustomÊ±Ê¹ÓÃ*/
            public uint dwPos_y;/*y×ø±ê£¬positionmodeÎªCustomÊ±Ê¹ÓÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*ÈÕÆÚÏÔÊ¾¸ñÊ½*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DATE_FORMAT
        {
            public byte byItem1;/*Month,0.mm;1.mmm;2.mmmm*/
            public byte byItem2;/*Day,0.dd;*/
            public byte byItem3;/*Year,0.yy;1.yyyy*/
            public byte byDateForm;/*0~5£¬3¸öitemµÄÅÅÁÐ×éºÏ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chSeprator;/*·Ö¸ô·û*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chDisplaySeprator;/*ÏÔÊ¾·Ö¸ô·û*/
            public byte byDisplayForm;/*0~5£¬3¸öitemµÄÅÅÁÐ×éºÏ*///lili mode by lili
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 27, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        /*Ê±¼äÏÔÊ¾¸ñÊ½*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVRT_TIME_FORMAT
        {
            public byte byTimeForm;/*1. HH MM SS;0. HH MM*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byHourMode;/*0,12;1,24*/ //lili mode
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chSeprator;/*±¨ÎÄ·Ö¸ô·û£¬ÔÝÊ±Ã»ÓÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chDisplaySeprator;/*ÏÔÊ¾·Ö¸ô·û*/
            public byte byDisplayForm;/*0~5£¬3¸öitemµÄÅÅÁÐ×éºÏ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public byte byDisplayHourMode;/*0,12;1,24*/ //lili mode
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OVERLAY_CHANNEL
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byChannel;/*µþ¼ÓµÄÍ¨µÀ*/
            public uint dwDelayTime;/*µþ¼ÓÑÓÊ±Ê±¼ä*/
            public byte byEnableDelayTime;/*ÊÇ·ñÆôÓÃµþ¼ÓÑÓÊ±£¬ÔÚÎÞÍË¿¨ÃüÁîÊ±ÆôÓÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_ACTION
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_OSD_POSITION struOsdPosition;
            public NET_DVR_FRAMETYPECODE struActionCode;/*½»Ò×ÀàÐÍµÈ¶ÔÓ¦µÄÂë*/
            public NET_DVR_FRAMETYPECODE struPreCode;/*µþ¼Ó×Ö·ûÇ°µÄ×Ö·û*/
            public byte byActionCodeMode;/*½»Ò×ÀàÐÍµÈ¶ÔÓ¦µÄÂë0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_DATE
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_DATE_FORMAT struDateForm;
            public NET_DVR_OSD_POSITION struOsdPosition;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_TIME
        {
            public NET_DVR_PACKAGE_LOCATION location;
            public NET_DVRT_TIME_FORMAT struTimeForm;
            public NET_DVR_OSD_POSITION struOsdPosition;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_OTHERS
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_PACKAGE_LENGTH struPackageLength;
            public NET_DVR_OSD_POSITION struOsdPosition;
            public NET_DVR_FRAMETYPECODE struPreCode;/*µþ¼Ó×Ö·ûÇ°µÄ×Ö·û*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //ÓÃ»§×Ô¶¨ÒåÐ­Òé
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_USER_DEFINE_PROTOCOL
        {
            public NET_DVR_IDENTIFICAT struIdentification;  //±¨ÎÄ±êÖ¾
            public NET_DVR_FILTER struFilter; //Êý¾Ý°ü¹ýÂËÉèÖÃ
            public NET_DVR_ATM_PACKAGE_OTHERS struCardNoPara; //µþ¼Ó¿¨ºÅÉèÖÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ACTION_TYPE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ATM_PACKAGE_ACTION[] struTradeActionPara; //µþ¼Ó½»Ò×ÐÐÎªÉèÖÃ 0-9 ÒÀ´Î¶ÔÓ¦InCard OutCard OverLay SetTime GetStatus Query WithDraw Deposit ChanPass Transfer
            public NET_DVR_ATM_PACKAGE_OTHERS struAmountPara; //µþ¼Ó½»Ò×½ð¶îÉèÖÃ
            public NET_DVR_ATM_PACKAGE_OTHERS struSerialNoPara; //µþ¼Ó½»Ò×ÐòºÅÉèÖÃ
            public NET_DVR_OVERLAY_CHANNEL struOverlayChan; //µþ¼ÓÍ¨µÀÉèÖÃ
            public NET_DVR_ATM_PACKAGE_DATE struRes1; //µþ¼ÓÈÕÆÚ£¬±£Áô
            public NET_DVR_ATM_PACKAGE_TIME struRes2; //µþ¼ÓÊ±¼ä£¬±£Áô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;        //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_FRAMEFORMAT_V30
        {
            public uint dwSize;                 //½á¹¹´óÐ¡
            public byte byEnable;				/*ÊÇ·ñÆôÓÃ0,²»ÆôÓÃ;1,ÆôÓÃ*/
            public byte byInputMode;			/**ÊäÈë·½Ê½:0-ÍøÂç¼àÌý¡¢1ÍøÂçÐ­Òé¡¢2-´®¿Ú¼àÌý¡¢3-´®¿ÚÐ­Òé*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;              //±£Áô×Ö½Ú 
            public NET_DVR_IPADDR struAtmIp;				/*ATM »úIP ÍøÂç¼àÌýÊ±Ê¹ÓÃ */
            public ushort wAtmPort;				/* ÍøÂçÐ­Òé·½Ê½Ê±ÊÇÊ¹ÓÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;              // ±£Áô×Ö½Ú
            public uint dwAtmType;				/*ATMÐ­ÒéÀàÐÍ£¬´ÓNET_DVR_ATM_PROTOCOL½á¹¹ÖÐ»ñÈ¡£¬Èç¹ûÀàÐÍÎª×Ô¶¨ÒåÊ±Ê¹ÓÃÓÃ»§×Ô¶¨ÒåÐ­Òé*/
            public NET_DVR_ATM_USER_DEFINE_PROTOCOL struAtmUserDefineProtocol; //ÓÃ»§×Ô¶¨ÒåÐ­Òé£¬µ±ATMÀàÐÍÎª×Ô¶¨Ê±ÐèÒªÊ¹ÓÃ¸Ã¶¨Òå
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        //Ð­ÒéÐÅÏ¢Êý¾Ý½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PROTO_TYPE
        {
            public uint dwAtmType; //ATMÐ­ÒéÀàÐÍ£¬Í¬Ê±×÷ÎªË÷ÒýÐòºÅ ATM ÅäÖÃÖÐµÄdwAtmType ×Ô¶¨ÒåÊ±Îª1025
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = ATM_DESC_LEN)]
            public string chDesc; //ATMÐ­Òé¼òµ¥ÃèÊö
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ATM_PROTO_LIST
        {
            public uint dwAtmProtoNum;/*Ð­ÒéÁÐ±íµÄ¸öÊý*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ATM_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ATM_PROTO_TYPE[] struAtmProtoType;/*Ð­ÒéÁÐ±íÐÅÏ¢*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PROTOCOL
        {
            public uint dwSize;
            public NET_DVR_ATM_PROTO_LIST struNetListenList;     // ÍøÂç¼àÌýÐ­ÒéÃèÊö
            public NET_DVR_ATM_PROTO_LIST struSerialListenList; //´®¿Ú¼àÌýÐ­ÒéÃèÊö
            public NET_DVR_ATM_PROTO_LIST struNetProtoList;     //ÍøÂçÐ­ÒéÃèÊö
            public NET_DVR_ATM_PROTO_LIST struSerialProtoList;   //´®¿ÚÐ­ÒéÃèÊö
            public NET_DVR_ATM_PROTO_TYPE struCustomProto;      //×Ô¶¨ÒåÐ­Òé            
        }

        /*****************************DS-6001D/F(begin)***************************/
        //DS-6001D Decoder
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderIP;//½âÂëÉè±¸Á¬½ÓµÄ·þÎñÆ÷IP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderUser;//½âÂëÉè±¸Á¬½ÓµÄ·þÎñÆ÷µÄÓÃ»§Ãû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderPasswd;//½âÂëÉè±¸Á¬½ÓµÄ·þÎñÆ÷µÄÃÜÂë
            public byte bySendMode;//½âÂëÉè±¸Á¬½Ó·þÎñÆ÷µÄÁ¬½ÓÄ£Ê½
            public byte byEncoderChannel;//½âÂëÉè±¸Á¬½ÓµÄ·þÎñÆ÷µÄÍ¨µÀºÅ
            public ushort wEncoderPort;//½âÂëÉè±¸Á¬½ÓµÄ·þÎñÆ÷µÄ¶Ë¿ÚºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] reservedData;//±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERSTATE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderIP;//½âÂëÉè±¸Á¬½ÓµÄ·þÎñÆ÷IP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderUser;//½âÂëÉè±¸Á¬½ÓµÄ·þÎñÆ÷µÄÓÃ»§Ãû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderPasswd;//½âÂëÉè±¸Á¬½ÓµÄ·þÎñÆ÷µÄÃÜÂë
            public byte byEncoderChannel;//½âÂëÉè±¸Á¬½ÓµÄ·þÎñÆ÷µÄÍ¨µÀºÅ
            public byte bySendMode;//½âÂëÉè±¸Á¬½ÓµÄ·þÎñÆ÷µÄÁ¬½ÓÄ£Ê½
            public ushort wEncoderPort;//½âÂëÉè±¸Á¬½ÓµÄ·þÎñÆ÷µÄ¶Ë¿ÚºÅ
            public uint dwConnectState;//½âÂëÉè±¸Á¬½Ó·þÎñÆ÷µÄ×´Ì¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] reservedData;//±£Áô
        }

        /*½âÂëÉè±¸¿ØÖÆÂë¶¨Òå*/
        public const int NET_DEC_STARTDEC = 1;
        public const int NET_DEC_STOPDEC = 2;
        public const int NET_DEC_STOPCYCLE = 3;
        public const int NET_DEC_CONTINUECYCLE = 4;

        /*Á¬½ÓµÄÍ¨µÀÅäÖÃ*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DECCHANINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IPµØÖ· */
            public ushort wDVRPort;/* ¶Ë¿ÚºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* ÓÃ»§Ãû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ÃÜÂë */
            public byte byChannel;/* Í¨µÀºÅ */
            public byte byLinkMode;/* Á¬½ÓÄ£Ê½ */
            public byte byLinkType;/* Á¬½ÓÀàÐÍ 0£­Ö÷ÂëÁ÷ 1£­×ÓÂëÁ÷ */
        }

        /*Ã¿¸ö½âÂëÍ¨µÀµÄÅäÖÃ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECINFO
        {
            public byte byPoolChans;/*Ã¿Â·½âÂëÍ¨µÀÉÏµÄÑ­»·Í¨µÀÊýÁ¿, ×î¶à4Í¨µÀ 0±íÊ¾Ã»ÓÐ½âÂë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECPOOLNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECCHANINFO[] struchanConInfo;
            public byte byEnablePoll;/*ÊÇ·ñÂÖÑ² 0-·ñ 1-ÊÇ*/
            public byte byPoolTime;/*ÂÖÑ²Ê±¼ä 0-±£Áô 1-10Ãë 2-15Ãë 3-20Ãë 4-30Ãë 5-45Ãë 6-1·ÖÖÓ 7-2·ÖÖÓ 8-5·ÖÖÓ */
        }

        /*Õû¸öÉè±¸½âÂëÅäÖÃ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECCFG
        {
            public uint dwSize;
            public uint dwDecChanNum;/*½âÂëÍ¨µÀµÄÊýÁ¿*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECINFO[] struDecInfo;
        }

        //2005-08-01
        /* ½âÂëÉè±¸Í¸Ã÷Í¨µÀÉèÖÃ */
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PORTINFO
        {
            public uint dwEnableTransPort;/* ÊÇ·ñÆô¶¯Í¸Ã÷Í¨µÀ 0£­²»ÆôÓÃ 1£­ÆôÓÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDecoderIP;/* DVR IPµØÖ· */
            public ushort wDecoderPort;/* ¶Ë¿ÚºÅ */
            public ushort wDVRTransPort;/* ÅäÖÃÇ°¶ËDVRÊÇ´Ó485/232Êä³ö£¬1±íÊ¾232´®¿Ú,2±íÊ¾485´®¿Ú */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string cReserve;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PORTCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRANSPARENTNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PORTINFO[] struTransPortInfo;/* Êý×é0±íÊ¾232 Êý×é1±íÊ¾485 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct bytime
        {
            public uint dwChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/*ÇëÇóÊÓÆµÓÃ»§Ãû*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ÃÜÂë */
            public NET_DVR_TIME struStartTime;/* °´Ê±¼ä»Ø·ÅµÄ¿ªÊ¼Ê±¼ä */
            public NET_DVR_TIME struStopTime;/* °´Ê±¼ä»Ø·ÅµÄ½áÊøÊ±¼ä */
        }

        /* ¿ØÖÆÍøÂçÎÄ¼þ»Ø·Å */
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PLAYREMOTEFILE
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDecoderIP;/* DVR IPµØÖ· */
            public ushort wDecoderPort;/* ¶Ë¿ÚºÅ */
            public ushort wLoadMode;/* »Ø·ÅÏÂÔØÄ£Ê½ 1£­°´Ãû×Ö 2£­°´Ê±¼ä */

            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct mode_size
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
                public byte[] byRes;

                /*[FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]             
                public byte[] byFile;/* »Ø·ÅµÄÎÄ¼þÃû */
                /*[FieldOffsetAttribute(0)]
                public bytime bytime;
                * */
            }
        }

        /*****************************DS-6001D/F(end)***************************/

        //µ¥×Ö·û²ÎÊý(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SHOWSTRINGINFO
        {
            public ushort wShowString;// Ô¤ÀÀµÄÍ¼ÏóÉÏÊÇ·ñÏÔÊ¾×Ö·û,0-²»ÏÔÊ¾,1-ÏÔÊ¾ ÇøÓò´óÐ¡704*576,µ¥¸ö×Ö·ûµÄ´óÐ¡Îª32*32
            public ushort wStringSize;/* ¸ÃÐÐ×Ö·ûµÄ³¤¶È£¬²»ÄÜ´óÓÚ44¸ö×Ö·û */
            public ushort wShowStringTopLeftX;/* ×Ö·ûÏÔÊ¾Î»ÖÃµÄx×ø±ê */
            public ushort wShowStringTopLeftY;/* ×Ö·ûÃû³ÆÏÔÊ¾Î»ÖÃµÄy×ø±ê */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 44)]
            public string sString;/* ÒªÏÔÊ¾µÄ×Ö·ûÄÚÈÝ */
        }

        //µþ¼Ó×Ö·û(9000À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* ÒªÏÔÊ¾µÄ×Ö·ûÄÚÈÝ */
        }

        //µþ¼Ó×Ö·ûÀ©Õ¹(8Ìõ×Ö·û)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM_EX, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* ÒªÏÔÊ¾µÄ×Ö·ûÄÚÈÝ */
        }

        //µþ¼Ó×Ö·û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* ÒªÏÔÊ¾µÄ×Ö·ûÄÚÈÝ */
        }

        /****************************DS9000ÐÂÔö½á¹¹(begin)******************************/
        /*EMAIL²ÎÊý½á¹¹*/
        //ÓëÔ­½á¹¹ÌåÓÐ²îÒì
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struReceiver
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sName;/* ÊÕ¼þÈËÐÕÃû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAddress;/* ÊÕ¼þÈËµØÖ· */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EMAILCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAccount;/* ÕËºÅ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_PWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*ÃÜÂë */

            [StructLayoutAttribute(LayoutKind.Sequential)]
            public struct struSender
            {
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
                public byte[] sName;/* ·¢¼þÈËÐÕÃû */
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
                public byte[] sAddress;/* ·¢¼þÈËµØÖ· */
            }

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSmtpServer;/* smtp·þÎñÆ÷ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPop3Server;/* pop3·þÎñÆ÷ */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
            public struReceiver[] struStringInfo;/* ×î¶à¿ÉÒÔÉèÖÃ3¸öÊÕ¼þÈË */

            public byte byAttachment;/* ÊÇ·ñ´ø¸½¼þ */
            public byte bySmtpServerVerify;/* ·¢ËÍ·þÎñÆ÷ÒªÇóÉí·ÝÑéÖ¤ */
            public byte byMailInterval;/* mail interval */
            public byte byEnableSSL;//sslÊÇ·ñÆôÓÃ9000_1.1
            public ushort wSmtpPort;//gmailµÄ465£¬ÆÕÍ¨µÄÎª25  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 74, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô
        }

        /*DVRÊµÏÖÑ²º½Êý¾Ý½á¹¹*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_PARA
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* Ô¤ÖÃµãºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseSpeed;/* Ñ²º½ËÙ¶È */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.U2)]
            public ushort[] wDwellTime;/* Í£ÁôÊ±¼ä */
            public byte byEnableThisCruise;/* ÊÇ·ñÆôÓÃ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }
        /****************************DS9000ÐÂÔö½á¹¹(end)******************************/
        //Ê±¼äµã
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIMEPOINT
        {
            public uint dwMonth;//ÔÂ 0-11±íÊ¾1-12¸öÔÂ
            public uint dwWeekNo;//µÚ¼¸ÖÜ 0£­µÚ1ÖÜ 1£­µÚ2ÖÜ 2£­µÚ3ÖÜ 3£­µÚ4ÖÜ 4£­×îºóÒ»ÖÜ
            public uint dwWeekDate;//ÐÇÆÚ¼¸ 0£­ÐÇÆÚÈÕ 1£­ÐÇÆÚÒ» 2£­ÐÇÆÚ¶þ 3£­ÐÇÆÚÈý 4£­ÐÇÆÚËÄ 5£­ÐÇÆÚÎå 6£­ÐÇÆÚÁù
            public uint dwHour;//Ð¡Ê±	¿ªÊ¼Ê±¼ä0£­23 ½áÊøÊ±¼ä1£­23
            public uint dwMin;//·Ö	0£­59
        }

        //ÏÄÁîÊ±²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZONEANDDST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£Áô
            public uint dwEnableDST;//ÊÇ·ñÆôÓÃÏÄÊ±ÖÆ 0£­²»ÆôÓÃ 1£­ÆôÓÃ
            public byte byDSTBias;//ÏÄÁîÊ±Æ«ÒÆÖµ£¬30min, 60min, 90min, 120min, ÒÔ·ÖÖÓ¼Æ£¬´«µÝÔ­Ê¼ÊýÖµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_TIMEPOINT struBeginPoint;//ÏÄÊ±ÖÆ¿ªÊ¼Ê±¼ä
            public NET_DVR_TIMEPOINT struEndPoint;//ÏÄÊ±ÖÆÍ£Ö¹Ê±¼ä
        }

        //Í¼Æ¬ÖÊÁ¿
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEGPARA
        {
            /*×¢Òâ£ºµ±Í¼ÏñÑ¹Ëõ·Ö±æÂÊÎªVGAÊ±£¬Ö§³Ö0=CIF, 1=QCIF, 2=D1×¥Í¼£¬
	        µ±·Ö±æÂÊÎª3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA,7=XVGA, 8=HD900p
	        ½öÖ§³Öµ±Ç°·Ö±æÂÊµÄ×¥Í¼*/
            public ushort wPicSize;/* 0=CIF, 1=QCIF, 2=D1 3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA*/
            public ushort wPicQuality;/* Í¼Æ¬ÖÊÁ¿ÏµÊý 0-×îºÃ 1-½ÏºÃ 2-Ò»°ã */
        }

        /* aux video out parameter */
        //¸¨ÖúÊä³ö²ÎÊýÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXOUTCFG
        {
            public uint dwSize;
            public uint dwAlarmOutChan;/* Ñ¡Ôñ±¨¾¯µ¯³ö´ó±¨¾¯Í¨µÀÇÐ»»Ê±¼ä£º1»­ÃæµÄÊä³öÍ¨µÀ: 0:Ö÷Êä³ö/1:¸¨1/2:¸¨2/3:¸¨3/4:¸¨4 */
            public uint dwAlarmChanSwitchTime;/* :1Ãë - 10:10Ãë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXOUT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwAuxSwitchTime;/* ¸¨ÖúÊä³öÇÐ»»Ê±¼ä: 0-²»ÇÐ»»,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXOUT * MAX_WINDOW, ArraySubType = UnmanagedType.I1)]
            public byte[] byAuxOrder;/* ¸¨ÖúÊä³öÔ¤ÀÀË³Ðò, 0xff±íÊ¾ÏàÓ¦µÄ´°¿Ú²»Ô¤ÀÀ */
        }

        //ntp
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NTPPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sNTPServer;/* Domain Name or IP addr of NTP server */
            public ushort wInterval;/* adjust time interval(hours) */
            public byte byEnableNTP;/* enable NPT client 0-no£¬1-yes*/
            public byte cTimeDifferenceH;/* Óë¹ú¼Ê±ê×¼Ê±¼äµÄ Ð¡Ê±Æ«ÒÆ-12 ... +13 */
            public byte cTimeDifferenceM;/* Óë¹ú¼Ê±ê×¼Ê±¼äµÄ ·ÖÖÓÆ«ÒÆ0, 30, 45*/
            public byte res1;
            public ushort wNtpPort; /* ntp server port 9000ÐÂÔö Éè±¸Ä¬ÈÏÎª123*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res2;
        }

        //ddns
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNSÕËºÅÓÃ»§Ãû/ÃÜÂë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName; /* ÓòÃû */
            public byte byEnableDDNS;/*ÊÇ·ñÓ¦ÓÃ 0-·ñ£¬1-ÊÇ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA_EX
        {
            public byte byHostIndex;/* 0-Hikvision DNS 1£­Dyndns 2£­PeanutHull(»¨Éú¿Ç)*/
            public byte byEnableDDNS;/*ÊÇ·ñÓ¦ÓÃDDNS 0-·ñ£¬1-ÊÇ*/
            public ushort wDDNSPort;/* DDNS¶Ë¿ÚºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNSÓÃ»§Ãû*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* DDNSÃÜÂë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName;/* Éè±¸Åä±¸µÄÓòÃûµØÖ· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sServerName;/* DDNS ¶ÔÓ¦µÄ·þÎñÆ÷µØÖ·£¬¿ÉÒÔÊÇIPµØÖ·»òÓòÃû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //9000À©Õ¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struDDNS
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNSÕËºÅÓÃ»§Ãû*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ÃÜÂë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName;/* Éè±¸Åä±¸µÄÓòÃûµØÖ· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sServerName;/* DDNSÐ­Òé¶ÔÓ¦µÄ·þÎñÆ÷µØÖ·£¬¿ÉÒÔÊÇIPµØÖ·»òÓòÃû */
            public ushort wDDNSPort;/* ¶Ë¿ÚºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA_V30
        {
            public byte byEnableDDNS;
            public byte byHostIndex;/* 0-Hikvision DNS(±£Áô) 1£­Dyndns 2£­PeanutHull(»¨Éú¿Ç)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DDNS_NUMS, ArraySubType = UnmanagedType.Struct)]
            public struDDNS[] struDDNS;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //email
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EMAILPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* ÓÊ¼þÕËºÅ/ÃÜÂë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sSmtpServer;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sPop3Server;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sMailAddr;/* email */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sEventMailAddr1;/* ÉÏ´«±¨¾¯/Òì³£µÈµÄemail */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sEventMailAddr2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //ÍøÂç²ÎÊýÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETAPPCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDNSIp; /* DNS·þÎñÆ÷µØÖ· */
            public NET_DVR_NTPPARA struNtpClientParam;/* NTP²ÎÊý */
            public NET_DVR_DDNSPARA struDDNSClientParam;/* DDNS²ÎÊý */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 464, ArraySubType = UnmanagedType.I1)]
            public byte[] res;/* ±£Áô */
        }

        //nfs½á¹¹ÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SINGLE_NFS
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sNfsHostIPAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNfsDirectory;

            public void Init()
            {
                this.sNfsDirectory = new byte[PATHNAME_LEN];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NFSCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NFS_DISK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_NFS[] struNfsDiskParam;

            public void Init()
            {
                this.struNfsDiskParam = new NET_DVR_SINGLE_NFS[MAX_NFS_DISK];

                for (int i = 0; i < MAX_NFS_DISK; i++)
                {
                    struNfsDiskParam[i].Init();
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ISCSI_CFG
        {
            public uint dwSize;                   // ½á¹¹´óÐ¡
            public ushort wVrmPort;                  // VRM ¼àÌý¶Ë¿Ú
            public byte byEnable;                  // ÊÇ·ñÆôÓÃ ISCSI´æ´¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                 // ±£Áô×Ö½Ú
            public NET_DVR_IPADDR struVrmAddr;          // VRM ipµØÖ· 16Î»
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string chNvtIndexCode;        //nvt index Code 
        }

        //Ñ²º½µãÅäÖÃ(HIK IP¿ìÇò×¨ÓÃ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_POINT
        {
            public byte PresetNum;//Ô¤ÖÃµã
            public byte Dwell;//Í£ÁôÊ±¼ä
            public byte Speed;//ËÙ¶È
            public byte Reserve;//±£Áô

            public void Init()
            {
                PresetNum = 0;
                Dwell = 0;
                Speed = 0;
                Reserve = 0;
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_RET
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CRUISE_POINT[] struCruisePoint;//×î´óÖ§³Ö32¸öÑ²º½µã

            public void Init()
            {
                struCruisePoint = new NET_DVR_CRUISE_POINT[32];
                for (int i = 0; i < 32; i++)
                {
                    struCruisePoint[i].Init();
                }
            }
        }

        /************************************¶àÂ·½âÂëÆ÷(begin)***************************************/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETCFG_OTHER
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFirstDNSIP;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sSecondDNSIP;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DECINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IPµØÖ· */
            public ushort wDVRPort;/* ¶Ë¿ÚºÅ */
            public byte byChannel;/* Í¨µÀºÅ */
            public byte byTransProtocol;/* ´«ÊäÐ­ÒéÀàÐÍ 0-TCP, 1-UDP */
            public byte byTransMode;/* ´«ÊäÂëÁ÷Ä£Ê½ 0£­Ö÷ÂëÁ÷ 1£­×ÓÂëÁ÷*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* ¼à¿ØÖ÷»úµÇÂ½ÕÊºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ¼à¿ØÖ÷»úÃÜÂë */
        }

        //Æô¶¯/Í£Ö¹¶¯Ì¬½âÂë
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DYNAMIC_DEC
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* ¶¯Ì¬½âÂëÍ¨µÀÐÅÏ¢ */
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_STATUS
        {
            public uint dwSize;
            public uint dwIsLinked;/* ½âÂëÍ¨µÀ×´Ì¬ 0£­ÐÝÃß 1£­ÕýÔÚÁ¬½Ó 2£­ÒÑÁ¬½Ó 3-ÕýÔÚ½âÂë */
            public uint dwStreamCpRate;/* Stream copy rate, X kbits/second */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string cRes;/* ±£Áô */
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* ½âÂëÍ¨µÀÐÅÏ¢ */
            public uint dwDecState;/* 0-¶¯Ì¬½âÂë 1£­Ñ­»·½âÂë 2£­°´Ê±¼ä»Ø·Å 3£­°´ÎÄ¼þ»Ø·Å */
            public NET_DVR_TIME StartTime;/* °´Ê±¼ä»Ø·Å¿ªÊ¼Ê±¼ä */
            public NET_DVR_TIME StopTime;/* °´Ê±¼ä»Ø·ÅÍ£Ö¹Ê±¼ä */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;/* °´ÎÄ¼þ»Ø·ÅÎÄ¼þÃû */
        }

        //Á¬½ÓµÄÍ¨µÀÅäÖÃ 2007-11-05
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DECCHANINFO
        {
            public uint dwEnable;/* ÊÇ·ñÆôÓÃ 0£­·ñ 1£­ÆôÓÃ*/
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* ÂÖÑ­½âÂëÍ¨µÀÐÅÏ¢ */
        }

        //2007-11-05 ÐÂÔöÃ¿¸ö½âÂëÍ¨µÀµÄÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO
        {
            public uint dwSize;
            public uint dwPoolTime;/*ÂÖÑ²Ê±¼ä */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_DECCHANINFO[] struchanConInfo;
        }

        //2007-12-22
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct TTY_CONFIG
        {
            public byte baudrate;/* ²¨ÌØÂÊ */
            public byte databits;/* Êý¾ÝÎ» */
            public byte stopbits;/* Í£Ö¹Î» */
            public byte parity;/* ÆæÅ¼Ð£ÑéÎ» */
            public byte flowcontrol;/* Á÷¿Ø */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_INFO
        {
            public byte byTranChanEnable;/* µ±Ç°Í¸Ã÷Í¨µÀÊÇ·ñ´ò¿ª 0£º¹Ø±Õ 1£º´ò¿ª */
            /*
             *	¶àÂ·½âÂëÆ÷±¾µØÓÐ1¸ö485´®¿Ú£¬1¸ö232´®¿Ú¶¼¿ÉÒÔ×÷ÎªÍ¸Ã÷Í¨µÀ,Éè±¸ºÅ·ÖÅäÈçÏÂ£º
             *	0 RS485
             *	1 RS232 Console
             */
            public byte byLocalSerialDevice;/* Local serial device */
            /*
	         *	Ô¶³Ì´®¿ÚÊä³ö»¹ÊÇÁ½¸ö,Ò»¸öRS232£¬Ò»¸öRS485
	         *	1±íÊ¾232´®¿Ú
	         *	2±íÊ¾485´®¿Ú
	         */
            public byte byRemoteSerialDevice;/* Remote output serial device */
            public byte res1;/* ±£Áô */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteDevIP;/* Remote Device IP */
            public ushort wRemoteDevPort;/* Remote Net Communication Port */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res2;/* ±£Áô */
            public TTY_CONFIG RemoteSerialDevCfg;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG
        {
            public uint dwSize;
            public byte by232IsDualChan;/* ÉèÖÃÄÄÂ·232Í¸Ã÷Í¨µÀÊÇÈ«Ë«¹¤µÄ È¡Öµ1µ½MAX_SERIAL_NUM */
            public byte by485IsDualChan;/* ÉèÖÃÄÄÂ·485Í¸Ã÷Í¨µÀÊÇÈ«Ë«¹¤µÄ È¡Öµ1µ½MAX_SERIAL_NUM */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res;/* ±£Áô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SERIAL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;/*Í¬Ê±Ö§³Ö½¨Á¢MAX_SERIAL_NUM¸öÍ¸Ã÷Í¨µÀ*/
        }

        //2007-12-24 Merry Christmas Eve...
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IPµØÖ· */
            public ushort wDVRPort;/* ¶Ë¿ÚºÅ */
            public byte byChannel;/* Í¨µÀºÅ */
            public byte byReserve;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* ÓÃ»§Ãû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ÃÜÂë */
            public uint dwPlayMode;/* 0£­°´ÎÄ¼þ 1£­°´Ê±¼ä*/
            public NET_DVR_TIME StartTime;
            public NET_DVR_TIME StopTime;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_CONTROL
        {
            public uint dwSize;
            public uint dwPlayCmd;/* ²¥·ÅÃüÁî ¼ûÎÄ¼þ²¥·ÅÃüÁî*/
            public uint dwCmdParam;/* ²¥·ÅÃüÁî²ÎÊý */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS
        {
            public uint dwSize;
            public uint dwCurMediaFileLen;/* µ±Ç°²¥·ÅµÄÃ½ÌåÎÄ¼þ³¤¶È */
            public uint dwCurMediaFilePosition;/* µ±Ç°²¥·ÅÎÄ¼þµÄ²¥·ÅÎ»ÖÃ */
            public uint dwCurMediaFileDuration;/* µ±Ç°²¥·ÅÎÄ¼þµÄ×ÜÊ±¼ä */
            public uint dwCurPlayTime;/* µ±Ç°ÒÑ¾­²¥·ÅµÄÊ±¼ä */
            public uint dwCurMediaFIleFrames;/* µ±Ç°²¥·ÅÎÄ¼þµÄ×ÜÖ¡Êý */
            public uint dwCurDataType;/* µ±Ç°´«ÊäµÄÊý¾ÝÀàÐÍ£¬19-ÎÄ¼þÍ·£¬20-Á÷Êý¾Ý£¬ 21-²¥·Å½áÊø±êÖ¾ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //2009-4-11 added by likui ¶àÂ·½âÂëÆ÷new
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_PASSIVEMODE
        {
            public ushort wTransProtol;//´«ÊäÐ­Òé£¬0-TCP, 1-UDP, 2-MCAST
            public ushort wPassivePort;//UDP¶Ë¿Ú, TCPÊ±Ä¬ÈÏ
            // char	sMcastIP[16];		//TCP,UDPÊ±ÎÞÐ§, MCASTÊ±Îª¶à²¥µØÖ·
            public NET_DVR_IPADDR struMcastIP;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_INFO_V30
        {
            public byte byTranChanEnable;/* µ±Ç°Í¸Ã÷Í¨µÀÊÇ·ñ´ò¿ª 0£º¹Ø±Õ 1£º´ò¿ª */
            /*
	         *	¶àÂ·½âÂëÆ÷±¾µØÓÐ1¸ö485´®¿Ú£¬1¸ö232´®¿Ú¶¼¿ÉÒÔ×÷ÎªÍ¸Ã÷Í¨µÀ,Éè±¸ºÅ·ÖÅäÈçÏÂ£º
	         *	0 RS485
	         *	1 RS232 Console
	         */
            public byte byLocalSerialDevice;/* Local serial device */
            /*
	         *	Ô¶³Ì´®¿ÚÊä³ö»¹ÊÇÁ½¸ö,Ò»¸öRS232£¬Ò»¸öRS485
	         *	1±íÊ¾232´®¿Ú
	         *	2±íÊ¾485´®¿Ú
	         */
            public byte byRemoteSerialDevice;/* Remote output serial device */
            public byte byRes1;/* ±£Áô */
            public NET_DVR_IPADDR struRemoteDevIP;/* Remote Device IP */
            public ushort wRemoteDevPort;/* Remote Net Communication Port */
            public byte byIsEstablished;/* Í¸Ã÷Í¨µÀ½¨Á¢³É¹¦±êÖ¾£¬0-Ã»ÓÐ³É¹¦£¬1-½¨Á¢³É¹¦ */
            public byte byRes2;/* ±£Áô */
            public TTY_CONFIG RemoteSerialDevCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUsername;/* 32BYTES */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword;/* 16BYTES */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30
        {
            public uint dwSize;
            public byte by232IsDualChan;/* ÉèÖÃÄÄÂ·232Í¸Ã÷Í¨µÀÊÇÈ«Ë«¹¤µÄ È¡Öµ1µ½MAX_SERIAL_NUM */
            public byte by485IsDualChan;/* ÉèÖÃÄÄÂ·485Í¸Ã÷Í¨µÀÊÇÈ«Ë«¹¤µÄ È¡Öµ1µ½MAX_SERIAL_NUM */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] vyRes;/* ±£Áô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SERIAL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;/*Í¬Ê±Ö§³Ö½¨Á¢MAX_SERIAL_NUM¸öÍ¸Ã÷Í¨µÀ*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CHAN_INFO_V30
        {
            public uint dwEnable;/* ÊÇ·ñÆôÓÃ 0£­·ñ 1£­ÆôÓÃ*/
            public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;/* ÂÖÑ­½âÂëÍ¨µÀÐÅÏ¢ */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO_V30
        {
            public uint dwSize;
            public uint dwPoolTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_INFO_V30[] struchanConInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO_V30
        {
            public uint dwSize;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;/*Á÷Ã½Ìå·þÎñÆ÷ÅäÖÃ*/
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;/* ½âÂëÍ¨µÀÐÅÏ¢ */
            public uint dwDecState;/* 0-¶¯Ì¬½âÂë 1£­Ñ­»·½âÂë 2£­°´Ê±¼ä»Ø·Å 3£­°´ÎÄ¼þ»Ø·Å */
            public NET_DVR_TIME StartTime;/* °´Ê±¼ä»Ø·Å¿ªÊ¼Ê±¼ä */
            public NET_DVR_TIME StopTime;/* °´Ê±¼ä»Ø·ÅÍ£Ö¹Ê±¼ä */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;/* °´ÎÄ¼þ»Ø·ÅÎÄ¼þÃû */
            public uint dwGetStreamMode;/*È¡Á÷Ä£Ê½:1-Ö÷¶¯£¬2-±»¶¯*/
            public NET_DVR_MATRIX_PASSIVEMODE struPassiveMode;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_RESOLUTIONNUM = 64; //Ö§³ÖµÄ×î´ó·Ö±æÂÊÊýÄ¿

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_ABILITY
        {
            public uint dwSize;
            public byte byDecNums;
            public byte byStartChan;
            public byte byVGANums;
            public byte byBNCNums;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8 * 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byVGAWindowMode;/*VGAÖ§³ÖµÄ´°¿ÚÄ£Ê½*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byBNCWindowMode;/*BNCÖ§³ÖµÄ´°¿ÚÄ£Ê½*/
            public byte byDspNums;
            public byte byHDMINums;//HDMIÏÔÊ¾Í¨µÀ¸öÊý£¨´Ó25¿ªÊ¼£©
            public byte byDVINums;//DVIÏÔÊ¾Í¨µÀ¸öÊý£¨´Ó29¿ªÊ¼£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RESOLUTIONNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] bySupportResolution;//°´ÕÕÉÏÃæµÄÃ¶¾Ù¶¨Òå,Ò»¸ö×Ö½Ú´ú±íÒ»¸ö·Ö±æÂÊÊÇ//·ñÖ§³Ö£¬1£ºÖ§³Ö£¬0£º²»Ö§³Ö
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4 * 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byHDMIWindowMode;//HDMIÖ§³ÖµÄ´°¿ÚÄ£Ê½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4 * 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVIWindowMode;//DVIÖ§³ÖµÄ´°¿ÚÄ£Ê½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //ÉÏ´«logo½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_LOGOCFG
        {
            public uint dwCorordinateX;//Í¼Æ¬ÏÔÊ¾ÇøÓòX×ø±ê
            public uint dwCorordinateY;//Í¼Æ¬ÏÔÊ¾ÇøÓòY×ø±ê
            public ushort wPicWidth; //Í¼Æ¬¿í
            public ushort wPicHeight; //Í¼Æ¬¸ß
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byFlash;//ÊÇ·ñÉÁË¸1-ÉÁË¸£¬0-²»ÉÁË¸
            public byte byTranslucent;//ÊÇ·ñ°ëÍ¸Ã÷1-°ëÍ¸Ã÷£¬0-²»°ëÍ¸Ã÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£Áô
            public uint dwLogoSize;//LOGO´óÐ¡£¬°üÀ¨BMPµÄÎÄ¼þÍ·
        }

        /*±àÂëÀàÐÍ*/
        public const int NET_DVR_ENCODER_UNKOWN = 0;/*Î´Öª±àÂë¸ñÊ½*/
        public const int NET_DVR_ENCODER_H264 = 1;/*HIK 264*/
        public const int NET_DVR_ENCODER_S264 = 2;/*Standard H264*/
        public const int NET_DVR_ENCODER_MPEG4 = 3;/*MPEG4*/
        public const int NET_DVR_ORIGINALSTREAM = 4;/*Original Stream*/
        public const int NET_DVR_PICTURE = 5;//*Picture*/
        public const int NET_DVR_ENCODER_MJPEG = 6;
        public const int NET_DVR_ECONDER_MPEG2 = 7;
        /* ´ò°ü¸ñÊ½ */
        public const int NET_DVR_STREAM_TYPE_UNKOWN = 0;/*Î´Öª´ò°ü¸ñÊ½*/
        public const int NET_DVR_STREAM_TYPE_HIKPRIVT = 1; /*º£¿µ×Ô¶¨Òå´ò°ü¸ñÊ½*/
        public const int NET_DVR_STREAM_TYPE_TS = 7;/* TS´ò°ü */
        public const int NET_DVR_STREAM_TYPE_PS = 8;/* PS´ò°ü */
        public const int NET_DVR_STREAM_TYPE_RTP = 9;/* RTP´ò°ü */

        /*½âÂëÍ¨µÀ×´Ì¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CHAN_STATUS
        {
            public byte byDecodeStatus;/*µ±Ç°×´Ì¬:0:Î´Æô¶¯£¬1£ºÆô¶¯½âÂë*/
            public byte byStreamType;/*ÂëÁ÷ÀàÐÍ*/
            public byte byPacketType;/*´ò°ü·½Ê½*/
            public byte byRecvBufUsage;/*½ÓÊÕ»º³åÊ¹ÓÃÂÊ*/
            public byte byDecBufUsage;/*½âÂë»º³åÊ¹ÓÃÂÊ*/
            public byte byFpsDecV;/*ÊÓÆµ½âÂëÖ¡ÂÊ*/
            public byte byFpsDecA;/*ÒôÆµ½âÂëÖ¡ÂÊ*/
            public byte byCpuLoad;/*DSP CPUÊ¹ÓÃÂÊ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDecodedV;/*½âÂëµÄÊÓÆµÖ¡*/
            public uint dwDecodedA;/*½âÂëµÄÒôÆµÖ¡*/
            public ushort wImgW;/*½âÂëÆ÷µ±Ç°µÄÍ¼Ïñ´óÐ¡,¿í*/
            public ushort wImgH; //¸ß
            public byte byVideoFormat;/*ÊÓÆµÖÆÊ½:0-NON,NTSC--1,PAL--2*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwDecChan; /*»ñÈ¡È«²¿½âÂëÍ¨µÀ×´Ì¬Ê±ÓÐÐ§£¬ÉèÖÃÊ±¿ÉÌî0*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        /*ÏÔÊ¾Í¨µÀ×´Ì¬*/
        public const int NET_DVR_MAX_DISPREGION = 16;         /*Ã¿¸öÏÔÊ¾Í¨µÀ×î¶à¿ÉÒÔÏÔÊ¾µÄ´°¿Ú*/
        //VGA·Ö±æÂÊ£¬Ä¿Ç°ÄÜÓÃµÄÊÇ£ºVGA_THS8200_MODE_XGA_60HZ¡¢VGA_THS8200_MODE_SXGA_60HZ¡¢
        //
        public enum VGA_MODE
        {
            /*VGA*/
            VGA_NOT_AVALIABLE,
            VGA_THS8200_MODE_SVGA_60HZ,    //(800*600)
            VGA_THS8200_MODE_SVGA_75HZ,    //(800*600)
            VGA_THS8200_MODE_XGA_60HZ,     //(1024*768)
            VGA_THS8200_MODE_XGA_75HZ,     //(1024*768)
            VGA_THS8200_MODE_SXGA_60HZ,    //(1280*1024)
            VGA_THS8200_MODE_720P_60HZ,    //(1280*720)
            VGA_THS8200_MODE_1080I_60HZ,   //(1920*1080)
            VGA_THS8200_MODE_1080P_30HZ,   //(1920*1080)
            VGA_THS8200_MODE_UXGA_30HZ,    //(1600*1200)
            /*HDMI*/
            HDMI_SII9134_MODE_XGA_60HZ,	   //(1024*768)
            HDMI_SII9134_MODE_SXGA_60HZ,   //(1280*1024)
            HDMI_SII9134_MODE_SXGA2_60HZ,  //(1280*960)
            HDMI_SII9134_MODE_720P_60HZ,   //(1280*720)	
            HDMI_SII9134_MODE_720P_50HZ,   //(1280*720)		
            HDMI_SII9134_MODE_1080I_60HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080I_50HZ,  //(1920*1080)	
            HDMI_SII9134_MODE_1080P_25HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_30HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_50HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_60HZ,  //(1920*1080)
            HDMI_SII9134_MODE_UXGA_60HZ,   //(1600*1200)
            /*DVI*/
            DVI_SII9134_MODE_XGA_60HZ,	   //(1024*768)
            DVI_SII9134_MODE_SXGA_60HZ,	   //(1280*1024)
            DVI_SII9134_MODE_SXGA2_60HZ,   //(1280*960)
            DVI_SII9134_MODE_720P_60HZ,	   //(1280*720)	
            DVI_SII9134_MODE_720P_50HZ,    //(1280*720)		
            DVI_SII9134_MODE_1080I_60HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080I_50HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_25HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_30HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_50HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_60HZ,   //(1920*1080)
            DVI_SII9134_MODE_UXGA_60HZ,     //(1600*1200)
            VGA_DECSVR_MODE_SXGA2_60HZ,
            HDMI_DECSVR_MODE_1080P_24HZ,
            DVI_DECSVR_MODE_1080P_24HZ,
            YPbPr_DECSVR_MODE_720P_60HZ,
            YPbPr_DECSVR_MODE_1080I_60HZ
        }

        //µÍÖ¡ÂÊ¶¨Òå
        public const int LOW_DEC_FPS_1_2 = 51;
        public const int LOW_DEC_FPS_1_4 = 52;
        public const int LOW_DEC_FPS_1_8 = 53;
        public const int LOW_DEC_FPS_1_16 = 54;

        /*ÊÓÆµÖÆÊ½±ê×¼*/
        public enum VIDEO_STANDARD
        {
            VS_NON = 0,
            VS_NTSC = 1,
            VS_PAL = 2,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_VIDEOPLATFORM
        {
            /*¸÷¸ö×Ó´°¿Ú¶ÔÓ¦½âÂëÍ¨µÀËù¶ÔÓ¦µÄ½âÂë×ÓÏµÍ³µÄ²ÛÎ»ºÅ(¶ÔÓÚÊÓÆµ×ÛºÏÆ½Ì¨ÖÐ½âÂë×ÓÏµÍ³ÓÐÐ§)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_NOTVIDEOPLATFORM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGA_DISP_CHAN_CFG
        {
            public uint dwSize;
            public byte byAudio;/*ÒôÆµÊÇ·ñ¿ªÆô,0-·ñ£¬1-ÊÇ*/
            public byte byAudioWindowIdx;/*ÒôÆµ¿ªÆô×Ó´°¿Ú*/
            public byte byVgaResolution;/*VGAµÄ·Ö±æÂÊ*/
            public byte byVedioFormat;/*ÊÓÆµÖÆÊ½£¬1:NTSC,2:PAL,0-NON*/
            public uint dwWindowMode;/*»­ÃæÄ£Ê½£¬´ÓÄÜÁ¦¼¯Àï»ñÈ¡£¬Ä¿Ç°Ö§³Ö1,2,4,9,16*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*¸÷¸ö×Ó´°¿Ú¹ØÁªµÄ½âÂëÍ¨µÀ*/
            public byte byEnlargeStatus;          /*ÊÇ·ñ´¦ÓÚ·Å´ó×´Ì¬£¬0£º²»·Å´ó£¬1£º·Å´ó*/
            public byte byEnlargeSubWindowIndex;//·Å´óµÄ×Ó´°¿ÚºÅ
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct struDiff
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                public byte[] byRes;
            }
            public byte byUnionType;/*Çø·Ö¹²ÓÃÌå£¬0-ÊÓÆµ×ÛºÏÆ½Ì¨ÄÚ²¿½âÂëÆ÷ÏÔÊ¾Í¨µÀÅäÖÃ£¬1-ÆäËû½âÂëÆ÷ÏÔÊ¾Í¨µÀÅäÖÃ*/
            public byte byScale; /*ÏÔÊ¾Ä£Ê½£¬0---ÕæÊµÏÔÊ¾£¬1---Ëõ·ÅÏÔÊ¾( Õë¶ÔBNC )*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_CHAN_STATUS
        {
            public byte byDispStatus;/*ÏÔÊ¾×´Ì¬£º0£ºÎ´ÏÔÊ¾£¬1£ºÆô¶¯ÏÔÊ¾*/
            public byte byBVGA; /*VGA/BNC*/
            public byte byVideoFormat;/*ÊÓÆµÖÆÊ½:1:NTSC,2:PAL,0-NON*/
            public byte byWindowMode;/*µ±Ç°»­ÃæÄ£Ê½*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*¸÷¸ö×Ó´°¿Ú¹ØÁªµÄ½âÂëÍ¨µÀ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_DVR_MAX_DISPREGION, ArraySubType = UnmanagedType.I1)]
            public byte[] byFpsDisp;/*Ã¿¸ö×Ó»­ÃæµÄÏÔÊ¾Ö¡ÂÊ*/
            public byte byScreenMode;			//ÆÁÄ»Ä£Ê½0-ÆÕÍ¨ 1-´óÆÁ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_DECODECHANNUM = 32;//¶àÂ·½âÂëÆ÷×î´ó½âÂëÍ¨µÀÊý
        public const int MAX_DISPCHANNUM = 24;//¶àÂ·½âÂëÆ÷×î´óÏÔÊ¾Í¨µÀÊý

        /*½âÂëÆ÷Éè±¸×´Ì¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODER_WORK_STATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECODECHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_STATUS[] struDecChanStatus;/*½âÂëÍ¨µÀ×´Ì¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPCHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISP_CHAN_STATUS[] struDispChanStatus;/*ÏÔÊ¾Í¨µÀ×´Ì¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_ALARMIN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatus;/*±¨¾¯ÊäÈë×´Ì¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAalarmOutStatus;/*±¨¾¯Êä³ö×´Ì¬*/
            public byte byAudioInChanStatus;/*ÓïÒô¶Ô½²×´Ì¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //2009-12-1 Ôö¼Ó±»¶¯½âÂë²¥·Å¿ØÖÆ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PASSIVEDECODE_CONTROL
        {
            public uint dwSize;
            public uint dwPlayCmd;		/* ²¥·ÅÃüÁî ¼ûÎÄ¼þ²¥·ÅÃüÁî*/
            public uint dwCmdParam;		/* ²¥·ÅÃüÁî²ÎÊý */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//Reverse
        }

        public const int PASSIVE_DEC_PAUSE = 1;	/*±»¶¯½âÂëÔÝÍ£(½öÎÄ¼þÁ÷ÓÐÐ§)*/
        public const int PASSIVE_DEC_RESUME = 2;	/*»Ö¸´±»¶¯½âÂë(½öÎÄ¼þÁ÷ÓÐÐ§)*/
        public const int PASSIVE_DEC_FAST = 3;   /*¿ìËÙ±»¶¯½âÂë(½öÎÄ¼þÁ÷ÓÐÐ§)*/
        public const int PASSIVE_DEC_SLOW = 4;   /*ÂýËÙ±»¶¯½âÂë(½öÎÄ¼þÁ÷ÓÐÐ§)*/
        public const int PASSIVE_DEC_NORMAL = 5;   /*Õý³£±»¶¯½âÂë(½öÎÄ¼þÁ÷ÓÐÐ§)*/
        public const int PASSIVE_DEC_ONEBYONE = 6;  /*±»¶¯½âÂëµ¥Ö¡²¥·Å(±£Áô)*/
        public const int PASSIVE_DEC_AUDIO_ON = 7;   /*ÒôÆµ¿ªÆô*/
        public const int PASSIVE_DEC_AUDIO_OFF = 8; 	 /*ÒôÆµ¹Ø±Õ*/
        public const int PASSIVE_DEC_RESETBUFFER = 9;    /*Çå¿Õ»º³åÇø*/

        //2009-12-16 Ôö¼Ó¿ØÖÆ½âÂëÆ÷½âÂëÍ¨µÀËõ·Å
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DECCHAN_CONTROL
        {
            public uint dwSize;
            public byte byDecChanScaleStatus;/*½âÂëÍ¨µÀÏÔÊ¾Ëõ·Å¿ØÖÆ,1±íÊ¾Ëõ·ÅÏÔÊ¾£¬0±íÊ¾ÕæÊµÏÔÊ¾*/
            public byte byDecodeDelay;//½âÂëÑÓÊ±£¬0-Ä¬ÈÏ£¬1-ÊµÊ±ÐÔºÃ£¬2-ÊµÊ±ÐÔ½ÏºÃ£¬3-ÊµÊ±ÐÔÖÐ£¬Á÷³©ÐÔÖÐ£¬4-Á÷³©ÐÔ½ÏºÃ£¬5-Á÷³©ÐÔºÃ£¬0xff-×Ô¶¯µ÷Õû   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 66, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /************************************¶àÂ·½âÂëÆ÷(end)***************************************/

        /************************************ÊÓÆµ×ÛºÏÆ½Ì¨(begin)***************************************/
        public const int MAX_SUBSYSTEM_NUM = 80;   //Ò»¸ö¾ØÕóÏµÍ³ÖÐ×î¶à×ÓÏµÍ³ÊýÁ¿
        public const int MAX_SUBSYSTEM_NUM_V40 = 120;   //Ò»¸ö¾ØÕóÏµÍ³ÖÐ×î¶à×ÓÏµÍ³ÊýÁ¿
        public const int MAX_SERIALLEN = 36;  //×î´óÐòÁÐºÅ³¤¶È
        public const int MAX_LOOPPLANNUM = 16;  //×î´ó¼Æ»®ÇÐ»»×é
        public const int DECODE_TIMESEGMENT = 4;     //¼Æ»®½âÂëÃ¿ÌìÊ±¼ä¶ÎÊý

        public const int MAX_DOMAIN_NAME = 64;  /* ×î´óÓòÃû³¤¶È */
        public const int MAX_DISKNUM_V30 = 33; //9000Éè±¸×î´óÓ²ÅÌÊý/* ×î¶à33¸öÓ²ÅÌ(°üÀ¨16¸öÄÚÖÃSATAÓ²ÅÌ¡¢1¸öeSATAÓ²ÅÌºÍ16¸öNFSÅÌ) */
        public const int MAX_DAYS = 7;       //Ã¿ÖÜÌìÊý
        public const int MAX_DISPNUM_V41 = 32;
        public const int MAX_WINDOWS_NUM = 12;
        public const int MAX_VOUTNUM = 32;
        public const int MAX_SUPPORT_RES = 32;
        public const int MAX_BIGSCREENNUM = 100;

        public const int VIDEOPLATFORM_ABILITY = 0x210; //ÊÓÆµ×ÛºÏÆ½Ì¨ÄÜÁ¦¼¯
        public const int MATRIXDECODER_ABILITY_V41 = 0x260; //½âÂëÆ÷ÄÜÁ¦¼¯

        public const int NET_DVR_MATRIX_BIGSCREENCFG_GET = 1140;//»ñÈ¡´óÆÁÆ´½Ó²ÎÊý        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SUBSYSTEMINFO
        {
            public byte bySubSystemType;//×ÓÏµÍ³ÀàÐÍ£¬1-½âÂëÓÃ×ÓÏµÍ³£¬2-±àÂëÓÃ×ÓÏµÍ³£¬0-NULL£¨´Ë²ÎÊýÖ»ÄÜ»ñÈ¡£©
            public byte byChan;//×ÓÏµÍ³Í¨µÀÊý£¨´Ë²ÎÊýÖ»ÄÜ»ñÈ¡£©
            public byte byLoginType;//×¢²áÀàÐÍ£¬1-Ö±Á¬£¬2-DNS£¬3-»¨Éú¿Ç
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struSubSystemIP;/*IPµØÖ·£¨¿ÉÐÞ¸Ä£©*/
            public ushort wSubSystemPort;//×ÓÏµÍ³¶Ë¿ÚºÅ£¨¿ÉÐÞ¸Ä£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_IPADDR struSubSystemIPMask;//×ÓÍøÑÚÂë
            public NET_DVR_IPADDR struGatewayIpAddr;	/* Íø¹ØµØÖ·*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* ÓÃ»§Ãû £¨´Ë²ÎÊýÖ»ÄÜ»ñÈ¡£©*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*ÃÜÂë£¨´Ë²ÎÊýÖ»ÄÜ»ñÈ¡£©*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string sDomainName;//ÓòÃû(¿ÉÐÞ¸Ä)
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string sDnsAddress;/*DNSÓòÃû»òIPµØÖ·*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//ÐòÁÐºÅ£¨´Ë²ÎÊýÖ»ÄÜ»ñÈ¡£©
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALLSUBSYSTEMINFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUBSYSTEM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SUBSYSTEMINFO[] struSubSystemInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOOPPLAN_SUBCFG
        {
            public uint dwSize;
            public uint dwPoolTime; /*ÂÖÑ¯¼ä¸ô£¬µ¥Î»£ºÃë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_INFO_V30[] struChanConInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMMODECFG
        {
            public uint dwSize;
            public byte byAlarmMode;//±¨¾¯´¥·¢ÀàÐÍ£¬1-ÂÖÑ¯£¬2-±£³Ö 
            public ushort wLoopTime;//ÂÖÑ¯Ê±¼ä, µ¥Î»£ºÃë 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CODESPLITTERINFO
        {
            public uint dwSize;
            public NET_DVR_IPADDR struIP;/*Âë·ÖÆ÷IPµØÖ·*/
            public ushort wPort;//Âë·ÖÆ÷¶Ë¿ÚºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* ÓÃ»§Ãû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*ÃÜÂë */
            public byte byChan;//Âë·ÖÆ÷485ºÅ
            public byte by485Port;//485¿ÚµØÖ·      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ASSOCIATECFG
        {
            public byte byAssociateType;//¹ØÁªÀàÐÍ£¬1-±¨¾¯
            public ushort wAlarmDelay;//±¨¾¯ÑÓÊ±£¬0£­5Ãë£»1£­10Ãë£»2£­30Ãë£»3£­1·ÖÖÓ£»4£­2·ÖÖÓ£»5£­5·ÖÖÓ£»6£­10·ÖÖÓ£»
            public byte byAlarmNum;//±¨¾¯ºÅ£¬¾ßÌåµÄÖµÓÉÓ¦ÓÃ¸³£¬ÏàÍ¬µÄ±¨¾¯¸³ÏàÍ¬µÄÖµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DYNAMICDECODE
        {
            public uint dwSize;
            public NET_DVR_ASSOCIATECFG struAssociateCfg;//´¥·¢¶¯Ì¬½âÂë¹ØÁª½á¹¹
            public NET_DVR_PU_STREAM_CFG struPuStreamCfg;//¶¯Ì¬½âÂë½á¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODESCHED
        {
            public NET_DVR_SCHEDTIME struSchedTime;
            public byte byDecodeType;/*0-ÎÞ£¬1-ÂÖÑ¯½âÂë£¬2-¶¯Ì¬½âÂë*/
            public byte byLoopGroup;//ÂÖÑ¯×éºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_PU_STREAM_CFG struDynamicDec;//¶¯Ì¬½âÂë
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLANDECODE
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * DECODE_TIMESEGMENT, ArraySubType = UnmanagedType.I1)]
            public NET_DVR_DECODESCHED[] struDecodeSched;//ÖÜÒ»×÷Îª¿ªÊ¼£¬ºÍ9000Ò»ÖÂ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;
        }
        /************************************ÊÓÆµ×ÛºÏÆ½Ì¨(end)***************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPLATFORM_ABILITY
        {
            public uint dwSize;
            public byte byCodeSubSystemNums;//±àÂë×ÓÏµÍ³ÊýÁ¿
            public byte byDecodeSubSystemNums;//½âÂë×ÓÏµÍ³ÊýÁ¿
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byWindowMode; /*ÏÔÊ¾Í¨µÀÖ§³ÖµÄ´°¿ÚÄ£Ê½*/
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byRes;
        }



        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SUBSYSTEM_ABILITY
        {
            /*×ÓÏµÍ³ÀàÐÍ£¬1-½âÂëÓÃ×ÓÏµÍ³£¬2-±àÂëÓÃ×ÓÏµÍ³£¬3-¼¶ÁªÊä³ö×ÓÏµÍ³£¬4-¼¶ÁªÊäÈë×ÓÏµÍ³£¬5-Âë·ÖÆ÷×ÓÏµÍ³£¬6-±¨¾¯Ö÷»ú×ÓÏµÍ³£¬7-ÖÇÄÜ×ÓÏµÍ³£¬8-V6½âÂë×ÓÏµÍ³£¬9-V6×ÓÏµÍ³£¬0-NULL£¨´Ë²ÎÊýÖ»ÄÜ»ñÈ¡£©*/
            public byte bySubSystemType;
            public byte byChanNum;//×ÓÏµÍ³Í¨µÀÊý
            public byte byStartChan;//×ÓÏµÍ³ÆðÊ¼Í¨µÀÊý
            public byte bySlotNum;//²ÛÎ»ºÅ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public struDecoderSystemAbility _struAbility;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struDecoderSystemAbility
        {
            public byte byVGANums;//VGAÏÔÊ¾Í¨µÀ¸öÊý£¨´Ó1¿ªÊ¼£©
            public byte byBNCNums;//BNCÏÔÊ¾Í¨µÀ¸öÊý£¨´Ó9¿ªÊ¼£©
            public byte byHDMINums;//HDMIÏÔÊ¾Í¨µÀ¸öÊý£¨´Ó25¿ªÊ¼£©
            public byte byDVINums;//DVIÏÔÊ¾Í¨µÀ¸öÊý£¨´Ó29¿ªÊ¼£©

            public byte byLayerNums;//´óÆÁÆ´½ÓÖÐ£¬×öÖ÷ÆÁÊ±ËùÖ§³ÖÍ¼²ãÊý
            public byte bySpartan;//³©ÏÔ¹¦ÄÜ£¬0-²»Ö§³Ö£¬1-Ö§³Ö
            public byte byDecType; //½âÂë×ÓÏµÍ³ÀàÐÍ£¬0-ÆÕÍ¨ÐÍ,1-ÔöÇ¿ÐÍ(ÆÕÍ¨ÐÍ·ÖÆÁÊ±Ç°4´°¿ÚÐèÊ¹ÓÃ×ÔÉí×ÊÔ´£¬ÔöÇ¿ÐÍÎÞ´ËÏÞÖÆ£¬ÔöÇ¿ÐÍ×î¶à¿É±»ÆäËû×ÓÏµÍ³½è16Â·D1½âÂë×ÊÔ´
            //ÔöÇ¿ÐÍ±»´óÆÁ¹ØÁªÎª×ÓÆÁºó×ÊÔ´¿É±»½èÓÃ£¬ÆÕÍ¨ÐÍÔò²»ÄÜ±»½èÓÃ)
            public byte byOutputSwitch;//ÊÇ·ñÖ§³ÖHDMI/DVI»¥ÏàÇÐ»»£¬0-²»Ö§³Ö£¬1-Ö§³Ö
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byDecoderType; //½âÂë°åÀàÐÍ  0-ÆÕÍ¨½âÂë°å 1-ÍòÄÜ½âÂë°å
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struAbility
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            //  [FieldOffsetAttribute(0)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPLATFORM_ABILITY_V40
        {
            public uint dwSize;
            public byte byCodeSubSystemNums;
            public byte byDecodeSubSystemNums;//½âÂë×ÓÏµÍ³ÊýÁ¿
            public byte bySupportNat;//ÊÇ·ñÖ§³ÖNAT£¬0-²»Ö§³Ö£¬1-Ö§³Ö
            public byte byInputSubSystemNums;//¼¶ÁªÊäÈë×ÓÏµÍ³ÊýÁ¿
            public byte byOutputSubSystemNums;//¼¶ÁªÊä³ö×ÓÏµÍ³ÊýÁ¿
            public byte byCodeSpitterSubSystemNums;//Âë·Ö×ÓÏµÍ³ÊýÁ¿
            public byte byAlarmHostSubSystemNums;//±¨¾¯×ÓÏµÍ³ÊýÁ¿
            public byte bySupportBigScreenNum;//ËùÖ§³Ö×î¶à×é³É´óÆÁµÄ¸öÊý
            public byte byVCASubSystemNums;//ÖÇÄÜ×ÓÏµÍ³ÊýÁ¿
            public byte byV6SubSystemNums;//V6×ÓÏµÍ³ÊýÁ¿
            public byte byV6DecoderSubSystemNums;//V6½âÂë×ÓÏµÍ³ÊýÁ¿
            public byte bySupportBigScreenX;/*´óÆÁÆ´½ÓµÄÄ£Ê½£ºm¡Án*/
            public byte bySupportBigScreenY;
            public byte bySupportSceneNums;//Ö§³Ö³¡¾°Ä£Ê½µÄ¸öÊý
            public byte byVcaSupportChanMode;//ÖÇÄÜÖ§³ÖµÄÍ¨µÀÊ¹ÓÃÄ£Ê½£¬0-Ê¹ÓÃ½âÂëÍ¨µÀ£¬1-Ê¹ÓÃÏÔÊ¾Í¨µÀ¼°×ÓÍ¨µÀºÅ
            public byte bySupportScreenNums;//ËùÖ§³ÖµÄ´óÆÁµÄÆÁÄ»×î´ó¸öÊý
            public byte bySupportLayerNums;//ËùÖ§³ÖµÄÍ¼²ãÊý£¬0xff-ÎÞÐ§
            public byte byNotSupportPreview;//ÊÇ·ñÖ§³ÖÔ¤ÀÀ,1-²»Ö§³Ö£¬0-Ö§³Ö
            public byte byNotSupportStorage;//ÊÇ·ñÖ§³Ö´æ´¢,1-²»Ö§³Ö£¬0-Ö§³Ö
            public byte byUploadLogoMode;//ÉÏ´«logoÄ£Ê½£¬0-ÉÏ´«¸ø½âÂëÍ¨µÀ£¬1-ÉÏ´«¸øÏÔÊ¾Í¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUBSYSTEM_NUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SUBSYSTEM_ABILITY[] struSubSystemAbility;
            public byte by485Nums;//485´®¿Ú¸öÊý
            public byte by232Nums;//232´®¿Ú¸öÊý
            public byte bySerieStartChan;//ÆðÊ¼Í¨µÀ
            public byte byScreenMode;//´óÆÁÄ£Ê½£¬0-Ö÷ÆÁÓÉ¿Í»§¶Ë·ÖÅä£¬1-Ö÷ÆÁÓÉÉè±¸¶Ë·ÖÅä
            public byte byDevVersion;//Éè±¸°æ±¾£¬0-B10/B11/B12£¬1-B20
            public byte bySupportBaseMapNums;//ËùÖ§³ÖµÄµ×Í¼Êý£¬µ×Í¼ºÅ´Ó1¿ªÊ¼
            public ushort wBaseLengthX;//Ã¿¸öÆÁ´óÐ¡µÄ»ù×¼Öµ£¬B20Ê¹ÓÃ
            public ushort wBaseLengthY;
            public byte bySupportPictureTrans;  //ÊÇ·ñÖ§³ÖÍ¼Æ¬»ØÏÔ£¬0-²»Ö§³Ö£¬1-Ö§³Ö	
            public byte bySupportPreAllocDec;   //ÊÇ·ñÖ§³ÖÖÇÄÜ½âÂë×ÊÔ´Ô¤·ÖÅä£¬0-²»Ö§³Ö£¬1-Ö§³Ö
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 628, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLESCREENCFG
        {
            public byte byScreenSeq;//ÆÁÄ»ÐòºÅ£¬0xff±íÊ¾²»ÓÃ´ËÆÁ,64-T½âÂëÆ÷µÚÒ»¸ö±íÊ¾Ö÷ÆÁ
            public byte bySubSystemNum;//½âÂë×ÓÏµÍ³²ÛÎ»ºÅ,½âÂëÆ÷´ËÖµÃ»ÓÐÓÃ
            public byte byDispNum;//½âÂë×ÓÏµÍ³ÉÏ¶ÔÓ¦ÏÔÊ¾Í¨µÀºÅ£¬64-T½âÂëÆ÷ÖÐ¸ÃÖµ±íÊ¾½âÂëÆ÷µÄÏÔÊ¾Í¨µÀºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENCFG
        {
            public uint dwSize;
            public byte byEnable;//´óÆÁÆ´½ÓÊ¹ÄÜ£¬0-²»Ê¹ÄÜ£¬1-Ê¹ÄÜ
            public byte byModeX;/*´óÆÁÆ´½ÓÄ£Ê½*/
            public byte byModeY;
            public byte byMainDecodeSystem;//×ÛºÏÆ½Ì¨µÄ½âÂë°åÖÐ¸ÃÖµ±íÊ¾Ö÷ÆÁ²ÛÎ»ºÅ£¬64-T½âÂëÆ÷ÖÐ¸ÃÖµ±íÊ¾½âÂëÍ¨µÀºÅ
            public byte byMainDecoderDispChan;//Ö÷ÆÁËùÓÃÏÔÊ¾Í¨µÀºÅ£¬1.1netra°æ±¾ÐÂÔö£¬netra½âÂëÆ÷ÓÐÁ½¸öÏÔÊ¾Í¨µÀ£¬¶¼ÄÜ¹»×÷ÎªÖ÷ÆÁ¡£64-TÖÐ¸ÃÖµÎÞÐ§
            public byte byVideoStandard;      //´óÆÁÃ¿¸ö×ÓÆÁÖÆÊ½ÏàÍ¬ 1:NTSC,2:PAL
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwResolution;         //´óÆÁÃ¿¸ö×ÓÆÁ·Ö±æÂÊÏàÍ¬
            //´óÆÁÆ´½Ó´ÓÆÁÄ»ÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_BIGSCREENNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLESCREENCFG[] struFollowSingleScreen;
            //ÆðÊ¼×ø±ê±ØÐëÎª»ù×¼×ø±êµÄÕûÊý±¶
            public ushort wBigScreenX; //´óÆÁÔÚµçÊÓÇ½ÖÐÆðÊ¼X×ø±ê
            public ushort wBigScreenY; //´óÆÁÔÚµçÊÓÇ½ÖÐÆðÊ¼Y×ø±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            public void Init()
            {
                byRes1 = new byte[2];
                struFollowSingleScreen = new NET_DVR_SINGLESCREENCFG[MAX_BIGSCREENNUM];
                byRes2 = new byte[12];
            }
        }

        /************************************ÊÓÆµ×ÛºÏÆ½Ì¨(end)***************************************/

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_EMAILCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sPassWord;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sFromName;/* Sender *///×Ö·û´®ÖÐµÄµÚÒ»¸ö×Ö·ûºÍ×îºóÒ»¸ö×Ö·û²»ÄÜÊÇ"@",²¢ÇÒ×Ö·û´®ÖÐÒªÓÐ"@"×Ö·û
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sFromAddr;/* Sender address */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sToName1;/* Receiver1 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sToName2;/* Receiver2 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sToAddr1;/* Receiver address1 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sToAddr2;/* Receiver address2 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sEmailServer;/* Email server address */
            public byte byServerType;/* Email server type: 0-SMTP, 1-POP, 2-IMTP¡­*/
            public byte byUseAuthen;/* Email server authentication method: 1-enable, 0-disable */
            public byte byAttachment;/* enable attachment */
            public byte byMailinterval;/* mail interval 0-2s, 1-3s, 2-4s. 3-5s*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_NEW
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_EX struLowCompression;//¶¨Ê±Â¼Ïñ
            public NET_DVR_COMPRESSION_INFO_EX struEventCompression;//ÊÂ¼þ´¥·¢Â¼Ïñ
        }

        //Çò»úÎ»ÖÃÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZPOS
        {
            public ushort wAction;//»ñÈ¡Ê±¸Ã×Ö¶ÎÎÞÐ§
            public ushort wPanPos;//Ë®Æ½²ÎÊý
            public ushort wTiltPos;//´¹Ö±²ÎÊý
            public ushort wZoomPos;//±ä±¶²ÎÊý
        }

        //Çò»ú·¶Î§ÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZSCOPE
        {
            public ushort wPanPosMin;//Ë®Æ½²ÎÊýmin
            public ushort wPanPosMax;//Ë®Æ½²ÎÊýmax
            public ushort wTiltPosMin;//´¹Ö±²ÎÊýmin
            public ushort wTiltPosMax;//´¹Ö±²ÎÊýmax
            public ushort wZoomPosMin;//±ä±¶²ÎÊýmin
            public ushort wZoomPosMax;//±ä±¶²ÎÊýmax
        }

        //rtspÅäÖÃ ipcamera×¨ÓÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RTSPCFG
        {
            public uint dwSize;//³¤¶È
            public ushort wPort;//rtsp·þÎñÆ÷ÕìÌý¶Ë¿Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
            public byte[] byReserve;//Ô¤Áô
        }

        /********************************½Ó¿Ú²ÎÊý½á¹¹(begin)*********************************/

        //NET_DVR_Login()²ÎÊý½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//ÐòÁÐºÅ
            public byte byAlarmInPortNum;//DVR±¨¾¯ÊäÈë¸öÊý
            public byte byAlarmOutPortNum;//DVR±¨¾¯Êä³ö¸öÊý
            public byte byDiskNum;//DVRÓ²ÅÌ¸öÊý
            public byte byDVRType;//DVRÀàÐÍ, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;//DVR Í¨µÀ¸öÊý
            public byte byStartChan;//ÆðÊ¼Í¨µÀºÅ,ÀýÈçDVS-1,DVR - 1
        }

        //NET_DVR_Login_V30()²ÎÊý½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;  //ÐòÁÐºÅ
            public byte byAlarmInPortNum;		        //±¨¾¯ÊäÈë¸öÊý
            public byte byAlarmOutPortNum;		        //±¨¾¯Êä³ö¸öÊý
            public byte byDiskNum;				    //Ó²ÅÌ¸öÊý
            public byte byDVRType;				    //Éè±¸ÀàÐÍ, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;				    //Ä£ÄâÍ¨µÀ¸öÊý
            public byte byStartChan;			        //ÆðÊ¼Í¨µÀºÅ,ÀýÈçDVS-1,DVR - 1
            public byte byAudioChanNum;                //ÓïÒôÍ¨µÀÊý
            public byte byIPChanNum;					//×î´óÊý×ÖÍ¨µÀ¸öÊý£¬µÍÎ»  
            public byte byZeroChanNum;			//ÁãÍ¨µÀ±àÂë¸öÊý //2010-01-16
            public byte byMainProto;			//Ö÷ÂëÁ÷´«ÊäÐ­ÒéÀàÐÍ 0-private, 1-rtsp,2-Í¬Ê±Ö§³ÖprivateºÍrtsp
            public byte bySubProto;				//×ÓÂëÁ÷´«ÊäÐ­ÒéÀàÐÍ0-private, 1-rtsp,2-Í¬Ê±Ö§³ÖprivateºÍrtsp
            public byte bySupport;        //ÄÜÁ¦£¬Î»Óë½á¹ûÎª0±íÊ¾²»Ö§³Ö£¬1±íÊ¾Ö§³Ö£¬
                                          //bySupport & 0x1, ±íÊ¾ÊÇ·ñÖ§³ÖÖÇÄÜËÑË÷
                                          //bySupport & 0x2, ±íÊ¾ÊÇ·ñÖ§³Ö±¸·Ý
                                          //bySupport & 0x4, ±íÊ¾ÊÇ·ñÖ§³ÖÑ¹Ëõ²ÎÊýÄÜÁ¦»ñÈ¡
                                          //bySupport & 0x8, ±íÊ¾ÊÇ·ñÖ§³Ö¶àÍø¿¨
                                          //bySupport & 0x10, ±íÊ¾Ö§³ÖÔ¶³ÌSADP
                                          //bySupport & 0x20, ±íÊ¾Ö§³ÖRaid¿¨¹¦ÄÜ
                                          //bySupport & 0x40, ±íÊ¾Ö§³ÖIPSAN Ä¿Â¼²éÕÒ
                                          //bySupport & 0x80, ±íÊ¾Ö§³Örtp over rtsp
            public byte bySupport1;        // ÄÜÁ¦¼¯À©³ä£¬Î»Óë½á¹ûÎª0±íÊ¾²»Ö§³Ö£¬1±íÊ¾Ö§³Ö
                                           //bySupport1 & 0x1, ±íÊ¾ÊÇ·ñÖ§³Ösnmp v30
                                           //bySupport1 & 0x2, Ö§³ÖÇø·Ö»Ø·ÅºÍÏÂÔØ
                                           //bySupport1 & 0x4, ÊÇ·ñÖ§³Ö²¼·ÀÓÅÏÈ¼¶	
                                           //bySupport1 & 0x8, ÖÇÄÜÉè±¸ÊÇ·ñÖ§³Ö²¼·ÀÊ±¼ä¶ÎÀ©Õ¹
                                           //bySupport1 & 0x10, ±íÊ¾ÊÇ·ñÖ§³Ö¶à´ÅÅÌÊý£¨³¬¹ý33¸ö£©
                                           //bySupport1 & 0x20, ±íÊ¾ÊÇ·ñÖ§³Örtsp over http	
                                           //bySupport1 & 0x80, ±íÊ¾ÊÇ·ñÖ§³Ö³µÅÆÐÂ±¨¾¯ÐÅÏ¢2012-9-28, ÇÒ»¹±íÊ¾ÊÇ·ñÖ§³ÖNET_DVR_IPPARACFG_V40½á¹¹Ìå
            public byte bySupport2; /*ÄÜÁ¦£¬Î»Óë½á¹ûÎª0±íÊ¾²»Ö§³Ö£¬·Ç0±íÊ¾Ö§³Ö							
							bySupport2 & 0x1, ±íÊ¾½âÂëÆ÷ÊÇ·ñÖ§³ÖÍ¨¹ýURLÈ¡Á÷½âÂë
							bySupport2 & 0x2,  ±íÊ¾Ö§³ÖFTPV40
							bySupport2 & 0x4,  ±íÊ¾Ö§³ÖANR
							bySupport2 & 0x8,  ±íÊ¾Ö§³ÖCCDµÄÍ¨µÀ²ÎÊýÅäÖÃ
							bySupport2 & 0x10,  ±íÊ¾Ö§³Ö²¼·À±¨¾¯»Ø´«ÐÅÏ¢£¨½öÖ§³Ö×¥ÅÄ»ú±¨¾¯ ÐÂÀÏ±¨¾¯½á¹¹£©
							bySupport2 & 0x20,  ±íÊ¾ÊÇ·ñÖ§³Öµ¥¶À»ñÈ¡Éè±¸×´Ì¬×ÓÏî
							bySupport2 & 0x40,  ±íÊ¾ÊÇ·ñÊÇÂëÁ÷¼ÓÃÜÉè±¸*/
            public ushort wDevType;              //Éè±¸ÐÍºÅ
            public byte bySupport3; //ÄÜÁ¦¼¯À©Õ¹£¬Î»Óë½á¹ûÎª0±íÊ¾²»Ö§³Ö£¬1±íÊ¾Ö§³Ö
                                    //bySupport3 & 0x1, ±íÊ¾ÊÇ·ñ¶àÂëÁ÷
                                    // bySupport3 & 0x4 ±íÊ¾Ö§³Ö°´×éÅäÖÃ£¬ ¾ßÌå°üº¬ Í¨µÀÍ¼Ïñ²ÎÊý¡¢±¨¾¯ÊäÈë²ÎÊý¡¢IP±¨¾¯ÊäÈë¡¢Êä³ö½ÓÈë²ÎÊý¡¢
                                    // ÓÃ»§²ÎÊý¡¢Éè±¸¹¤×÷×´Ì¬¡¢JPEG×¥Í¼¡¢¶¨Ê±ºÍÊ±¼ä×¥Í¼¡¢Ó²ÅÌÅÌ×é¹ÜÀí 
                                    //bySupport3 & 0x8Îª1 ±íÊ¾Ö§³ÖÊ¹ÓÃTCPÔ¤ÀÀ¡¢UDPÔ¤ÀÀ¡¢¶à²¥Ô¤ÀÀÖÐµÄ"ÑÓÊ±Ô¤ÀÀ"×Ö¶ÎÀ´ÇëÇóÑÓÊ±Ô¤ÀÀ£¨ºóÐø¶¼½«Ê¹ÓÃÕâÖÖ·½Ê½ÇëÇóÑÓÊ±Ô¤ÀÀ£©¡£¶øµ±bySupport3 & 0x8Îª0Ê±£¬½«Ê¹ÓÃ "Ë½ÓÐÑÓÊ±Ô¤ÀÀ"Ð­Òé¡£
                                    //bySupport3 & 0x10 ±íÊ¾Ö§³Ö"»ñÈ¡±¨¾¯Ö÷»úÖ÷Òª×´Ì¬£¨V40£©"¡£
                                    //bySupport3 & 0x20 ±íÊ¾ÊÇ·ñÖ§³ÖÍ¨¹ýDDNSÓòÃû½âÎöÈ¡Á÷

            public byte byMultiStreamProto;//ÊÇ·ñÖ§³Ö¶àÂëÁ÷,°´Î»±íÊ¾,0-²»Ö§³Ö,1-Ö§³Ö,bit1-ÂëÁ÷3,bit2-ÂëÁ÷4,bit7-Ö÷ÂëÁ÷£¬bit-8×ÓÂëÁ÷
            public byte byStartDChan;		//ÆðÊ¼Êý×ÖÍ¨µÀºÅ,0±íÊ¾ÎÞÐ§
            public byte byStartDTalkChan;	//ÆðÊ¼Êý×Ö¶Ô½²Í¨µÀºÅ£¬Çø±ðÓÚÄ£Äâ¶Ô½²Í¨µÀºÅ£¬0±íÊ¾ÎÞÐ§
            public byte byHighDChanNum;		//Êý×ÖÍ¨µÀ¸öÊý£¬¸ßÎ»
            public byte bySupport4;
            public byte byLanguageType;// Ö§³ÖÓïÖÖÄÜÁ¦,°´Î»±íÊ¾,Ã¿Ò»Î»0-²»Ö§³Ö,1-Ö§³Ö  
                                       //  byLanguageType µÈÓÚ0 ±íÊ¾ ÀÏÉè±¸
                                       //  byLanguageType & 0x1±íÊ¾Ö§³ÖÖÐÎÄ
                                       //  byLanguageType & 0x2±íÊ¾Ö§³ÖÓ¢ÎÄ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;		//±£Áô
        }

        //sdkÍøÂç»·¾³Ã¶¾Ù±äÁ¿£¬ÓÃÓÚÔ¶³ÌÉý¼¶
        public enum SDK_NETWORK_ENVIRONMENT
        {
            LOCAL_AREA_NETWORK = 0,
            WIDE_AREA_NETWORK,
        }

        //ÏÔÊ¾Ä£Ê½
        public enum DISPLAY_MODE
        {
            NORMALMODE = 0,
            OVERLAYMODE
        }

        //·¢ËÍÄ£Ê½
        public enum SEND_MODE
        {
            PTOPTCPMODE = 0,
            PTOPUDPMODE,
            MULTIMODE,
            RTPMODE,
            RESERVEDMODE
        }

        //×¥Í¼Ä£Ê½
        public enum CAPTURE_MODE
        {
            BMP_MODE = 0,		//BMPÄ£Ê½
            JPEG_MODE = 1		//JPEGÄ£Ê½ 
        }

        //ÊµÊ±ÉùÒôÄ£Ê½
        public enum REALSOUND_MODE
        {
            MONOPOLIZE_MODE = 1,//¶ÀÕ¼Ä£Ê½
            SHARE_MODE = 2		//¹²ÏíÄ£Ê½
        }

        public struct NET_DVR_CLIENTINFO
        {
            public Int32 lChannel;//Í¨µÀºÅ
            public Int32 lLinkMode;//×î¸ßÎ»(31)Îª0±íÊ¾Ö÷ÂëÁ÷£¬Îª1±íÊ¾×ÓÂëÁ÷£¬0£­30Î»±íÊ¾ÂëÁ÷Á¬½Ó·½Ê½: 0£ºTCP·½Ê½,1£ºUDP·½Ê½,2£º¶à²¥·½Ê½,3 - RTP·½Ê½£¬4-ÒôÊÓÆµ·Ö¿ª(TCP)
            public IntPtr hPlayWnd;//²¥·Å´°¿ÚµÄ¾ä±ú,ÎªNULL±íÊ¾²»²¥·ÅÍ¼Ïó
            public string sMultiCastIP;//¶à²¥×éµØÖ·
        }

        //SDK×´Ì¬ÐÅÏ¢(9000ÐÂÔö)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SDKSTATE
        {
            public uint dwTotalLoginNum;//µ±Ç°loginÓÃ»§Êý
            public uint dwTotalRealPlayNum;//µ±Ç°realplayÂ·Êý
            public uint dwTotalPlayBackNum;//µ±Ç°»Ø·Å»òÏÂÔØÂ·Êý
            public uint dwTotalAlarmChanNum;//µ±Ç°½¨Á¢±¨¾¯Í¨µÀÂ·Êý
            public uint dwTotalFormatNum;//µ±Ç°Ó²ÅÌ¸ñÊ½»¯Â·Êý
            public uint dwTotalFileSearchNum;//µ±Ç°ÈÕÖ¾»òÎÄ¼þËÑË÷Â·Êý
            public uint dwTotalLogSearchNum;//µ±Ç°ÈÕÖ¾»òÎÄ¼þËÑË÷Â·Êý
            public uint dwTotalSerialNum;//µ±Ç°Í¸Ã÷Í¨µÀÂ·Êý
            public uint dwTotalUpgradeNum;//µ±Ç°Éý¼¶Â·Êý
            public uint dwTotalVoiceComNum;//µ±Ç°ÓïÒô×ª·¢Â·Êý
            public uint dwTotalBroadCastNum;//µ±Ç°ÓïÒô¹ã²¥Â·Êý
            public uint dwTotalListenNum;	    //µ±Ç°ÍøÂç¼àÌýÂ·Êý
            public uint dwEmailTestNum;       //µ±Ç°ÓÊ¼þ¼ÆÊýÂ·Êý
            public uint dwBackupNum;          // µ±Ç°ÎÄ¼þ±¸·ÝÂ·Êý
            public uint dwTotalInquestUploadNum; //µ±Ç°ÉóÑ¶ÉÏ´«Â·Êý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //SDK¹¦ÄÜÖ§³ÖÐÅÏ¢(9000ÐÂÔö)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SDKABL
        {
            public uint dwMaxLoginNum;//×î´óloginÓÃ»§Êý MAX_LOGIN_USERS
            public uint dwMaxRealPlayNum;//×î´órealplayÂ·Êý WATCH_NUM
            public uint dwMaxPlayBackNum;//×î´ó»Ø·Å»òÏÂÔØÂ·Êý WATCH_NUM
            public uint dwMaxAlarmChanNum;//×î´ó½¨Á¢±¨¾¯Í¨µÀÂ·Êý ALARM_NUM
            public uint dwMaxFormatNum;//×î´óÓ²ÅÌ¸ñÊ½»¯Â·Êý SERVER_NUM
            public uint dwMaxFileSearchNum;//×î´óÎÄ¼þËÑË÷Â·Êý SERVER_NUM
            public uint dwMaxLogSearchNum;//×î´óÈÕÖ¾ËÑË÷Â·Êý SERVER_NUM
            public uint dwMaxSerialNum;//×î´óÍ¸Ã÷Í¨µÀÂ·Êý SERVER_NUM
            public uint dwMaxUpgradeNum;//×î´óÉý¼¶Â·Êý SERVER_NUM
            public uint dwMaxVoiceComNum;//×î´óÓïÒô×ª·¢Â·Êý SERVER_NUM
            public uint dwMaxBroadCastNum;//×î´óÓïÒô¹ã²¥Â·Êý MAX_CASTNUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //±¨¾¯Éè±¸ÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ALARMER
        {
            public byte byUserIDValid;/* useridÊÇ·ñÓÐÐ§ 0-ÎÞÐ§£¬1-ÓÐÐ§ */
            public byte bySerialValid;/* ÐòÁÐºÅÊÇ·ñÓÐÐ§ 0-ÎÞÐ§£¬1-ÓÐÐ§ */
            public byte byVersionValid;/* °æ±¾ºÅÊÇ·ñÓÐÐ§ 0-ÎÞÐ§£¬1-ÓÐÐ§ */
            public byte byDeviceNameValid;/* Éè±¸Ãû×ÖÊÇ·ñÓÐÐ§ 0-ÎÞÐ§£¬1-ÓÐÐ§ */
            public byte byMacAddrValid; /* MACµØÖ·ÊÇ·ñÓÐÐ§ 0-ÎÞÐ§£¬1-ÓÐÐ§ */
            public byte byLinkPortValid;/* login¶Ë¿ÚÊÇ·ñÓÐÐ§ 0-ÎÞÐ§£¬1-ÓÐÐ§ */
            public byte byDeviceIPValid;/* Éè±¸IPÊÇ·ñÓÐÐ§ 0-ÎÞÐ§£¬1-ÓÐÐ§ */
            public byte bySocketIPValid;/* socket ipÊÇ·ñÓÐÐ§ 0-ÎÞÐ§£¬1-ÓÐÐ§ */
            public int lUserID; /* NET_DVR_Login()·µ»ØÖµ, ²¼·ÀÊ±ÓÐÐ§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;/* ÐòÁÐºÅ */
            public uint dwDeviceVersion;/* °æ±¾ÐÅÏ¢ ¸ß16Î»±íÊ¾Ö÷°æ±¾£¬µÍ16Î»±íÊ¾´Î°æ±¾*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string sDeviceName;/* Éè±¸Ãû×Ö */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;/* MACµØÖ· */
            public ushort wLinkPort; /* link port */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sDeviceIP;/* IPµØÖ· */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sSocketIP;/* ±¨¾¯Ö÷¶¯ÉÏ´«Ê±µÄsocket IPµØÖ· */
            public byte byIpProtocol; /* IpÐ­Òé 0-IPV4, 1-IPV6 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //Ó²½âÂëÏÔÊ¾ÇøÓò²ÎÊý(×Ó½á¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_PARA
        {
            public int bToScreen;
            public int bToVideoOut;
            public int nLeft;
            public int nTop;
            public int nWidth;
            public int nHeight;
            public int nReserved;
        }

        //Ó²½âÂëÔ¤ÀÀ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CARDINFO
        {
            public int lChannel;//Í¨µÀºÅ
            public int lLinkMode;//×î¸ßÎ»(31)Îª0±íÊ¾Ö÷ÂëÁ÷£¬Îª1±íÊ¾×Ó£¬0£­30Î»±íÊ¾ÂëÁ÷Á¬½Ó·½Ê½:0£ºTCP·½Ê½,1£ºUDP·½Ê½,2£º¶à²¥·½Ê½,3 - RTP·½Ê½£¬4-µç»°Ïß£¬5£­128k¿í´ø£¬6£­256k¿í´ø£¬7£­384k¿í´ø£¬8£­512k¿í´ø£»
            [MarshalAsAttribute(UnmanagedType.LPStr)]
            public string sMultiCastIP;
            public NET_DVR_DISPLAY_PARA struDisplayPara;
        }

        //Â¼ÏóÎÄ¼þ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FIND_DATA
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//ÎÄ¼þÃû
            public NET_DVR_TIME struStartTime;//ÎÄ¼þµÄ¿ªÊ¼Ê±¼ä
            public NET_DVR_TIME struStopTime;//ÎÄ¼þµÄ½áÊøÊ±¼ä
            public uint dwFileSize;//ÎÄ¼þµÄ´óÐ¡
        }

        //Â¼ÏóÎÄ¼þ²ÎÊý(9000)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//ÎÄ¼þÃû
            public NET_DVR_TIME struStartTime;//ÎÄ¼þµÄ¿ªÊ¼Ê±¼ä
            public NET_DVR_TIME struStopTime;//ÎÄ¼þµÄ½áÊøÊ±¼ä
            public uint dwFileSize;//ÎÄ¼þµÄ´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
            public byte byLocked;//9000Éè±¸Ö§³Ö,1±íÊ¾´ËÎÄ¼þÒÑ¾­±»Ëø¶¨,0±íÊ¾Õý³£µÄÎÄ¼þ
            public byte byFileType;  //ÎÄ¼þÀàÐÍ:0£­¶¨Ê±Â¼Ïñ,1-ÒÆ¶¯Õì²â £¬2£­±¨¾¯´¥·¢£¬
            //3-±¨¾¯|ÒÆ¶¯Õì²â 4-±¨¾¯&ÒÆ¶¯Õì²â 5-ÃüÁî´¥·¢ 6-ÊÖ¶¯Â¼Ïñ,7£­Õð¶¯±¨¾¯£¬8-»·¾³±¨¾¯£¬9-ÖÇÄÜ±¨¾¯£¬10-PIR±¨¾¯£¬11-ÎÞÏß±¨¾¯£¬12-ºô¾È±¨¾¯,14-ÖÇÄÜ½»Í¨ÊÂ¼þ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Â¼ÏóÎÄ¼þ²ÎÊý(cvr)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//ÎÄ¼þÃû
            public NET_DVR_TIME struStartTime;//ÎÄ¼þµÄ¿ªÊ¼Ê±¼ä
            public NET_DVR_TIME struStopTime;//ÎÄ¼þµÄ½áÊøÊ±¼ä
            public uint dwFileSize;//ÎÄ¼þµÄ´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
            public byte byLocked;//9000Éè±¸Ö§³Ö,1±íÊ¾´ËÎÄ¼þÒÑ¾­±»Ëø¶¨,0±íÊ¾Õý³£µÄÎÄ¼þ
            public byte byFileType;  //ÎÄ¼þÀàÐÍ:0£­¶¨Ê±Â¼Ïñ,1-ÒÆ¶¯Õì²â £¬2£­±¨¾¯´¥·¢£¬
                                     //3-±¨¾¯|ÒÆ¶¯Õì²â 4-±¨¾¯&ÒÆ¶¯Õì²â 5-ÃüÁî´¥·¢ 6-ÊÖ¶¯Â¼Ïñ,7£­Õð¶¯±¨¾¯£¬8-»·¾³±¨¾¯£¬9-ÖÇÄÜ±¨¾¯£¬10-PIR±¨¾¯£¬11-ÎÞÏß±¨¾¯£¬12-ºô¾È±¨¾¯,14-ÖÇÄÜ½»Í¨ÊÂ¼þ
            public byte byQuickSearch; //0:ÆÕÍ¨²éÑ¯½á¹û£¬1£º¿ìËÙ£¨ÈÕÀú£©²éÑ¯½á¹û
            public byte byRes;
            public uint dwFileIndex; //ÎÄ¼þË÷ÒýºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        //Â¼ÏóÎÄ¼þ²ÎÊý(´ø¿¨ºÅ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_CARD
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//ÎÄ¼þÃû
            public NET_DVR_TIME struStartTime;//ÎÄ¼þµÄ¿ªÊ¼Ê±¼ä
            public NET_DVR_TIME struStopTime;//ÎÄ¼þµÄ½áÊøÊ±¼ä
            public uint dwFileSize;//ÎÄ¼þµÄ´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
        }

        //Â¼ÏóÎÄ¼þ²éÕÒÌõ¼þ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILECOND
        {
            public int lChannel;//Í¨µÀºÅ
            public uint dwFileType;//Â¼ÏóÎÄ¼þÀàÐÍ0xff£­È«²¿£¬0£­¶¨Ê±Â¼Ïñ,1-ÒÆ¶¯Õì²â £¬2£­±¨¾¯´¥·¢£¬
            //3-±¨¾¯|ÒÆ¶¯Õì²â 4-±¨¾¯&ÒÆ¶¯Õì²â 5-ÃüÁî´¥·¢ 6-ÊÖ¶¯Â¼Ïñ
            public uint dwIsLocked;//ÊÇ·ñËø¶¨ 0-Õý³£ÎÄ¼þ,1-Ëø¶¨ÎÄ¼þ, 0xff±íÊ¾ËùÓÐÎÄ¼þ
            public uint dwUseCardNo;//ÊÇ·ñÊ¹ÓÃ¿¨ºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNumber;//¿¨ºÅ
            public NET_DVR_TIME struStartTime;//¿ªÊ¼Ê±¼ä
            public NET_DVR_TIME struStopTime;//½áÊøÊ±¼ä
        }

        //ÔÆÌ¨ÇøÓòÑ¡Ôñ·Å´óËõÐ¡(HIK ¿ìÇò×¨ÓÃ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POINT_FRAME
        {
            public int xTop;//·½¿òÆðÊ¼µãµÄx×ø±ê
            public int yTop;//·½¿ò½áÊøµãµÄy×ø±ê
            public int xBottom;//·½¿ò½áÊøµãµÄx×ø±ê
            public int yBottom;//·½¿ò½áÊøµãµÄy×ø±ê
            public int bCounter;//±£Áô
        }

        //ÓïÒô¶Ô½²²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_AUDIO
        {
            public byte byAudioEncType;//ÒôÆµ±àÂëÀàÐÍ 0-G722; 1-G711
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;//ÕâÀï±£ÁôÒôÆµµÄÑ¹Ëõ²ÎÊý 
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_AP_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = IW_ESSID_MAX_SIZE)]
            public string sSsid;
            public uint dwMode;/* 0 mange Ä£Ê½;1 ad-hocÄ£Ê½£¬²Î¼ûNICMODE */
            public uint dwSecurity;  /*0 ²»¼ÓÃÜ£»1 wep¼ÓÃÜ£»2 wpa-psk;3 wpa-Enterprise£¬²Î¼ûWIFISECURITY*/
            public uint dwChannel;/*1-11±íÊ¾11¸öÍ¨µÀ*/
            public uint dwSignalStrength;/*0-100ÐÅºÅÓÉ×îÈõ±äÎª×îÇ¿*/
            public uint dwSpeed;/*ËÙÂÊ,µ¥Î»ÊÇ0.01mbps*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AP_INFO_LIST
        {
            public uint dwSize;
            public uint dwCount;/*ÎÞÏßAPÊýÁ¿£¬²»³¬¹ý20*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = WIFI_MAX_AP_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_AP_INFO[] struApInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_WIFIETHERNET
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpAddress;/*IPµØÖ·*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpMask;/*ÑÚÂë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/*ÎïÀíµØÖ·£¬Ö»ÓÃÀ´ÏÔÊ¾*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] bRes;
            public uint dwEnableDhcp;/*ÊÇ·ñÆô¶¯dhcp  0²»Æô¶¯ 1Æô¶¯*/
            public uint dwAutoDns;/*Èç¹ûÆô¶¯dhcpÊÇ·ñ×Ô¶¯»ñÈ¡dns,0²»×Ô¶¯»ñÈ¡ 1×Ô¶¯»ñÈ¡£»¶ÔÓÚÓÐÏßÈç¹ûÆô¶¯dhcpÄ¿Ç°×Ô¶¯»ñÈ¡dns*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFirstDns; /*µÚÒ»¸ödnsÓòÃû*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sSecondDns;/*µÚ¶þ¸ödnsÓòÃû*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sGatewayIpAddr;/* Íø¹ØµØÖ·*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] bRes2;
        }

        //wifiÁ¬½Ó×´Ì¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_CONNECT_STATUS
        {
            public uint dwSize;
            public byte byCurStatus;	//1-ÒÑÁ¬½Ó£¬2-Î´Á¬½Ó£¬3-ÕýÔÚÁ¬½Ó
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;		//±£Áô
            public uint dwErrorCode;	// byCurStatus = 2Ê±ÓÐÐ§,1-ÓÃ»§Ãû»òÃÜÂë´íÎó,2-ÎÞ´ËÂ·ÓÉÆ÷,3-Î´Öª´íÎó
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 244, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_WORKMODE
        {
            public uint dwSize;
            public uint dwNetworkInterfaceMode;/*0 ×Ô¶¯ÇÐ»»Ä£Ê½¡¡1 ÓÐÏßÄ£Ê½*/
        }

        //ÖÇÄÜ¿ØÖÆÐÅÏ¢
        public const int MAX_VCA_CHAN = 16;//×î´óÖÇÄÜÍ¨µÀÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CTRLINFO
        {
            public byte byVCAEnable;//ÊÇ·ñ¿ªÆôÖÇÄÜ
            public byte byVCAType;//ÖÇÄÜÄÜÁ¦ÀàÐÍ£¬VCA_CHAN_ABILITY_TYPE 
            public byte byStreamWithVCA;//ÂëÁ÷ÖÐÊÇ·ñ´øÖÇÄÜÐÅÏ¢
            public byte byMode;//Ä£Ê½£¬VCA_CHAN_MODE_TYPE ,atmÄÜÁ¦µÄÊ±ºòÐèÒªÅäÖÃ
            public byte byControlType;   //¿ØÖÆÀàÐÍ£¬°´Î»±íÊ¾£¬0-·ñ£¬1-ÊÇ
            // byControlType &1 ÊÇ·ñÆôÓÃ×¥ÅÄ¹¦ÄÜ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô£¬ÉèÖÃÎª0 
        }

        //ÖÇÄÜ¿ØÖÆÐÅÏ¢½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CTRLCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VCA_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_CTRLINFO[] struCtrlInfo;//¿ØÖÆÐÅÏ¢,Êý×é0¶ÔÓ¦Éè±¸µÄÆðÊ¼Í¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÖÇÄÜÉè±¸ÄÜÁ¦¼¯
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DEV_ABILITY
        {
            public uint dwSize;//½á¹¹³¤¶È
            public byte byVCAChanNum;//ÖÇÄÜÍ¨µÀ¸öÊý
            public byte byPlateChanNum;//³µÅÆÍ¨µÀ¸öÊý
            public byte byBBaseChanNum;//ÐÐÎª»ù±¾°æ¸öÊý
            public byte byBAdvanceChanNum;//ÐÐÎª¸ß¼¶°æ¸öÊý
            public byte byBFullChanNum;//ÐÐÎªÍêÕû°æ¸öÊý
            public byte byATMChanNum;//ÖÇÄÜATM¸öÊý
            public byte byPDCChanNum;         //ÈËÊýÍ³¼ÆÍ¨µÀ¸öÊý
            public byte byITSChanNum;         //½»Í¨ÊÂ¼þÍ¨µÀ¸öÊý
            public byte byBPrisonChanNum;     //ÐÐÎª¼àÓü°æ(¼àÉá)Í¨µÀ¸öÊý
            public byte byFSnapChanNum;       //ÈËÁ³×¥ÅÄÍ¨µÀ¸öÊý
            public byte byFSnapRecogChanNum;  //ÈËÁ³×¥ÅÄºÍÊ¶±ðÍ¨µÀ¸öÊý
            public byte byFRetrievalChanNum;  //ÈËÁ³ºó¼ìË÷¸öÊý
            public byte bySupport;            //ÄÜÁ¦£¬Î»Óë½á¹ûÎª0±íÊ¾²»Ö§³Ö£¬1±íÊ¾Ö§³Ö
            //bySupport & 0x1£¬±íÊ¾ÊÇ·ñÖ§³ÖÖÇÄÜ¸ú×Ù 2012-3-22
            //bySupport & 0x2£¬±íÊ¾ÊÇ·ñÖ§³Ö128Â·È¡Á÷À©Õ¹2012-12-27
            public byte byFRecogChanNum;      //ÈËÁ³Ê¶±ðÍ¨µÀ¸öÊý
            public byte byBPPerimeterChanNum; //ÐÐÎª¼àÓü°æ(ÖÜ½ç)Í¨µÀ¸öÊý
            public byte byTPSChanNum;         //½»Í¨ÓÕµ¼Í¨µÀ¸öÊý
            public byte byTFSChanNum;         //µÀÂ·Î¥ÕÂÈ¡Ö¤Í¨µÀ¸öÊý
            public byte byFSnapBFullChanNum;  //ÈËÁ³×¥ÅÄºÍÐÐÎª·ÖÎöÍ¨µÀ¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÐÐÎª·ÖÎöÄÜÁ¦ÀàÐÍ
        public enum VCA_ABILITY_TYPE : uint
        {
            TRAVERSE_PLANE_ABILITY = 0x01,       //´©Ô½¾¯½äÃæ
            ENTER_AREA_ABILITY = 0x02,       //½øÈëÇøÓò
            EXIT_AREA_ABILITY = 0x04,       //Àë¿ªÇøÓò
            INTRUSION_ABILITY = 0x08,       //ÈëÇÖ
            LOITER_ABILITY = 0x10,       //ÅÇ»²
            LEFT_TAKE_ABILITY = 0x20,       //ÎïÆ·ÒÅÁôÄÃÈ¡
            PARKING_ABILITY = 0x40,       //Í£³µ
            RUN_ABILITY = 0x80,       //¿ìËÙÒÆ¶¯
            HIGH_DENSITY_ABILITY = 0x100,      //ÈËÔ±¾Û¼¯
            LF_TRACK_ABILITY = 0x200,      //Çò»ú¸ú×Ù
            VIOLENT_MOTION_ABILITY = 0x400,      //¾çÁÒÔË¶¯¼ì²â
            REACH_HIGHT_ABILITY = 0x800,      //ÅÊ¸ß¼ì²â
            GET_UP_ABILITY = 0x1000,     //ÆðÉí¼ì²â
            LEFT_ABILITY = 0x2000,     //ÎïÆ·ÒÅÁô
            TAKE_ABILITY = 0x4000,     //ÎïÆ·ÄÃÈ¡
            LEAVE_POSITION = 0x8000,     //Àë¸Ú
            TRAIL_ABILITY = 0x10000,    //Î²Ëæ 
            KEY_PERSON_GET_UP_ABILITY = 0x20000,    //ÖØµãÈËÔ±ÆðÉí¼ì²â
            FALL_DOWN_ABILITY = 0x80000,    //µ¹µØ
            AUDIO_ABNORMAL_ABILITY = 0x100000,   //ÉùÇ¿Í»±ä
            ADV_REACH_HEIGHT_ABILITY = 0x200000,   //ÕÛÏßÅÊ¸ß
            TOILET_TARRY_ABILITY = 0x400000,   //Èç²Þ³¬Ê±
            YARD_TARRY_ABILITY = 0x800000,   //·Å·ç³¡ÖÍÁô
            ADV_TRAVERSE_PLANE_ABILITY = 0x1000000,  //ÕÛÏß¾¯½äÃæ
            HUMAN_ENTER_ABILITY = 0x10000000, //ÈË¿¿½üATM ,Ö»ÔÚATM_PANELÄ£Ê½ÏÂÖ§³Ö
            OVER_TIME_ABILITY = 0x20000000, //²Ù×÷³¬Ê±,Ö»ÔÚATM_PANELÄ£Ê½ÏÂÖ§³Ö
            STICK_UP_ABILITY = 0x40000000, //ÌùÖ½Ìõ
            INSTALL_SCANNER_ABILITY = 0x80000000  //°²×°¶Á¿¨Æ÷
        }

        //ÖÇÄÜÍ¨µÀÀàÐÍ
        public enum VCA_CHAN_ABILITY_TYPE
        {
            VCA_BEHAVIOR_BASE = 1,          //ÐÐÎª·ÖÎö»ù±¾°æ
            VCA_BEHAVIOR_ADVANCE = 2,          //ÐÐÎª·ÖÎö¸ß¼¶°æ
            VCA_BEHAVIOR_FULL = 3,          //ÐÐÎª·ÖÎöÍêÕû°æ
            VCA_PLATE = 4,          //³µÅÆÄÜÁ¦
            VCA_ATM = 5,          //ATMÄÜÁ¦
            VCA_PDC = 6,          //ÈËÁ÷Á¿Í³¼Æ
            VCA_ITS = 7,          //ÖÇÄÜ ½»Í¨ÊÂ¼þ
            VCA_BEHAVIOR_PRISON = 8,          //ÐÐÎª·ÖÎö¼àÓü°æ(¼àÉá) 
            VCA_FACE_SNAP = 9,           //ÈËÁ³×¥ÅÄÄÜÁ¦
            VCA_FACE_SNAPRECOG = 10,          //ÈËÁ³×¥ÅÄºÍÊ¶±ðÄÜÁ¦
            VCA_FACE_RETRIEVAL = 11,          //ÈËÁ³ºó¼ìË÷ÄÜÁ¦
            VCA_FACE_RECOG = 12,          //ÈËÁ³Ê¶±ðÄÜÁ¦
            VCA_BEHAVIOR_PRISON_PERIMETER = 13, // ÐÐÎª·ÖÎö¼àÓü°æ (ÖÜ½ç)
            VCA_TPS = 14,          //½»Í¨ÓÕµ¼
            VCA_TFS = 15,          //µÀÂ·Î¥ÕÂÈ¡Ö¤
            VCA_BEHAVIOR_FACESNAP = 16           //ÈËÁ³×¥ÅÄºÍÐÐÎª·ÖÎöÄÜÁ¦
        }

        //ÖÇÄÜATMÄ£Ê½ÀàÐÍ(ATMÄÜÁ¦ÌØÓÐ)
        public enum VCA_CHAN_MODE_TYPE
        {
            VCA_ATM_PANEL = 0,//ATMÃæ°å
            VCA_ATM_SURROUND = 1,//ATM»·¾³
            VCA_ATM_FACE = 2	//ATMÈËÁ³
        }
        public enum TFS_CHAN_MODE_TYPE
        {
            TFS_CITYROAD = 0,  //TFS ³ÇÊÐµÀÂ·
            TFS_FREEWAY = 1   //TFS ¸ßËÙµÀÂ·
        }

        //ÐÐÎª·ÖÎö³¡¾°Ä£Ê½
        public enum BEHAVIOR_SCENE_MODE_TYPE
        {
            BEHAVIOR_SCENE_DEFAULT = 0, //ÏµÍ³Ä¬ÈÏ
            BEHAVIOR_SCENE_WALL = 1,    //Î§Ç½
            BEHAVIOR_SCENE_INDOOR = 2   //ÊÒÄÚ
        }

        //Í¨µÀÄÜÁ¦ÊäÈë²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CHAN_IN_PARAM
        {
            public byte byVCAType;//VCA_CHAN_ABILITY_TYPEÃ¶¾ÙÖµ
            public byte byMode;//Ä£Ê½£¬VCA_CHAN_MODE_TYPE ,atmÄÜÁ¦µÄÊ±ºòÐèÒªÅäÖÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô£¬ÉèÖÃÎª0 
        }

        //ÐÐÎªÄÜÁ¦¼¯½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BEHAVIOR_ABILITY
        {
            public uint dwSize;//½á¹¹³¤¶È
            public uint dwAbilityType;//Ö§³ÖµÄÄÜÁ¦ÀàÐÍ£¬°´Î»±íÊ¾£¬¼ûVCA_ABILITY_TYPE¶¨Òå
            public byte byMaxRuleNum;//×î´ó¹æÔòÊý
            public byte byMaxTargetNum;//×î´óÄ¿±êÊý
            public byte bySupport;		// Ö§³ÖµÄ¹¦ÄÜÀàÐÍ   °´Î»±íÊ¾  
            // bySupport & 0x01 Ö§³Ö±ê¶¨¹¦ÄÜ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô£¬ÉèÖÃÎª0
        }

        // ½»Í¨ÄÜÁ¦¼¯½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ITS_ABILITY
        {
            public uint dwSize;             // ½á¹¹Ìå´óÐ¡
            public uint dwAbilityType;      // Ö§³ÖµÄÄÜÁ¦ÁÐ±í  ²ÎÕÕITS_ABILITY_TYPE
            public byte byMaxRuleNum;	 	//×î´ó¹æÔòÊý
            public byte byMaxTargetNum; 	//×î´óÄ¿±êÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    // ±£Áô
        }
        /***********************************end*******************************************/

        /************************************ÖÇÄÜ²ÎÊý½á¹¹*********************************/
        //ÖÇÄÜ¹²ÓÃ½á¹¹
        //×ø±êÖµ¹éÒ»»¯,¸¡µãÊýÖµÎªµ±Ç°»­ÃæµÄ°Ù·Ö±È´óÐ¡, ¾«¶ÈÎªÐ¡ÊýµãºóÈýÎ»
        //µã×ø±ê½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_POINT
        {
            public float fX;// XÖá×ø±ê, 0.001~1
            public float fY;//YÖá×ø±ê, 0.001~1
        }

        //ÇøÓò¿ò½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RECT
        {
            public float fX;//±ß½ç¿ò×óÉÏ½ÇµãµÄXÖá×ø±ê, 0.001~1
            public float fY;//±ß½ç¿ò×óÉÏ½ÇµãµÄYÖá×ø±ê, 0.001~1
            public float fWidth;//±ß½ç¿òµÄ¿í¶È, 0.001~1
            public float fHeight;//±ß½ç¿òµÄ¸ß¶È, 0.001~1
        }

        //ÐÐÎª·ÖÎöÊÂ¼þÀàÐÍ
        public enum VCA_EVENT_TYPE : uint
        {
            VCA_TRAVERSE_PLANE = 0x1,        //´©Ô½¾¯½äÃæ
            VCA_ENTER_AREA = 0x2,        //Ä¿±ê½øÈëÇøÓò,Ö§³ÖÇøÓò¹æÔò
            VCA_EXIT_AREA = 0x4,        //Ä¿±êÀë¿ªÇøÓò,Ö§³ÖÇøÓò¹æÔò
            VCA_INTRUSION = 0x8,        //ÖÜ½çÈëÇÖ,Ö§³ÖÇøÓò¹æÔò
            VCA_LOITER = 0x10,       //ÅÇ»²,Ö§³ÖÇøÓò¹æÔò
            VCA_LEFT_TAKE = 0x20,       //ÎïÆ·ÒÅÁôÄÃÈ¡,Ö§³ÖÇøÓò¹æÔò
            VCA_PARKING = 0x40,       //Í£³µ,Ö§³ÖÇøÓò¹æÔò
            VCA_RUN = 0x80,       //¿ìËÙÒÆ¶¯,Ö§³ÖÇøÓò¹æÔò
            VCA_HIGH_DENSITY = 0x100,      //ÇøÓòÄÚÈËÔ±¾Û¼¯,Ö§³ÖÇøÓò¹æÔò
            VCA_VIOLENT_MOTION = 0x200,		 //¾çÁÒÔË¶¯¼ì²â
            VCA_REACH_HIGHT = 0x400,		 //ÅÊ¸ß¼ì²â
            VCA_GET_UP = 0x800,	     //ÆðÉí¼ì²â
            VCA_LEFT = 0x1000,     //ÎïÆ·ÒÅÁô
            VCA_TAKE = 0x2000,     //ÎïÆ·ÄÃÈ¡
            VCA_LEAVE_POSITION = 0x4000,     //Àë¸Ú
            VCA_TRAIL = 0x8000,     //Î²Ëæ
            VCA_KEY_PERSON_GET_UP = 0x10000,    //ÖØµãÈËÔ±ÆðÉí¼ì²â
            VCA_FALL_DOWN = 0x80000,    //µ¹µØ¼ì²â
            VCA_AUDIO_ABNORMAL = 0x100000,   //ÉùÇ¿Í»±ä¼ì²â
            VCA_ADV_REACH_HEIGHT = 0x200000,   //ÕÛÏßÅÊ¸ß
            VCA_TOILET_TARRY = 0x400000,   //Èç²Þ³¬Ê±
            VCA_YARD_TARRY = 0x800000,   //·Å·ç³¡ÖÍÁô
            VCA_ADV_TRAVERSE_PLANE = 0x1000000,  //ÕÛÏß¾¯½äÃæ
            VCA_HUMAN_ENTER = 0x10000000, //ÈË¿¿½üATM           Ö»ÔÚATM_PANELÄ£Ê½ÏÂÖ§³Ö
            VCA_OVER_TIME = 0x20000000, //²Ù×÷³¬Ê±            Ö»ÔÚATM_PANELÄ£Ê½ÏÂÖ§³Ö
            VCA_STICK_UP = 0x40000000, //ÌùÖ½Ìõ,Ö§³ÖÇøÓò¹æÔò
            VCA_INSTALL_SCANNER = 0x80000000  //°²×°¶Á¿¨Æ÷,Ö§³ÖÇøÓò¹æÔò
        }

        //ÐÐÎª·ÖÎöÊÂ¼þÀàÐÍÀ©Õ¹
        public enum VCA_RULE_EVENT_TYPE_EX : ushort
        {
            ENUM_VCA_EVENT_TRAVERSE_PLANE = 1,   //´©Ô½¾¯½äÃæ
            ENUM_VCA_EVENT_ENTER_AREA = 2,   //Ä¿±ê½øÈëÇøÓò,Ö§³ÖÇøÓò¹æÔò
            ENUM_VCA_EVENT_EXIT_AREA = 3,   //Ä¿±êÀë¿ªÇøÓò,Ö§³ÖÇøÓò¹æÔò
            ENUM_VCA_EVENT_INTRUSION = 4,   //ÖÜ½çÈëÇÖ,Ö§³ÖÇøÓò¹æÔò
            ENUM_VCA_EVENT_LOITER = 5,   //ÅÇ»²,Ö§³ÖÇøÓò¹æÔò
            ENUM_VCA_EVENT_LEFT_TAKE = 6,   //ÎïÆ·ÒÅÁôÄÃÈ¡,Ö§³ÖÇøÓò¹æÔò
            ENUM_VCA_EVENT_PARKING = 7,   //Í£³µ,Ö§³ÖÇøÓò¹æÔò
            ENUM_VCA_EVENT_RUN = 8,   //¿ìËÙÒÆ¶¯,Ö§³ÖÇøÓò¹æÔò
            ENUM_VCA_EVENT_HIGH_DENSITY = 9,   //ÇøÓòÄÚÈËÔ±¾Û¼¯,Ö§³ÖÇøÓò¹æÔò
            ENUM_VCA_EVENT_VIOLENT_MOTION = 10,  //¾çÁÒÔË¶¯¼ì²â
            ENUM_VCA_EVENT_REACH_HIGHT = 11,  //ÅÊ¸ß¼ì²â
            ENUM_VCA_EVENT_GET_UP = 12,  //ÆðÉí¼ì²â
            ENUM_VCA_EVENT_LEFT = 13,  //ÎïÆ·ÒÅÁô
            ENUM_VCA_EVENT_TAKE = 14,  //ÎïÆ·ÄÃÈ¡
            ENUM_VCA_EVENT_LEAVE_POSITION = 15,  //Àë¸Ú
            ENUM_VCA_EVENT_TRAIL = 16,  //Î²Ëæ
            ENUM_VCA_EVENT_KEY_PERSON_GET_UP = 17,  //ÖØµãÈËÔ±ÆðÉí¼ì²â
            ENUM_VCA_EVENT_FALL_DOWN = 20,  //µ¹µØ¼ì²â
            ENUM_VCA_EVENT_AUDIO_ABNORMAL = 21,  //ÉùÇ¿Í»±ä¼ì²â
            ENUM_VCA_EVENT_ADV_REACH_HEIGHT = 22,  //ÕÛÏßÅÊ¸ß
            ENUM_VCA_EVENT_TOILET_TARRY = 23,  //Èç²Þ³¬Ê±
            ENUM_VCA_EVENT_YARD_TARRY = 24,  //·Å·ç³¡ÖÍÁô
            ENUM_VCA_EVENT_ADV_TRAVERSE_PLANE = 25,  //ÕÛÏß¾¯½äÃæ
            ENUM_VCA_EVENT_HUMAN_ENTER = 29,  //ÈË¿¿½üATM,Ö»ÔÚATM_PANELÄ£Ê½ÏÂÖ§³Ö   
            ENUM_VCA_EVENT_OVER_TIME = 30,  //²Ù×÷³¬Ê±,Ö»ÔÚATM_PANELÄ£Ê½ÏÂÖ§³Ö
            ENUM_VCA_EVENT_STICK_UP = 31,  //ÌùÖ½Ìõ,Ö§³ÖÇøÓò¹æÔò
            ENUM_VCA_EVENT_INSTALL_SCANNER = 32   //°²×°¶Á¿¨Æ÷,Ö§³ÖÇøÓò¹æÔò
        }

        //¾¯½äÃæ´©Ô½·½ÏòÀàÐÍ
        public enum VCA_CROSS_DIRECTION
        {
            VCA_BOTH_DIRECTION,// Ë«Ïò 
            VCA_LEFT_GO_RIGHT,// ÓÉ×óÖÁÓÒ 
            VCA_RIGHT_GO_LEFT,// ÓÉÓÒÖÁ×ó 
        }

        //Ïß½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE
        {
            public NET_VCA_POINT struStart;//Æðµã 
            public NET_VCA_POINT struEnd; //ÖÕµã

            //             public void init()
            //             {
            //                 struStart = new NET_VCA_POINT();
            //                 struEnd = new NET_VCA_POINT();
            //             }
        }

        //¸Ã½á¹¹»áµ¼ÖÂxaml½çÃæ³ö²»À´£¡£¡£¡£¡£¡£¡£¡£¡£¡£¿£¿ÎÊÌâÔÝÊ±»¹Ã»ÓÐÕÒµ½  
        //ÔÝÊ±ÆÁ±Î½á¹¹ÏÈ
        //¶à±ßÐÍ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_POLYGON
        {
            /// DWORD->unsigned int
            public uint dwPointNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = VCA_MAX_POLYGON_POINT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POINT[] struPos;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TRAVERSE_PLANE
        {
            public NET_VCA_LINE struPlaneBottom;//¾¯½äÃæµ×±ß
            public VCA_CROSS_DIRECTION dwCrossDirection;//´©Ô½·½Ïò: 0-Ë«Ïò£¬1-´Ó×óµ½ÓÒ£¬2-´ÓÓÒµ½×ó
            public byte byRes1;//±£Áô
            public byte byPlaneHeight;//¾¯½äÃæ¸ß¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            //             public void init()
            //             {
            //                 struPlaneBottom = new NET_VCA_LINE();
            //                 struPlaneBottom.init();
            //                 byRes2 = new byte[38];
            //             }
        }

        //½øÈë/Àë¿ªÇøÓò²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_AREA
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¸ù¾Ý±¨¾¯ÑÓ³ÙÊ±¼äÀ´±êÊ¶±¨¾¯ÖÐ´øÍ¼Æ¬£¬±¨¾¯¼ä¸ôºÍIO±¨¾¯Ò»ÖÂ£¬1Ãë·¢ËÍÒ»¸ö¡£
        //ÈëÇÖ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_INTRUSION
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public ushort wDuration;//±¨¾¯ÑÓ³ÙÊ±¼ä: 1-120Ãë£¬½¨Òé5Ãë£¬ÅÐ¶ÏÊÇÓÐÐ§±¨¾¯µÄÊ±¼ä
            public byte bySensitivity;        //ÁéÃô¶È²ÎÊý£¬·¶Î§[1-100]
            public byte byRate;               //Õ¼±È£ºÇøÓòÄÚËùÓÐÎ´±¨¾¯Ä¿±ê³ß´çÄ¿±êÕ¼ÇøÓòÃæ»ýµÄ±ÈÖØ£¬¹éÒ»»¯Îª£­£»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÅÇ»²²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LOITER
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public ushort wDuration;//´¥·¢ÅÇ»²±¨¾¯µÄ³ÖÐøÊ±¼ä£º1-120Ãë£¬½¨Òé10Ãë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¶ª°ü/¼ñ°ü²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TAKE_LEFT
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public ushort wDuration;//´¥·¢¶ª°ü/¼ñ°ü±¨¾¯µÄ³ÖÐøÊ±¼ä£º1-120Ãë£¬½¨Òé10Ãë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Í£³µ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PARKING
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public ushort wDuration;//´¥·¢Í£³µ±¨¾¯³ÖÐøÊ±¼ä£º1-120Ãë£¬½¨Òé10Ãë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±¼ÅÜ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RUN
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public float fRunDistance;//ÈË±¼ÅÜ×î´ó¾àÀë, ·¶Î§: [0.1, 1.00]
            public byte byRes1;             // ±£Áô×Ö½Ú
            public byte byMode;             // 0 ÏñËØÄ£Ê½  1 Êµ¼ÊÄ£Ê½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÈËÔ±¾Û¼¯²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HIGH_DENSITY
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public float fDensity;//ÃÜ¶È±ÈÂÊ, ·¶Î§: [0.1, 1.0]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public ushort wDuration;      // ´¥·¢ÈËÔ±¾Û¼¯²ÎÊý±¨¾¯ãÐÖµ 20-360s
        }

        //¾çÁÒÔË¶¯²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_VIOLENT_MOTION
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public ushort wDuration;           //´¥·¢¾çÁÒÔË¶¯±¨¾¯ãÐÖµ£º1-50Ãë
            public byte bySensitivity;       //ÁéÃô¶È²ÎÊý£¬·¶Î§[1,5]
            public byte byMode;              //0-´¿ÊÓÆµÄ£Ê½£¬1-ÒôÊÓÆµÁªºÏÄ£Ê½£¬2-´¿ÒôÆµÄ£Ê½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;            //±£Áô
        }

        //ÅÊ¸ß²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_REACH_HIGHT
        {
            public NET_VCA_LINE struVcaLine;   //ÅÊ¸ß¾¯½äÃæ
            public ushort wDuration; //´¥·¢ÅÊ¸ß±¨¾¯ãÐÖµ£º1-120Ãë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           // ±£Áô×Ö½Ú
        }

        //Æð´²²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_GET_UP
        {
            public NET_VCA_POLYGON struRegion; //ÇøÓò·¶Î§
            public ushort wDuration;	        //´¥·¢Æð´²±¨¾¯ãÐÖµ1-100 Ãë
            public byte byMode;             //ÆðÉí¼ì²âÄ£Ê½,0-´ó´²Í¨ÆÌÄ£Ê½,1-¸ßµÍÆÌÄ£Ê½,2-´ó´²Í¨ÆÌ×øÁ¢ÆðÉíÄ£Ê½
            public byte bySensitivity;      //ÁéÃô¶È²ÎÊý£¬·¶Î§[1,10]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    //±£Áô×Ö½Ú
        }

        //ÎïÆ·ÒÅÁô
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LEFT
        {
            public NET_VCA_POLYGON struRegion; // ÇøÓò·¶Î§
            public ushort wDuration;       // ´¥·¢ÎïÆ·ÒÅÁô±¨¾¯ãÐÖµ 10-100Ãë
            public byte bySensitivity;   // ÁéÃô¶È²ÎÊý£¬·¶Î§[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        // ±£Áô×Ö½Ú
        }

        // ÎïÆ·ÄÃÈ¡
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TAKE
        {
            public NET_VCA_POLYGON struRegion;     // ÇøÓò·¶Î§
            public ushort wDuration;      // ´¥·¢ÎïÆ·ÄÃÈ¡±¨¾¯ãÐÖµ10-100Ãë
            public byte bySensitivity;  // ÁéÃô¶È²ÎÊý£¬·¶Î§[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_OVER_TIME
        {
            public NET_VCA_POLYGON struRegion;    // ÇøÓò·¶Î§
            public ushort wDuration;  // ²Ù×÷±¨¾¯Ê±¼äãÐÖµ 4s-60000s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_ENTER
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;			//±£Áô×Ö½Ú
        }

        //ÌùÖ½Ìõ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_STICK_UP
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public ushort wDuration;//±¨¾¯³ÖÐøÊ±¼ä£º10-60Ãë£¬½¨Òé10Ãë
            public byte bySensitivity;//ÁéÃô¶È²ÎÊý£¬·¶Î§[1,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¶Á¿¨Æ÷²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SCANNER
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public ushort wDuration;//¶Á¿¨³ÖÐøÊ±¼ä£º10-60Ãë
            public byte bySensitivity;//ÁéÃô¶È²ÎÊý£¬·¶Î§[1,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Àë¸ÚÊÂ¼þ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LEAVE_POSITION
        {
            public NET_VCA_POLYGON struRegion; //ÇøÓò·¶Î§
            public ushort wLeaveDelay;  //ÎÞÈË±¨¾¯Ê±¼ä£¬µ¥Î»£ºs£¬È¡Öµ1-1800
            public ushort wStaticDelay; //Ë¯¾õ±¨¾¯Ê±¼ä£¬µ¥Î»£ºs£¬È¡Öµ1-1800
            public byte byMode;       //Ä£Ê½£¬0-Àë¸ÚÊÂ¼þ£¬1-Ë¯¸ÚÊÂ¼þ£¬2-Àë¸ÚË¯¸ÚÊÂ¼þ
            public byte byPersonType; //Öµ¸ÚÈËÊýÀàÐÍ£¬0-µ¥ÈËÖµ¸Ú£¬1-Ë«ÈËÖµ¸Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£Áô
        }

        //Î²Ëæ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TRAIL
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public ushort wRes;      /* ±£Áô */
            public byte bySensitivity;       /* ÁéÃô¶È²ÎÊý£¬·¶Î§[1,5] */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µ¹µØ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FALL_DOWN
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public ushort wDuration;      /* ´¥·¢ÊÂ¼þãÐÖµ 1-60s*/
            public byte bySensitivity;       /* ÁéÃô¶È²ÎÊý£¬·¶Î§[1,5] */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÉùÇ¿Í»±ä²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_AUDIO_ABNORMAL
        {
            public ushort wDecibel;       //ÉùÒôÇ¿¶È
            public byte bySensitivity;  //ÁéÃô¶È²ÎÊý£¬·¶Î§[1,5] 
            public byte byAudioMode;    //ÉùÒô¼ì²âÄ£Ê½£¬0-ÁéÃô¶È¼ì²â£¬1-·Ö±´ãÐÖµ¼ì²â£¬2-ÁéÃô¶ÈÓë·Ö±´ãÐÖµ¼ì²â 
            public byte byEnable;       //Ê¹ÄÜ£¬ÊÇ·ñ¿ªÆô
            public byte byThreshold;    //ÉùÒôãÐÖµ[0,100]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //±£Áô   
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIO_EXCEPTION
        {
            public uint dwSize;
            public byte byEnableAudioInException;  //Ê¹ÄÜ£¬ÊÇ·ñ¿ªÆô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_VCA_AUDIO_ABNORMAL struAudioAbnormal;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmSched; //²¼·ÀÊ±¼ä
            public NET_DVR_HANDLEEXCEPTION_V40 struHandleException;  //Òì³£´¦Àí·½Ê½
            public uint dwMaxRelRecordChanNum;  //±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ Êý£¨Ö»¶Á£©×î´óÖ§³ÖÊýÁ¿
            public uint dwRelRecordChanNum;     //±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ Êý Êµ¼ÊÖ§³ÖµÄÊýÁ¿
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] byRelRecordChan;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TOILET_TARRY
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public ushort wDelay;        //Èç²Þ³¬Ê±Ê±¼ä[1,3600]£¬µ¥Î»£ºÃë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_YARD_TARRY
        {
            public NET_VCA_POLYGON struRegion;//ÇøÓò·¶Î§
            public ushort wDelay;        //·Å·ç³¡ÖÍÁôÊ±¼ä[1,120]£¬µ¥Î»£ºÃë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADV_REACH_HEIGHT
        {
            public NET_VCA_POLYGON struRegion; //ÅÊ¸ßÕÛÏß
            public uint dwCrossDirection;   //¿çÔ½·½Ïò(Ïê¼ûVCA_CROSS_DIRECTION): 0-Ë«Ïò£¬1-´Ó×óµ½ÓÒ2-´ÓÓÒµ½×ó
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADV_TRAVERSE_PLANE
        {
            public NET_VCA_POLYGON struRegion; //¾¯½äÃæÕÛÏß
            public uint dwCrossDirection;   //¿çÔ½·½Ïò(Ïê¼ûVCA_CROSS_DIRECTION): 0-Ë«Ïò£¬1-´Ó×óµ½ÓÒ2-´ÓÓÒµ½×ó
            public byte bySensitivity;      //ÁéÃô¶È²ÎÊý£¬·¶Î§[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    //±£Áô×Ö½Ú
        }

        //¾¯½äÊÂ¼þ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_VCA_EVENT_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;//²ÎÊý

            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TRAVERSE_PLANE struTraversePlane;//´©Ô½¾¯½äÃæ²ÎÊý 
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_AREA struArea;//½øÈë/Àë¿ªÇøÓò²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_INTRUSION struIntrusion;//ÈëÇÖ²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_LOITER struLoiter;//ÅÇ»²²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TAKE_LEFT struTakeTeft;//¶ª°ü/¼ñ°ü²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_PARKING struParking;//Í£³µ²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_RUN struRun;//±¼ÅÜ²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_HIGH_DENSITY struHighDensity;//ÈËÔ±¾Û¼¯²ÎÊý  
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_VIOLENT_MOTION struViolentMotion;	//¾çÁÒÔË¶¯
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_REACH_HIGHT struReachHight;      //ÅÊ¸ß
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_GET_UP struGetUp;           //Æð´²
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_LEFT struLeft;            //ÎïÆ·ÒÅÁô
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TAKE struTake;            // ÎïÆ·ÄÃÈ¡
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_HUMAN_ENTER struHumanEnter;      //ÈËÔ±½øÈë
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_OVER_TIME struOvertime;        //²Ù×÷³¬Ê±
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_STICK_UP struStickUp;//ÌùÖ½Ìõ
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_SCANNER struScanner;//¶Á¿¨Æ÷²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_LEAVE_POSITION struLeavePos;        //Àë¸Ú²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TRAIL struTrail;           //Î²Ëæ²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_FALL_DOWN struFallDown;        //µ¹µØ²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_AUDIO_ABNORMAL struAudioAbnormal;   //ÉùÇ¿Í»±ä
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_ADV_REACH_HEIGHT struReachHeight;     //ÕÛÏßÅÊ¸ß²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TOILET_TARRY struToiletTarry;     //Èç²Þ³¬Ê±²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_YARD_TARRY struYardTarry;       //·Å·ç³¡ÖÍÁô²ÎÊý
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_ADV_TRAVERSE_PLANE struAdvTraversePlane;//ÕÛÏß¾¯½äÃæ²ÎÊý            
        }

        // ³ß´ç¹ýÂËÆ÷ÀàÐÍ
        public enum SIZE_FILTER_MODE
        {
            IMAGE_PIX_MODE,//¸ù¾ÝÏñËØ´óÐ¡ÉèÖÃ
            REAL_WORLD_MODE,//¸ù¾ÝÊµ¼Ê´óÐ¡ÉèÖÃ
            DEFAULT_MODE 	// Ä¬ÈÏÄ£Ê½
        }

        //³ß´ç¹ýÂËÆ÷
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SIZE_FILTER
        {
            public byte byActive;//ÊÇ·ñ¼¤»î³ß´ç¹ýÂËÆ÷ 0-·ñ ·Ç0-ÊÇ
            public byte byMode;//¹ýÂËÆ÷Ä£Ê½SIZE_FILTER_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô£¬ÖÃ0
            public NET_VCA_RECT struMiniRect;//×îÐ¡Ä¿±ê¿ò,È«0±íÊ¾²»ÉèÖÃ
            public NET_VCA_RECT struMaxRect;//×î´óÄ¿±ê¿ò,È«0±íÊ¾²»ÉèÖÃ
        }

        //¾¯½ä¹æÔò½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ONE_RULE
        {
            public byte byActive;//ÊÇ·ñ¼¤»î¹æÔò,0-·ñ,·Ç0-ÊÇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô£¬ÉèÖÃÎª0×Ö¶Î
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//¹æÔòÃû³Æ
            public VCA_EVENT_TYPE dwEventType;//ÐÐÎª·ÖÎöÊÂ¼þÀàÐÍ
            public NET_VCA_EVENT_UNION uEventParam;//ÐÐÎª·ÖÎöÊÂ¼þ²ÎÊý
            public NET_VCA_SIZE_FILTER struSizeFilter;//³ß´ç¹ýÂËÆ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;//´¦Àí·½Ê½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ,Îª1±íÊ¾´¥·¢¸ÃÍ¨µÀ
        }

        //ÐÐÎª·ÖÎöÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULECFG
        {
            public uint dwSize;//½á¹¹³¤¶È
            public byte byPicProType;//±¨¾¯Ê±Í¼Æ¬´¦Àí·½Ê½ 0-²»´¦Àí ·Ç0-ÉÏ´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPictureParam;//Í¼Æ¬¹æ¸ñ½á¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ONE_RULE[] struRule;//¹æÔòÊý×é
        }

        //³ß´ç¹ýÂË²ßÂÔ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FILTER_STRATEGY
        {
            public byte byStrategy;      //³ß´ç¹ýÂË²ßÂÔ 0 - ²»ÆôÓÃ 1-¸ß¶ÈºÍ¿í¶È¹ýÂË,2-Ãæ»ý¹ýÂË
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       //±£Áô
        }

        //¹æÔò´¥·¢²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_TRIGGER_PARAM
        {
            public byte byTriggerMode;   //¹æÔòµÄ´¥·¢·½Ê½£¬0- ²»ÆôÓÃ£¬1- ¹ì¼£µã 2- Ä¿±êÃæ»ý 
            public byte byTriggerPoint;  //´¥·¢µã£¬´¥·¢·½Ê½Îª¹ì¼£µãÊ±ÓÐÐ§ 0- ÖÐ,1-ÉÏ,2-ÏÂ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       //±£Áô
            public float fTriggerArea;    //´¥·¢Ä¿±êÃæ»ý°Ù·Ö±È [0,100]£¬´¥·¢·½Ê½ÎªÄ¿±êÃæ»ýÊ±ÓÐÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       //±£Áô
        }

        //¾¯½ä¹æÔò½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ONE_RULE_V41
        {
            public byte byActive; //ÊÇ·ñ¼¤»î¹æÔò,0-·ñ,·Ç0-ÊÇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±£Áô£¬ÉèÖÃÎª0×Ö¶Î
            public ushort wEventTypeEx; //ÐÐÎªÊÂ¼þÀàÐÍÀ©Õ¹£¬ÓÃÓÚ´úÌæ×Ö¶ÎdwEventType£¬²Î¿¼VCA_RULE_EVENT_TYPE_EX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; //¹æÔòÃû³Æ
            public VCA_EVENT_TYPE dwEventType;	//ÐÐÎªÊÂ¼þÀàÐÍ£¬±£ÁôÊÇÎªÁË¼æÈÝ£¬ºóÐø½¨ÒéÊ¹ÓÃwEventTypeEx»ñÈ¡ÊÂ¼þÀàÐÍ
            public NET_VCA_EVENT_UNION uEventParam; //ÐÐÎª·ÖÎöÊÂ¼þ²ÎÊý
            public NET_VCA_SIZE_FILTER struSizeFilter;  //³ß´ç¹ýÂËÆ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	//´¦Àí·½Ê½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ,Îª1±íÊ¾´¥·¢¸ÃÍ¨µÀ
            public ushort wAlarmDelay; //ÖÇÄÜ±¨¾¯ÑÓÊ±£¬0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£Áô
            public NET_VCA_FILTER_STRATEGY struFilterStrategy; //³ß´ç¹ýÂË²ßÂÔ
            public NET_VCA_RULE_TRIGGER_PARAM struTriggerParam;   //¹æÔò´¥·¢²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÐÐÎª·ÖÎöÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULECFG_V41
        {
            public uint dwSize;			//½á¹¹³¤¶È
            public byte byPicProType;	//±¨¾¯Ê±Í¼Æ¬´¦Àí·½Ê½ 0-²»´¦Àí ·Ç0-ÉÏ´«
            public byte byUpLastAlarm; //2011-04-06 ÊÇ·ñÏÈÉÏ´«×î½üÒ»´ÎµÄ±¨¾¯
            public byte byPicRecordEnable;  /*2012-3-1ÊÇ·ñÆôÓÃÍ¼Æ¬´æ´¢, 0-²»ÆôÓÃ, 1-ÆôÓÃ*/
            public byte byRes1;
            public NET_DVR_JPEGPARA struPictureParam; 		//Í¼Æ¬¹æ¸ñ½á¹¹	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ONE_RULE_V41[] struRule;  //¹æÔòÊý×é
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¼ò»¯Ä¿±ê½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TARGET_INFO
        {
            public uint dwID;//Ä¿±êID ,ÈËÔ±ÃÜ¶È¹ý¸ß±¨¾¯Ê±Îª0
            public NET_VCA_RECT struRect; //Ä¿±ê±ß½ç¿ò 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô
        }

        //¼ò»¯µÄ¹æÔòÐÅÏ¢, °üº¬¹æÔòµÄ»ù±¾ÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_INFO
        {
            public byte byRuleID;//¹æÔòID,0-7
            public byte byRes;//±£Áô
            public ushort wEventTypeEx;   //ÐÐÎªÊÂ¼þÀàÐÍÀ©Õ¹£¬ÓÃÓÚ´úÌæ×Ö¶ÎdwEventType£¬²Î¿¼VCA_RULE_EVENT_TYPE_EX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//¹æÔòÃû³Æ
            public VCA_EVENT_TYPE dwEventType;//¾¯½äÊÂ¼þÀàÐÍ
            public NET_VCA_EVENT_UNION uEventParam;//ÊÂ¼þ²ÎÊý
        }

        //Ç°¶ËÉè±¸µØÖ·ÐÅÏ¢£¬ÖÇÄÜ·ÖÎöÒÇ±íÊ¾µÄÊÇÇ°¶ËÉè±¸µÄµØÖ·ÐÅÏ¢£¬ÆäËûÉè±¸±íÊ¾±¾»úµÄµØÖ·
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DEV_INFO
        {
            public NET_DVR_IPADDR struDevIP;//Ç°¶ËÉè±¸µØÖ·£¬
            public ushort wPort;//Ç°¶ËÉè±¸¶Ë¿ÚºÅ£¬ 
            public byte byChannel;//Ç°¶ËÉè±¸Í¨µÀ£¬
            public byte byRes;// ±£Áô×Ö½Ú
        }

        //ÐÐÎª·ÖÎö½á¹ûÉÏ±¨½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_ALARM
        {
            public uint dwSize;//½á¹¹³¤¶È
            public uint dwRelativeTime;//Ïà¶ÔÊ±±ê
            public uint dwAbsTime;//¾ø¶ÔÊ±±ê
            public NET_VCA_RULE_INFO struRuleInfo;//ÊÂ¼þ¹æÔòÐÅÏ¢
            public NET_VCA_TARGET_INFO struTargetInfo;//±¨¾¯Ä¿±êÐÅÏ¢
            public NET_VCA_DEV_INFO struDevInfo;//Ç°¶ËÉè±¸ÐÅÏ¢
            public uint dwPicDataLen;//·µ»ØÍ¼Æ¬µÄ³¤¶È Îª0±íÊ¾Ã»ÓÐÍ¼Æ¬£¬´óÓÚ0±íÊ¾¸Ã½á¹¹ºóÃæ½ô¸úÍ¼Æ¬Êý¾Ý*/
            public byte byPicType;		//  0-ÆÕÍ¨Í¼Æ¬ 1-¶Ô±ÈÍ¼Æ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;//±£Áô£¬ÉèÖÃÎª0
            public IntPtr pImage;//Ö¸ÏòÍ¼Æ¬µÄÖ¸Õë
        }

        //ÐÐÎª·ÖÎö¹æÔòDSPÐÅÏ¢µþ¼Ó½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DRAW_MODE
        {
            public uint dwSize;
            public byte byDspAddTarget;//±àÂëÊÇ·ñµþ¼ÓÄ¿±ê
            public byte byDspAddRule;//±àÂëÊÇ·ñµþ¼Ó¹æÔò
            public byte byDspPicAddTarget;//×¥Í¼ÊÇ·ñµþ¼ÓÄ¿±ê
            public byte byDspPicAddRule;//×¥Í¼ÊÇ·ñµþ¼Ó¹æÔò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÎïÌåÀàÐÍ
        public enum OBJECT_TYPE_ENUM
        {
            ENUM_OBJECT_TYPE_COAT = 1  //ÉÏÒÂ
        }

        //ÎïÌåÑÕÉ«Ìõ¼þ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR_COND
        {
            public uint dwChannel;   //Í¨µÀºÅ
            public uint dwObjType;   //ÎïÌåÀàÐÍ£¬²Î¼ûOBJECT_TYPE_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±£Áô
        }

        //Í¼Æ¬²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PIC
        {
            public byte byPicType;        //Í¼Æ¬ÀàÐÍ£¬1-jpg
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        //±£Áô
            public uint dwPicWidth;       //Í¼Æ¬¿í¶È
            public uint dwPicHeight;      //Í¼Æ¬¸ß¶È
            public uint dwPicDataLen;     //Í¼Æ¬Êý¾ÝÊµ¼Ê´óÐ¡
            public uint dwPicDataBuffLen; //Í¼Æ¬Êý¾Ý»º³åÇø´óÐ¡
            public IntPtr byPicDataBuff;    //Í¼Æ¬Êý¾Ý»º³åÇø
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       //±£Áô
        }

        //ÑÕÉ«ÁªºÏÌå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR_UNION
        {
            public NET_DVR_COLOR struColor;   //ÑÕÉ«Öµ
            public NET_DVR_PIC struPicture; //Í¼Æ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±£Áô
        }

        //ÎïÌåÑÕÉ«²ÎÊý½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR
        {
            public uint dwSize;       //½á¹¹Ìå´óÐ¡
            public byte byEnable;     //0-²»ÆôÓÃ£¬1-ÆôÓÃ
            public byte byColorMode;  //È¡É«·½Ê½£¬1-ÑÕÉ«Öµ£¬2-Í¼Æ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±£Áô
            public NET_DVR_OBJECT_COLOR_UNION uObjColor; //ÎïÌåÑÕÉ«ÁªºÏÌå£¬È¡ÖµÒÀÀµÓÚÈ¡É«·½Ê½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±£Áô
        }

        //ÇøÓòÀàÐÍ
        public enum AREA_TYPE_ENUM
        {
            ENUM_OVERLAP_REGION = 1,//¹²Í¬ÇøÓò
            ENUM_BED_LOCATION = 2   //´²ÆÌÎ»ÖÃ
        }

        //¸¨ÖúÇøÓò
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXAREA
        {
            public uint dwAreaType;   //ÇøÓòÀàÐÍ£¬²Î¼ûAREA_TYPE_ENUM
            public byte byEnable;     //0-²»ÆôÓÃ£¬1-ÆôÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;     //±£Áô
            public NET_VCA_POLYGON struPolygon; //ÇøÓò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±£Áô
        }

        //¸¨ÖúÇøÓòÁÐ±í
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXAREA_LIST
        {
            public uint dwSize;	// ½á¹¹Ìå´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_AUXAREA[] struArea; //¸¨ÖúÇøÓò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	// ±£Áô
        }

        //Í¨µÀ¹¤×÷Ä£Ê½
        public enum CHAN_WORKMODE_ENUM
        {
            ENUM_CHAN_WORKMODE_INDEPENDENT = 1,  //¶ÀÁ¢Ä£Ê½
            ENUM_CHAN_WORKMODE_MASTER = 2,      //Ö÷Ä£Ê½
            ENUM_CHAN_WORKMODE_SLAVE = 3        //´ÓÄ£Ê½
        }

        //Í¨µÀ¹¤×÷Ä£Ê½²ÎÊý½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNEL_WORKMODE
        {
            public uint dwSize;        //½á¹¹Ìå´óÐ¡
            public byte byWorkMode;    //¹¤×÷Ä£Ê½£¬²Î¼ûCHAN_WORKMODE_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£Áô
        }

        //Éè±¸Í¨µÀ²ÎÊý½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNEL
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byAddress;	//Éè±¸IP»òÓòÃû
            public ushort wDVRPort;			 	    //¶Ë¿ÚºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                   //±£Áô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	        //Ö÷»úÓÃ»§Ãû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;       //Ö÷»úÃÜÂë
            public uint dwChannel;                   //Í¨µÀºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                  //±£Áô
        }

        //´ÓÍ¨µÀÐÅÏ¢ÁªºÏÌå
        [StructLayout(LayoutKind.Explicit)]
        public struct NET_DVR_SLAVE_CHANNEL_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //ÁªºÏÌå´óÐ¡
        }

        //´ÓÍ¨µÀ²ÎÊý½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SLAVE_CHANNEL_PARAM
        {
            public byte byChanType;   //´ÓÍ¨µÀÀàÐÍ£¬1-±¾»úÍ¨µÀ£¬2-Ô¶³ÌÍ¨µÀ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±£Áô
            public NET_DVR_SLAVE_CHANNEL_UNION uSlaveChannel; //´ÓÍ¨µÀÁªºÏÌå£¬È¡ÖµÒÀÀµÓÚbyChanType
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±£Áô
        }


        //´ÓÍ¨µÀ²ÎÊýÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SLAVE_CHANNEL_CFG
        {
            public uint dwSize;   //½á¹¹Ìå´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SLAVE_CHANNEL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SLAVE_CHANNEL_PARAM[] struChanParam;//´ÓÍ¨µÀ²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£Áô
        }

        //ÊÓÆµÖÊÁ¿Õï¶Ï¼ì²âÊÂ¼þ
        public enum VQD_EVENT_ENUM
        {
            ENUM_VQD_EVENT_BLUR = 1,  //Í¼ÏñÄ£ºý
            ENUM_VQD_EVENT_LUMA = 2,  //ÁÁ¶ÈÒì³£
            ENUM_VQD_EVENT_CHROMA = 3,  //Í¼ÏñÆ«É«
            ENUM_VQD_EVENT_SNOW = 4,  //Ñ©»¨¸ÉÈÅ
            ENUM_VQD_EVENT_STREAK = 5,  //ÌõÎÆ¸ÉÈÅ
            ENUM_VQD_EVENT_FREEZE = 6,  //»­Ãæ¶³½á
            ENUM_VQD_EVENT_SIGNAL_LOSS = 7,  //ÐÅºÅ¶ªÊ§
            ENUM_VQD_EVENT_PTZ = 8,  //ÔÆÌ¨Ê§¿Ø
            ENUM_VQD_EVENT_SCNENE_CHANGE = 9,  //³¡¾°Í»±ä
            ENUM_VQD_EVENT_VIDEO_ABNORMAL = 10, //ÊÓÆµÒì³£
            ENUM_VQD_EVENT_VIDEO_BLOCK = 11, //ÊÓÆµÕÚµ²
        }

        //ÊÓÆµÖÊÁ¿Õï¶ÏÊÂ¼þÌõ¼þ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_COND
        {
            public uint dwChannel;   //Í¨µÀºÅ
            public uint dwEventType; //¼ì²âÊÂ¼þÀàÐÍ£¬²Î¼ûVQD_EVENT_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±£Áô
        }

        //ÊÓÆµÖÊÁ¿Õï¶ÏÊÂ¼þ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_PARAM
        {
            public byte byThreshold;    //±¨¾¯ãÐÖµ£¬·¶Î§[0,100]
            public byte byTriggerMode;  //1-³ÖÐø´¥·¢£¬2-µ¥´Î´¥·¢
            public byte byUploadPic;    //0-²»ÉÏ´«Í¼Æ¬£¬1-ÉÏ´«Í¼Æ¬£¬ÎÞÂÛÊÇ·ñÉÏ´«Í¼Æ¬£¬ÊÂºó¶¼¿ÉÒÔ´ÓÉè±¸»ñÈ¡¸ÃÊÂ¼þËù¶ÔÓ¦×îÐÂµÄÒ»ÕÅ±¨¾¯Í¼Æ¬£¬²Î¼û½Ó¿ÚNET_DVR_StartDownload
            public byte byRes1;         //±£Áô
            public uint dwTimeInterval; //³ÖÐø´¥·¢±¨¾¯Ê±¼ä¼ä¸ô£¬·¶Î§[0,3600] µ¥Î»£ºÃë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     //±£Áô
        }

        //ÊÓÆµÖÊÁ¿Õï¶ÏÊÂ¼þ¹æÔò
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_RULE
        {
            public uint dwSize;       //½á¹¹Ìå´óÐ¡ 
            public byte byEnable;     //0-²»ÆôÓÃ£¬1-ÆôÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±£Áô
            public NET_DVR_VQD_EVENT_PARAM struEventParam; //ÊÓÆµÖÊÁ¿Õï¶ÏÊÂ¼þ²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//¼ì²âÊ±¼ä
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;  //´¦Àí·½Ê½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IVMS_IP_CHANNEL, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ£º1±íÊ¾´¥·¢¸ÃÍ¨µÀ£»0±íÊ¾²»´¥·¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£Áô
        }

        //»ù×¼³¡¾°²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BASELINE_SCENE
        {
            public uint dwSize;     //½á¹¹Ìå´óÐ¡
            public byte byEnable;   //0-²»ÆôÓÃ£¬1-ÆôÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£Áô
        }

        //»ù×¼³¡¾°²Ù×÷²ÎÊý½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CONTROL_BASELINE_SCENE_PARAM
        {
            public uint dwSize;     //½á¹¹Ìå´óÐ¡
            public uint dwChannel;  //Í¨µÀºÅ
            public byte byCommand;  //²Ù×÷ÀàÐÍ£¬1-´Ë×Ö¶Î±£Áô£¬ÔÝ²»Ê¹ÓÃ£¬2-¸üÐÂ»ù×¼³¡¾°
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£Áô
        }

        //ÊÓÆµÖÊÁ¿Õï¶Ï±¨¾¯½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_ALARM
        {
            public uint dwSize;                //½á¹¹Ìå´óÐ¡
            public uint dwRelativeTime;        //Ïà¶ÔÊ±±ê
            public uint dwAbsTime;	          //¾ø¶ÔÊ±±ê
            public NET_VCA_DEV_INFO struDevInfo; //Ç°¶ËÉè±¸ÐÅÏ¢ 
            public uint dwEventType;           //ÊÂ¼þÀàÐÍ£¬²Î¿¼VQD_EVENT_ENUM
            public float fThreshold;            //±¨¾¯ãÐÖµ[0.000,1.000]
            public uint dwPicDataLen;          //Í¼Æ¬³¤¶È£¬Îª0±íÊ¾Ã»ÓÐÍ¼Æ¬
            public IntPtr pImage;               //Ö¸ÏòÍ¼Æ¬µÄÖ¸Õë 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;            //±£Áô
        }

        //±ê¶¨µã×Ó½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CB_POINT
        {
            public NET_VCA_POINT struPoint;     //±ê¶¨µã£¬Ö÷ÉãÏñ»ú£¨Ç¹»ú£©
            public NET_DVR_PTZPOS struPtzPos;  //Çò»úÊäÈëµÄPTZ×ø±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±ê¶¨²ÎÊýÅäÖÃ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_CALIBRATION_PARAM
        {
            public byte byPointNum;			//ÓÐÐ§±ê¶¨µã¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CALIB_PT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CB_POINT[] struCBPoint; //±ê¶¨µã×é
        }

        //Çò»úÅäÖÃ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_CFG
        {
            public uint dwSize;				//½á¹¹³¤¶È	
            public byte byEnable;				//±ê¶¨Ê¹ÄÜ
            public byte byFollowChan;          // ±»¿ØÖÆµÄ´ÓÍ¨µÀ
            public byte byDomeCalibrate;			//ÉèÖÃÖÇÄÜ¸ú×ÙÇò»ú±ê¶¨£¬1ÉèÖÃ 0²»ÉèÖÃ 
            public byte byRes;					// ±£Áô×Ö½Ú
            public NET_DVR_TRACK_CALIBRATION_PARAM struCalParam; //±ê¶¨µã×é
        }

        //¸ú×ÙÄ£Ê½
        public enum TRACK_MODE
        {
            MANUAL_CTRL = 0,  //ÊÖ¶¯¸ú×Ù
            ALARM_TRACK    //±¨¾¯´¥·¢¸ú×Ù
        }

        //ÊÖ¶¯¿ØÖÆ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MANUAL_CTRL_INFO
        {
            public NET_VCA_POINT struCtrlPoint;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¸ú×ÙÄ£Ê½½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_MODE
        {
            public uint dwSize;		//½á¹¹³¤¶È
            public byte byTrackMode;   //¸ú×ÙÄ£Ê½
            public byte byRuleConfMode;   //¹æÔòÅäÖÃ¸ú×ÙÄ£Ê½0-±¾µØÅäÖÃ¸ú×Ù£¬1-Ô¶³ÌÅäÖÃ¸ú×Ù
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±£Áô£¬ÖÃ0
            [StructLayout(LayoutKind.Explicit)]
            public struct uModeParam
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
                public uint[] dwULen;
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_JPEG
        {
            public byte byPicProType;	    /*±¨¾¯Ê±Í¼Æ¬´¦Àí·½Ê½ 0-²»´¦Àí 1-ÉÏ´«*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±£Áô×Ö½Ú
            public NET_DVR_JPEGPARA struPicParam; 				/*Í¼Æ¬¹æ¸ñ½á¹¹*/
        }

        //·ÖÎöÒÇÐÐÎª·ÖÎö¹æÔò½á¹¹
        //¾¯½ä¹æÔò½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ONE_RULE
        {
            public byte byActive;/* ÊÇ·ñ¼¤»î¹æÔò,0-·ñ, ·Ç0-ÊÇ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£Áô£¬ÉèÖÃÎª0×Ö¶Î
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//¹æÔòÃû³Æ
            public VCA_EVENT_TYPE dwEventType;//ÐÐÎª·ÖÎöÊÂ¼þÀàÐÍ
            public NET_VCA_EVENT_UNION uEventParam;//ÐÐÎª·ÖÎöÊÂ¼þ²ÎÊý
            public NET_VCA_SIZE_FILTER struSizeFilter;//³ß´ç¹ýÂËÆ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;/*±£Áô£¬ÉèÖÃÎª0*/
        }

        // ·ÖÎöÒÇ¹æÔò½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_RULECFG
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_ONE_RULE[] struRule; //¹æÔòÊý×é
        }

        // IVMSÐÐÎª·ÖÎöÅäÖÃ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_BEHAVIORCFG
        {
            public uint dwSize;
            public byte byPicProType;//±¨¾¯Ê±Í¼Æ¬´¦Àí·½Ê½ 0-²»´¦Àí ·Ç0-ÉÏ´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPicParam;//Í¼Æ¬¹æ¸ñ½á¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_RULECFG[] struRuleCfg;//Ã¿¸öÊ±¼ä¶Î¶ÔÓ¦¹æÔò
        }

        //ÖÇÄÜ·ÖÎöÒÇÈ¡Á÷¼Æ»®×Ó½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_DEVSCHED
        {
            public NET_DVR_SCHEDTIME struTime;//Ê±¼ä²ÎÊý
            public NET_DVR_PU_STREAM_CFG struPUStream;//Ç°¶ËÈ¡Á÷²ÎÊý
        }

        //ÖÇÄÜ·ÖÎöÒÇ²ÎÊýÅäÖÃ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_STREAMCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_DEVSCHED[] struDevSched;//°´Ê±¼ä¶ÎÅäÖÃÇ°¶ËÈ¡Á÷ÒÔ¼°¹æÔòÐÅÏ¢
        }

        //ÆÁ±ÎÇøÓò
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_MASK_REGION
        {
            public byte byEnable;//ÊÇ·ñ¼¤»î, 0-·ñ£¬·Ç0-ÊÇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô£¬ÖÃ0
            public NET_VCA_POLYGON struPolygon;//ÆÁ±Î¶à±ßÐÎ
        }

        //ÆÁ±ÎÇøÓòÁ´±í½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_MASK_REGION_LIST
        {
            public uint dwSize;//½á¹¹³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô£¬ÖÃ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MASK_REGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_MASK_REGION[] struMask;//ÆÁ±ÎÇøÓòÊý×é
        }

        //ATM½øÈëÇøÓò²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ENTER_REGION
        {
            public uint dwSize;
            public byte byEnable;//ÊÇ·ñ¼¤»î£¬0-·ñ£¬·Ç0-ÊÇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_VCA_POLYGON struPolygon;//½øÈëÇøÓò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //IVMSÆÁ±ÎÇøÓòÁ´±í
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_MASK_REGION_LIST
        {
            public uint dwSize;//½á¹¹³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_MASK_REGION_LIST[] struList;
        }

        //IVMSµÄATM½øÈëÇøÓò²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ENTER_REGION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ENTER_REGION[] struEnter;//½øÈëÇøÓò
        }

        // ivms ±¨¾¯Í¼Æ¬ÉÏ´«½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ALARM_JPEG
        {
            public byte byPicProType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPicParam;
        }

        // IVMS ºó¼ìË÷ÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_SEARCHCFG
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DEC_REMOTE_PLAY struRemotePlay;// Ô¶³Ì»Ø·Å
            public NET_IVMS_ALARM_JPEG struAlarmJpeg;// ±¨¾¯ÉÏ´«Í¼Æ¬ÅäÖÃ
            public NET_IVMS_RULECFG struRuleCfg;//IVMS ÐÐÎª¹æÔòÅäÖÃ
        }

        /************************************end******************************************/
        //NASÈÏÖ¤ÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IDENTIFICATION_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;		/* ÓÃ»§Ãû 32*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;		/* ÃÜÂë 16*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_MOUNT_PARAM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen;   //ÁªºÏÌå½á¹¹´óÐ¡
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAS_MOUNT_PARAM
        {
            public byte byMountType; //0¡«±£Áô,1~NFS, 2~ SMB/CIFS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_MOUNT_PARAM_UNION uMountParam;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_MOUNTMETHOD_PARAM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen; //ÁªºÏÌå½á¹¹´óÐ¡   
        }

        //ÍøÂçÓ²ÅÌ½á¹¹ÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_NET_DISK_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£Áô
            public NET_DVR_IPADDR struNetDiskAddr;//ÍøÂçÓ²ÅÌµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDirectory;// PATHNAME_LEN = 128
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£Áô
        }

        public const int MAX_NET_DISK = 16;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NET_DISKCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NET_DISK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_NET_DISK_INFO[] struNetDiskParam;
        }

        //ÊÂ¼þÀàÐÍ
        //Ö÷ÀàÐÍ
        public enum MAIN_EVENT_TYPE
        {
            EVENT_MOT_DET = 0,//ÒÆ¶¯Õì²â
            EVENT_ALARM_IN = 1,//±¨¾¯ÊäÈë
            EVENT_VCA_BEHAVIOR = 2,//ÐÐÎª·ÖÎö
            EVENT_INQUEST = 3,       //ÉóÑ¶ÊÂ¼þ
            EVENT_VCA_DETECTION = 4, //ÖÇÄÜÕì²â
            EVENT_STREAM_INFO = 100  //Á÷IDÐÅÏ¢
        }

        public const int INQUEST_START_INFO = 0x1001;      /*Ñ¶ÎÊ¿ªÊ¼ÐÅÏ¢*/
        public const int INQUEST_STOP_INFO = 0x1002;       /*Ñ¶ÎÊÍ£Ö¹ÐÅÏ¢*/
        public const int INQUEST_TAG_INFO = 0x1003;       /*ÖØµã±ê¼ÇÐÅÏ¢*/
        public const int INQUEST_SEGMENT_INFO = 0x1004;      /*ÉóÑ¶Æ¬¶Ï×´Ì¬ÐÅÏ¢*/

        public enum VCA_DETECTION_MINOR_TYPE : uint
        {
            EVENT_VCA_TRAVERSE_PLANE = 1,        //Ô½¾¯Õì²â
            EVENT_FIELD_DETECTION,		     //ÇøÓòÈëÇÖÕì²â
            EVENT_AUDIO_INPUT_ALARM,      //ÒôÆµÊäÈëÒì³£
            EVENT_SOUND_INTENSITY_ALARM,   //ÉùÇ¿Í»±äÕì²â
            EVENT_FACE_DETECTION,             //ÈËÁ³Õì²â
            EVENT_VIRTUAL_FOCUS_ALARM, /*Ðé½¹Õì²â*/
            EVENT_SCENE_CHANGE_ALARM, /*³¡¾°±ä¸üÕì²â*/
            EVENT_ALL = 0xffffffff				//±íÊ¾È«²¿
        }

        //ÐÐÎª·ÖÎöÖ÷ÀàÐÍ¶ÔÓ¦µÄ´ËÀàÐÍ£¬ 0xffff±íÊ¾È«²¿
        public enum BEHAVIOR_MINOR_TYPE
        {
            EVENT_TRAVERSE_PLANE = 0,// ´©Ô½¾¯½äÃæ,
            EVENT_ENTER_AREA,//Ä¿±ê½øÈëÇøÓò,Ö§³ÖÇøÓò¹æÔò
            EVENT_EXIT_AREA,//Ä¿±êÀë¿ªÇøÓò,Ö§³ÖÇøÓò¹æÔò
            EVENT_INTRUSION,// ÖÜ½çÈëÇÖ,Ö§³ÖÇøÓò¹æÔò
            EVENT_LOITER,//ÅÇ»²,Ö§³ÖÇøÓò¹æÔò
            EVENT_LEFT_TAKE,//¶ª°ü¼ñ°ü,Ö§³ÖÇøÓò¹æÔò
            EVENT_PARKING,//Í£³µ,Ö§³ÖÇøÓò¹æÔò
            EVENT_RUN,//±¼ÅÜ,Ö§³ÖÇøÓò¹æÔò
            EVENT_HIGH_DENSITY,//ÇøÓòÄÚÈËÔ±ÃÜ¶È,Ö§³ÖÇøÓò¹æÔò
            EVENT_STICK_UP,//ÌùÖ½Ìõ,Ö§³ÖÇøÓò¹æÔò
            EVENT_INSTALL_SCANNER,//°²×°¶Á¿¨Æ÷,Ö§³ÖÇøÓò¹æÔò
            EVENT_OPERATE_OVER_TIME,        // ²Ù×÷³¬Ê±
            EVENT_FACE_DETECT,              // Òì³£ÈËÁ³
            EVENT_LEFT,                     // ÎïÆ·ÒÅÁô
            EVENT_TAKE,                      // ÎïÆ·ÄÃÈ¡
            EVENT_LEAVE_POSITION,         //Àë¸ÚÊÂ¼þ
            EVENT_TRAIL_INFO = 16,            //Î²Ëæ
            EVENT_FALL_DOWN_INFO = 19,                 //µ¹µØ
            EVENT_OBJECT_PASTE = 20,		// ÒìÎïÕ³ÌùÇøÓò
            EVENT_FACE_CAPTURE_INFO = 21,                //Õý³£ÈËÁ³
            EVENT_MULTI_FACES_INFO = 22,                  //¶àÕÅÈËÁ³
            EVENT_AUDIO_ABNORMAL_INFO = 23,             //ÉùÇ¿Í»±ä
            EVENT_DETECT = 24     			   //ÖÇÄÜÕì²â
        }

        // Ö÷ÀàÐÍ100£¬¶ÔÓ¦µÄÐ¡ÀàÐÍ
        public enum STREAM_INFO_MINOR_TYPE
        {
            EVENT_STREAM_ID = 0,				// Á÷ID
            EVENT_TIMING = 1,					// ¶¨Ê±Â¼Ïñ
            EVENT_MOTION_DETECT = 2,			// ÒÆ¶¯Õì²â
            EVENT_ALARM = 3,					// ±¨¾¯Â¼Ïñ
            EVENT_ALARM_OR_MOTION_DETECT = 4,	// ±¨¾¯»òÒÆ¶¯Õì²â
            EVENT_ALARM_AND_MOTION_DETECT = 5,	// ±¨¾¯ºÍÒÆ¶¯Õì²â
            EVENT_COMMAND_TRIGGER = 6,			// ÃüÁî´¥·¢
            EVENT_MANNUAL = 7,					// ÊÖ¶¯Â¼Ïñ
            EVENT_BACKUP_VOLUME = 8				// ´æµµ¾íÂ¼Ïñ
        }

        //°îÅµCVR
        public const int MAX_ID_COUNT = 256;
        public const int MAX_STREAM_ID_COUNT = 1024;
        public const int STREAM_ID_LEN = 32;
        public const int PLAN_ID_LEN = 32;

        // Á÷ÐÅÏ¢ - 72×Ö½Ú³¤
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = STREAM_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byID;      //IDÊý¾Ý
            public uint dwChannel;                //¹ØÁªÉè±¸Í¨µÀ£¬µÈÓÚ0xffffffffÊ±£¬±íÊ¾²»¹ØÁª
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                //±£Áô
            public void init()
            {
                byID = new byte[STREAM_ID_LEN];
                byRes = new byte[32];
            }
        }

        //ÊÂ¼þËÑË÷Ìõ¼þ 200-04-07 9000_1.1
        public const int SEARCH_EVENT_INFO_LEN = 300;

        //±¨¾¯ÊäÈë
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInNo;//±¨¾¯ÊäÈëºÅ£¬byAlarmInNo[0]ÈôÖÃ1Ôò±íÊ¾²éÕÒÓÉ±¨¾¯ÊäÈë1´¥·¢µÄÊÂ¼þ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN - MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byAlarmInNo = new byte[MAX_ALARMIN_V30];
                byRes = new byte[SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30];
            }
        }

        //±¨¾¯ÊäÈë °´Öµ±íÊ¾
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.U2)]
            public ushort[] wAlarmInNo;//±¨¾¯ÊäÈëºÅ£¬byAlarmInNo[0]ÈôÖÃ1Ôò±íÊ¾²éÕÒÓÉ±¨¾¯ÊäÈë1´¥·¢µÄÊÂ¼þ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                wAlarmInNo = new ushort[128];
                byRes = new byte[44];
            }
        }

        //ÒÆ¶¯Õì²â
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotDetChanNo;//ÒÆ¶¯Õì²âÍ¨µÀ£¬byMotDetChanNo[0]ÈôÖÃ1Ôò±íÊ¾²éÕÒÓÉÍ¨µÀ1·¢ÉúÒÆ¶¯Õì²â´¥·¢µÄÊÂ¼þ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byMotDetChanNo = new byte[MAX_CHANNUM_V30];
                byRes = new byte[SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30];
            }
        }

        //ÒÆ¶¯Õì²â--°´Öµ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
            public ushort[] wMotDetChanNo;//±¨¾¯ÊäÈëºÅ£¬byAlarmInNo[0]ÈôÖÃ1Ôò±íÊ¾²éÕÒÓÉ±¨¾¯ÊäÈë1´¥·¢µÄÊÂ¼þ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 172, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                wMotDetChanNo = new ushort[64];
                byRes = new byte[172];
            }
        }

        //ÐÐÎª·ÖÎö
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChanNo;//´¥·¢ÊÂ¼þµÄÍ¨µÀ
            public byte byRuleID;//¹æÔòID£¬0xff±íÊ¾È«²¿
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 235, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£Áô

            public void init()
            {
                byChanNo = new byte[MAX_CHANNUM_V30];
                byRes1 = new byte[235];
            }
        }

        //ÐÐÎª·ÖÎö--°´Öµ·½Ê½²éÕÒ 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
            public ushort[] wChanNo;	//´¥·¢ÊÂ¼þµÄÍ¨µÀ			
            public byte byRuleID;      //ÐÐÎª·ÖÎöÀàÐÍ£¬¹æÔò0xff±íÊ¾È«²¿£¬´Ó0¿ªÊ¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 171, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	 /*±£Áô*/
            public void init()
            {
                wChanNo = new ushort[64];
                byRes = new byte[171];
            }
        }

        //ÉóÑ¶ÊÂ¼þËÑË÷Ìõ¼þ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_INQUEST_PARAM
        {
            public byte byRoomIndex;    //ÉóÑ¶ÊÒ±àºÅ,´Ó1¿ªÊ¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 299, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£Áô
            public void init()
            {
                byRes = new byte[299];
            }
        }

        //ÖÇÄÜÕì²â²éÕÒÌõ¼þ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCADETECT_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;//´¥·¢ÖÇÄÜÕì²âµÄÍ¨µÀºÅ£¬°´Êý×éÏÂ±ê±íÊ¾£¬byChan[0]ÈôÖÃ1Ôò±íÊ¾²éÕÒÓÉÍ¨µÀ1·¢ÉúÒÆ¶¯Õì²â´¥·¢µÄÊÂ¼þ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£Áô
            public void init()
            {
                byChan = new byte[256];
                byRes = new byte[44];
            }
        }

        //ÖÇÄÜÕì²â²éÕÒÌõ¼þ £¬Í¨µÀºÅ°´Öµ±íÊ¾
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCADETECT_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30 - 1, ArraySubType = UnmanagedType.U4)]
            public uint[] dwChanNo;// ´¥·¢Í¨µÀºÅ,°´Öµ±íÊ¾£¬0xffffffffÎÞÐ§£¬ÇÒºóÐøÊý¾ÝÒ²±íÊ¾ÎÞÐ§Öµ
            public byte byAll;//0-±íÊ¾²»ÊÇÈ«²¿£¬1-±íÊ¾È«²¿¡£
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 47, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                dwChanNo = new uint[MAX_CHANNUM_V30 - 1];
                byRes = new byte[47];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_STREAMID_PARAM
        {
            public NET_DVR_STREAM_INFO struIDInfo; // Á÷idÐÅÏ¢£¬72×Ö½Ú³¤
            public uint dwCmdType;  // Íâ²¿´¥·¢ÀàÐÍ£¬NVR½ÓÈëÔÆ´æ´¢Ê¹ÓÃ
            public byte byBackupVolumeNum; //´æµµ¾íºÅ£¬CVRÊ¹ÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 223, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                struIDInfo.init();
                byRes = new byte[223];
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct SEARCH_EVENT_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;
            /* [FieldOffsetAttribute(0)]
             public EVENT_ALARM_BYBIT struAlarmParam;
             [FieldOffsetAttribute(0)]
             public EVENT_ALARM_BYVALUE struAlarmParamByValue;
             [FieldOffsetAttribute(0)]
             public EVENT_MOTION_BYBIT struMotionParam;
             [FieldOffsetAttribute(0)]
             public EVENT_MOTION_BYVALUE struMotionParamByValue;
             [FieldOffsetAttribute(0)]
             public EVENT_VCA_BYBIT struVcaParam;
             [FieldOffsetAttribute(0)]
             public EVENT_VCA_BYVALUE struVcaParamByValue;
             [FieldOffsetAttribute(0)]
             public EVENT_INQUEST_PARAM struInquestParam;
             [FieldOffsetAttribute(0)]
             public EVENT_VCADETECT_BYBIT struVCADetectByBit;
             [FieldOffsetAttribute(0)]
             public EVENT_VCADETECT_BYVALUE struVCADetectByValue;
             [FieldOffsetAttribute(0)]
             public EVENT_STREAMID_PARAM struStreamIDParam;
             * */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEARCH_EVENT_PARAM
        {
            public ushort wMajorType;//0-ÒÆ¶¯Õì²â£¬1-±¨¾¯ÊäÈë, 2-ÖÇÄÜÊÂ¼þ
            public ushort wMinorType;//ËÑË÷´ÎÀàÐÍ- ¸ù¾ÝÖ÷ÀàÐÍ±ä»¯£¬0xffff±íÊ¾È«²¿
            public NET_DVR_TIME struStartTime;//ËÑË÷µÄ¿ªÊ¼Ê±¼ä£¬Í£Ö¹Ê±¼ä: Í¬Ê±Îª(0, 0) ±íÊ¾´Ó×îÔçµÄÊ±¼ä¿ªÊ¼£¬µ½×îºó£¬×îÇ°ÃæµÄ4000¸öÊÂ¼þ
            public NET_DVR_TIME struEndTime;
            public byte byLockType;		// 0xff-È«²¿£¬0-Î´Ëø£¬1-Ëø¶¨
            public byte byValue;			//0-°´Î»±íÊ¾£¬1-°´Öµ±íÊ¾
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô
            public SEARCH_EVENT_UNION uSeniorPara;
        }

        //±¨¾¯ÊäÈë½á¹û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_RET
        {
            public uint dwAlarmInNo;//±¨¾¯ÊäÈëºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes = new byte[SEARCH_EVENT_INFO_LEN];
            }
        }
        //ÒÆ¶¯Õì²â½á¹û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_RET
        {
            public uint dwMotDetNo;//ÒÆ¶¯Õì²âÍ¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes = new byte[SEARCH_EVENT_INFO_LEN];
            }
        }
        //ÐÐÎª·ÖÎö½á¹û 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_RET
        {
            public uint dwChanNo;//´¥·¢ÊÂ¼þµÄÍ¨µÀºÅ
            public byte byRuleID;//¹æÔòID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£Áô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//¹æÔòÃû³Æ
            public NET_VCA_EVENT_UNION uEvent;//ÐÐÎªÊÂ¼þ²ÎÊý£¬wMinorType = VCA_EVENT_TYPE¾ö¶¨ÊÂ¼þÀàÐÍ

            public void init()
            {
                byRes1 = new byte[3];
                byRuleName = new byte[NAME_LEN];
            }
        }

        //ÉóÑ¶ÊÂ¼þ²éÑ¯½á¹û 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_INQUEST_RET
        {
            public byte byRoomIndex;  //ÉóÑ¶ÊÒ±àºÅ,´Ó1¿ªÊ¼
            public byte byDriveIndex; //¿ÌÂ¼»ú±àºÅ,´Ó1¿ªÊ¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±£Áô            
            public uint dwSegmentNo;     //±¾Æ¬¶ÏÔÚ±¾´ÎÉóÑ¶ÖÐµÄÐòºÅ,´Ó1¿ªÊ¼ 
            public ushort wSegmetSize;     //±¾Æ¬¶ÏµÄ´óÐ¡, µ¥Î»M 
            public ushort wSegmentState;   //±¾Æ¬¶Ï×´Ì¬ 0 ¿ÌÂ¼Õý³££¬1 ¿ÌÂ¼Òì³££¬2 ²»¿ÌÂ¼ÉóÑ¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 288, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     //±£Áô

            public void init()
            {
                byRes1 = new byte[6];
                byRes2 = new byte[288];
            }
        }

        //Á÷idÂ¼Ïñ²éÑ¯½á¹û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_STREAMID_RET
        {
            public uint dwRecordType;	//Â¼ÏñÀàÐÍ 0-¶¨Ê±Â¼Ïñ 1-ÒÆ¶¯Õì²â 2-±¨¾¯Â¼Ïñ 3-±¨¾¯|ÒÆ¶¯Õì²â 4-±¨¾¯&ÒÆ¶¯Õì²â 5-ÃüÁî´¥·¢ 6-ÊÖ¶¯Â¼Ïñ 7-Õð¶¯±¨¾¯ 8-»·¾³´¥·¢ 9-ÖÇÄÜ±¨¾¯ 10-»Ø´«Â¼Ïñ
            public uint dwRecordLength;	//Â¼Ïñ´óÐ¡
            public byte byLockFlag;    // Ëø¶¨±êÖ¾ 0£ºÃ»Ëø¶¨ 1£ºËø¶¨
            public byte byDrawFrameType;    // 0£º·Ç³éÖ¡Â¼Ïñ 1£º³éÖ¡Â¼Ïñ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byFileName; 	//ÎÄ¼þÃû
            public uint dwFileIndex;    		// ´æµµ¾íÉÏµÄÎÄ¼þË÷Òý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes1 = new byte[2];
                byFileName = new byte[NAME_LEN];
                byRes = new byte[256];
            }
        }

        //SDK_V35  2009-10-26

        // ±ê¶¨ÅäÖÃÀàÐÍ
        public enum tagCALIBRATE_TYPE
        {
            PDC_CALIBRATE = 0x01,  // PDC ±ê¶¨
            BEHAVIOR_OUT_CALIBRATE = 0x02, //ÐÐÎªÊÒÍâ³¡¾°±ê¶¨  
            BEHAVIOR_IN_CALIBRATE = 0x03,    // ÐÐÎªÊÒÄÚ³¡¾°±ê¶¨ 
            ITS_CALBIRETE = 0x04      //  ½»Í¨ÊÂ¼þ±ê¶¨
        }

        public const int MAX_RECT_NUM = 6;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECT_LIST
        {
            public byte byRectNum;    // ¾ØÐÎ¿òµÄ¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±£Áô×Ö½Ú 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struVcaRect; // ×î´óÎª6¸öRect 
        }

        // PDC ±ê¶¨²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_CALIBRATION
        {
            public NET_DVR_RECT_LIST struRectList;       // ±ê¶¨¾ØÐÎ¿òÁÐ±í
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±£Áô×Ö½Ú 
        }

        // ±ê¶¨ÏßµÄÊôÐÔÀà±ð£¬ÓÃÀ´±íÊ¾µ±Ç°±ê¶¨ÏßÔÚÊµ¼Ê±íÊ¾µÄÊÇ¸ß¶ÈÏß»¹ÊÇ³¤¶ÈÏß¡£
        public enum LINE_MODE
        {
            HEIGHT_LINE,        //¸ß¶ÈÑù±¾Ïß
            LENGTH_LINE        //³¤¶ÈÑù±¾Ïß
        }
        /*ÔÚÉèÖÃ±ê¶¨ÐÅÏ¢µÄÊ±ºò£¬Èç¹ûÏàÓ¦Î»ÉèÖÃÁËÊ¹ÄÜ£¬²¢ÉèÖÃÏà¹Ø²ÎÊý£¬ÈôÃ»ÓÐÉèÖÃÊ¹ÄÜ£¬Ôò±ê¶¨ºó¿ÉÒÔ»ñÈ¡Ïà¹ØµÄÉãÏñ»ú²ÎÊý*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERA_PARAM
        {
            public byte byEnableHeight;     // ÊÇ·ñÊ¹ÄÜÉèÖÃÉãÏñ»ú¸ß¶ÈÏß
            public byte byEnableAngle;      // ÊÇ·ñÊ¹ÄÜÉèÖÃÉãÏñ»ú¸©Ñö½Ç¶È
            public byte byEnableHorizon;    // ÊÇ·ñÊ¹ÄÜÉèÖÃÉãÏñ»úµØÆ½Ïß
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±£Áô×Ö½Ú 
            public float fCameraHeight;    // ÉãÏñ»ú¸ß¶È
            public float fCameraAngle;     // ÉãÏñ»ú¸©Ñö½Ç¶È
            public float fHorizon;         // ³¡¾°ÖÐµÄµØÆ½Ïß
        }

        /*µ±fValue±íÊ¾Ä¿±ê¸ß¶ÈµÄÊ±ºò£¬struStartPointºÍstruEndPoint·Ö±ð±íÊ¾Ä¿±êÍ·²¿µãºÍ½Å²¿µã¡£
         * µ±fValue±íÊ¾Ïß¶Î³¤¶ÈµÄÊ±ºò£¬struStartPointºÍstruEndPoint·Ö±ð±íÊ¾Ïß¶ÎÆðÊ¼µãºÍÖÕµã£¬
         * mode±íÊ¾µ±Ç°Ñù±¾Ïß±íÊ¾¸ß¶ÈÏß»¹ÊÇ³¤¶ÈÏß¡£*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LINE_SEGMENT
        {
            public byte byLineMode;     // ²ÎÕÕ LINE_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±£Áô×Ö½Ú 
            public NET_VCA_POINT struStartPoint;
            public NET_VCA_POINT struEndPoint;
            public float fValue;
        }

        public const int MAX_LINE_SEG_NUM = 8;

        /*±ê¶¨Ñù±¾ÏßÄ¿Ç°ÐèÒª4-8µ÷Ñù±¾Ïß£¬ÒÔ»ñÈ¡ÉãÏñ»úÏà¹Ø²ÎÊý*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BEHAVIOR_OUT_CALIBRATION
        {
            public uint dwLineSegNum;          // Ñù±¾Ïß¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINE_SEG_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LINE_SEGMENT[] struLineSegment;    // Ñù±¾Ïß×î´ó¸öÊý
            public NET_DVR_CAMERA_PARAM struCameraParam;    // ÉãÏñ»ú²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*¸Ã½á¹¹Ìå±íÊ¾IASÖÇÄÜ¿â±ê¶¨Ñù±¾£¬ÆäÖÐ°üÀ¨Ò»¸öÄ¿±ê¿òºÍÒ»Ìõ¶ÔÓ¦µÄ¸ß¶È±ê¶¨Ïß£»
         * Ä¿±ê¿òÎªÕ¾Á¢µÄÈËÌåÍâ½Ó¾ØÐÎ¿ò£»¸ß¶ÈÏßÑù±¾±êÊ¶´ÓÈËÍ·¶¥µãµ½½ÅµãµÄ±ê¶¨Ïß£»ÓÃ¹éÒ»»¯×ø±ê±íÊ¾£»*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IN_CAL_SAMPLE
        {
            public NET_VCA_RECT struVcaRect;   // Ä¿±ê¿ò
            public NET_DVR_LINE_SEGMENT struLineSegment;    // ¸ß¶È±ê¶¨Ïß
        }

        public const int MAX_SAMPLE_NUM = 5;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BEHAVIOR_IN_CALIBRATION
        {
            public uint dwCalSampleNum;      //  ±ê¶¨Ñù±¾¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SAMPLE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IN_CAL_SAMPLE[] struCalSample; // ±ê¶¨Ñù±¾×î´ó¸öÊý
            public NET_DVR_CAMERA_PARAM struCameraParam;    // ÉãÏñ»ú²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int CALIB_PT_NUM = 4;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ITS_CALIBRATION
        {
            public uint dwPointNum; //±ê¶¨µãÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CALIB_PT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POINT[] struPoint; //Í¼Ïñ×ø±ê
            public float fWidth;
            public float fHeight;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        // ±£Áô×Ö½Ú
        }

        // ±ê¶¨²ÎÊýÁªºÏÌå
        // ºóÐøµÄÏà¹Ø±ê¶¨²ÎÊý¿ÉÒÔ·ÅÔÚ¸Ã½á¹¹ÀïÃæ
        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_CALIBRATION_PRARM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //ÁªºÏÌå½á¹¹´óÐ¡
            /*[FieldOffsetAttribute(0)]
            public NET_DVR_PDC_CALIBRATION struPDCCalibration;  //PDC ±ê¶¨²ÎÊý
            [FieldOffsetAttribute(0)]
            public NET_DVR_BEHAVIOR_OUT_CALIBRATION  struBehaviorOutCalibration;  //  ÐÐÎªÊÒÍâ³¡¾°±ê¶¨  Ö÷ÒªÓ¦ÓÃÓÚIVSµÈ
            [FieldOffsetAttribute(0)]
            public NET_DVR_BEHAVIOR_IN_CALIBRATION  struBehaviorInCalibration;     // ÐÐÎªÊÒÄÚ³¡¾°±ê¶¨£¬Ö÷ÒªÓ¦ÓÃIASµÈ 
            [FieldOffsetAttribute(0)]
            public NET_DVR_ITS_CALIBRATION struITSCalibration;
             * */
        }

        // ±ê¶¨ÅäÖÃ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CALIBRATION_CFG
        {
            public uint dwSize;               //±ê¶¨½á¹¹´óÐ¡
            public byte byEnable;           // ÊÇ·ñÆôÓÃ±ê¶¨
            public byte byCalibrationType;    // ±ê¶¨ÀàÐÍ ¸ù¾Ý²»Í¬ÀàÐÍÔÚÁªºÏÌåÀàÑ¡Ôñ²»Í¬µÄ±ê¶¨ ²Î¿¼CALIBRATE_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_CALIBRATION_PRARM_UNION uCalibrateParam;  // ±ê¶¨²ÎÊýÁªºÏÌå
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //Á÷Á¿Í³¼Æ·½Ïò½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_ENTER_DIRECTION
        {
            public NET_VCA_POINT struStartPoint; //Á÷Á¿Í³¼Æ·½ÏòÆðÊ¼µã
            public NET_VCA_POINT struEndPoint;    // Á÷Á¿Í³¼Æ·½Ïò½áÊøµã 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_RULE_CFG
        {
            public uint dwSize;              //½á¹¹´óÐ¡
            public byte byEnable;             // ÊÇ·ñ¼¤»î¹æÔò;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // ±£Áô×Ö½Ú 
            public NET_VCA_POLYGON struPolygon;            // ¶à±ßÐÎ
            public NET_DVR_PDC_ENTER_DIRECTION struEnterDirection;    // Á÷Á¿½øÈë·½Ïò
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_RULE_CFG_V41
        {
            public uint dwSize;              //½á¹¹´óÐ¡
            public byte byEnable;             // ÊÇ·ñ¼¤»î¹æÔò;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // ±£Áô×Ö½Ú 
            public NET_VCA_POLYGON struPolygon;            // ¶à±ßÐÎ
            public NET_DVR_PDC_ENTER_DIRECTION struEnterDirection;    // Á÷Á¿½øÈë·½Ïò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME struAlarmTime;//²¼·ÀÊ±¼ä
            public NET_DVR_TIME_EX struDayStartTime; //°×Ìì¿ªÊ¼Ê±¼ä£¬Ê±·ÖÃëÓÐÐ§
            public NET_DVR_TIME_EX struNightStartTime; //Ò¹Íí¿ªÊ¼Ê±¼ä£¬Ê±·ÖÃëÓÐÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±£Áô×Ö½Ú
        }

        //ÊÔÓÃ°æÐÅÏ¢½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRIAL_VERSION_CFG
        {
            public uint dwSize;
            public ushort wReserveTime; //ÊÔÓÃÆÚÊ£ÓàÊ±¼ä£¬0xffff±íÊ¾ÎÞÐ§£¬µ¥Î»£ºÌì
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SYN_CHANNEL_NAME_PARAM
        {
            public uint dwSize;
            public uint dwChannel; //Í¨µÀºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RESET_COUNTER_CFG
        {
            public uint dwSize;
            public byte byEnable; //ÊÇ·ñÆôÓÃ£¬0-²»ÆôÓÃ£¬1-ÆôÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_TIME_EX[] struTime;//Êý¾ÝÇåÁãÊ±¼ä£¬Ê±·ÖÃëÓÐÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CTRLINFO_COND
        {
            public uint dwSize;
            public NET_DVR_STREAM_INFO struStreamInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CTRLINFO_CFG
        {
            public uint dwSize;
            public byte byVCAEnable;     //ÊÇ·ñ¿ªÆôÖÇÄÜ
            public byte byVCAType;       //ÖÇÄÜÄÜÁ¦ÀàÐÍ£¬VCA_CHAN_ABILITY_TYPE 
            public byte byStreamWithVCA; //ÂëÁ÷ÖÐÊÇ·ñ´øÖÇÄÜÐÅÏ¢
            public byte byMode;			//Ä£Ê½£¬ATM ÄÜÁ¦Ê±²ÎÕÕVCA_CHAN_MODE_TYPE ,TFS ÄÜÁ¦Ê±²ÎÕÕ TFS_CHAN_MODE_TYPE£¬ÐÐÎª·ÖÎöÍêÕû°æÊ±²ÎÕÕBEHAVIOR_SCENE_MODE_TYPE
            public byte byControlType;   //¿ØÖÆÀàÐÍ£¬°´Î»±íÊ¾£¬0-·ñ£¬1-ÊÇ
                                         //byControlType &1 ÊÇ·ñÆôÓÃ×¥ÅÄ¹¦ÄÜ
                                         //byControlType &2 ÊÇ·ñÆôÓÃÁª¶¯Ç°¶ËÉè±¸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 83, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 		//±£Áô£¬ÉèÖÃÎª0
        }

        /*ÉèÖÃÈËÁ÷Á¿Í³¼Æ²ÎÊý  ¸´ÓÃÐÐÎªÄÚ²¿¹Ø¼ü×Ö²ÎÊý
         * HUMAN_GENERATE_RATE
         * Ä¿±êÉú³ÉËÙ¶È²ÎÊý£¬¿ØÖÆPDC¿âÉú³ÉÄ¿±êµÄËÙ¶È¡£ËÙ¶ÈÔ½¿ì£¬Ä¿±êÔ½ÈÝÒ×Éú³É¡£
         * µ±ÊäÈëÊÓÆµ¹âÕÕÌõ¼þ½Ï²î£¬¶Ô±È¶È½ÏµÍÊ±£¬»òÕßÉèÖÃµÄ¹æÔòÇøÓò½ÏÐ¡Ê±£¬Ó¦¼Ó¿ìÄ¿±êÉú³ÉËÙ¶È£¬ ±ÜÃâÄ¿±êµÄÂ©¼ì£»
         * µ±ÊäÈëÊÓÆµÖÐ¶Ô±È¶È½Ï¸ßÊ±£¬»òÕß¹æÔòÇøÓò½Ï´óÊ±£¬Ó¦¸Ã½µµÍÄ¿±êÉú³ÉËÙ¶È£¬ÒÔ¼õÉÙÎó¼ì¡£
         * Ä¿±êÉú³ÉËÙ¶È²ÎÊý¹²ÓÐ5¼¶£¬1¼¶ËÙ¶È×îÂý£¬5¼¶×î¿ì£¬Ä¬ÈÏ²ÎÊýÎª3¡£
         *
         * DETECT_SENSITIVE
         * Ä¿±ê¼ì²âÁéÃô¶È¿ØÖÆ²ÎÊý£¬¿ØÖÆPDC¿âÖÐÒ»¸ö¾ØÐÎÇøÓò±»¼ì²âÎªÄ¿±êµÄÁéÃô¶È¡£
         * ÁéÃô¶ÈÔ½¸ß£¬¾ØÐÎÇøÓòÔ½ÈÝÒ×±»¼ì²âÎªÄ¿±ê£¬ÁéÃô¶ÈÔ½µÍÔòÔ½ÄÑ¼ì²âÎªÄ¿±ê¡£
         * µ±ÊäÈëÊÓÆµ¹âÕÕÌõ¼þ½Ï²î£¬¶Ô±È¶È½ÏµÍÊ±£¬Ó¦Ìá¸ß¼ì²âÁéÃô¶È£¬ ±ÜÃâÄ¿±êµÄÂ©¼ì£»
         * µ±ÊäÈëÊÓÆµÖÐ¶Ô±È¶È½Ï¸ßÊ±£¬Ó¦¸Ã½µµÍ¼ì²âÁéÃô¶È£¬ÒÔ¼õÉÙÎó¼ì¡£
         * ¶ÔÓ¦²ÎÊý¹²ÓÐ5¼¶£¬¼¶±ð1ÁéÃô¶È×îµÍ£¬5¼¶×î¸ß£¬Ä¬ÈÏ¼¶±ðÎª3¡£
         * 
         * TRAJECTORY_LEN
         * ¹ì¼£Éú³É³¤¶È¿ØÖÆ²ÎÊý£¬±íÊ¾Éú³É¹ì¼£Ê±ÒªÇóÄ¿±êµÄ×î´óÎ»ÒÆÏñËØ¡£
         * ¶ÔÓ¦²ÎÊý¹²ÓÐ5¼¶£¬¼¶±ð1£¬Éú³É³¤¶È×î³¤£¬¹ì¼£Éú³É×îÂý£¬5¼¶Éú³É³¤¶È×î¶Ì£¬¹ì¼£Éú³É×î¿ì£¬Ä¬ÈÏ¼¶±ðÎª3¡£
         * 
         * TRAJECT_CNT_LEN
         * ¹ì¼£¼ÆÊý³¤¶È¿ØÖÆ²ÎÊý£¬±íÊ¾¹ì¼£¼ÆÊýÊ±ÒªÇóÄ¿±êµÄ×î´óÎ»ÒÆÏñËØ¡£
         * ¶ÔÓ¦²ÎÊý¹²ÓÐ5¼¶£¬¼¶±ð1£¬¼ÆÊýÒªÇó³¤¶È×î³¤£¬¹ì¼£¼ÆÊý×îÂý£¬5¼¶¼ÆÊýÒªÇó³¤¶È×î¶Ì£¬¹ì¼£¼ÆÊý×î¿ì£¬Ä¬ÈÏ¼¶±ðÎª3¡£
         * 
         * PREPROCESS
         * Í¼ÏñÔ¤´¦Àí¿ØÖÆ²ÎÊý£¬0 - ²»´¦Àí£»1 - ´¦Àí¡£Ä¬ÈÏÎª0£»
         * 
         * CAMERA_ANGLE
         * ÉãÏñ»ú½Ç¶ÈÊäÈë²ÎÊý£¬ 0 - ÇãÐ±£» 1 - ´¹Ö±¡£Ä¬ÈÏÎª0£»
         */

        public enum PDC_PARAM_KEY
        {
            HUMAN_GENERATE_RATE = 50,  // Ä¿±êÉú³ÉËÙ¶È ´Ó50¿ªÊ¼
            DETECT_SENSITIVE = 51,  // ¼ì²âÁéÃô¶È
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_TARGET_INFO
        {
            public uint dwTargetID;                 // Ä¿±êid 
            public NET_VCA_RECT struTargetRect;    // Ä¿±ê¿ò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_TARGET_IN_FRAME
        {
            public byte byTargetNum;                   //Ä¿±ê¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] yRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TARGET_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PDC_TARGET_INFO[] struTargetInfo;   //Ä¿±êÐÅÏ¢Êý×é
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                  // ±£Áô×Ö½Ú
        }

        //µ¥Ö¡Í³¼Æ½á¹ûÊ±Ê¹ÓÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_STATFRAME
        {
            public uint dwRelativeTime;     // Ïà¶ÔÊ±±ê
            public uint dwAbsTime;          // ¾ø¶ÔÊ±±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_STATTIME
        {
            public NET_DVR_TIME tmStart; // Í³¼ÆÆðÊ¼Ê±¼ä 
            public NET_DVR_TIME tmEnd;  //  Í³¼Æ½áÊøÊ±¼ä 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_PDCPARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 140, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_ALRAM_INFO
        {
            public uint dwSize;           // PDCÈËÁ÷Á¿±¨¾¯ÉÏ´«½á¹¹Ìå´óÐ¡
            public byte byMode;            // 0 µ¥Ö¡Í³¼Æ½á¹û 1×îÐ¡Ê±¼ä¶ÎÍ³¼Æ½á¹û  
            public byte byChannel;           // ±¨¾¯ÉÏ´«Í¨µÀºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;         // ±£Áô×Ö½Ú   
            public NET_VCA_DEV_INFO struDevInfo;		        //Ç°¶ËÉè±¸ÐÅÏ¢
            public UNION_PDCPARAM uStatModeParam;
            public uint dwLeaveNum;        // Àë¿ªÈËÊý
            public uint dwEnterNum;        // ½øÈëÈËÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;           // ±£Áô×Ö½Ú
        }

        //ÈËÁ÷Á¿ÐÅÏ¢²éÑ¯
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_QUERY
        {
            public NET_DVR_TIME tmStart;
            public NET_DVR_TIME tmEnd;
            public uint dwLeaveNum;
            public uint dwEnterNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZ_POSITION
        {
            // ÊÇ·ñÆôÓÃ³¡¾°£¬ÔÚÉèÖÃ³¡¾°ÐÐÎª¹æÔòµÄÊ±ºò¸Ã×Ö¶ÎÎÞÐ§£¬ÔÚÉèÖÃÇò»ú±¾µØÅäÖÃ³¡¾°Î»ÖÃÐÅÏ¢Ê±×÷ÎªÊ¹ÄÜÎ»
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±£Áô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPtzPositionName; //³¡¾°Î»ÖÃÃû³Æ
            public NET_DVR_PTZPOS struPtzPos; //ptz ×ø±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_RULE_CFG
        {
            public uint dwSize;             // ½á¹¹´óÐ¡ 
            public NET_DVR_PTZ_POSITION struPtzPosition;    // ³¡¾°Î»ÖÃÐÅÏ¢
            public NET_VCA_RULECFG struVcaRuleCfg;     //ÐÐÎª¹æÔòÅäÖÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_RULE_CFG_V41
        {
            public uint dwSize;             // ½á¹¹´óÐ¡ 
            public NET_DVR_PTZ_POSITION struPtzPosition;    // ³¡¾°Î»ÖÃÐÅÏ¢
            public NET_VCA_RULECFG_V41 struVcaRuleCfg;     //ÐÐÎª¹æÔòÅäÖÃ
            public byte byTrackEnable; //ÊÇ·ñÆôÓÃ¸ú×Ù
            public byte byRes1;
            public ushort wTrackDuration; //¸ú×Ù³ÖÐøÊ±¼ä£¬µ¥Î»s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LIMIT_ANGLE
        {
            public byte byEnable;	// ÊÇ·ñÆôÓÃ³¡¾°ÏÞÎ»¹¦ÄÜ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_PTZPOS struUp;     // ÉÏÏÞÎ»
            public NET_DVR_PTZPOS struDown;   // ÏÂÏÞÎ»
            public NET_DVR_PTZPOS struLeft;   // ×óÏÞÎ»
            public NET_DVR_PTZPOS struRight;  // ÓÒÏÞÎ»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_INDEX
        {
            public byte byIndex;    // ³¡¾°Ë÷Òý
            public byte byRes1;
            public ushort wDwell;	// Í£ÁôÊ±¼ä 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   // ±£Áô×Ö½Ú
        }

        public const int MAX_POSITION_NUM = 10;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_TRACK_CFG
        {
            public uint dwSize;
            public byte byNum; // ³¡¾°¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_POSITION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_POSITION_INDEX[] struPositionIndex;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //Ñ²º½Â·¾¶³¡¾°ÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PATROL_SCENE_INFO
        {
            public ushort wDwell;         // Í£ÁôÊ±¼ä 30-300
            public byte byPositionID;   // ³¡¾°ºÅ1-10£¬Ä¬ÈÏ0±íÊ¾¸ÃÑ²º½µã²»Ìí¼Ó³¡¾°
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //³¡¾°Ñ²º½¸ú×ÙÅäÖÃÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PATROL_TRACKCFG
        {
            public uint dwSize;  // ½á¹¹´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PATROL_SCENE_INFO[] struPatrolSceneInfo;    // Ñ²º½Â·¾¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                              // ±£Áô×Ö½Ú
        }

        //Çò»ú±¾µØ¹æÔò²Ëµ¥ÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_PARAMCFG
        {
            public uint dwSize;             // ½á¹¹´óÐ¡
            public ushort wAlarmDelayTime;    // ±¨¾¯ÑÓÊ±Ê±¼ä£¬Ä¿Ç°Çò»úÖ»Ö§³ÖÈ«¾ÖÈëÇÖ ·¶Î§1-120Ãë
            public ushort wTrackHoldTime;     // ±¨¾¯¸ú×Ù³ÖÐøÊ±¼ä  ·¶Î§0-300Ãë
            public byte byTrackMode;        //  ²ÎÕÕ IPDOME_TRACK_MODE
            public byte byPreDirection;	// ¸ú×Ù·½ÏòÔ¤ÅÐ 0-²»ÆôÓÃ 1-ÆôÓÃ
            public byte byTrackSmooth;	    // ¸ú×ÙÁ¬Ðø  0-²»ÆôÓÃ 1-ÆôÓÃ
            public byte byZoomAdjust;	// ±¶ÂÊÏµÊýµ÷Õû ²Î¼ûÏÂ±í
            public byte byMaxTrackZoom;	//×î´ó¸ú×Ù±¶ÂÊÏµÊý,0-±íÊ¾Ä¬ÈÏ±¶ÂÊÏµÊý,µÈ¼¶6-±ê¶¨Öµ*1.0(Ä¬ÈÏ),1-5ÎªËõÐ¡±ê¶¨Öµ£¬ÖµÔ½Ð¡£¬ËõÐ¡µÄ±ÈÀýÔ½´ó,7-15Îª·Å´ó£¬ÖµÔ½´ó£¬·Å´óµÄ±ÈÀýÔ½´ó
            public byte byStopTrackWhenFindFace;  //ÈËÁ³¼ì²âµ½ºóÊÇ·ñÍ£Ö¹¸ú×Ù 0-·ñ 1-ÊÇ
            public byte byStopTrackThreshold;   //¸ú×ÙÖÕÖ¹ÆÀ·ÖãÐÖµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //  ±£Áô×Ö½Ú                
        }

        //Çò»ú»úÐ¾²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DOME_MOVEMENT_PARAM
        {
            public ushort wMaxZoom;   // Çò»ú×î´ó±¶ÂÊÏµÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 42, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±£Áô×Ö½Ú
        }

        /********************************ÖÇÄÜ½»Í¨ÊÂ¼þ begin****************************************/
        public const int MAX_REGION_NUM = 8;  // ÇøÓòÁÐ±í×î´óÊýÄ¿
        public const int MAX_TPS_RULE = 8;   // ×î´ó²ÎÊý¹æÔòÊýÄ¿
        public const int MAX_AID_RULE = 8;   // ×î´óÊÂ¼þ¹æÔòÊýÄ¿
        public const int MAX_LANE_NUM = 8;   // ×î´ó³µµÀÊýÄ¿

        //½»Í¨ÊÂ¼þÀàÐÍ
        public enum TRAFFIC_AID_TYPE
        {
            CONGESTION = 0x01,    //Óµ¶Â
            PARKING = 0x02,    //Í£³µ  
            INVERSE = 0x04,    //ÄæÐÐ
            PEDESTRIAN = 0x08,    //ÐÐÈË                      
            DEBRIS = 0x10,    //ÒÅÁôÎï Å×È÷ÎïËéÆ¬ 
            SMOKE = 0x20,    //ÑÌÎí  
            OVERLINE = 0x40,     //Ñ¹Ïß
            VEHICLE_CONTROL_LIST = 0x80,  //ºÚÃûµ¥Êý¾Ý
            SPEED = 0x100  //³¬ËÙ
        }

        public enum TRAFFIC_SCENE_MODE
        {
            FREEWAY = 0,    //  ¸ßËÙ»§Íâ³¡¾°
            TUNNEL,         //  ¸ßËÙËíµÀ³¡¾°
            BRIDGE          //  ¸ßËÙÇÅÁº³¡¾°
        }

        public enum ITS_ABILITY_TYPE
        {
            ITS_CONGESTION_ABILITY = 0x01,      //Óµ¶Â
            ITS_PARKING_ABILITY = 0x02,      //Í£³µ  
            ITS_INVERSE_ABILITY = 0x04,      //ÄæÐÐ
            ITS_PEDESTRIAN_ABILITY = 0x08,      //ÐÐÈË                      
            ITS_DEBRIS_ABILITY = 0x10,      //ÒÅÁôÎï Å×È÷ÎïËéÆ¬
            ITS_SMOKE_ABILITY = 0x20,      //ÑÌÎí-ËíµÀ
            ITS_OVERLINE_ABILITY = 0x40,      //Ñ¹Ïß
            ITS_VEHICLE_CONTROL_LIST_ABILITY = 0x80,        //ºÚÃûµ¥Êý¾Ý
            ITS_SPEED_ABILITY = 0x100,	    //³¬ËÙ	
            ITS_LANE_VOLUME_ABILITY = 0x010000,  //³µµÀÁ÷Á¿
            ITS_LANE_VELOCITY_ABILITY = 0x020000,  //³µµÀÆ½¾ùËÙ¶È
            ITS_TIME_HEADWAY_ABILITY = 0x040000,  //³µÍ·Ê±¾à
            ITS_SPACE_HEADWAY_ABILITY = 0x080000,  //³µÍ·¼ä¾à
            ITS_TIME_OCCUPANCY_RATIO_ABILITY = 0x100000,  //³µµÀÕ¼ÓÐÂÊ£¬£¨Ê±¼äÉÏ)
            ITS_SPACE_OCCUPANCY_RATIO_ABILITY = 0x200000,  //³µµÀÕ¼ÓÐÂÊ£¬°Ù·Ö±È¼ÆËã£¨¿Õ¼äÉÏ)
            ITS_LANE_QUEUE_ABILITY = 0x400000,  //ÅÅ¶Ó³¤¶È
            ITS_VEHICLE_TYPE_ABILITY = 0x800000,  //³µÁ¾ÀàÐÍ
            ITS_TRAFFIC_STATE_ABILITY = 0x1000000  //½»Í¨×´Ì¬
        }

        // ½»Í¨Í³¼Æ²ÎÊý
        public enum ITS_TPS_TYPE
        {
            LANE_VOLUME = 0x01,    //³µµÀÁ÷Á¿
            LANE_VELOCITY = 0x02,    //³µµÀËÙ¶È
            TIME_HEADWAY = 0x04,    //³µÍ·Ê±¾à
            SPACE_HEADWAY = 0x08,    //³µÍ·¼ä¾à
            TIME_OCCUPANCY_RATIO = 0x10,    //³µµÀÕ¼ÓÐÂÊ (Ê±¼äÉÏ)
            SPACE_OCCUPANCY_RATIO = 0x20,    //³µµÀÕ¼ÓÐÂÊ£¬°Ù·Ö±È¼ÆËã(¿Õ¼äÉÏ)
            QUEUE = 0x40,    //ÅÅ¶Ó³¤¶È
            VEHICLE_TYPE = 0x80,    //³µÁ¾ÀàÐÍ
            TRAFFIC_STATE = 0x100    //½»Í¨×´Ì¬
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REGION_LIST
        {
            public uint dwSize;	// ½á¹¹Ìå´óÐ¡
            public byte byNum;      // ÇøÓò¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    // ±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_REGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POLYGON[] struPolygon; // ÇøÓò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	// ±£Áô×Ö½Ú
        }

        //·½Ïò½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIRECTION
        {
            public NET_VCA_POINT struStartPoint;   // ·½ÏòÆðÊ¼µã
            public NET_VCA_POINT struEndPoint;     // ·½Ïò½áÊøµã 
        }

        //µ¥¸ö³µµÀ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_LANE
        {
            public byte byEnable;  //³µµÀÊÇ·ñÆôÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	   // ±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLaneName;       // ³µµÀ¹æÔòÃû³Æ
            public NET_DVR_DIRECTION struFlowDirection;// ³µµÀÄÚ³µÁ÷·½Ïò
            public NET_VCA_POLYGON struPolygon;		// ³µµÀÇøÓò
        }

        //³µµÀÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_CFG
        {
            public uint dwSize;	// ½á¹¹Ìå´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_LANE[] struLane;	// ³µµÀ²ÎÊý Êý×éÏÂ±ê×÷Îª³µµÀID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	 // ±£Áô×Ö½Ú
        }

        //½»Í¨ÊÂ¼þ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_PARAM
        {
            public ushort wParkingDuration;       // Î¥Í£¼ì²âÁéÃô¶È  10-120s
            public ushort wPedestrianDuration;    // ÐÐÈË³ÖÐøÊ±¼ä    1-120s
            public ushort wDebrisDuration;        // Å×È÷Îï³ÖÐøÊ±¼ä  10-120s
            public ushort wCongestionLength;      // Óµ¶Â³¤¶ÈãÐÖµ    5-200£¨Ã×£©
            public ushort wCongestionDuration;    // Óµ¶Â³ÖÐø²ÎÊý    10-120s
            public ushort wInverseDuration;       // ÄæÐÐ³ÖÐøÊ±¼ä    1-10s
            public ushort wInverseDistance;       // ÄæÐÐ¾àÀëãÐÖµ µ¥Î»m ·¶Î§[2-100] Ä¬ÈÏ 10Ã×
            public ushort wInverseAngleTolerance; // ÔÊÐí½Ç¶ÈÆ«²î 90-180¶È,³µÁ÷ÓëÄæÐÐÔÊÐíµÄ¼Ð½Ç
            public ushort wIllegalParkingTime;    // Î¥Í£Ê±¼ä[4,60]£¬µ¥Î»£º·ÖÖÓ ,TFS(½»Í¨Î¥ÕÂÈ¡Ö¤) ³ÇÊÐÄ£Ê½ÏÂ
            public ushort wIllegalParkingPicNum;  // Î¥Í£Í¼Æ¬ÊýÁ¿[1,6], TFS(½»Í¨Î¥ÕÂÈ¡Ö¤) ³ÇÊÐÄ£Ê½ÏÂ
            public byte byMergePic;             // Í¼Æ¬Æ´½Ó,TFS ³ÇÊÐÄ£Ê½ÏÂ 0- ²»Æ´½Ó 1- Æ´½Ó
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;             // ±£Áô×Ö½Ú
        }

        //µ¥Ìõ½»Í¨ÊÂ¼þ¹æÔò½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_AID_RULE
        {
            public byte byEnable;                   // ÊÇ·ñÆôÓÃÊÂ¼þ¹æÔò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                  // ±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;       // ¹æÔòÃû³Æ 
            public uint dwEventType;                // ½»Í¨ÊÂ¼þ¼ì²âÀàÐÍ TRAFFIC_AID_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter; // ³ß´ç¹ýÂËÆ÷
            public NET_VCA_POLYGON struPolygon;    // ¹æÔòÇøÓò
            public NET_DVR_AID_PARAM struAIDParam;   //  ÊÂ¼þ²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //´¦Àí·½Ê½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;        //±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ,Îª1±íÊ¾´¥·¢¸ÃÍ¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //½»Í¨ÊÂ¼þ¹æÔò
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_RULECFG
        {
            public uint dwSize;                    // ½á¹¹Ìå´óÐ¡ 
            public byte byPicProType;              //±¨¾¯Ê±Í¼Æ¬´¦Àí·½Ê½ 0-²»´¦Àí ·Ç0-ÉÏ´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                 // ±£Áô×Ö½Ú
            public NET_DVR_JPEGPARA struPictureParam; //Í¼Æ¬¹æ¸ñ½á¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AID_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_AID_RULE[] struOneAIDRule;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //µ¥Ìõ½»Í¨ÊÂ¼þ¹æÔò½á¹¹Ìå(À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_AID_RULE_V41
        {
            public byte byEnable;                 // ÊÇ·ñÆôÓÃÊÂ¼þ¹æÔò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                // ±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;     // ¹æÔòÃû³Æ 
            public uint dwEventType;              // ½»Í¨ÊÂ¼þ¼ì²âÀàÐÍ TRAFFIC_AID_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter;           // ³ß´ç¹ýÂËÆ÷
            public NET_VCA_POLYGON struPolygon;              // ¹æÔòÇøÓò
            public NET_DVR_AID_PARAM struAIDParam;             // ÊÂ¼þ²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;// ²¼·ÀÊ±¼ä¶Î
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	          //´¦Àí·½Ê½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IVMS_IP_CHANNEL, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ£º1±íÊ¾´¥·¢¸ÃÍ¨µÀ£»0±íÊ¾²»´¥·¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;               //±£Áô
        }

        //½»Í¨ÊÂ¼þ¹æÔò(À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_RULECFG_V41
        {
            public uint dwSize;                     // ½á¹¹Ìå´óÐ¡ 
            public byte byPicProType;               // ±¨¾¯Ê±Í¼Æ¬´¦Àí·½Ê½ 0-²»´¦Àí ·Ç0-ÉÏ´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                  // ±£Áô×Ö½Ú
            public NET_DVR_JPEGPARA struPictureParam; 	// Í¼Æ¬¹æ¸ñ½á¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AID_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_AID_RULE_V41[] struAIDRule;  //¹æÔòÊý×é
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                //±£Áô
        }

        //½»Í¨Í³¼Æ²ÎÊý½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_TPS_RULE
        {
            public byte byEnable;                   //ÊÇ·ñÊ¹ÄÜ³µµÀ½»Í¨¹æÔò²ÎÊý
            public byte byLaneID;		            //³µµÀID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwCalcType;                 //Í³¼Æ²ÎÊýÀàÐÍITS_TPS_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter; //³ß´ç¹ýÂËÆ÷ 
            public NET_VCA_POLYGON struVitrualLoop;    //ÐéÄâÏßÈ¦
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	//´¦Àí·½Ê½,Ò»°ãÎª´¦ÀíÊÇ·ñÉÏ´«ÖÐÐÄ£¬ÆäËû¹¦ÄÜ²»ÐèÒª
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                         //±£Áô×Ö½Ú
        }

        //½»Í¨²ÎÊýÍ³¼Æ¹æÔòÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_RULECFG
        {
            public uint dwSize;              // ½á¹¹´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_TPS_RULE[] struOneTpsRule; // ÏÂ±ê¶ÔÓ¦½»Í¨²ÎÊýID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // ±£Áô×Ö½Ú
        }

        //½»Í¨Í³¼Æ²ÎÊý½á¹¹Ìå(À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_TPS_RULE_V41
        {
            public byte byEnable;                     //ÊÇ·ñÊ¹ÄÜ³µµÀ½»Í¨¹æÔò²ÎÊý
            public byte byLaneID;		              //³µµÀID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                    //±£Áô
            public uint dwCalcType;                   // Í³¼Æ²ÎÊýÀàÐÍITS_TPS_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter;  //³ß´ç¹ýÂËÆ÷ 
            public NET_VCA_POLYGON struVitrualLoop; //ÐéÄâÏßÈ¦
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	   //´¦Àí·½Ê½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                   // ±£Áô×Ö½Ú
        }

        //½»Í¨²ÎÊýÍ³¼Æ¹æÔòÅäÖÃ½á¹¹Ìå(À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_RULECFG_V41
        {
            public uint dwSize;         // ½á¹¹´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_TPS_RULE_V41[] struOneTpsRule; // ÏÂ±ê¶ÔÓ¦½»Í¨²ÎÊýID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     // ±£Áô
        }

        //½»Í¨ÊÂ¼þÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_INFO
        {
            public byte byRuleID;   // ¹æÔòÐòºÅ£¬Îª¹æÔòÅäÖÃ½á¹¹ÏÂ±ê£¬0-16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; //  ¹æÔòÃû³Æ
            public uint dwAIDType;  // ±¨¾¯ÊÂ¼þÀàÐÍ
            public NET_DVR_DIRECTION struDirect; // ±¨¾¯Ö¸ÏòÇøÓò  
            public byte bySpeedLimit; //ÏÞËÙÖµ£¬µ¥Î»km/h[0,255]
            public byte byCurrentSpeed; //µ±Ç°ËÙ¶ÈÖµ£¬µ¥Î»km/h[0,255]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;  // ±£Áô×Ö½Ú 
        }

        //½»Í¨ÊÂ¼þ±¨¾¯ 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_ALARM
        {
            public uint dwSize;         // ½á¹¹³¤¶È
            public uint dwRelativeTime;	// Ïà¶ÔÊ±±ê
            public uint dwAbsTime;		// ¾ø¶ÔÊ±±ê
            public NET_VCA_DEV_INFO struDevInfo;	// Ç°¶ËÉè±¸ÐÅÏ¢
            public NET_DVR_AID_INFO struAIDInfo;    // ½»Í¨ÊÂ¼þÐÅÏ¢
            public uint dwPicDataLen;   // ·µ»ØÍ¼Æ¬µÄ³¤¶È Îª0±íÊ¾Ã»ÓÐÍ¼Æ¬£¬´óÓÚ0±íÊ¾¸Ã½á¹¹ºóÃæ½ô¸úÍ¼Æ¬Êý¾Ý
            public IntPtr pImage;        // Ö¸ÏòÍ¼Æ¬µÄÖ¸Õë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±£Áô×Ö½Ú  
        }

        //³µµÀ¶ÓÁÐ½á¹¹Ìå 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_QUEUE
        {
            public NET_VCA_POINT struHead;       //¶ÓÁÐÍ·
            public NET_VCA_POINT struTail;       //¶ÓÁÐÎ²
            public uint dwLength;      //Êµ¼Ê¶ÓÁÐ³¤¶È µ¥Î»ÎªÃ× [0-500]
        }

        public enum TRAFFIC_DATA_VARY_TYPE
        {
            NO_VARY,         //ÎÞ±ä»¯ 
            VEHICLE_ENTER,   //³µÁ¾½øÈëÐéÄâÏßÈ¦
            VEHICLE_LEAVE,   //³µÁ¾Àë¿ªÐéÄâÏßÈ¦ 
            UEUE_VARY        //¶ÓÁÐ±ä»¯             
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;  //³µµÀ¹æÔòÃû³Æ 
            public byte byRuleID;              //¹æÔòÐòºÅ£¬Îª¹æÔòÅäÖÃ½á¹¹ÏÂ±ê£¬0-7 
            public byte byVaryType;            //³µµÀ½»Í¨²ÎÊý±ä»¯ÀàÐÍ ²ÎÕÕ TRAFFIC_DATA_VARY_TYPE
            public byte byLaneType;			   //³µµÀÉÏÐÐ»òÏÂÐÐ
            public byte byRes1;
            public uint dwLaneVolume;         //³µµÀÁ÷Á¿ £¬Í³¼ÆÓÐ¶àÉÙ³µ×ÓÍ¨¹ý
            public uint dwLaneVelocity;        //³µµÀËÙ¶È£¬¹«Àï¼ÆËã
            public uint dwTimeHeadway;         //³µÍ·Ê±¾à£¬ÒÔÃë¼ÆËã
            public uint dwSpaceHeadway;        //³µÍ·¼ä¾à£¬ÒÔÃ×À´¼ÆËã
            public float fSpaceOccupyRation;    //³µµÀÕ¼ÓÐÂÊ£¬°Ù·Ö±È¼ÆËã£¨¿Õ¼äÉÏ)
            public NET_DVR_LANE_QUEUE struLaneQueue;    //³µµÀ¶ÓÁÐ³¤¶È
            public NET_VCA_POINT struRuleLocation; //ÏßÈ¦¹æÔòµÄÖÐÐÄµãÎ»ÖÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_INFO
        {
            public uint dwLanNum;   // ½»Í¨²ÎÊýµÄ³µµÀÊýÄ¿
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LANE_PARAM[] struLaneParam;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_ALARM
        {
            public uint dwSize;          //½á¹¹Ìå´óÐ¡
            public uint dwRelativeTime;  //Ïà¶ÔÊ±±ê
            public uint dwAbsTime;       //¾ø¶ÔÊ±±ê
            public NET_VCA_DEV_INFO struDevInfo;     //Ç°¶ËÉè±¸ÐÅÏ¢
            public NET_DVR_TPS_INFO struTPSInfo;     //½»Í¨ÊÂ¼þÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      //±£Áô×Ö½Ú
        }

        public enum TRAFFIC_DATA_VARY_TYPE_EX_ENUM
        {
            ENUM_TRAFFIC_VARY_NO = 0x00,   //ÎÞ±ä»¯
            ENUM_TRAFFIC_VARY_VEHICLE_ENTER = 0x01,   //³µÁ¾½øÈëÐéÄâÏßÈ¦
            ENUM_TRAFFIC_VARY_VEHICLE_LEAVE = 0x02,   //³µÁ¾Àë¿ªÐéÄâÏßÈ¦
            ENUM_TRAFFIC_VARY_QUEUE = 0x04,   //¶ÓÁÐ±ä»¯
            ENUM_TRAFFIC_VARY_STATISTIC = 0x08,   //Í³¼ÆÊý¾Ý±ä»¯£¨Ã¿·ÖÖÓ±ä»¯Ò»´Î°üÀ¨Æ½¾ùËÙ¶È£¬³µµÀ¿Õ¼ä/Ê±¼äÕ¼ÓÐÂÊ£¬½»Í¨×´Ì¬£©        
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_PARAM_V41
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; // ³µµÀ¹æÔòÃû³Æ
            public byte byRuleID;             // ¹æÔòÐòºÅ£¬Îª¹æÔòÅäÖÃ½á¹¹ÏÂ±ê£¬0-7 
            public byte byLaneType;		     // ³µµÀÉÏÐÐ»òÏÂÐÐ
            public byte byTrafficState;       // ³µµÀµÄ½»Í¨×´Ì¬£¬0-ÎÞÐ§£¬1-³©Í¨£¬2-Óµ¼·£¬3-¶ÂÈû
            public byte byRes1;               // ±£Áô
            public uint dwVaryType;           // ³µµÀ½»Í¨²ÎÊý±ä»¯ÀàÐÍ²ÎÕÕ  TRAFFIC_DATA_VARY_TYPE_EX_ENUM£¬°´Î»Çø·Ö
            public uint dwTpsType;            // Êý¾Ý±ä»¯ÀàÐÍ±êÖ¾£¬±íÊ¾µ±Ç°ÉÏ´«µÄÍ³¼Æ²ÎÊýÖÐ£¬ÄÄÐ©Êý¾ÝÓÐÐ§£¬²ÎÕÕITS_TPS_TYPE,°´Î»Çø·Ö
            public uint dwLaneVolume;	     // ³µµÀÁ÷Á¿£¬Í³¼ÆÓÐ¶àÉÙ³µ×ÓÍ¨¹ý
            public uint dwLaneVelocity;       // ³µµÀËÙ¶È£¬¹«Àï¼ÆËã
            public uint dwTimeHeadway;       // ³µÍ·Ê±¾à£¬ÒÔÃë¼ÆËã
            public uint dwSpaceHeadway;       // ³µÍ·¼ä¾à£¬ÒÔÃ×À´¼ÆËã
            public float fSpaceOccupyRation;   // ³µµÀÕ¼ÓÐÂÊ£¬°Ù·Ö±È¼ÆËã£¨¿Õ¼äÉÏ)
            public float fTimeOccupyRation;    // Ê±¼äÕ¼ÓÐÂÊ£¬°Ù·Ö±È¼ÆËã
            public uint dwLightVehicle;       // Ð¡ÐÍ³µÊýÁ¿
            public uint dwMidVehicle;         // ÖÐÐÍ³µÊýÁ¿
            public uint dwHeavyVehicle;       // ÖØÐÍ³µÊýÁ¿
            public NET_DVR_LANE_QUEUE struLaneQueue;        // ³µµÀ¶ÓÁÐ³¤¶È
            public NET_VCA_POINT struRuleLocation;     // ¹æÔòÎ»ÖÃÐéÄâÏßÈ¦µÄÖÐÐÄ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;           // ±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_INFO_V41
        {
            public uint dwLanNum;          // ½»Í¨²ÎÊýµÄ³µµÀÊýÄ¿
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LANE_PARAM_V41[] struLaneParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±£Áô
        }

        //ÈËÁ³¹æÔòÅäÖÃ 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_RULECFG
        {
            public uint dwSize;              // ½á¹¹Ìå´óÐ¡
            public byte byEnable;            // ÊÇ·ñÆôÓÃ
            public byte byEventType;			//¾¯½äÊÂ¼þÀàÐÍ£¬ 0-Òì³£ÈËÁ³; 1-Õý³£ÈËÁ³;2-Òì³£ÈËÁ³&Õý³£ÈËÁ³;
            public byte byUpLastAlarm;       //2011-04-06 ÊÇ·ñÏÈÉÏ´«×î½üÒ»´ÎµÄ±¨¾¯
            public byte byUpFacePic; //ÊÇ·ñÉÏ´«ÈËÁ³×ÓÍ¼£¬0-·ñ£¬1-ÊÇ	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;
            public NET_VCA_POLYGON struVcaPolygon;    // ÈËÁ³¼ì²â¹æÔòÇøÓò
            public byte byPicProType;	//±¨¾¯Ê±Í¼Æ¬´¦Àí·½Ê½ 0-²»´¦Àí ·Ç0-ÉÏ´«
            public byte bySensitivity;   // ¹æÔòÁéÃô¶È
            public ushort wDuration;      // ´¥·¢ÈËÁ³±¨¾¯Ê±¼äãÐÖµ
            public NET_DVR_JPEGPARA struPictureParam; 		//Í¼Æ¬¹æ¸ñ½á¹¹
            public NET_VCA_SIZE_FILTER struSizeFilter;         //³ß´ç¹ýÂËÆ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //´¦Àí·½Ê½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;			//±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ,Îª1±íÊ¾´¥·¢¸ÃÍ¨µÀ
            public byte byPicRecordEnable;  /*2012-3-1ÊÇ·ñÆôÓÃÍ¼Æ¬´æ´¢, 0-²»ÆôÓÃ, 1-ÆôÓÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         //±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_PIPCFG
        {
            public byte byEnable; //ÊÇ·ñ¿ªÆô»­ÖÐ»­
            public byte byBackChannel; //±³¾°Í¨µÀºÅ£¨Ãæ°åÍ¨µÀ£©
            public byte byPosition; //µþ¼ÓÎ»ÖÃ£¬0-×óÉÏ,1-×óÏÂ,2-ÓÒÉÏ,3-ÓÒÏÂ
            public byte byPIPDiv; //·ÖÆÁÏµÊý(ÈËÁ³»­Ãæ:Ãæ°å»­Ãæ)£¬0-1:4,1-1:9,2-1:16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_RULECFG_V41
        {
            public uint dwSize;              // ½á¹¹Ìå´óÐ¡
            public byte byEnable;            // ÊÇ·ñÆôÓÃ
            public byte byEventType;			//¾¯½äÊÂ¼þÀàÐÍ£¬ 0-Òì³£ÈËÁ³; 1-Õý³£ÈËÁ³;2-Òì³£ÈËÁ³&Õý³£ÈËÁ³;
            public byte byUpLastAlarm;       //2011-04-06 ÊÇ·ñÏÈÉÏ´«×î½üÒ»´ÎµÄ±¨¾¯
            public byte byUpFacePic; //ÊÇ·ñÉÏ´«ÈËÁ³×ÓÍ¼£¬0-·ñ£¬1-ÊÇ	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;
            public NET_VCA_POLYGON struVcaPolygon;    // ÈËÁ³¼ì²â¹æÔòÇøÓò
            public byte byPicProType;	//±¨¾¯Ê±Í¼Æ¬´¦Àí·½Ê½ 0-²»´¦Àí ·Ç0-ÉÏ´«
            public byte bySensitivity;   // ¹æÔòÁéÃô¶È
            public ushort wDuration;      // ´¥·¢ÈËÁ³±¨¾¯Ê±¼äãÐÖµ
            public NET_DVR_JPEGPARA struPictureParam; 		//Í¼Æ¬¹æ¸ñ½á¹¹
            public NET_VCA_SIZE_FILTER struSizeFilter;         //³ß´ç¹ýÂËÆ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //´¦Àí·½Ê½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;			//±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ,Îª1±íÊ¾´¥·¢¸ÃÍ¨µÀ
            public byte byPicRecordEnable;  /*2012-10-22ÊÇ·ñÆôÓÃÍ¼Æ¬´æ´¢, 0-²»ÆôÓÃ, 1-ÆôÓÃ*/
            public byte byRes1;
            public ushort wAlarmDelay; //2012-10-22ÖÇÄÜ±¨¾¯ÑÓÊ±£¬0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
            public NET_DVR_FACE_PIPCFG struFacePIP; //2012-11-7»­ÖÐ»­²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_ALARM
        {
            public uint dwSize;     		// ½á¹¹´óÐ¡
            public uint dwRelativeTime; // Ïà¶ÔÊ±±ê
            public uint dwAbsTime;			// ¾ø¶ÔÊ±±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;   // ¹æÔòÃû³Æ
            public NET_VCA_TARGET_INFO struTargetInfo;	//±¨¾¯Ä¿±êÐÅÏ¢
            public NET_VCA_DEV_INFO struDevInfo;		//Ç°¶ËÉè±¸ÐÅÏ¢
            public uint dwPicDataLen;						//·µ»ØÍ¼Æ¬µÄ³¤¶È Îª0±íÊ¾Ã»ÓÐÍ¼Æ¬£¬´óÓÚ0±íÊ¾¸Ã½á¹¹ºóÃæ½ô¸úÍ¼Æ¬Êý¾Ý*/
            public byte byAlarmPicType;			// 0-Òì³£ÈËÁ³±¨¾¯Í¼Æ¬ 1- ÈËÁ³Í¼Æ¬,2-¶àÕÅÈËÁ³ 
            public byte byPanelChan;        /*2012-3-1ÈËÁ³Í¨µÀ¹ØÁªµÄÃæ°åÍ¨µÀ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwFacePicDataLen;			//ÈËÁ³Í¼Æ¬µÄ³¤¶È Îª0±íÊ¾Ã»ÓÐÍ¼Æ¬£¬´óÓÚ0±íÊ¾¸Ã½á¹¹ºóÃæ½ô¸úÍ¼Æ¬Êý¾Ý*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±£Áô×Ö½Ú
            public IntPtr pFaceImage; //Ö¸ÏòÈËÁ³Í¼Ö¸Õë
            public IntPtr pImage;   						//Ö¸ÏòÍ¼Æ¬µÄÖ¸Õë
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;        	// ÁªºÏÌå´óÐ¡Îª12×Ö½Ú
            public uint dwHumanIn;  	//ÓÐÎÞÈË½Ó½ü 0 - ÎÞÈË 1- ÓÐÈË  
            public float fCrowdDensity;  // ÈËÔ±¾Û¼¯Öµ
        }

        //Ä¿Ç°Ö»ÓÐÓÐÈËÎÞÈËÊÂ¼þºÍÈËÔ±¾Û¼¯ÊÂ¼þÊµÊ±±¨¾¯ÉÏ´«
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_INFO
        {
            public byte byRuleID;				// Rule ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				// ±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;	// ¹æÔòÃû³Æ
            public uint dwEventType;    		// ²ÎÕÕVCA_EVENT_TYPE
            public NET_DVR_EVENT_PARAM_UNION uEventParam;  // 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_INFO_LIST
        {
            public byte byNum;		// ÊÂ¼þÊµÊ±ÐÅÏ¢¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// ±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_EVENT_INFO[] struEventInfo;	// ÊÂ¼ÊÊµÊ±ÐÅÏ¢
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RULE_INFO_ALARM
        {
            public uint dwSize;				// ½á¹¹Ìå´óÐ¡
            public uint dwRelativeTime; 	// Ïà¶ÔÊ±±ê
            public uint dwAbsTime;			// ¾ø¶ÔÊ±±ê
            public NET_VCA_DEV_INFO struDevInfo;		// Ç°¶ËÉè±¸ÐÅÏ¢
            public NET_DVR_EVENT_INFO_LIST struEventInfoList;	//ÊÂ¼þÐÅÏ¢ÁÐ±í
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// ±£Áô×Ö½Ú
        }

        //µ¥Ìõ³¡¾°Ê±¼ä¶Î
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_SCENE_TIME
        {
            public byte byActive;                     //0 -ÎÞÐ§,1¨CÓÐÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                    //±£Áô
            public uint dwSceneID;                    //³¡¾°ID
            public NET_DVR_SCHEDTIME struEffectiveTime;   //³¡¾°ÆðÐ§Ê±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                   //±£Áô
        }

        //³¡¾°ÆðÐ§Ê±¼ä¶ÎÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_TIME_CFG
        {
            public uint dwSize;                                               //½á¹¹´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SCENE_TIMESEG_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_SCENE_TIME[] struSceneTime; //³¡¾°Ê±¼ä¶ÎÊý×é
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                                            //±£Áô
        }

        //µ¥Ìõ³¡¾°ÅäÖÃÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_SCENE_CFG
        {
            public byte byEnable;                 //ÊÇ·ñÆôÓÃ¸Ã³¡¾°,0-²»ÆôÓÃ 1- ÆôÓÃ
            public byte byDirection;              //¼à²â·½Ïò 1-ÉÏÐÐ£¬2-ÏÂÐÐ£¬3-Ë«Ïò£¬4-ÓÉ¶«ÏòÎ÷£¬5-ÓÉÄÏÏò±±£¬6-ÓÉÎ÷Ïò¶«£¬7-ÓÉ±±ÏòÄÏ£¬8-ÆäËü
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                //±£Áô
            public uint dwSceneID;                //³¡¾°ID(Ö»¶Á), 0 - ±íÊ¾¸Ã³¡¾°ÎÞÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySceneName;    //³¡¾°Ãû³Æ
            public NET_DVR_PTZPOS struPtzPos;       //ptz ×ø±ê
            public uint dwTrackTime;              //Çò»ú¸ú×ÙÊ±¼ä[5,300] Ãë£¬TFS(½»Í¨È¡Ö¤)Ä£Ê½ÏÂÓÐÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;               //±£Áô
        }

        //³¡¾°ÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_CFG
        {
            public uint dwSize;                                          //½á¹¹´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITS_SCENE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_SCENE_CFG[] struSceneCfg; //³¡¾°ÅäÖÃÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                                      //±£Áô
        }

        //¶à³¡¾°²Ù×÷Ìõ¼þ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_COND
        {
            public uint dwSize;       //½á¹¹´óÐ¡
            public Int32 lChannel;     //Í¨µÀºÅ
            public uint dwSceneID;    //³¡¾°ID, 0-±íÊ¾¸Ã³¡¾°ÎÞÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±£Áô
        }

        //È¡Ö¤·½Ê½
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FORENSICS_MODE
        {
            public uint dwSize;      //½á¹¹´óÐ¡
            public byte byMode;      // 0-ÊÖ¶¯È¡Ö¤ ,1-×Ô¶¯È¡Ö¤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±£Áô
        }

        //±¨¾¯³¡¾°ÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_INFO
        {
            public uint dwSceneID;              //³¡¾°ID, 0 - ±íÊ¾¸Ã³¡¾°ÎÞÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySceneName;  //³¡¾°Ãû³Æ
            public byte byDirection;            //¼à²â·½Ïò 1-ÉÏÐÐ£¬2-ÏÂÐÐ£¬3-Ë«Ïò£¬4-ÓÉ¶«ÏòÎ÷£¬5-ÓÉÄÏÏò±±£¬6-ÓÉÎ÷Ïò¶«£¬7-ÓÉ±±ÏòÄÏ£¬8-ÆäËü
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;              //±£Áô
            public NET_DVR_PTZPOS struPtzPos;             //Ptz ×ø±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;            //±£Áô
        }

        //½»Í¨ÊÂ¼þ±¨¾¯(À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_ALARM_V41
        {
            public uint dwSize;              //½á¹¹³¤¶È
            public uint dwRelativeTime;	    //Ïà¶ÔÊ±±ê
            public uint dwAbsTime;			//¾ø¶ÔÊ±±ê
            public NET_VCA_DEV_INFO struDevInfo;		    //Ç°¶ËÉè±¸ÐÅÏ¢
            public NET_DVR_AID_INFO struAIDInfo;         //½»Í¨ÊÂ¼þÐÅÏ¢
            public NET_DVR_SCENE_INFO struSceneInfo;       //³¡¾°ÐÅÏ¢
            public uint dwPicDataLen;        //Í¼Æ¬³¤¶È
            public IntPtr pImage; 			//Ö¸ÏòÍ¼Æ¬µÄÖ¸Õë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±£Áô
        }

        //½»Í¨Í³¼ÆÐÅÏ¢±¨¾¯(À©Õ¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_ALARM_V41
        {
            public uint dwSize;          // ½á¹¹Ìå´óÐ¡
            public uint dwRelativeTime;  // Ïà¶ÔÊ±±ê
            public uint dwAbsTime;       // ¾ø¶ÔÊ±±ê
            public NET_VCA_DEV_INFO struDevInfo;     // Ç°¶ËÉè±¸ÐÅÏ¢
            public NET_DVR_TPS_INFO_V41 struTPSInfo;     // ½»Í¨²ÎÊýÍ³¼ÆÐÅÏ¢ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_VERSION
        {
            public ushort wMajorVersion;		// Ö÷°æ±¾ºÅ
            public ushort wMinorVersion;		// ´Î°æ±¾ºÅ
            public ushort wRevisionNumber;	// ÐÞÕýºÅ
            public ushort wBuildNumber;		// ±àÒëºÅ
            public ushort wVersionYear;		//	°æ±¾ÈÕÆÚ-Äê
            public byte byVersionMonth;		//	°æ±¾ÈÕÆÚ-ÔÂ
            public byte byVersionDay;		//	°æ±¾ÈÕÆÚ-ÈÕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			// ±£Áô×Ö½Ú
        }
        /*******************************ÖÇÄÜ½»Í¨ÊÂ¼þ end*****************************************/

        /******************************³µÅÆÊ¶±ð begin******************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_PARAM
        {
            public byte byPlateRecoMode;    //³µÅÆÊ¶±ðµÄÄ£Ê½,Ä¬ÈÏÎª1(ÊÓÆµ´¥·¢Ä£Ê½)
            public byte byBelive;	/*ÕûÅÆÖÃÐÅ¶ÈãÐÖµ, Ö»ÓÃÓÚÊÓÆµÊ¶±ð·½Ê½, ¸ù¾Ý±³¾°¸´ÔÓ³Ì¶ÈÉèÖÃ, Îó´¥·¢ÂÊ¸ß¾ÍÉè¸ß, Â©³µÂÊ¸ß¾ÍÉèµÍ, 
                                     * ½¨ÒéÔÚ80-90·¶Î§ÄÚ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATECFG
        {
            public uint dwSize;
            public uint dwEnable;				           /* ÊÇ·ñÆôÓÃÊÓÆµ³µÅÆÊ¶±ð 0£­·ñ 1£­ÊÇ */
            public byte byPicProType;	//±¨¾¯Ê±Í¼Æ¬´¦Àí·½Ê½ 0-²»´¦Àí ·Ç0-ÉÏ´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  // ±£Áô×Ö½Ú
            public NET_DVR_JPEGPARA struPictureParam; 		//Í¼Æ¬¹æ¸ñ½á¹¹
            public NET_DVR_PLATE_PARAM struPlateParam;   // ³µÅÆÊ¶±ð²ÎÊýÅäÖÃ
            public NET_DVR_HANDLEEXCEPTION struHandleType;	   /* ´¦Àí·½Ê½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;        //±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ,Îª1±íÊ¾´¥·¢¸ÃÍ¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±£Áô×Ö½Ú
        }

        //³µÅÆÊ¶±ð½á¹û×Ó½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_INFO
        {
            public byte byPlateType; //³µÅÆÀàÐÍ
            public byte byColor; //³µÅÆÑÕÉ«
            public byte byBright; //³µÅÆÁÁ¶È
            public byte byLicenseLen;	//³µÅÆ×Ö·û¸öÊý
            public byte byEntireBelieve;//Õû¸ö³µÅÆµÄÖÃÐÅ¶È£¬0-100
            public byte byRegion;                       // ÇøÓòË÷ÒýÖµ 0-±£Áô£¬1-Å·ÖÞ(EU)£¬2-¶íÓïÇøÓò(ER)£¬3-Å·ÖÞ&¶íÂÞË¹(EU&CIS) ,4-ÖÐ¶«(ME),0xff-ËùÓÐ
            public byte byCountry;                      // ¹ú¼ÒË÷ÒýÖµ£¬²ÎÕÕÃ¶¾ÙCOUNTRY_INDEX£¨²»Ö§³Ö"COUNTRY_ALL = 0xff, //ALL  È«²¿"£©
            public byte byArea;                         //ÇøÓò£¨Ê¡·Ý£©£¬¸÷¹ú¼ÒÄÚ²¿ÇøÓòÃ¶¾Ù£¬°¢ÁªÇõ²ÎÕÕ EMI_AREA
            public byte byPlateSize;                    //³µÅÆ³ß´ç£¬0~Î´Öª£¬1~long, 2~short(ÖÐ¶«³µÅÆÊ¹ÓÃ)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                       //±£Áô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CATEGORY_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPlateCategory;//³µÅÆ¸½¼ÓÐÅÏ¢, ¼´ÖÐ¶«³µÅÆÖÐ³µÅÆºÅÂëÅÔ±ßµÄÐ¡×ÖÐÅÏ¢£¬(Ä¿Ç°Ö»ÓÐÖÐ¶«µØÇøÖ§³Ö)
            public uint dwXmlLen;                        //XML±¨¾¯ÐÅÏ¢³¤¶È
            public IntPtr pXmlBuf;                      // XML±¨¾¯ÐÅÏ¢Ö¸Õë,±¨¾¯ÀàÐÍÎª COMM_ITS_PLATE_RESULÊ±ÓÐÐ§£¬ÆäXML¶ÔÓ¦µ½EventNotificationAlert XML Block
            public NET_VCA_RECT struPlateRect;	//³µÅÆÎ»ÖÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LICENSE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLicense;	//³µÅÆºÅÂë 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LICENSE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byBelieve; //¸÷¸öÊ¶±ð×Ö·ûµÄÖÃÐÅ¶È£¬Èç¼ì²âµ½³µÅÆ"ÕãA12345", ÖÃÐÅ¶ÈÎª,20,30,40,50,60,70£¬Ôò±íÊ¾"Õã"×ÖÕýÈ·µÄ¿ÉÄÜÐÔÖ»ÓÐ%£¬"A"×ÖµÄÕýÈ·µÄ¿ÉÄÜÐÔÊÇ%
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATERECO_RESULE
        {
            public uint dwSize;
            public uint dwRelativeTime;	//Ïà¶ÔÊ±±ê
            public uint dwAbsTime;	//¾ø¶ÔÊ±±ê
            public NET_VCA_DEV_INFO struDevInfo; // Ç°¶ÎÉè±¸ÐÅÏ¢
            public NET_DVR_PLATE_INFO struPlateInfo;
            public uint dwPicDataLen;	//·µ»ØÍ¼Æ¬µÄ³¤¶È Îª0±íÊ¾Ã»ÓÐÍ¼Æ¬£¬´óÓÚ0±íÊ¾¸Ã½á¹¹ºóÃæ½ô¸úÍ¼Æ¬Êý¾Ý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;	//±£Áô£¬ÉèÖÃÎª0
            public IntPtr pImage;   //Ö¸ÏòÍ¼Æ¬µÄÖ¸Õë
        }
        /******************************³µÅÆÊ¶±ð end******************************************/

        /******************************×¥ÅÄ»ú*******************************************/
        //IOÊäÈëÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IO_INCFG
        {
            public uint dwSize;
            public byte byIoInStatus;//ÊäÈëµÄIO¿Ú×´Ì¬£¬0-ÏÂ½µÑØ£¬1-ÉÏÉýÑØ£¬2-ÉÏÉýÑØºÍÏÂ½µÑØ£¬3-¸ßµçÆ½£¬4-µÍµçÆ½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô×Ö½Ú
        }

        //IOÊä³öÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IO_OUTCFG
        {
            public uint dwSize;
            public byte byDefaultStatus;//IOÄ¬ÈÏ×´Ì¬£º0-µÍµçÆ½£¬1-¸ßµçÆ½ 
            public byte byIoOutStatus;//IOÆðÐ§Ê±×´Ì¬£º0-µÍµçÆ½£¬1-¸ßµçÆ½£¬2-Âö³å
            public ushort wAheadTime;//Êä³öIOÌáÇ°Ê±¼ä£¬µ¥Î»us
            public uint dwTimePluse;//Âö³å¼ä¸ôÊ±¼ä£¬µ¥Î»us
            public uint dwTimeDelay;//IOÓÐÐ§³ÖÐøÊ±¼ä£¬µ¥Î»us
            public byte byFreqMulti;		//±¶Æµ£¬ÊýÖµ·¶Î§[1,15]
            public byte byDutyRate;		//Õ¼¿Õ±È£¬[0,40%]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÉÁ¹âµÆÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLASH_OUTCFG
        {
            public uint dwSize;
            public byte byMode;//ÉÁ¹âµÆÉÁË¸Ä£Ê½£¬0-²»ÉÁ£¬1-ÉÁ£¬2-¹ØÁªÉÁ£¬3-ÂÖÉÁ
            public byte byRelatedIoIn;//ÉÁ¹âµÆ¹ØÁªµÄÊäÈëIOºÅ£¨¹ØÁªÉÁÊ±´Ë²ÎÊýÓÐÐ§£©
            public byte byRecognizedLane;  /*¹ØÁªµÄIOºÅ£¬°´Î»±íÊ¾£¬bit0±íÊ¾IO1ÊÇ·ñ¹ØÁª£¬0-²»¹ØÁª£¬1-¹ØÁª*/
            public byte byDetectBrightness;/*×Ô¶¯¼ì²âÁÁ¶ÈÊ¹ÄÜÉÁ¹âµÆ0-²»¼ì²â£»1-¼ì²â*/
            public byte byBrightnessThreld;/*Ê¹ÄÜÉÁ¹âµÆÁÁ¶ÈãÐÖµ£¬·¶Î§[0,100],¸ßÓÚãÐÖµÉÁ*/
            public byte byStartHour;		//¿ªÊ¼Ê±¼ä-Ð¡Ê±,È¡Öµ·¶Î§0-23
            public byte byStartMinute;		//¿ªÊ¼Ê±¼ä-·Ö,È¡Öµ·¶Î§0-59
            public byte byEndHour;		 	//½áÊøÊ±¼ä-Ð¡Ê±,È¡Öµ·¶Î§0-23
            public byte byEndMinute;		//½áÊøÊ±¼ä-·Ö,È¡Öµ·¶Î§0-59
            public byte byFlashLightEnable;	//ÉèÖÃÉÁ¹âµÆÊ±¼äÊ¹ÄÜ:0-¹Ø;1-¿ª
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ºìÂÌµÆ¹¦ÄÜ£¨2¸öIOÊäÈëÒ»×é£©
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LIGHTSNAPCFG
        {
            public uint dwSize;
            public byte byLightIoIn;//ºìÂÌµÆµÄIO ºÅ
            public byte byTrigIoIn;//´¥·¢µÄIOºÅ
            public byte byRelatedDriveWay;//´¥·¢IO¹ØÁªµÄ³µµÀºÅ
            public byte byTrafficLight; //0-¸ßµçÆ½ºìµÆ£¬µÍµçÆ½ÂÌµÆ£»1-¸ßµçÆ½ÂÌµÆ£¬µÍµçÆ½ºìµÆ
            public byte bySnapTimes1; //ºìµÆ×¥ÅÄ´ÎÊý1£¬0-²»×¥ÅÄ£¬·Ç0-Á¬ÅÄ´ÎÊý£¬×î´ó5´Î 
            public byte bySnapTimes2; //ÂÌµÆ×¥ÅÄ´ÎÊý2£¬0-²»×¥ÅÄ£¬·Ç0-Á¬ÅÄ´ÎÊý£¬×î´ó5´Î 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime1;//ºìµÆÁ¬ÅÄ¼ä¸ôÊ±¼ä£¬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime2;//ÂÌµÆÁ¬ÅÄ¼ä¸ôÊ±¼ä£¬ms
            public byte byRecord;//´³ºìµÆÖÜÆÚÂ¼Ïñ±êÖ¾£¬0-²»Â¼Ïñ£¬1-Â¼Ïñ
            public byte bySessionTimeout;//´³ºìµÆÖÜÆÚÂ¼Ïñ³¬Ê±Ê±¼ä£¨Ãë£©
            public byte byPreRecordTime;//´³ºìµÆÂ¼ÏñÆ¬¶ÎÔ¤Â¼Ê±¼ä(Ãë)
            public byte byVideoDelay;//´³ºìµÆÂ¼ÏñÆ¬¶ÎÑÓÊ±Ê±¼ä£¨Ãë£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£Áô×Ö½Ú
        }

        //²âËÙ¹¦ÄÜ(2¸öIOÊäÈëÒ»×é£©
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MEASURESPEEDCFG
        {
            public uint dwSize;
            public byte byTrigIo1;   //²âËÙµÚ1ÏßÈ¦
            public byte byTrigIo2;   //²âËÙµÚ2ÏßÈ¦
            public byte byRelatedDriveWay;//´¥·¢IO¹ØÁªµÄ³µµÀºÅ
            public byte byTestSpeedTimeOut;//²âËÙÄ£Ê½³¬Ê±Ê±¼ä£¬µ¥Î»s
            public uint dwDistance;//ÏßÈ¦¾àÀë,cm
            public byte byCapSpeed;//²âËÙÄ£Ê½ÆðÅÄËÙ¶È£¬µ¥Î»km/h
            public byte bySpeedLimit;//ÏÞËÙÖµ£¬µ¥Î»km/h
            public byte bySnapTimes1; //ÏßÈ¦1×¥ÅÄ´ÎÊý£¬0-²»×¥ÅÄ£¬·Ç0-Á¬ÅÄ´ÎÊý£¬×î´ó5´Î 
            public byte bySnapTimes2; //ÏßÈ¦2×¥ÅÄ´ÎÊý£¬0-²»×¥ÅÄ£¬·Ç0-Á¬ÅÄ´ÎÊý£¬×î´ó5´Î 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime1;//ÏßÈ¦1Á¬ÅÄ¼ä¸ôÊ±¼ä£¬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime2;//ÏßÈ¦2Á¬ÅÄ¼ä¸ôÊ±¼ä£¬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô×Ö½Ú
        }

        //ÊÓÆµ²ÎÊýÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOEFFECT
        {
            public byte byBrightnessLevel; /*0-100*/
            public byte byContrastLevel; /*0-100*/
            public byte bySharpnessLevel; /*0-100*/
            public byte bySaturationLevel; /*0-100*/
            public byte byHueLevel; /*0-100,£¨±£Áô£©*/
            public byte byEnableFunc; //Ê¹ÄÜ£¬°´Î»±íÊ¾£¬bit0-SMART IR(·À¹ýÆØ)£¬bit1-µÍÕÕ¶È,bit2-Ç¿¹âÒÖÖÆÊ¹ÄÜ£¬0-·ñ£¬1-ÊÇ
            public byte byLightInhibitLevel; //Ç¿¹âÒÖÖÆµÈ¼¶£¬[1-3]±íÊ¾µÈ¼¶
            public byte byGrayLevel; //»Ò¶ÈÖµÓò£¬0-[0-255]£¬1-[16-235]
        }

        //ÔöÒæÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GAIN
        {
            public byte byGainLevel; /*ÔöÒæ£º0-100*/
            public byte byGainUserSet; /*ÓÃ»§×Ô¶¨ÒåÔöÒæ£»0-100£¬¶ÔÓÚ×¥ÅÄ»ú£¬ÊÇCCDÄ£Ê½ÏÂµÄ×¥ÅÄÔöÒæ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwMaxGainValue;/*×î´óÔöÒæÖµ£¬µ¥Î»dB*/
        }

        //°×Æ½ºâÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WHITEBALANCE
        {
            public byte byWhiteBalanceMode; /*0-ÊÖ¶¯°×Æ½ºâ£¨MWB£©,1-×Ô¶¯°×Æ½ºâ1£¨AWB1£©,2-×Ô¶¯°×Æ½ºâ2 (AWB2),3-×Ô¶¯¿ØÖÆ¸ÄÃûÎªËø¶¨°×Æ½ºâ(Locked WB)£¬
	                         4-ÊÒÍâ(Indoor)£¬5-ÊÒÄÚ(Outdoor)6-ÈÕ¹âµÆ(Fluorescent Lamp)£¬7-ÄÆµÆ(Sodium Lamp)£¬
	                         8-×Ô¶¯¸ú×Ù(Auto-Track)9-Ò»´Î°×Æ½ºâ(One Push)£¬10-ÊÒÍâ×Ô¶¯(Auto-Outdoor)£¬
	                         11-ÄÆµÆ×Ô¶¯ (Auto-Sodiumlight)£¬12-Ë®ÒøµÆ(Mercury Lamp)£¬13-×Ô¶¯°×Æ½ºâ(Auto)£¬
	                         14-°×³ãµÆ (IncandescentLamp)£¬15-Å¯¹âµÆ(Warm Light Lamp)£¬16-×ÔÈ»¹â(Natural Light) */
            public byte byWhiteBalanceModeRGain; /*ÊÖ¶¯°×Æ½ºâÊ±ÓÐÐ§£¬ÊÖ¶¯°×Æ½ºâ RÔöÒæ*/
            public byte byWhiteBalanceModeBGain; /*ÊÖ¶¯°×Æ½ºâÊ±ÓÐÐ§£¬ÊÖ¶¯°×Æ½ºâ BÔöÒæ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÆØ¹â¿ØÖÆ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXPOSURE
        {
            public byte byExposureMode; /*0 ÊÖ¶¯ÆØ¹â 1×Ô¶¯ÆØ¹â*/
            public byte byAutoApertureLevel; /* ×Ô¶¯¹âÈ¦ÁéÃô¶È, 0-10 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwVideoExposureSet; /* ×Ô¶¨ÒåÊÓÆµÆØ¹âÊ±¼ä£¨µ¥Î»us£©*//*×¢:×Ô¶¯ÆØ¹âÊ±¸ÃÖµÎªÆØ¹â×îÂýÖµ ÐÂÔö20-1s(1000000us)*/
            public uint dwExposureUserSet; /* ×Ô¶¨ÒåÆØ¹âÊ±¼ä,ÔÚ×¥ÅÄ»úÉÏÓ¦ÓÃÊ±£¬CCDÄ£Ê½Ê±ÊÇ×¥ÅÄ¿ìÃÅËÙ¶È*/
            public uint dwRes;
        }

        //¿í¶¯Ì¬ÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WDR
        {
            public byte byWDREnabled; /*¿í¶¯Ì¬£º0 dsibale  1 enable 2 auto*/
            public byte byWDRLevel1; /*0-F*/
            public byte byWDRLevel2; /*0-F*/
            public byte byWDRContrastLevel; /*0-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÈÕÒ¹×ª»»¹¦ÄÜÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DAYNIGHT
        {
            public byte byDayNightFilterType; /*ÈÕÒ¹ÇÐ»»£º0-°×Ìì£¬1-Ò¹Íí£¬2-×Ô¶¯£¬3-¶¨Ê±£¬4-±¨¾¯ÊäÈë´¥·¢*/
            public byte bySwitchScheduleEnabled; /*0 dsibale  1 enable,(±£Áô)*/
            //¶¨Ê±Ä£Ê½²ÎÊý
            public byte byBeginTime; /*¿ªÊ¼Ê±¼ä£¨Ð¡Ê±£©£¬0-23*/
            public byte byEndTime; /*½áÊøÊ±¼ä£¨Ð¡Ê±£©£¬0-23*/
            //Ä£Ê½2
            public byte byDayToNightFilterLevel; //0-7
            public byte byNightToDayFilterLevel; //0-7
            public byte byDayNightFilterTime;//(60Ãë)
            //¶¨Ê±Ä£Ê½²ÎÊý
            public byte byBeginTimeMin; //¿ªÊ¼Ê±¼ä£¨·Ö£©£¬0-59
            public byte byBeginTimeSec; //¿ªÊ¼Ê±¼ä£¨Ãë£©£¬0-59
            public byte byEndTimeMin; //½áÊøÊ±¼ä£¨·Ö£©£¬0-59
            public byte byEndTimeSec; //½áÊøÊ±¼ä£¨Ãë£©£¬0-59
                                      //±¨¾¯ÊäÈë´¥·¢Ä£Ê½²ÎÊý
            public byte byAlarmTrigState; //±¨¾¯ÊäÈë´¥·¢×´Ì¬£¬0-°×Ìì£¬1-Ò¹Íí
        }

        //GammaÐ£Õý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GAMMACORRECT
        {
            public byte byGammaCorrectionEnabled; /*0 dsibale  1 enable*/
            public byte byGammaCorrectionLevel; /*0-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±³¹â²¹³¥ÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKLIGHT
        {
            public byte byBacklightMode; /*±³¹â²¹³¥:0 off 1 UP¡¢2 DOWN¡¢3 LEFT¡¢4 RIGHT¡¢5MIDDLE¡¢6×Ô¶¨Òå*/
            public byte byBacklightLevel; /*0x0-0xF*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPositionX1; //£¨X×ø±ê1£©
            public uint dwPositionY1; //£¨Y×ø±ê1£©
            public uint dwPositionX2; //£¨X×ø±ê2£©
            public uint dwPositionY2; //£¨Y×ø±ê2£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //Êý×Ö½µÔë¹¦ÄÜ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NOISEREMOVE
        {
            public byte byDigitalNoiseRemoveEnable; /*0-²»ÆôÓÃ£¬1-ÆÕÍ¨Ä£Ê½Êý×Ö½µÔë£¬2-×¨¼ÒÄ£Ê½Êý×Ö½µÔë*/
            public byte byDigitalNoiseRemoveLevel; /*ÆÕÍ¨Ä£Ê½Êý×Ö½µÔë¼¶±ð£º0x0-0xF*/
            public byte bySpectralLevel;       /*×¨¼ÒÄ£Ê½ÏÂ¿ÕÓòÇ¿¶È£º0-100*/
            public byte byTemporalLevel;   /*×¨¼ÒÄ£Ê½ÏÂÊ±ÓòÇ¿¶È£º0-100*/
            public byte byDigitalNoiseRemove2DEnable;         /* ×¥ÅÄÖ¡2D½µÔë£¬0-²»ÆôÓÃ£¬1-ÆôÓÃ */
            public byte byDigitalNoiseRemove2DLevel;            /* ×¥ÅÄÖ¡2D½µÔë¼¶±ð£¬0-100 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //CMOSÄ£Ê½ÏÂÇ°¶Ë¾µÍ·ÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CMOSMODECFG
        {
            public byte byCaptureMod;   //×¥ÅÄÄ£Ê½£º0-×¥ÅÄÄ£Ê½1£»1-×¥ÅÄÄ£Ê½2
            public byte byBrightnessGate;//ÁÁ¶ÈãÐÖµ
            public byte byCaptureGain1;   //×¥ÅÄÔöÒæ1,0-100
            public byte byCaptureGain2;   //×¥ÅÄÔöÒæ2,0-100
            public uint dwCaptureShutterSpeed1;//×¥ÅÄ¿ìÃÅËÙ¶È1
            public uint dwCaptureShutterSpeed2;//×¥ÅÄ¿ìÃÅËÙ¶È2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Ç°¶Ë²ÎÊýÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERAPARAMCFG
        {
            public uint dwSize;
            public NET_DVR_VIDEOEFFECT struVideoEffect;/*ÁÁ¶È¡¢¶Ô±È¶È¡¢±¥ºÍ¶È¡¢Èñ¶È¡¢É«µ÷ÅäÖÃ*/
            public NET_DVR_GAIN struGain;/*×Ô¶¯ÔöÒæ*/
            public NET_DVR_WHITEBALANCE struWhiteBalance;/*°×Æ½ºâ*/
            public NET_DVR_EXPOSURE struExposure; /*ÆØ¹â¿ØÖÆ*/
            public NET_DVR_GAMMACORRECT struGammaCorrect;/*GammaÐ£Õý*/
            public NET_DVR_WDR struWdr;/*¿í¶¯Ì¬*/
            public NET_DVR_DAYNIGHT struDayNight;/*ÈÕÒ¹×ª»»*/
            public NET_DVR_BACKLIGHT struBackLight;/*±³¹â²¹³¥*/
            public NET_DVR_NOISEREMOVE struNoiseRemove;/*Êý×Ö½µÔë*/
            public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
            public byte byIrisMode; /*0 ×Ô¶¯¹âÈ¦ 1ÊÖ¶¯¹âÈ¦*/
            public byte byMirror;  /* ¾µÏñ£º0 off£¬1- leftright£¬2- updown£¬3-center */
            public byte byDigitalZoom;  /*Êý×ÖËõ·Å:0 dsibale  1 enable*/
            public byte byDeadPixelDetect;   /*»µµã¼ì²â,0 dsibale  1 enable*/
            public byte byBlackPwl;/*ºÚµçÆ½²¹³¥ ,  0-255*/
            public byte byEptzGate;// EPTZ¿ª¹Ø±äÁ¿:0-²»ÆôÓÃµç×ÓÔÆÌ¨£¬1-ÆôÓÃµç×ÓÔÆÌ¨
            public byte byLocalOutputGate;//±¾µØÊä³ö¿ª¹Ø±äÁ¿0-±¾µØÊä³ö¹Ø±Õ1-±¾µØBNCÊä³ö´ò¿ª 2-HDMIÊä³ö¹Ø±Õ  
                                          //20-HDMI_720P50Êä³ö¿ª
                                          //21-HDMI_720P60Êä³ö¿ª
                                          //22-HDMI_1080I60Êä³ö¿ª
                                          //23-HDMI_1080I50Êä³ö¿ª
                                          //24-HDMI_1080P24Êä³ö¿ª
                                          //25-HDMI_1080P25Êä³ö¿ª
                                          //26-HDMI_1080P30Êä³ö¿ª
                                          //27-HDMI_1080P50Êä³ö¿ª
                                          //28-HDMI_1080P60Êä³ö¿ª
                                          //40-SDI_720P50,
                                          //41-SDI_720P60,
                                          //42-SDI_1080I50,
                                          //43-SDI_1080I60,
                                          //44-SDI_1080P24,
                                          //45-SDI_1080P25,
                                          //46-SDI_1080P30,
                                          //47-SDI_1080P50,
                                          //48-SDI_1080P60
            public byte byCoderOutputMode;//±àÂëÆ÷fpgaÊä³öÄ£Ê½0Ö±Í¨3ÏñËØ°á¼Ò
            public byte byLineCoding; //ÊÇ·ñ¿ªÆôÐÐ±àÂë£º0-·ñ£¬1-ÊÇ
            public byte byDimmerMode; //µ÷¹âÄ£Ê½£º0-°ë×Ô¶¯£¬1-×Ô¶¯
            public byte byPaletteMode; //µ÷É«°å£º0-°×ÈÈ£¬1-ºÚÈÈ£¬2-µ÷É«°å2£¬¡­£¬8-µ÷É«°å8
            public byte byEnhancedMode; //ÔöÇ¿·½Ê½£¨Ì½²âÎïÌåÖÜ±ß£©£º0-²»ÔöÇ¿£¬1-1£¬2-2£¬3-3£¬4-4
            public byte byDynamicContrastEN;    //¶¯Ì¬¶Ô±È¶ÈÔöÇ¿ 0-1
            public byte byDynamicContrast;    //¶¯Ì¬¶Ô±È¶È 0-100
            public byte byJPEGQuality;    //JPEGÍ¼ÏñÖÊÁ¿ 0-100
            public NET_DVR_CMOSMODECFG struCmosModeCfg;//CMOSÄ£Ê½ÏÂÇ°¶Ë²ÎÊýÅäÖÃ£¬¾µÍ·Ä£Ê½´ÓÄÜÁ¦¼¯»ñÈ¡
            public byte byFilterSwitch; //ÂË²¨¿ª¹Ø£º0-²»ÆôÓÃ£¬1-ÆôÓÃ
            public byte byFocusSpeed; //¾µÍ·µ÷½¹ËÙ¶È£º0-10
            public byte byAutoCompensationInterval; //¶¨Ê±×Ô¶¯¿ìÃÅ²¹³¥£º1-120£¬µ¥Î»£º·ÖÖÓ
            public byte bySceneMode;  //³¡¾°Ä£Ê½£º0-ÊÒÍâ£¬1-ÊÒÄÚ£¬2-Ä¬ÈÏ£¬3-Èõ¹â
        }

        //Í¸Îí
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFOGCFG
        {
            public byte byMode; //Ä£Ê½£¬0-²»ÆôÓÃ£¬1-×Ô¶¯Ä£Ê½£¬2-³£¿ªÄ£Ê½
            public byte byLevel; //µÈ¼¶£¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µç×Ó·À¶¶
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ELECTRONICSTABILIZATION
        {
            public byte byEnable;//Ê¹ÄÜ 0- ²»ÆôÓÃ£¬1- ÆôÓÃ
            public byte byLevel; //µÈ¼¶£¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //×ßÀÈÄ£Ê½
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CORRIDOR_MODE_CCD
        {
            public byte byEnableCorridorMode; //ÊÇ·ñÆôÓÃ×ßÀÈÄ£Ê½ 0¡«²»ÆôÓÃ£¬ 1¡«ÆôÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //SMART IR(·À¹ýÆØ)ÅäÖÃ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMARTIR_PARAM
        {
            public byte byMode;//0¡«ÊÖ¶¯£¬1¡«×Ô¶¯
            public byte byIRDistance;//ºìÍâ¾àÀëµÈ¼¶(µÈ¼¶£¬¾àÀëÕý±ÈÀý)level:1~100 Ä¬ÈÏ:50£¨ÊÖ¶¯Ä£Ê½ÏÂÔö¼Ó£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÔÚbyIrisMode ÎªP-Iris1Ê±ÉúÐ§£¬ÅäÖÃºìÍâ¹âÈ¦´óÐ¡µÈ¼¶£¬ÅäÖÃÄ£Ê½
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PIRIS_PARAM
        {
            public byte byMode;//0-×Ô¶¯£¬1-ÊÖ¶¯
            public byte byPIrisAperture;//ºìÍâ¹âÈ¦´óÐ¡µÈ¼¶(µÈ¼¶,¹âÈ¦´óÐ¡Õý±ÈÀý)level:1~100 Ä¬ÈÏ:50£¨ÊÖ¶¯Ä£Ê½ÏÂÔö¼Ó£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Ç°¶Ë²ÎÊýÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERAPARAMCFG_EX
        {
            public uint dwSize;
            public NET_DVR_VIDEOEFFECT struVideoEffect;/*ÁÁ¶È¡¢¶Ô±È¶È¡¢±¥ºÍ¶È¡¢Èñ¶È¡¢É«µ÷ÅäÖÃ*/
            public NET_DVR_GAIN struGain;/*×Ô¶¯ÔöÒæ*/
            public NET_DVR_WHITEBALANCE struWhiteBalance;/*°×Æ½ºâ*/
            public NET_DVR_EXPOSURE struExposure; /*ÆØ¹â¿ØÖÆ*/
            public NET_DVR_GAMMACORRECT struGammaCorrect;/*GammaÐ£Õý*/
            public NET_DVR_WDR struWdr;/*¿í¶¯Ì¬*/
            public NET_DVR_DAYNIGHT struDayNight;/*ÈÕÒ¹×ª»»*/
            public NET_DVR_BACKLIGHT struBackLight;/*±³¹â²¹³¥*/
            public NET_DVR_NOISEREMOVE struNoiseRemove;/*Êý×Ö½µÔë*/
            public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
            public byte byIrisMode; /*0-×Ô¶¯¹âÈ¦ 1-ÊÖ¶¯¹âÈ¦, 2-P-Iris1*/
            public byte byMirror;  /* ¾µÏñ£º0 off£¬1- leftright£¬2- updown£¬3-center */
            public byte byDigitalZoom;  /*Êý×ÖËõ·Å:0 dsibale  1 enable*/
            public byte byDeadPixelDetect;   /*»µµã¼ì²â,0 dsibale  1 enable*/
            public byte byBlackPwl;/*ºÚµçÆ½²¹³¥ ,  0-255*/
            public byte byEptzGate;// EPTZ¿ª¹Ø±äÁ¿:0-²»ÆôÓÃµç×ÓÔÆÌ¨£¬1-ÆôÓÃµç×ÓÔÆÌ¨
            public byte byLocalOutputGate;//±¾µØÊä³ö¿ª¹Ø±äÁ¿0-±¾µØÊä³ö¹Ø±Õ1-±¾µØBNCÊä³ö´ò¿ª 2-HDMIÊä³ö¹Ø±Õ  
                                          //20-HDMI_720P50Êä³ö¿ª
                                          //21-HDMI_720P60Êä³ö¿ª
                                          //22-HDMI_1080I60Êä³ö¿ª
                                          //23-HDMI_1080I50Êä³ö¿ª
                                          //24-HDMI_1080P24Êä³ö¿ª
                                          //25-HDMI_1080P25Êä³ö¿ª
                                          //26-HDMI_1080P30Êä³ö¿ª
                                          //27-HDMI_1080P50Êä³ö¿ª
                                          //28-HDMI_1080P60Êä³ö¿ª
            public byte byCoderOutputMode;//±àÂëÆ÷fpgaÊä³öÄ£Ê½0Ö±Í¨3ÏñËØ°á¼Ò
            public byte byLineCoding; //ÊÇ·ñ¿ªÆôÐÐ±àÂë£º0-·ñ£¬1-ÊÇ
            public byte byDimmerMode; //µ÷¹âÄ£Ê½£º0-°ë×Ô¶¯£¬1-×Ô¶¯
            public byte byPaletteMode; //µ÷É«°å£º0-°×ÈÈ£¬1-ºÚÈÈ£¬2-µ÷É«°å2£¬¡­£¬8-µ÷É«°å8
            public byte byEnhancedMode; //ÔöÇ¿·½Ê½£¨Ì½²âÎïÌåÖÜ±ß£©£º0-²»ÔöÇ¿£¬1-1£¬2-2£¬3-3£¬4-4
            public byte byDynamicContrastEN;    //¶¯Ì¬¶Ô±È¶ÈÔöÇ¿ 0-1
            public byte byDynamicContrast;    //¶¯Ì¬¶Ô±È¶È 0-100
            public byte byJPEGQuality;    //JPEGÍ¼ÏñÖÊÁ¿ 0-100
            public NET_DVR_CMOSMODECFG struCmosModeCfg;//CMOSÄ£Ê½ÏÂÇ°¶Ë²ÎÊýÅäÖÃ£¬¾µÍ·Ä£Ê½´ÓÄÜÁ¦¼¯»ñÈ¡
            public byte byFilterSwitch; //ÂË²¨¿ª¹Ø£º0-²»ÆôÓÃ£¬1-ÆôÓÃ
            public byte byFocusSpeed; //¾µÍ·µ÷½¹ËÙ¶È£º0-10
            public byte byAutoCompensationInterval; //¶¨Ê±×Ô¶¯¿ìÃÅ²¹³¥£º1-120£¬µ¥Î»£º·ÖÖÓ
            public byte bySceneMode;  //³¡¾°Ä£Ê½£º0-ÊÒÍâ£¬1-ÊÒÄÚ£¬2-Ä¬ÈÏ£¬3-Èõ¹â
            public NET_DVR_DEFOGCFG struDefogCfg;//Í¸Îí²ÎÊý
            public NET_DVR_ELECTRONICSTABILIZATION struElectronicStabilization;//µç×Ó·À¶¶
            public NET_DVR_CORRIDOR_MODE_CCD struCorridorMode;//×ßÀÈÄ£Ê½
            public byte byExposureSegmentEnable; //0~²»ÆôÓÃ,1~ÆôÓÃ  ÆØ¹âÊ±¼äºÍÔöÒæ³Ê½×ÌÝ×´µ÷Õû£¬±ÈÈçÆØ¹âÍùÉÏµ÷ÕûÊ±£¬ÏÈÌá¸ßÆØ¹âÊ±¼äµ½ÖÐ¼äÖµ£¬È»ºóÌá¸ßÔöÒæµ½ÖÐ¼äÖµ£¬ÔÙÌá¸ßÆØ¹âµ½×î´óÖµ£¬×îºóÌá¸ßÔöÒæµ½×î´óÖµ
            public byte byBrightCompensate;//ÁÁ¶ÈÔöÇ¿ [0~100]

            /*0-¹Ø±Õ¡¢1-640*480@25fps¡¢2-640*480@30ps¡¢3-704*576@25fps¡¢4-704*480@30fps¡¢5-1280*720@25fps¡¢6-1280*720@30fps¡¢
             * 7-1280*720@50fps¡¢8-1280*720@60fps¡¢9-1280*960@15fps¡¢10-1280*960@25fps¡¢11-1280*960@30fps¡¢
             * 12-1280*1024@25fps¡¢13--1280*1024@30fps¡¢14-1600*900@15fps¡¢15-1600*1200@15fps¡¢16-1920*1080@15fps¡¢
             * 17-1920*1080@25fps¡¢18-1920*1080@30fps¡¢19-1920*1080@50fps¡¢20-1920*1080@60fps¡¢21-2048*1536@15fps¡¢22-2048*1536@20fps¡¢
             * 23-2048*1536@24fps¡¢24-2048*1536@25fps¡¢25-2048*1536@30fps¡¢26-2560*2048@25fps¡¢27-2560*2048@30fps¡¢
             * 28-2560*1920@7.5fps¡¢29-3072*2048@25fps¡¢30-3072*2048@30fps¡¢31-2048*1536@12.5¡¢32-2560*1920@6.25¡¢
             * 33-1600*1200@25¡¢34-1600*1200@30¡¢35-1600*1200@12.5¡¢36-1600*900@12.5¡¢37-1600@900@15¡¢38-800*600@25¡¢39-800*600@30*/
            public byte byCaptureModeN; //ÊÓÆµÊäÈëÄ£Ê½£¨NÖÆ£©
            public byte byCaptureModeP; //ÊÓÆµÊäÈëÄ£Ê½£¨PÖÆ£©
            public NET_DVR_SMARTIR_PARAM struSmartIRParam; //ºìÍâ·Å¹ý±¬ÅäÖÃÐÅÏ¢
            public NET_DVR_PIRIS_PARAM struPIrisParam;//PIrisÅäÖÃÐÅÏ¢¶ÔÓ¦byIrisMode×Ö¶Î´Ó2-PIris1¿ªÊ¼ÉúÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 296, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        //³µÅÆÑÕÉ«
        public enum VCA_PLATE_COLOR
        {
            VCA_BLUE_PLATE = 0,//À¶É«³µÅÆ
            VCA_YELLOW_PLATE,//»ÆÉ«³µÅÆ
            VCA_WHITE_PLATE,//°×É«³µÅÆ
            VCA_BLACK_PLATE,//ºÚÉ«³µÅÆ
            VCA_GREEN_PLATE //ÂÌÉ«³µÅÆ
        }

        //³µÅÆÀàÐÍ
        public enum VCA_PLATE_TYPE
        {
            VCA_STANDARD92_PLATE = 0,//±ê×¼ÃñÓÃ³µÓë¾ü³µ
            VCA_STANDARD02_PLATE,//02Ê½ÃñÓÃ³µÅÆ 
            VCA_WJPOLICE_PLATE,//Îä¾¯³µ 
            VCA_JINGCHE_PLATE,//¾¯³µ
            STANDARD92_BACK_PLATE,//ÃñÓÃ³µË«ÐÐÎ²ÅÆ
            VCA_SHIGUAN_PLATE,          //Ê¹¹Ý³µÅÆ
            VCA_NONGYONG_PLATE,         //Å©ÓÃ³µ
            VCA_MOTO_PLATE              //Ä¦ÍÐ³µ
        }

        public enum VLR_VEHICLE_CLASS
        {
            VLR_OTHER = 0,   //ÆäËü
            VLR_VOLKSWAGEN = 1,    //´óÖÚ
            VLR_BUICK = 2,  //±ð¿Ë
            VLR_BMW = 3,   //±¦Âí
            VLR_HONDA = 4,   //±¾Ìï
            VLR_PEUGEOT = 5,   //±êÖÂ
            VLR_TOYOTA = 6,   //·áÌï
            VLR_FORD = 7,  //¸£ÌØ
            VLR_NISSAN = 8,  //ÈÕ²ú
            VLR_AUDI = 9,  //°ÂµÏ
            VLR_MAZDA = 10,  //Âí×Ô´ï
            VLR_CHEVROLET = 11,   //Ñ©·ðÀ¼
            VLR_CITROEN = 12,  //Ñ©ÌúÁú
            VLR_HYUNDAI = 13,   //ÏÖ´ú
            VLR_CHERY = 14   //ÆæÈð
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VEHICLE_INFO
        {
            public uint dwIndex;
            public byte byVehicleType;
            public byte byColorDepth;
            public byte byColor;
            public byte byRes1;
            public ushort wSpeed;
            public ushort wLength;
            public byte byIllegalType;
            public byte byVehicleLogoRecog; //²Î¿¼Ã¶¾ÙÀàÐÍ VLR_VEHICLE_CLASS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£Áô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byCustomInfo;  //×Ô¶¨ÒåÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes2 = new byte[2];
                byCustomInfo = new byte[16];
                byRes = new byte[16];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_RESULT
        {
            public uint dwSize;
            public byte byResultType;
            public byte byChanIndex;
            public ushort wAlarmRecordID;	//±¨¾¯Â¼ÏñID(ÓÃÓÚ²éÑ¯Â¼Ïñ£¬½öµ±byResultTypeÎª2Ê±ÓÐÐ§)
            public uint dwRelativeTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAbsTime;
            public uint dwPicLen;
            public uint dwPicPlateLen;
            public uint dwVideoLen;
            public byte byTrafficLight;
            public byte byPicNum;
            public byte byDriveChan;
            public byte byVehicleType; //0- Î´Öª£¬1- ¿Í³µ£¬2- »õ³µ£¬3- ½Î³µ£¬4- Ãæ°ü³µ£¬5- Ð¡»õ³µ
            public uint dwBinPicLen;
            public uint dwCarPicLen;
            public uint dwFarCarPicLen;
            public IntPtr pBuffer3;
            public IntPtr pBuffer4;
            public IntPtr pBuffer5;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public NET_DVR_PLATE_INFO struPlateInfo;
            public NET_DVR_VEHICLE_INFO struVehicleInfo;
            public IntPtr pBuffer1;
            public IntPtr pBuffer2;

            public void Init()
            {
                byAbsTime = new byte[32];
                byRes3 = new byte[8];
            }
        }

        //Í¼Ïñµþ¼ÓÐÅÏ¢ÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IMAGEOVERLAYCFG
        {
            public uint dwSize;
            public byte byOverlayInfo;//µþ¼ÓÊ¹ÄÜ¿ª¹Ø£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayMonitorInfo;//ÊÇ·ñµþ¼Ó¼à²âµãÐÅÏ¢£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayTime;//ÊÇ·ñµþ¼ÓÊ±¼ä£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlaySpeed;//ÊÇ·ñµþ¼ÓËÙ¶È£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlaySpeeding;//ÊÇ·ñµþ¼Ó³¬ËÙ±ÈÀý£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayLimitFlag;//ÊÇ·ñµþ¼ÓÏÞËÙ±êÖ¾£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayPlate;//ÊÇ·ñµþ¼Ó³µÅÆºÅ£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayColor;//ÊÇ·ñµþ¼Ó³µÉíÑÕÉ«£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayLength;//ÊÇ·ñµþ¼Ó³µ³¤£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayType;//ÊÇ·ñµþ¼Ó³µÐÍ£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayColorDepth;//ÊÇ·ñµþ¼Ó³µÉíÑÕÉ«ÉîÇ³£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayDriveChan;//ÊÇ·ñµþ¼Ó³µµÀ£¬0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayMilliSec; //µþ¼ÓºÁÃëÐÅÏ¢ 0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayIllegalInfo; //µþ¼ÓÎ¥ÕÂÐÅÏ¢ 0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byOverlayRedOnTime;  //µþ¼ÓºìµÆÒÑÁÁÊ±¼ä 0-²»µþ¼Ó£¬1-µþ¼Ó
            public byte byFarAddPlateJpeg;      //Ô¶¾°Í¼ÊÇ·ñµþ¼Ó³µÅÆ½ØÍ¼,0-²»µþ¼Ó,1-µþ¼Ó
            public byte byNearAddPlateJpeg;      //½ü¾°Í¼ÊÇ·ñµþ¼Ó³µÅÆ½ØÍ¼,0-²»µþ¼Ó,1-µþ¼Ó
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±£Áô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitorInfo1;    //¼à²âµãÐÅÏ¢1
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitorInfo2; //¼ì²âµãÐÅÏ¢2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAPCFG
        {
            public uint dwSize;
            public byte byRelatedDriveWay;
            public byte bySnapTimes;
            public ushort wSnapWaitTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public enum ITC_MAINMODE_ABILITY
        {
            ITC_MODE_UNKNOW = 0x0,   //ÎÞ
            ITC_POST_MODE = 0x1,  //¿¨¿ÚÄ£Ê½
            ITC_EPOLICE_MODE = 0x2,  //µç¾¯Ä£Ê½
            ITC_POSTEPOLICE_MODE = 0x4  //¿¨Ê½µç¾¯Ä£Ê½
        }

        public enum ITC_RECOG_REGION_TYPE
        {
            ITC_REGION_RECT = 0x0,   //¾ØÐÎ
            ITC_REGION_POLYGON = 0x1,  //¶à±ßÐÎ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAP_ABILITY
        {
            public uint dwSize;
            public byte byIoInNum;//IOÊäÈë¿ÚÊý
            public byte byIoOutNum;//IOÊä³ö¿ÚÊý
            public byte bySingleSnapNum;//µ¥IO´¥·¢×éÊý
            public byte byLightModeArrayNum;//ºìÂÌµÆÄ£Ê½×éÊý
            public byte byMeasureModeArrayNum;//²âËÙÄ£Ê½×éÊý
            public byte byPlateEnable; //³µÅÆÊ¶±ðÄÜÁ¦
            public byte byLensMode;//¾µÍ·Ä£Ê½0-CCD,1-CMOS
            public byte byPreTriggerSupport; //ÊÇ·ñÖ§³ÖÔ­´¥·¢Ä£Ê½£¬0-Ö§³Ö£¬1-²»Ö§³Ö
            public uint dwAbilityType; //Ö§³ÖµÄ´¥·¢Ä£Ê½ÄÜÁ¦£¬°´Î»±íÊ¾£¬¶¨Òå¼ûITC_MAINMODE_ABILITY
            public byte byIoSpeedGroup; //Ö§³ÖµÄIO²âËÙ×éÊý
            public byte byIoLightGroup; //Ö§³ÖµÄIOºìÂÌµÆ×éÊý
            public byte byRecogRegionType; //ÅÆÊ¶ÇøÓòÖ§³ÖµÄÀàÐÍ£¬Ïê¼û¶¨ÒåITC_RECOG_REGION_TYPE
            public byte bySupport; //Éè±¸ÄÜÁ¦£¬°´Î»±íÊ¾£¬0-²»Ö§³Ö£¬1-Ö§³Ö
                                   // bySupport&0x1£¬±íÊ¾ÊÇ·ñÖ§³ÖÀ©Õ¹µÄ×Ö·ûµþ¼ÓÅäÖÃ
                                   // bySupport&0x2£¬±íÊ¾ÊÇ·ñÖ§³ÖÀ©Õ¹µÄÐ£Ê±ÅäÖÃ½á¹¹
                                   // bySupport&0x4, ±íÊ¾ÊÇ·ñÖ§³Ö¶àÍø¿¨(¶àÍø¸ôÀë)
                                   // bySupport&0x8, ±íÊ¾ÊÇ·ñÖ§³ÖÍø¿¨µÄbonding¹¦ÄÜ(ÍøÂçÈÝ´í)
                                   // bySupport&0x10, ±íÊ¾ÊÇ·ñÖ§³ÖÓïÒô¶Ô½²
                                   //2013-07-09 ÄÜÁ¦¼¯·µ»Ø
            public ushort wSupportMultiRadar;// Éè±¸ÄÜÁ¦£¬°´Î»±íÊ¾£¬0-²»Ö§³Ö£¬1-Ö§³Ö
                                             // wSupportMultiRadar&0x1£¬±íÊ¾ ¿¨¿ÚRS485À×´ï Ö§³Ö³µµÀ¹ØÁªÀ×´ï´¦Àí
                                             // wSupportMultiRadar&0x2£¬±íÊ¾ ¿¨¿ÚÐéÄâÏßÈ¦ Ö§³Ö³µµÀ¹ØÁªÀ×´ï´¦Àí
                                             // wSupportMultiRadar&0x4£¬±íÊ¾ »ìÐÐ¿¨¿Ú Ö§³Ö³µµÀ¹ØÁªÀ×´ï´¦Àí
                                             // wSupportMultiRadar&0x8£¬±íÊ¾ ÊÓÆµ¼ì²â Ö§³Ö³µµÀ¹ØÁªÀ×´ï´¦Àí
            public byte byICRPresetNum;
            // ±íÊ¾Ö§³ÖµÄICRÔ¤ÖÃµã£¨ÂË¹âÆ¬Æ«ÒÆµã£©Êý
            public byte byICRTimeSlot;//±íÊ¾Ö§³ÖµÄICRµÄÊ±¼ä¶ÎÊý£¨1¡«8£©
            public byte bySupportRS485Num;//±íÊ¾Ö§³ÖµÄRS485¿ÚµÄÊýÁ¿
            public byte byExpandRs485SupportSensor;// Éè±¸ÄÜÁ¦£¬°´Î»±íÊ¾£¬0-²»Ö§³Ö£¬1-Ö§³Ö
                                                   // byExpandRs485SupportSensor &0x1£¬±íÊ¾µç¾¯³µ¼ìÆ÷Ö§³Ö³µ¼ìÆ÷
                                                   // byExpandRs485SupportSensor &0x2£¬±íÊ¾¿¨Ê½µç¾¯³µ¼ìÆ÷Ö§³Ö³µ¼ìÆ÷
            public byte byExpandRs485SupportSignalLampDet;// Éè±¸ÄÜÁ¦£¬°´Î»±íÊ¾£¬0-²»Ö§³Ö£¬1-Ö§³Ö
                                                          // byExpandRs485SupportSignalLampDet &0x1£¬±íÊ¾µç¾¯³µ¼ìÆ÷Ö§³ÖÍâ½ÓÐÅºÅµÆ¼ì²âÆ÷
                                                          // byExpandRs485SupportSignalLampDet &0x2£¬±íÊ¾¿¨Ê½µç¾¯³µ¼ìÆ÷Ö§³ÖÍâ½ÓÐÅºÅµÆ¼ì²âÆ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICRTIMECFG
        {
            public NET_DVR_SCHEDTIME struTime;
            public byte byAssociateRresetNo;//Ô¤ÖÃµãºÅ1¡«8 , 0´ú±íÎÞ
            public byte bySubSwitchMode;//1~°×Ìì£¬2~ÍíÉÏ (µ±Ô¤ÖÃµãµÈÓÚ0 µÄÊ±ºòÉúÐ§)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_TIMESWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_ICRTIMECFG[] struAutoCtrlTime;//×Ô¶¯ÇÐ»»Ê±¼ä¶Î (×Ô¶¯ÇÐ»»ÏÂ Ê±¿ÕÏÂÉúÐ§ ÏÖÔÚÖ§³Ö4×é£¬Ô¤Áô4×é)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //Êµ¼ÊÉúÐ§¸ù¾ÝÄÜÁ¦¼¯¶¯Ì¬ÏÔÊ¾ [0~100] Êý×éÏÂ±ê±íÊ¾Ô¤ÖÃµãºÅ1¡«8 £¨0¡«7 Ïà¶ÔÓ¦£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_MANUALSWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //Êµ¼ÊÉúÐ§¸ù¾ÝÄÜÁ¦¼¯¶¯Ì¬ÏÔÊ¾ [0~100]
            public byte bySubSwitchMode;//1~°×Ìì£¬2~ÍíÉÏ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 147, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_AOTOSWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //Êµ¼ÊÉúÐ§¸ù¾ÝÄÜÁ¦¼¯¶¯Ì¬ÏÔÊ¾ [0~100] Êý×éÏÂ±ê±íÊ¾Ô¤ÖÃµãºÅ1¡«8 £¨0¡«7 Ïà¶ÔÓ¦£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 148, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 156, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen;
            public NET_ITC_ICR_AOTOSWITCH_PARAM struICRAutoSwitch;
            public NET_ITC_ICR_MANUALSWITCH_PARAM struICRManualSwitch;
            public NET_ITC_ICR_TIMESWITCH_PARAM struICRTimeSwitch;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICRCFG
        {
            public uint dwSize;
            public byte bySwitchType;//1~×Ô¶¯ÇÐ»»£¬2~ÊÖ¶¯ÇÐ»» ,3~¶¨Ê±ÇÐ»» 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_ITC_ICR_PARAM_UNION uICRParam;
        }

        //2013-07-09 Òì³£´¦Àí
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_HANDLEEXCEPTION
        {
            public uint dwHandleType; //Òì³£´¦Àí,Òì³£´¦Àí·½Ê½µÄ"»ò"½á¹û
            /*0x00: ÎÞÏìÓ¦*/
            /*0x01: ¼àÊÓÆ÷ÉÏ¾¯¸æ*/
            /*0x02: ÉùÒô¾¯¸æ*/
            /*0x04: ÉÏ´«ÖÐÐÄ*/
            /*0x08: ´¥·¢±¨¾¯Êä³ö£¨¼ÌµçÆ÷Êä³ö£©*/
            /*0x10: ´¥·¢JPRG×¥Í¼²¢ÉÏ´«Email*/
            /*0x20: ÎÞÏßÉù¹â±¨¾¯Æ÷Áª¶¯*/
            /*0x40: Áª¶¯µç×ÓµØÍ¼(Ä¿Ç°Ö»ÓÐPCNVRÖ§³Ö)*/
            /*0x200: ×¥Í¼²¢ÉÏ´«FTP*/
            public byte byEnable; //0¡«²»ÆôÓÃ£¬1¡«ÆôÓÃ
            public byte byRes;
            public ushort wDuration;//³ÖÐøÊ±¼ä(µ¥Î»/s)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITC_EXCEPTIONOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutTriggered;//´¥·¢Êä³öÍ¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_EXCEPTION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_HANDLEEXCEPTION[] struSnapExceptionType;
            //Êý×éµÄÃ¿¸öÔªËØ¶¼±íÊ¾Ò»ÖÖÒì³££¬Êý×é0- Ó²ÅÌ³ö´í,1-ÍøÏß¶Ï,2-IP µØÖ·³åÍ», 3-³µ¼ìÆ÷Òì³£, 4-ÐÅºÅµÆ¼ì²âÆ÷Òì³£
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRIGCOORDINATE
        {
            public ushort wTopLeftX; /*ÏßÈ¦×óÉÏ½Çºá×ø±ê£¨2¸ö×Ö½Ú£©*/
            public ushort wTopLeftY; /*ÏßÈ¦×óÉÏ½Ç×Ý×ø±ê£¨2¸ö×Ö½Ú£©*/
            public ushort wWdith; /*ÏßÈ¦¿í¶È£¨2¸ö×Ö½Ú£©*/
            public ushort wHeight; /*ÏßÈ¦¸ß¶È£¨2¸ö×Ö½Ú£©*/
        }

        public enum PROVINCE_CITY_IDX
        {
            ANHUI_PROVINCE = 0,              //°²»Õ
            AOMEN_PROVINCE = 1,              //°ÄÃÅ
            BEIJING_PROVINCE = 2,              //±±¾©
            CHONGQING_PROVINCE = 3,              //ÖØÇì
            FUJIAN_PROVINCE = 4,              //¸£½¨
            GANSU_PROVINCE = 5,              //¸ÊËà
            GUANGDONG_PROVINCE = 6,              //¹ã¶«
            GUANGXI_PROVINCE = 7,              //¹ãÎ÷
            GUIZHOU_PROVINCE = 8,              //¹óÖÝ
            HAINAN_PROVINCE = 9,              //º£ÄÏ
            HEBEI_PROVINCE = 10,             //ºÓ±±
            HENAN_PROVINCE = 11,             //ºÓÄÏ
            HEILONGJIANG_PROVINCE = 12,             //ºÚÁú½­
            HUBEI_PROVINCE = 13,             //ºþ±±
            HUNAN_PROVINCE = 14,             //ºþÄÏ
            JILIN_PROVINCE = 15,             //¼ªÁÖ
            JIANGSU_PROVINCE = 16,             //½­ËÕ
            JIANGXI_PROVINCE = 17,             //½­Î÷
            LIAONING_PROVINCE = 18,             //ÁÉÄþ
            NEIMENGGU_PROVINCE = 19,             //ÄÚÃÉ¹Å
            NINGXIA_PROVINCE = 20,             //ÄþÏÄ
            QINGHAI_PROVINCE = 21,             //Çàº£
            SHANDONG_PROVINCE = 22,             //É½¶«
            SHANXI_JIN_PROVINCE = 23,             //É½Î÷
            SHANXI_SHAN_PROVINCE = 24,             //ÉÂÎ÷
            SHANGHAI_PROVINCE = 25,             //ÉÏº£
            SICHUAN_PROVINCE = 26,             //ËÄ´¨
            TAIWAN_PROVINCE = 27,             //Ì¨Íå
            TIANJIN_PROVINCE = 28,             //Ìì½ò
            XIZANG_PROVINCE = 29,             //Î÷²Ø
            XIANGGANG_PROVINCE = 30,             //Ïã¸Û
            XINJIANG_PROVINCE = 31,             //ÐÂ½®
            YUNNAN_PROVINCE = 32,             //ÔÆÄÏ
            ZHEJIANG_PROVINCE = 33              //Õã½­
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GEOGLOCATION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
            public int[] iRes; /*±£Áô*/
            public uint dwCity; /*³ÇÊÐ£¬Ïê¼ûPROVINCE_CITY_IDX */
        }

        //³¡¾°Ä£Ê½
        public enum SCENE_MODE
        {
            UNKOWN_SCENE_MODE = 0,            //Î´Öª³¡¾°Ä£Ê½
            HIGHWAY_SCENE_MODE = 1,            //¸ßËÙ³¡¾°Ä£Ê½
            SUBURBAN_SCENE_MODE = 2,            //½¼Çø³¡¾°Ä£Ê½(±£Áô)
            URBAN_SCENE_MODE = 3,            //ÊÐÇø³¡¾°Ä£Ê½
            TUNNEL_SCENE_MODE = 4             //ËíµÀ³¡¾°Ä£Ê½(±£Áô)
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VTPARAM
        {
            public uint dwSize;
            public byte byEnable;  /* ÊÇ·ñÊ¹ÄÜÐéÄâÏßÈ¦£¬0-²»Ê¹ÓÃ£¬1-Ê¹ÓÃ*/
            public byte byIsDisplay; /* ÊÇ·ñÏÔÊ¾ÐéÄâÏßÈ¦£¬0-²»ÏÔÊ¾£¬1-ÏÔÊ¾*/
            public byte byLoopPos; //Íí¼ä´¥·¢ÏßÈ¦µÄÆ«Ïò£º0-ÏòÉÏ£¬1-ÏòÏÂ
            public byte bySnapGain; /*×¥ÅÄÔöÒæ*/
            public uint dwSnapShutter; /*×¥ÅÄ¿ìÃÅËÙ¶È*/
            public NET_DVR_TRIGCOORDINATE struTrigCoordinate; //±£Áô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_TRIGCOORDINATE[] struRes;
            public byte byTotalLaneNum;/*ÊÓÆµ´¥·¢µÄ³µµÀÊý1*/
            public byte byPolarLenType; /*Æ«Õñ¾µÀàÐÍ£¬0£º²»¼ÓÆ«Õñ¾µ£»1£º¼ÓÊ©ÄÍµÂÆ«Õñ¾µ¡£*/
            public byte byDayAuxLightMode; /*°×Ìì¸¨ÖúÕÕÃ÷Ä£Ê½£¬0£ºÎÞ¸¨ÖúÕÕÃ÷£»1£ºLEDµÆÕÕÃ÷£»2£ºÉÁ¹âµÆÕÕÃ÷*/
            public byte byLoopToCalRoadBright; /*ÓÃÒÔ¼ÆËãÂ·ÃæÁÁ¶ÈµÄ³µµÀ(ÐéÄâÏßÈ¦)*/
            public byte byRoadGrayLowTh; /*Â·ÃæÁÁ¶ÈµÍãÐÖµ³õÊ¼»¯Öµ1*/
            public byte byRoadGrayHighTh; /*Â·ÃæÁÁ¶È¸ßãÐÖµ³õÊ¼»¯Öµ140*/
            public ushort wLoopPosBias; /*Íí¼ä´¥·¢ÏßÈ¦Î»ÒÆ30*/
            public uint dwHfrShtterInitValue; /*Á¬ÐøÍ¼ÏñÆØ¹âÊ±¼äµÄ³õÊ¼Öµ2000*/
            public uint dwSnapShtterInitValue; /*×¥ÅÄÍ¼ÏñÆØ¹âÊ±¼äµÄ³õÊ¼Öµ500*/
            public uint dwHfrShtterMaxValue; /*Á¬ÐøÍ¼ÏñÆØ¹âÊ±¼äµÄ×î´óÖµ20000*/
            public uint dwSnapShtterMaxValue; /*×¥ÅÄÍ¼ÏñÆØ¹âÊ±¼äµÄ×î´óÖµ1500*/
            public uint dwHfrShtterNightValue; /*Íí¼äÁ¬ÐøÍ¼ÏñÆØ¹âÊ±¼äµÄÉèÖÃÖµ3000*/
            public uint dwSnapShtterNightMinValue; /*Íí¼ä×¥ÅÄÍ¼ÏñÆØ¹âÊ±¼äµÄ×îÐ¡Öµ3000*/
            public uint dwSnapShtterNightMaxValue; /*Íí¼ä×¥ÅÄÍ¼ÏñÆØ¹âÊ±¼äµÄ×î´óÖµ5000*/
            public uint dwInitAfe; /*ÔöÒæµÄ³õÊ¼Öµ200*/
            public uint dwMaxAfe; /*ÔöÒæµÄ×î´óÖµ400*/
            public ushort wResolutionX;/* Éè±¸µ±Ç°·Ö±æÂÊ¿í*/
            public ushort wResolutionY;/* Éè±¸µ±Ç°·Ö±æÂÊ¸ß*/
            public uint dwGainNightValue; /*Íí¼äÔöÒæ£¬Ä¬ÈÏÖµ70*/
            public uint dwSceneMode; /*³¡¾°Ä£Ê½£¬ Ïê¼ûSCENE_MODE */
            public uint dwRecordMode; /*Â¼Ïñ±êÖ¾£º0-²»Â¼Ïñ£¬1-Â¼Ïñ*/
            public NET_DVR_GEOGLOCATION struGeogLocation; /*µØÖ·Î»ÖÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrigFlag; /*´¥·¢±êÖ¾£¬0-³µÍ·´¥·¢£»1-³µÎ²´¥·¢£»2-³µÍ·/³µÎ²¶¼´¥·¢*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrigSensitive;  /*´¥·¢ÁéÃô¶È£¬1-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAPENABLECFG
        {
            public uint dwSize;
            public byte byPlateEnable;//ÊÇ·ñÖ§³Ö³µÅÆÊ¶±ð£¬0-²»Ö§³Ö£¬1-Ö§³Ö
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;   //±£Áô
            public byte byFrameFlip;   //Í¼ÏñÊÇ·ñ·­×ª 0-²»·­×ª£¬1-·­×ª
            public ushort wFlipAngle;    //Í¼Ïñ·­×ª½Ç¶È 0,90,180,270
            public ushort wLightPhase;   //ÏàÎ»£¬È¡Öµ·¶Î§[0, 360]
            public byte byLightSyncPower;  //ÊÇ·ñÐÅºÅµÆµçÔ´Í¬²½£¬0-²»Í¬²½£»1-Í¬²½
            public byte byFrequency;		//ÐÅºÅÆµÂÊ
            public byte byUploadSDEnable;  //ÊÇ·ñ×Ô¶¯ÉÏ´«SDÍ¼Æ¬£¬0-·ñ£»1-ÊÇ
            public byte byPlateMode; //Ê¶±ðÄ£Ê½²ÎÊý:0-ÊÓÆµ´¥·¢,1-Íâ²¿´¥·¢
            public byte byUploadInfoFTP; //ÊÇ·ñÉÏ´«×¥ÅÄ¸½¼ÓÐÅÏ¢µ½FTP£¬0-·ñ£¬1-ÊÇ
            public byte byAutoFormatSD; //ÊÇ·ñ×Ô¶¯¸ñÊ½»¯SD¿¨£¬0-·ñ£¬1-ÊÇ
            public ushort wJpegPicSize; //JpegÍ¼Æ¬´óÐ¡[64-8196]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }

        /*ftpÉÏ´«²ÎÊý*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FTPCFG
        {
            public uint dwSize;
            public uint dwEnableFTP;			/*ÊÇ·ñÆô¶¯ftpÉÏ´«¹¦ÄÜ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFTPIP;				/*ftp ·þÎñÆ÷*/
            public uint dwFTPPort;				/*ftp¶Ë¿Ú*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/*ÓÃ»§Ãû*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	/*ÃÜÂë*/
            public uint dwDirLevel;	/*0 = ²»Ê¹ÓÃÄ¿Â¼½á¹¹£¬Ö±½Ó±£´æÔÚ¸ùÄ¿Â¼,1 = Ê¹ÓÃ1¼¶Ä¿Â¼,2=Ê¹ÓÃ2¼¶Ä¿Â¼*/
            public ushort wTopDirMode;	/* Ò»¼¶Ä¿Â¼£¬0x1 = Ê¹ÓÃÉè±¸Ãû,0x2 = Ê¹ÓÃÉè±¸ºÅ,0x3 = Ê¹ÓÃÉè±¸ipµØÖ·£¬0x4=Ê¹ÓÃ¼à²âµã,0x5=Ê¹ÓÃÊ±¼ä(ÄêÔÂ),0x=6×Ô¶¨Òå,0x7=Î¥¹æÀàÐÍ,0x8=·½Ïò,0x9=µØµã*/
            public ushort wSubDirMode;	/* ¶þ¼¶Ä¿Â¼£¬0x1 = Ê¹ÓÃÍ¨µÀÃû,0x2 = Ê¹ÓÃÍ¨µÀºÅ£¬,0x3=Ê¹ÓÃÊ±¼ä(ÄêÔÂÈÕ),0x4=Ê¹ÓÃ³µµÀºÅ,0x=5×Ô¶¨Òå,0x6=Î¥¹æÀàÐÍ,0x7=·½Ïò,0x8=µØµã*/
            public byte byEnableAnony; //ÆôÓÃÄäÃû£¬0-·ñ£¬1-ÊÇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*¿ÉÓÃÀ´ÃüÃûÍ¼Æ¬µÄÏà¹ØÔªËØ */
        public const int PICNAME_ITEM_DEV_NAME = 1;		/*Éè±¸Ãû*/
        public const int PICNAME_ITEM_DEV_NO = 2;		/*Éè±¸ºÅ*/
        public const int PICNAME_ITEM_DEV_IP = 3;		/*Éè±¸IP*/
        public const int PICNAME_ITEM_CHAN_NAME = 4;	/*Í¨µÀÃû*/
        public const int PICNAME_ITEM_CHAN_NO = 5;		/*Í¨µÀºÅ*/
        public const int PICNAME_ITEM_TIME = 6;		/*Ê±¼ä*/
        public const int PICNAME_ITEM_CARDNO = 7;		/*¿¨ºÅ*/
        public const int PICNAME_ITEM_PLATE_NO = 8;   /*³µÅÆºÅÂë*/
        public const int PICNAME_ITEM_PLATE_COLOR = 9;   /*³µÅÆÑÕÉ«*/
        public const int PICNAME_ITEM_CAR_CHAN = 10;  /*³µµÀºÅ*/
        public const int PICNAME_ITEM_CAR_SPEED = 11;  /*³µÁ¾ËÙ¶È*/
        public const int PICNAME_ITEM_CARCHAN = 12;  /*¼à²âµã*/
        public const int PICNAME_ITEM_PIC_NUMBER = 13;  //Í¼Æ¬ÐòºÅ
        public const int PICNAME_ITEM_CAR_NUMBER = 14;  //³µÁ¾ÐòºÅ

        public const int PICNAME_ITEM_SPEED_LIMIT_VALUES = 15; //ÏÞËÙÖµ
        public const int PICNAME_ITEM_ILLEGAL_CODE = 16; //¹ú±êÎ¥·¨´úÂë
        public const int PICNAME_ITEM_CROSS_NUMBER = 17; //Â·¿Ú±àºÅ
        public const int PICNAME_ITEM_DIRECTION_NUMBER = 18; //·½Ïò±àºÅ

        public const int PICNAME_MAXITEM = 15;
        //Í¼Æ¬ÃüÃû
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICTURE_NAME
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PICNAME_MAXITEM, ArraySubType = UnmanagedType.I1)]
            public byte[] byItemOrder;	/*	èñÊý×é¶¨ÒåÎÄ¼þÃüÃûµÄ¹æÔò */
            public byte byDelimiter;		/*·Ö¸ô·û£¬Ò»°ãÎª'_'*/
        }


        //ÃüÃû¹æÔò£º2013-09-27
        public const int PICNAME_ITEM_PARK_DEV_IP = 1;	/*Éè±¸IP*/
        public const int PICNAME_ITEM_PARK_PLATE_NO = 2;/*³µÅÆºÅÂë*/
        public const int PICNAME_ITEM_PARK_TIME = 3;	/*Ê±¼ä*/
        public const int PICNAME_ITEM_PARK_INDEX = 4;   /*³µÎ»±àºÅ*/
        public const int PICNAME_ITEM_PARK_STATUS = 5;  /*³µÎ»×´Ì¬*/

        //Í¼Æ¬ÃüÃûÀ©Õ¹ 2013-09-27
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICTURE_NAME_EX
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PICNAME_MAXITEM, ArraySubType = UnmanagedType.I1)]
            public byte[] byItemOrder;	/*	èñÊý×é¶¨ÒåÎÄ¼þÃüÃûµÄ¹æÔò */
            public byte byDelimiter;	            	/*·Ö¸ô·û£¬Ò»°ãÎª'_'*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                      /*±£Áô*/
        }

        /* ´®¿Ú×¥Í¼ÉèÖÃ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SERIAL_CATCHPIC_PARA
        {
            public byte byStrFlag;	/*´®¿ÚÊý¾Ý¿ªÊ¼·û*/
            public byte byEndFlag;	/*½áÊø·û*/
            public ushort wCardIdx;	/*¿¨ºÅÏà¶ÔÆðÊ¼Î»*/
            public uint dwCardLen;	/*¿¨ºÅ³¤¶È*/
            public uint dwTriggerPicChans;	/*Ëù´¥·¢µÄÍ¨µÀºÅ£¬°´Î»£¬´ÓµÚ1Î»¿ªÊ¼¼Æ£¬¼´0x2±íÊ¾µÚÒ»Í¨µÀ*/
        }

        //DVR×¥Í¼²ÎÊýÅäÖÃ£¨»ùÏß£©
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEGCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_JPEGPARA[] struJpegPara;	/*Ã¿¸öÍ¨µÀµÄÍ¼Ïñ²ÎÊý*/
            public ushort wBurstMode;							/*×¥Í¼·½Ê½,°´Î»ÉèÖÃ.0x1=±¨¾¯ÊäÈë´¥·¢£¬0x2=ÒÆ¶¯Õì²â´¥·¢ 0x4=232´¥·¢£¬0x8=485´¥·¢£¬0x10=ÍøÂç´¥·¢*/
            public ushort wUploadInterval;					/*Í¼Æ¬ÉÏ´«¼ä¸ô(Ãë)[0,65535]*/
            public NET_DVR_PICTURE_NAME struPicNameRule;	/* Í¼Æ¬ÃüÃû¹æÔò */
            public byte bySaveToHD;		/*ÊÇ·ñ±£´æµ½Ó²ÅÌ*/
            public byte byRes1;
            public ushort wCatchInterval;		/*×¥Í¼¼ä¸ô(ºÁÃë)[0,65535]*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_SERIAL_CATCHPIC_PARA struRs232Cfg;
            public NET_DVR_SERIAL_CATCHPIC_PARA struRs485Cfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwTriggerPicTimes;	/* Ã¿¸öÍ¨µÀÒ»´Î´¥·¢ÅÄÕÕ´ÎÊý */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwAlarmInPicChanTriggered; /*±¨¾¯´¥·¢×¥ÅÄÍ¨µÀ,°´Î»ÉèÖÃ£¬´ÓµÚ1Î»¿ªÊ¼*/
        }

        //×¥ÅÄ´¥·¢ÇëÇó½á¹¹(±£Áô)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MANUALSNAP
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SPRCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHJC_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDefaultCHN; /*Éè±¸ÔËÐÐÊ¡·ÝµÄºº×Ö¼òÐ´*/
            public byte byPlateOSD;    /*0:²»·¢ËÍ³µÅÆ²ÊÉ«Í¼,1:·¢ËÍ³µÅÆ²ÊÉ«Í¼*/
            public byte bySendJPEG1;   /*0-²»´«ËÍ½ü¾°JPEGÍ¼,1-´«ËÍ½ü¾°JPEGÍ¼*/
            public byte bySendJPEG2;   /*0-²»´«ËÍÔ¶¾°JPEGÍ¼,1-´«ËÍÔ¶¾°JPEGÍ¼*/
            public ushort wDesignedPlateWidth;   /*³µÅÆÉè¼Æ¿í¶È*/
            public byte byTotalLaneNum;  /*Ê¶±ðµÄ³µµÀÊý*/
            public byte byRes1;      /*±£Áô*/
            public ushort wRecognizedLane;  /*Ê¶±ðµÄ³µµÀºÅ£¬°´Î»±íÊ¾£¬bit0±íÊ¾³µµÀ1ÊÇ·ñÊ¶±ð£¬0-²»Ê¶±ð£¬1-Ê¶±ð*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANERECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struLaneRect;  /*³µµÀÊ¶±ðÇøÓò*/
            public uint dwRecogMode;  /*Ê¶±ðµÄÀàÐÍ£¬
	        bit0-±³ÏòÊ¶±ð£º0-ÕýÏò³µÅÆÊ¶±ð£¬1-±³ÏòÊ¶±ð(Î²ÅÆÊ¶±ð) £» 
		    bit1-´ó³µÅÆÊ¶±ð»òÐ¡³µÅÆÊ¶±ð£º0-Ð¡³µÅÆÊ¶±ð£¬1-´ó³µÅÆÊ¶±ð £»
		    bit2-³µÉíÑÕÉ«Ê¶±ð£º0-²»²ÉÓÃ³µÉíÑÕÉ«Ê¶±ð£¬ÔÚ±³ÏòÊ¶±ð»òÐ¡³µÅÆÊ¶±ðÊ±½ûÖ¹ÆôÓÃ£¬1-³µÉíÑÕÉ«Ê¶±ð£»
		    bit3-Å©ÓÃ³µÊ¶±ð£º0-²»²ÉÓÃÅ©ÓÃ³µÊ¶±ð£¬1-Å©ÓÃ³µÊ¶±ð£» 
		    bit4-Ä£ºýÊ¶±ð£º0-²»²ÉÓÃÄ£ºýÊ¶±ð£¬1-Ä£ºýÊ¶±ð£»
		    bit5-Ö¡¶¨Î»»ò³¡¶¨Î»£º0-Ö¡¶¨Î»£¬1-³¡¶¨Î»£»
		    bit6-Ö¡Ê¶±ð»ò³¡Ê¶±ð£º0-Ö¡Ê¶±ð£¬1-³¡Ê¶±ð£» 
		    bit7-ÍíÉÏ»ò°×Ìì£º0-°×Ìì£¬1-ÍíÉÏ */
            public byte bySendPRRaw;       	//ÊÇ·ñ·¢ËÍÔ­Í¼£º0-²»·¢ËÍ£¬1-·¢ËÍ 
            public byte bySendBinImage;  	//ÊÇ·ñ·¢ËÍ³µÅÆ¶þÖµÍ¼£º0-²»·¢ËÍ£¬1-·¢ËÍ 
            public byte byDelayCapture;  //ÑÓÊ±×¥ÅÄ¿ØÖÆ,µ¥Î»£ºÖ¡
            public byte byUseLED;    //Ê¹ÓÃLED¿ØÖÆ£¬0-·ñ£¬1-ÊÇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLCCFG
        {
            public uint dwSize;
            public byte byPlcEnable;	//ÊÇ·ñÆôÓÃ³µÅÆÁÁ¶È²¹³¥£¨Ä¬ÈÏÆôÓÃ£©£º0-¹Ø±Õ£¬1-ÆôÓÃ 
            public byte byPlateExpectedBright;	//³µÅÆµÄÔ¤ÆÚÁÁ¶È£¨Ä¬ÈÏÖµ50£©, ·¶Î§[0, 100]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//±£Áô 
            public byte byTradeoffFlash;     //ÊÇ·ñ¿¼ÂÇÉÁ¹âµÆµÄÓ°Ïì: 0 - ·ñ;  1 - ÊÇ(Ä¬ÈÏ); 
                                             //Ê¹ÓÃÉÁ¹âµÆ²¹¹âÊ±, Èç¹û¿¼ÂÇ¼õÈõÉÁ¹âµÆµÄÁÁ¶ÈÔöÇ¿Ð§Ó¦, ÔòÐèÒªÉèÎª1;·ñÔòÎª0
            public byte byCorrectFactor;     //¾ÀÕýÏµÊý, ·¶Î§[0, 100], Ä¬ÈÏÖµ50 (ÔÚtradeoff_flashÇÐ»»Ê±,»Ö¸´Ä¬ÈÏÖµ£©
            public ushort wLoopStatsEn;  //ÊÇ·ñ¸ÃÏßÈ¦µÄÁÁ¶È£¬°´Î»±íÊ¾£¬0-²»Í³¼Æ£¬1-Í³¼Æ
            public byte byPlcBrightOffset;// ³µÅÆÁÁ¶È²¹³¥ÁéÃô¶È(ÐéÄâÏßÈ¦Ä£Ê½ÆðÐ§)£¬È¡Öµ·¶Î§1~100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICESTATECFG
        {
            public uint dwSize;
            public ushort wPreviewNum; //Ô¤ÀÀÁ¬½Ó¸öÊý
            public ushort wFortifyLinkNum; //²¼·ÀÁ¬½Ó¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struPreviewIP;  //Ô¤ÀÀµÄÓÃ»§IPµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FORTIFY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struFortifyIP; //²¼·ÀÁ¬½ÓµÄÓÃ»§IPµØÖ·
            public uint dwVideoFrameRate;	//Ö¡ÂÊ£º0-È«²¿; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; 14-15; 15-18; 16-22;
            public byte byResolution;  	//·Ö±æÂÊ0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5£¨±£Áô£©,16-VGA£¨640*480£©, 17-UXGA£¨1600*1200£©, 18-SVGA £¨800*600£©,19-HD720p£¨1280*720£©,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
            public byte bySnapResolution;  	//×¥ÅÄ·Ö±æÂÊ0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5£¨±£Áô£©,16-VGA£¨640*480£©, 17-UXGA£¨1600*1200£©, 18-SVGA £¨800*600£©,19-HD720p£¨1280*720£©,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
            public byte byStreamType; //´«ÊäÀàÐÍ£º0-Ö÷ÂëÁ÷£»1-×ÓÂëÁ÷
            public byte byTriggerType; //´¥·¢Ä£Ê½£º0-ÊÓÆµ´¥·¢£»1-ÆÕÍ¨´¥·¢
            public uint dwSDVolume;  //SD¿¨ÈÝÁ¿
            public uint dwSDFreeSpace; //SD¿¨Ê£Óà¿Õ¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DRIVECHAN_NUM * MAX_COIL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDetectorState;  //³µ¼ìÆ÷×´Ì¬£º0-Î´Ê¹ÓÃ£»1-Õý³££»2-Òì³£
            public byte byDetectorLinkState; //³µ¼ìÆ÷Á¬½Ó×´Ì¬£º0-Î´Á¬½Ó£»1-Á¬½Ó
            public byte bySDStatus;    //SD¿¨×´Ì¬ 0£­»î¶¯£»1£­ÐÝÃß£»2£­Òì³££¬3-ÎÞsd¿¨
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FORTIFY_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byFortifyLevel; //²¼·ÀµÈ¼¶£¬0-ÎÞ£¬1-Ò»µÈ¼¶£¨¸ß£©£¬2-¶þµÈ¼¶£¨ÖÐ£©£¬3-ÈýµÈ¼¶£¨µÍ£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSTEPOLICECFG
        {
            public uint dwSize;
            public uint dwDistance;//ÏßÈ¦¾àÀë,µ¥Î»cm£¬È¡Öµ·¶Î§[0,20000]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SIGNALLIGHT_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLightChan;	//ÐÅºÅµÆÍ¨µÀºÅ
            public byte byCapSpeed;//±êÖ¾ÏÞËÙ£¬µ¥Î»km/h£¬È¡Öµ·¶Î§[0,255]
            public byte bySpeedLimit;//ÏÞËÙÖµ£¬µ¥Î»km/h£¬È¡Öµ·¶Î§[0,255]
            public byte byTrafficDirection;//³µÁ÷·½Ïò£¬0-ÓÉ¶«ÏòÎ÷£¬1-ÓÉÎ÷Ïò¶«£¬2-ÓÉÄÏÏò±±£¬3-ÓÉ±±ÏòÄÏ
            public byte byRes1; //±£Áô
            public ushort wLoopPreDist;        /*´¥·¢ÑÓ³Ù¾àÀë £¬µ¥Î»£º·ÖÃ×*/
            public ushort wTrigDelay;             /*´¥·¢Ó²ÑÓÊ±Ê±¼ä £¬µ¥Î»£ººÁÃë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô×Ö½Ú
        }
        /***************************** end *********************************************/
        public const int IPC_PROTOCOL_NUM = 50;  //ipc Ð­Òé×î´ó¸öÊý

        //Ð­ÒéÀàÐÍ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PROTO_TYPE
        {
            public uint dwType;               /*ipcÐ­ÒéÖµ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; /*Ð­ÒéÃèÊö×Ö¶Î*/
        }

        //Ð­ÒéÁÐ±í
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_PROTO_LIST
        {
            public uint dwSize;
            public uint dwProtoNum;           /*ÓÐÐ§µÄipcÐ­ÒéÊýÄ¿*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = IPC_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE[] struProto;   /*ÓÐÐ§µÄipcÐ­Òé*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_ALERTLINE_NUM = 8; //×î´ó¾¯½äÏßÌõÊý	

        //Ô½½çÕì²â²éÑ¯Ìõ¼þ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRAVERSE_PLANE_SEARCHCOND
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALERTLINE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_TRAVERSE_PLANE[] struVcaTraversePlane;  //´©Ô½¾³½çÃæ²ÎÊý
            public uint dwPreTime;   /*ÖÇÄÜ±¨¾¯ÌáÇ°Ê±¼ä µ¥Î»:Ãë*/
            public uint dwDelayTime; /*ÖÇÄÜ±¨¾¯ÑÓ³ÙÊ±¼ä µ¥Î»:Ãë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5656, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }

        public const int MAX_INTRUSIONREGION_NUM = 8; //×î´óÇøÓòÊýÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INTRUSION_SEARCHCOND
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTRUSIONREGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_INTRUSION[] struVcaIntrusion; //ÈëÇÖÇøÓò
            public uint dwPreTime;   /*ÖÇÄÜ±¨¾¯ÌáÇ°Ê±¼ä µ¥Î»:Ãë*/
            public uint dwDelayTime; /*ÖÇÄÜ±¨¾¯ÑÓ³ÙÊ±¼ä µ¥Î»:Ãë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5400, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }


        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_AREA_SMARTSEARCH_COND_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6144, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;  //½á¹¹Ìå³¤¶È
            /*[FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64 * 96, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope; //Õì²âÇøÓò 0-96Î»±íÊ¾64ÐÐ£¬¹²ÓÐ96*64¸öÐ¡ºê¿é£¬1-ÊÇÒÆ¶¯Õì²âÇøÓò£¬0-·ÇÒÆ¶¯Õì²âÇøÓò 
            [FieldOffsetAttribute(0)]
            public NET_DVR_TRAVERSE_PLANE_SEARCHCOND struTraversPlaneCond; //Ô½½çÕì²â
            [FieldOffsetAttribute(0)]
            public NET_DVR_INTRUSION_SEARCHCOND struIntrusionCond; //ÇøÓòÈëÇÖ
             * */
        }

        //ÖÇÄÜËÑË÷²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMART_SEARCH_PARAM
        {
            public byte byChan;					//Í¨µÀºÅ
            public byte bySearchCondType; //ÖÇÄÜ²éÕÒÁªºÏÌåNET_DVR_AREA_SMARTSEARCH_COND_UNIONµÄË÷Òý     
            /*0-ÒÆ¶¯Õì²âÇøÓò £¬1-Ô½½çÕì²â£¬ 2-ÇøÓòÈëÇÖ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_TIME struStartTime;		//Â¼Ïñ¿ªÊ¼µÄÊ±¼ä
            public NET_DVR_TIME struEndTime;		//Â¼ÏñÍ£Ö¹µÄÊ±¼ä
            public NET_DVR_AREA_SMARTSEARCH_COND_UNION uSmartSearchCond;  //ÖÇÄÜ²éÕÒÌõ¼þ
            public byte bySensitivity;   			//ÒÆ¶¯Õì²âËÑË÷ÁéÃô¶È,1	>80%  2 40%~80%  3 1%~40%
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMART_SEARCH_RET
        {
            public NET_DVR_TIME struStartTime;	//ÒÆ¶¯Õì²â±¨¾¯¿ªÊ¼µÄÊ±¼ä
            public NET_DVR_TIME struEndTime;   //ÊÂ¼þÍ£Ö¹µÄÊ±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IPSAN ÎÄ¼þÄ¿Â¼²éÕÒ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSAN_SERACH_PARAM
        {
            public NET_DVR_IPADDR struIP;     // IPSAN IPµØÖ·
            public ushort wPort;      // IPSAN  ¶Ë¿Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSAN_SERACH_RET
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirectory;  // ·µ»ØµÄÎÄ¼þÄ¿Â¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVRÉè±¸²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICECFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName; //DVRÃû³Æ
            public uint dwDVRID;				//DVR ID,ÓÃÓÚÒ£¿ØÆ÷ //V1.4(0-99), V1.5(0-255)
            public uint dwRecycleRecord;		//ÊÇ·ñÑ­»·Â¼Ïñ,0:²»ÊÇ; 1:ÊÇ
            //ÒÔÏÂ²»¿É¸ü¸Ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber; //ÐòÁÐºÅ
            public uint dwSoftwareVersion;			//Èí¼þ°æ±¾ºÅ,¸ß16Î»ÊÇÖ÷°æ±¾,µÍ16Î»ÊÇ´Î°æ±¾
            public uint dwSoftwareBuildDate;			//Èí¼þÉú³ÉÈÕÆÚ,0xYYYYMMDD
            public uint dwDSPSoftwareVersion;		    //DSPÈí¼þ°æ±¾,¸ß16Î»ÊÇÖ÷°æ±¾,µÍ16Î»ÊÇ´Î°æ±¾
            public uint dwDSPSoftwareBuildDate;		// DSPÈí¼þÉú³ÉÈÕÆÚ,0xYYYYMMDD
            public uint dwPanelVersion;				// Ç°Ãæ°å°æ±¾,¸ß16Î»ÊÇÖ÷°æ±¾,µÍ16Î»ÊÇ´Î°æ±¾
            public uint dwHardwareVersion;	// Ó²¼þ°æ±¾,¸ß16Î»ÊÇÖ÷°æ±¾,µÍ16Î»ÊÇ´Î°æ±¾
            public byte byAlarmInPortNum;		//DVR±¨¾¯ÊäÈë¸öÊý
            public byte byAlarmOutPortNum;		//DVR±¨¾¯Êä³ö¸öÊý
            public byte byRS232Num;			//DVR 232´®¿Ú¸öÊý
            public byte byRS485Num;			//DVR 485´®¿Ú¸öÊý 
            public byte byNetworkPortNum;		//ÍøÂç¿Ú¸öÊý
            public byte byDiskCtrlNum;			//DVR Ó²ÅÌ¿ØÖÆÆ÷¸öÊý
            public byte byDiskNum;				//DVR Ó²ÅÌ¸öÊý
            public byte byDVRType;				//DVRÀàÐÍ, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;				//DVR Í¨µÀ¸öÊý
            public byte byStartChan;			//ÆðÊ¼Í¨µÀºÅ,ÀýÈçDVS-1,DVR - 1
            public byte byDecordChans;			//DVR ½âÂëÂ·Êý
            public byte byVGANum;				//VGA¿ÚµÄ¸öÊý 
            public byte byUSBNum;				//USB¿ÚµÄ¸öÊý
            public byte byAuxoutNum;			//¸¨¿ÚµÄ¸öÊý
            public byte byAudioNum;			//ÓïÒô¿ÚµÄ¸öÊý
            public byte byIPChanNum;			//×î´óÊý×ÖÍ¨µÀÊý µÍ8Î»£¬¸ß8Î»¼ûbyHighIPChanNum 
            public byte byZeroChanNum;			//ÁãÍ¨µÀ±àÂë¸öÊý
            public byte bySupport;        //ÄÜÁ¦£¬Î»Óë½á¹ûÎª0±íÊ¾²»Ö§³Ö£¬1±íÊ¾Ö§³Ö£¬
                                          //bySupport & 0x1, ±íÊ¾ÊÇ·ñÖ§³ÖÖÇÄÜËÑË÷
                                          //bySupport & 0x2, ±íÊ¾ÊÇ·ñÖ§³Ö±¸·Ý
                                          //bySupport & 0x4, ±íÊ¾ÊÇ·ñÖ§³ÖÑ¹Ëõ²ÎÊýÄÜÁ¦»ñÈ¡
                                          //bySupport & 0x8, ±íÊ¾ÊÇ·ñÖ§³Ö¶àÍø¿¨
                                          //bySupport & 0x10, ±íÊ¾Ö§³ÖÔ¶³ÌSADP
                                          //bySupport & 0x20, ±íÊ¾Ö§³ÖRaid¿¨¹¦ÄÜ
                                          //bySupport & 0x40, ±íÊ¾Ö§³ÖIPSANËÑË÷
                                          //bySupport & 0x80, ±íÊ¾Ö§³Örtp over rtsp
            public byte byEsataUseage;		//EsataµÄÄ¬ÈÏÓÃÍ¾£¬0-Ä¬ÈÏ±¸·Ý£¬1-Ä¬ÈÏÂ¼Ïñ
            public byte byIPCPlug;			//0-¹Ø±Õ¼´²å¼´ÓÃ£¬1-´ò¿ª¼´²å¼´ÓÃ
            public byte byStorageMode;		//0-ÅÌ×éÄ£Ê½,1-´ÅÅÌÅä¶î, 2³éÖ¡Ä£Ê½
            public byte bySupport1;     //ÄÜÁ¦£¬Î»Óë½á¹ûÎª0±íÊ¾²»Ö§³Ö£¬1±íÊ¾Ö§³Ö
                                        //bySupport1 & 0x1, ±íÊ¾ÊÇ·ñÖ§³Ösnmp v30
                                        //bySupport1 & 0x2, Ö§³ÖÇø·Ö»Ø·ÅºÍÏÂÔØ
                                        //bySupport1 & 0x4, ÊÇ·ñÖ§³Ö²¼·ÀÓÅÏÈ¼¶	
                                        //bySupport1 & 0x8, ÖÇÄÜÉè±¸ÊÇ·ñÖ§³Ö²¼·ÀÊ±¼ä¶ÎÀ©Õ¹
                                        //bySupport1 & 0x10, ±íÊ¾ÊÇ·ñÖ§³Ö¶à´ÅÅÌÊý£¨³¬¹ý33¸ö£©
                                        //bySupport1 & 0x20, ±íÊ¾ÊÇ·ñÖ§³Örtsp over http	
            public ushort wDevType;//Éè±¸ÐÍºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DEV_TYPE_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDevTypeName;//Éè±¸ÐÍºÅÃû³Æ 
            public byte bySupport2; //ÄÜÁ¦¼¯À©Õ¹£¬Î»Óë½á¹ûÎª0±íÊ¾²»Ö§³Ö£¬1±íÊ¾Ö§³Ö
                                    //bySupport2 & 0x1, ±íÊ¾ÊÇ·ñÖ§³ÖÀ©Õ¹µÄOSD×Ö·ûµþ¼Ó(ÖÕ¶ËºÍ×¥ÅÄ»úÀ©Õ¹Çø·Ö)
            public byte byAnalogAlarmInPortNum; //Ä£Äâ±¨¾¯ÊäÈë¸öÊý
            public byte byStartAlarmInNo;    //Ä£Äâ±¨¾¯ÊäÈëÆðÊ¼ºÅ
            public byte byStartAlarmOutNo;  //Ä£Äâ±¨¾¯Êä³öÆðÊ¼ºÅ
            public byte byStartIPAlarmInNo;  //IP±¨¾¯ÊäÈëÆðÊ¼ºÅ  0-ÎÞÐ§
            public byte byStartIPAlarmOutNo; //IP±¨¾¯Êä³öÆðÊ¼ºÅ 0-ÎÞÐ§
            public byte byHighIPChanNum;     //Êý×ÖÍ¨µÀ¸öÊý£¬¸ß8Î» 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			//±£Áô
        }

        public const int MAX_ZEROCHAN_NUM = 16;
        //ÁãÍ¨µÀÑ¹ËõÅäÖÃ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZEROCHANCFG
        {
            public uint dwSize;			    //½á¹¹³¤¶È
            public byte byEnable;			//0-Í£Ö¹ÁãÍ¨µÀ±àÂë£¬1-±íÊ¾ÆôÓÃÁãÍ¨µÀ±àÂë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			//±£Áô
            public uint dwVideoBitrate; 	/*ÊÓÆµÂëÂÊ 0-±£Áô 1-16K(±£Áô) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 
                                             * 12-320K 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K
                                             * 23-2048K
                                             * ×î¸ßÎ»(31Î»)ÖÃ³É1±íÊ¾ÊÇ×Ô¶¨ÒåÂëÁ÷, 0-30Î»±íÊ¾ÂëÁ÷Öµ(MIN-32K MAX-8192K) */
            public uint dwVideoFrameRate;   //Ö¡ÂÊ 0-È«²¿; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, 
                                            //V2.0Ôö¼Ó14-15, 15-18, 16-22;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;        //±£Áô
        }

        //ÁãÍ¨µÀËõ·Å²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZERO_ZOOMCFG
        {
            public uint dwSize;			    //½á¹¹³¤¶È
            public NET_VCA_POINT struPoint;	//»­ÃæÖÐµÄ×ø±êµã
            public byte byState;		 //ÏÖÔÚµÄ×´Ì¬£¬0-ËõÐ¡£¬1-·Å´ó  
            public byte byPreviewNumber;       //Ô¤ÀÀÊýÄ¿,0-1»­Ãæ,1-4»­Ãæ,2-9»­Ãæ,3-16»­Ãæ ¸Ã²ÎÊýÖ»¶Á
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOW_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPreviewSeq;//»­ÃæÍ¨µÀÐÅÏ¢ ¸Ã²ÎÊýÖ»¶Á
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				//±£Áô 
        }

        public const int DESC_LEN_64 = 64;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPCFG
        {
            public uint dwSize;			//½á¹¹³¤¶È
            public byte byEnable;			//0-½ûÓÃSNMP£¬1-±íÊ¾ÆôÓÃSNMP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			//±£Áô
            public ushort wVersion;		//snmp °æ±¾  v1 = 1, v2 =2, v3 =3£¬Éè±¸Ä¿Ç°²»Ö§³Ö v3
            public ushort wServerPort; //snmpÏûÏ¢½ÓÊÕ¶Ë¿Ú£¬Ä¬ÈÏ 161
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byReadCommunity; //¶Á¹²Í¬Ìå£¬×î¶à31,Ä¬ÈÏ"public"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWriteCommunity;//Ð´¹²Í¬Ìå,×î¶à31 ×Ö½Ú,Ä¬ÈÏ "private"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_64, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapHostIP;	//×ÔÏÝÖ÷»úipµØÖ·ÃèÊö£¬Ö§³ÖIPV4 IPV6ºÍÓòÃûÃèÊö    
            public ushort wTrapHostPort;   //trapÖ÷»ú¶Ë¿Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 70, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPv3_USER
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;			// ÓÃ»§Ãû				
            public byte bySecLevel;	//°²È«¼¶±ð 1-ÎÞÐ£Ñé 2-ÎÞÊÚÈ¨Ð£Ñé 3-ÊÚÈ¨Ð£Ñé
            public byte byAuthtype;	//ÈÏÖ¤ÀàÐÍ 0-MD5ÈÏÖ¤ 1-SHAÈÏÖ¤ 2: none
            public byte byPrivtype;	//0: DES; 1: AES; 2: none;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAuthpass;	//ÈÏÖ¤ÃÜÂë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPrivpass;	//¼ÓÃÜÃÜÂë
        }

        //snmpv30
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPCFG_V30
        {
            public uint dwSize;			//½á¹¹³¤¶È
            public byte byEnableV1;		//0-½ûÓÃSNMP V1£¬1-±íÊ¾ÆôÓÃSNMP V1
            public byte byEnableV2;		//0-½ûÓÃSNMP V2£¬1-±íÊ¾ÆôÓÃSNMP V2
            public byte byEnableV3;		//0-½ûÓÃSNMP V3£¬1-±íÊ¾ÆôÓÃSNMP V3
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public ushort wServerPort;					//snmpÏûÏ¢½ÓÊÕ¶Ë¿Ú£¬Ä¬ÈÏ 161
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byReadCommunity;		//¶Á¹²Í¬Ìå£¬×î¶à31,Ä¬ÈÏ"public"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWriteCommunity;		//Ð´¹²Í¬Ìå,×î¶à31 ×Ö½Ú,Ä¬ÈÏ "private"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_64, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapHostIP;		//×ÔÏÝÖ÷»úipµØÖ·ÃèÊö£¬Ö§³ÖIPV4 IPV6ºÍÓòÃûÃèÊö    
            public ushort wTrapHostPort;					// trapÖ÷»ú¶Ë¿Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_SNMPv3_USER struRWUser;    // ¶ÁÐ´ÓÃ»§
            public NET_DVR_SNMPv3_USER struROUser;    // Ö»¶ÁÓÃ»§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapName;
        }

        public const int PROCESSING = 0;    //ÕýÔÚ´¦Àí
        public const int PROCESS_SUCCESS = 100;   //¹ý³ÌÍê³É
        public const int PROCESS_EXCEPTION = 400;   //¹ý³ÌÒì³£
        public const int PROCESS_FAILED = 500;   //¹ý³ÌÊ§°Ü
        public const int PROCESS_QUICK_SETUP_PD_COUNT = 501; //Ò»¼üÅäÖÃÖÁÉÙ3¿éÓ²ÅÌ

        public const int SOFTWARE_VERSION_LEN = 48;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADPINFO
        {
            public NET_DVR_IPADDR struIP;     // Éè±¸IPµØÖ·
            public ushort wPort;      // Éè±¸¶Ë¿ÚºÅ
            public ushort wFactoryType;   // Éè±¸³§¼ÒÀàÐÍ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = SOFTWARE_VERSION_LEN)]
            public string chSoftwareVersion;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string chSerialNo; // ÐòÁÐºÅ
            public ushort wEncCnt;   // ±àÂëÍ¨µÀ¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;		// MAC µØÖ·
            public NET_DVR_IPADDR struSubDVRIPMask;   // DVR IPµØÖ·ÑÚÂë
            public NET_DVR_IPADDR struGatewayIpAddr;  // Íø¹Ø
            public NET_DVR_IPADDR struDnsServer1IpAddr;	/* ÓòÃû·þÎñÆ÷1µÄIPµØÖ· */
            public NET_DVR_IPADDR struDnsServer2IpAddr;	/* ÓòÃû·þÎñÆ÷2µÄIPµØÖ· */
            public byte byDns;
            public byte byDhcp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 158, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     // ±£Áô×Ö½Ú
        }

        public const int MAX_SADP_NUM = 256;  //ËÑË÷µ½Éè±¸×î´óÊýÄ¿
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADPINFO_LIST
        {
            public uint dwSize;   //  ½á¹¹´óÐ¡
            public ushort wSadpNum;   // ËÑË÷µ½Éè±¸ÊýÄ¿
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SADP_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SADPINFO[] struSadpInfo; // ËÑË÷
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADP_VERIFY
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string chPassword;
            public NET_DVR_IPADDR struOldIP;
            public ushort wOldPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /***************************** end *********************************************/

        /*******************************±¸·Ý½á¹¹ begin********************************/
        //»ñÈ¡±¸·ÝÉè±¸ÐÅÏ¢½Ó¿Ú¶¨Òå
        public const int DESC_LEN_32 = 32;   //ÃèÊö×Ö³¤¶È
        public const int MAX_NODE_NUM = 256;  //½Úµã¸öÊý

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DESC_NODE
        {
            public int iValue;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; //ÃèÊö×Ö¶Î 
            public uint dwFreeSpace; //»ñÈ¡´ÅÅÌÁÐ±í×¨ÓÃ,µ¥Î»ÎªM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			  //±£Áô  
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISKABILITY_LIST
        {
            public uint dwSize;            //½á¹¹³¤¶È
            public uint dwNodeNum;		 //ÄÜÁ¦½áµã¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NODE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DESC_NODE[] struDescNode;  //ÃèÊö²ÎÊý  
        }

        //±¸·Ý½ø¶ÈÁÐ±í
        public const int BACKUP_SUCCESS = 100;  //±¸·ÝÍê³É
        public const int BACKUP_CHANGE_DEVICE = 101;  //±¸·ÝÉè±¸ÒÑÂú£¬¸ü»»Éè±¸¼ÌÐø±¸·Ý

        public const int BACKUP_SEARCH_DEVICE = 300;  //ÕýÔÚËÑË÷±¸·ÝÉè±¸
        public const int BACKUP_SEARCH_FILE = 301;  //ÕýÔÚËÑË÷Â¼ÏñÎÄ¼þ
        public const int BACKUP_SEARCH_LOG_FILE = 302;  //ÕýÔÚËÑË÷ÈÕÖ¾ÎÄ¼þ

        public const int BACKUP_EXCEPTION = 400;  //±¸·ÝÒì³£
        public const int BACKUP_FAIL = 500;  //±¸·ÝÊ§°Ü

        public const int BACKUP_TIME_SEG_NO_FILE = 501;  //Ê±¼ä¶ÎÄÚÎÞÂ¼ÏñÎÄ¼þ
        public const int BACKUP_NO_RESOURCE = 502;  //ÉêÇë²»µ½×ÊÔ´
        public const int BACKUP_DEVICE_LOW_SPACE = 503;  //±¸·ÝÉè±¸ÈÝÁ¿²»×ã
        public const int BACKUP_DISK_FINALIZED = 504;  //¿ÌÂ¼¹âÅÌ·âÅÌ
        public const int BACKUP_DISK_EXCEPTION = 505;  //¿ÌÂ¼¹âÅÌÒì³£
        public const int BACKUP_DEVICE_NOT_EXIST = 506;  //±¸·ÝÉè±¸²»´æÔÚ
        public const int BACKUP_OTHER_BACKUP_WORK = 507;  //ÓÐÆäËû±¸·Ý²Ù×÷ÔÚ½øÐÐ
        public const int BACKUP_USER_NO_RIGHT = 508;  //ÓÃ»§Ã»ÓÐ²Ù×÷È¨ÏÞ
        public const int BACKUP_OPERATE_FAIL = 509;  //²Ù×÷Ê§°Ü
        public const int BACKUP_NO_LOG_FILE = 510;  //Ó²ÅÌÖÐÎÞÈÕÖ¾

        //±¸·Ý¹ý³Ì½Ó¿Ú¶¨Òå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_NAME_PARAM
        {
            public uint dwFileNum;   //ÎÄ¼þ¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECORD_FILE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FINDDATA_V30[] struFileList; //ÎÄ¼þÁÐ±í
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;   //±¸·Ý´ÅÅÌÃèÊö
            public byte byWithPlayer;      //ÊÇ·ñ±¸·Ý²¥·ÅÆ÷
            public byte byContinue;    /*ÊÇ·ñ¼ÌÐø±¸·Ý 0²»¼ÌÐø 1¼ÌÐø*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_TIME_PARAM
        {
            public int lChannel;        //°´Ê±¼ä±¸·ÝµÄÍ¨µÀ
            public NET_DVR_TIME struStartTime;   //±¸·ÝµÄÆðÊ¼Ê±¼ä
            public NET_DVR_TIME struStopTime;    //±¸·ÝµÄÖÕÖ¹Ê±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;     //±¸·Ý´ÅÅÌÃèÊö
            public byte byWithPlayer;               //ÊÇ·ñ±¸·Ý²¥·ÅÆ÷
            public byte byContinue;                 //ÊÇ·ñ¼ÌÐø±¸·Ý 0²»¼ÌÐø 1¼ÌÐø
            public byte byDrawFrame;			     //0 ²»³éÖ¡  1 ³éÖ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;					 // ±£Áô×Ö½Ú 
        }
        /********************************* end *******************************************/
        public enum COMPRESSION_ABILITY_TYPE
        {
            COMPRESSION_STREAM_ABILITY = 0, //ÂëÁ÷Ñ¹ËõÀàÐÍ
            MAIN_RESOLUTION_ABILITY = 1,    //Ö÷ÂëÁ÷Ñ¹Ëõ·Ö±æÂÊ
            SUB_RESOLUTION_ABILITY = 2, //×ÓÂëÁ÷Ñ¹Ëõ·Ö±æÂÊ
            EVENT_RESOLUTION_ABILITY = 3,  //ÊÂ¼þÑ¹Ëõ²ÎÊý·Ö±æÂÊ
            FRAME_ABILITY = 4,              //Ö¡ÂÊÄÜÁ¦
            BITRATE_TYPE_ABILITY = 5,       //Î»ÂÊÀàÐÍÄÜÁ¦
            BITRATE_ABILITY = 6,            //Î»ÂÊÉÏÏÞ
            THIRD_RESOLUTION_ABILITY = 7,   //ÈýÂëÁ÷Ñ¹Ëõ·Ö±æÂÊ
            STREAM_TYPE_ABILITY = 8,        //ÂëÁ÷ÀàÐÍ
            PIC_QUALITY_ABILITY = 9,         //Í¼ÏñÖÊÁ¿
            INTERVAL_BPFRAME_ABILITY = 10,  //BPÖ¡¼ä¸ô
            VIDEO_ENC_ABILITY = 11,           //ÊÓÆµ±àÂëÄÜÁ¦
            AUDIO_ENC_ABILITY = 12,           //ÒôÆµ±àÂëÄÜÁ¦
            VIDEO_ENC_COMPLEXITY_ABILITY = 13, //ÊÓÆµ±àÂë¸´ÔÓ¶ÈÄÜÁ¦
            FORMAT_ABILITY = 14, //·â×°¸ñÊ½ÄÜÁ¦
        }

        //ÄÜÁ¦ÁÐ±í
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ABILITY_LIST
        {
            public uint dwAbilityType;	//ÄÜÁ¦ÀàÐÍ COMPRESSION_ABILITY_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±£Áô×Ö½Ú
            public uint dwNodeNum;		//ÄÜÁ¦½áµã¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NODE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DESC_NODE[] struDescNode;  //ÃèÊö²ÎÊý  
        }

        public const int MAX_ABILITYTYPE_NUM = 12;   //×î´óÄÜÁ¦Ïî

        // Ñ¹Ëõ²ÎÊýÄÜÁ¦ÁÐ±í
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_ABILITY
        {
            public uint dwSize;            //½á¹¹³¤¶È
            public uint dwAbilityNum;		//ÄÜÁ¦ÀàÐÍ¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ABILITYTYPE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ABILITY_LIST[] struAbilityNode; //ÃèÊö²ÎÊý  
        }

        //Ä£Ê½A 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEA
        {
            public byte byStartMonth;	// ¿ªÊ¼ÔÂ ´Ó1¿ªÊ¼
            public byte byStartDay;		// ¿ªÊ¼ÈÕ ´Ó1¿ªÊ¼
            public byte byEndMonth;		// ½áÊøÔÂ 
            public byte byEndDay;		// ½áÊøÈÕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEB
        {
            public byte byStartMonth;	// ´Ó1¿ªÊ¼
            public byte byStartWeekNum;	// µÚ¼¸¸öÐÇÆÚ ´Ó1¿ªÊ¼ 
            public byte byStartWeekday;	// ÐÇÆÚ¼¸
            public byte byEndMonth;		// ´Ó1¿ªÊ¼
            public byte byEndWeekNum;	// µÚ¼¸¸öÐÇÆÚ ´Ó1¿ªÊ¼ 
            public byte byEndWeekday;	// ÐÇÆÚ¼¸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£Áô×Ö½Ú 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEC
        {
            public ushort wStartYear;		// Äê
            public byte byStartMon;		// ÔÂ
            public byte byStartDay;		// ÈÕ
            public ushort wEndYear;		// Äê
            public byte byEndMon;		// ÔÂ
            public byte byEndDay;		// ÈÕ
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_HOLIDATE_UNION
        {
            //ÁªºÏÌå´óÐ¡ 12×Ö½Ú
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] dwSize;
            /*[FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEA	struModeA;	// Ä£Ê½A
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEB	struModeB;	// Ä£Ê½B
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEC	struModeC;	// Ä£Ê½C
             * */
        }

        public enum HOLI_DATE_MODE
        {
            HOLIDATE_MODEA = 0,
            HOLIDATE_MODEB,
            HOLIDATE_MODEC
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PARAM
        {
            public byte byEnable;			// ÊÇ·ñÆôÓÃ
            public byte byDateMode;			// ÈÕÆÚÄ£Ê½ 0-Ä£Ê½A 1-Ä£Ê½B 2-Ä£Ê½C
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// ±£Áô×Ö½Ú
            public NET_DVR_HOLIDATE_UNION uHolidate;	// ¼ÙÈÕÈÕÆÚ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName;	// ¼ÙÈÕÃû³Æ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// ±£Áô×Ö½Ú
        }

        public const int MAX_HOLIDAY_NUM = 32;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PARAM_CFG
        {
            public uint dwSize;			// ½á¹¹Ìå´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HOLIDAY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HOLIDAY_PARAM[] struHolidayParam;	// ¼ÙÈÕ²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£Áô²ÎÊý
        }

        //¼ÙÈÕ±¨¾¯´¦Àí·½Ê½
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_HANDLE
        {
            public uint dwSize;				// ½á¹¹Ìå´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;	// ²¼·ÀÊ±¼ä¶Î
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;		// ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_RECORD
        {
            public uint dwSize;
            public NET_DVR_RECORDDAY struRecDay;     // Â¼Ïñ²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched; // Â¼ÏñÊ±¼ä¶Î
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //  ±£Áô×Ö½Ú
        }

        public const int MAX_LINK_V30 = 128;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_LINK
        {
            public NET_DVR_IPADDR struIP;     // ¿Í»§¶ËIP
            public int lChannel;   // Í¨µÀºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LINK_STATUS
        {
            public uint dwSize;      // ½á¹¹Ìå´óÐ¡
            public ushort wLinkNum;    // Á¬½ÓµÄÊýÄ¿
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  // ±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_LINK[] struOneLink;   // Á¬½ÓµÄ¿Í»§¶ËÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±£Áô×Ö½Ú
        }

        public const int MAX_BOND_NUM = 2;

        //µ¥BONDINGÍø¿¨ÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ONE_BONDING
        {
            public byte byMode;
            public byte byUseDhcp;
            public byte byMasterCard;
            public byte byStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NETWORK_CARD, ArraySubType = UnmanagedType.I1)]
            public byte[] byBond;
            public NET_DVR_ETHERNET_V30 struEtherNet;
            public NET_DVR_IPADDR struGatewayIpAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //BONDINGÍø¿¨ÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETWORK_BONDING
        {
            public uint dwSize;
            public byte byEnable;
            public byte byNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_BOND_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_BONDING[] struOneBond;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }


        //´ÅÅÌÅä¶î
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_QUOTA
        {
            public byte byQuotaType;	 // ´ÅÅÌÅä¶îÀàÐÍ,1 - °´ÈÝÁ¿ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // ±£Áô×Ö½Ú
            public uint dwHCapacity;     // ·ÖÅäµÄ´ÅÅÌÈÝÁ¿¸ß32Î» µ¥Î»MB
            public uint dwLCapacity;     // ·ÖÅäµÄ´ÅÅÌÈÝÁ¿µÍ32Î» µ¥Î»MB
            public uint dwHUsedSpace;    // ÒÑÊ¹ÓÃµÄ´ÅÅÌ´óÐ¡¸ß32Î» µ¥Î»MB
            public uint dwLUsedSpace;    // ÒÑÊ¹ÓÃµÄ´ÅÅÌ´óÐ¡µÍ32Î» µ¥Î»MB
            public byte byQuotaRatio;    //	·ÖÅäµÄ´ÅÅÌ±ÈÀý,µ¥Î»:%
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;      // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_QUOTA_CFG
        {
            public uint dwSize;         // ½á¹¹Ìå´óÐ¡
            public NET_DVR_DISK_QUOTA struPicQuota;    //  Í¼Æ¬Åä¶î
            public NET_DVR_DISK_QUOTA struRecordQuota;    //  Â¼ÏñÅä¶î
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIMING_CAPTURE
        {
            public NET_DVR_JPEGPARA struJpegPara;   // ¶¨Ê±×¥Í¼Í¼Æ¬ÖÊÁ¿
            public uint dwPicInterval; //¶¨Ê±×¥Í¼Ê±¼ä¼ä¸ô,µ¥Î»s   1-1s 2-2s 3-3s 4-4s 5-5s 
                                       //6-10m 7-30m 8-1h 9-12h 10-24h
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REL_CAPTURE_CHAN
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;    // °´Î»±íÊ¾
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          // ±£Áô×Ö½Ú
        }

        public const int MAX_PIC_EVENT_NUM = 32;
        public const int MAX_ALARMIN_CAPTURE = 16;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REL_CAPTURE_CHAN_V40
        {
            public uint dwMaxRelCaptureChanNum;  //×î´ó¿É´¥·¢µÄ¹ØÁªÍ¨µÀÊý-Ö»¶ÁÊôÐÔ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwChanNo; //´¥·¢µÄ¹ØÁª×¥Í¼Í¨µÀºÅ£¬°´Öµ±íÊ¾£¬²ÉÓÃ½ô´ÕÐÍÅÅÁÐ,0xffffffff±íÊ¾ºóÐøÎÞÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_CAPTURE_V40
        {
            public NET_DVR_JPEGPARA struJpegPara;   // ÊÂ¼þ×¥Í¼Í¼Æ¬ÖÊÁ¿
            public uint dwPicInterval;   // ÊÂ¼þ×¥Í¼Ê±¼ä¼ä¸ô  µ¥Î»ÎªÃë 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PIC_EVENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN_V40[] struRelCaptureChan;   // Êý×éÏÂ±ê 0 ÒÆ¶¯Õì²â´¥·¢×¥Í¼ 1 ÊÓÆµÕÚµ²´¥·¢×¥Í¼ 2 ÊÓÆµ¶ªÊ§´¥·¢×¥Í¼,Êý×é3±íÊ¾PIR±¨¾¯×¥Í¼£¬Êý×é4±íÊ¾ÎÞÏß±¨¾¯×¥Í¼£¬Êý×é5±íÊ¾ºô¾È±¨¾¯×¥Í¼,Êý×é6±íÊ¾ÖÇÄÜ×¥Í¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_CAPTURE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN_V40[] struAlarmInCapture;    // ±¨¾¯ÊäÈë´¥·¢×¥Í¼£¬ÏÂ±ê0 ´ú±í±¨¾¯ÊäÈë1 ÒÀ´ÎÀàÍÆ
            public uint dwMaxGroupNum;  //Éè±¸Ö§³ÖµÄ×î´ó±¨¾¯ÊäÈë×éÊý£¬Ã¿×é16¸ö±¨¾¯ÊäÈë
            public byte byCapTimes; //×¥Í¼ÕÅÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_CAPTURE
        {
            public NET_DVR_JPEGPARA struJpegPara;   // ÊÂ¼þ×¥Í¼Í¼Æ¬ÖÊÁ¿
            public uint dwPicInterval;  /*ÊÂ¼þ×¥Í¼Ê±¼ä¼ä¸ô  µ¥Î»ÎªÃë  1-1s 2-2s 3-3s 4-4s 5-5s 
                                             * 6-10m 7-30m 8-1h 9-12h 10-24h*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PIC_EVENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN[] struRelCaptureChan; /* Êý×éÏÂ±ê 0 ÒÆ¶¯Õì²â´¥·¢×¥Í¼ 1 ÊÓÆµÕÚµ²´¥·¢×¥Í¼,
                                                                   * 2 ÊÓÆµ¶ªÊ§´¥·¢×¥Í¼,Êý×é3±íÊ¾PIR±¨¾¯×¥Í¼£¬Êý×é4±íÊ¾ÎÞÏß±¨¾¯×¥Í¼£¬
                                                                   * Êý×é5±íÊ¾ºô¾È±¨¾¯×¥Í¼,Êý×é6±íÊ¾ÖÇÄÜ×¥Í¼£¬ Êý×é7±íÊ¾ÈËÁ³Õì²â*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_CAPTURE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN[] struAlarmInCapture;  //±¨¾¯ÊäÈë´¥·¢×¥Í¼£¬ÏÂ±ê0 ´ú±í±¨¾¯ÊäÈë1 ÒÀ´ÎÀàÍÆ
            public byte byCapTimes; //×¥Í¼ÕÅÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEG_CAPTURE_CFG_V40
        {
            public uint dwSize;               //½á¹¹Ìå³¤¶È
            public NET_DVR_TIMING_CAPTURE struTimingCapture;
            public NET_DVR_EVENT_CAPTURE_V40 struEventCapture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;     // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEG_CAPTURE_CFG
        {
            public uint dwSize;         // ½á¹¹Ìå´óÐ¡
            public NET_DVR_TIMING_CAPTURE struTimingCapture;
            public NET_DVR_EVENT_CAPTURE struEventCapture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;     // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_DAY
        {
            public byte byAllDayCapture;	// ÊÇ·ñÈ«Ìì×¥Í¼
            public byte byCaptureType;		// ×¥Í¼ÀàÐÍ£º0-¶¨Ê±×¥Í¼£¬1-ÒÆ¶¯Õì²â×¥Í¼£¬2-±¨¾¯×¥Í¼£¬3-ÒÆ¶¯Õì²â»ò±¨¾¯×¥Í¼£¬4-ÒÆ¶¯Õì²âºÍ±¨¾¯×¥Í¼£¬6-ÖÇÄÜ±¨¾¯×¥Í¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_SCHED
        {
            public NET_DVR_SCHEDTIME struCaptureTime;        // ×¥Í¼Ê±¼ä¶Î
            public byte byCaptureType;       // ×¥Í¼ÀàÐÍ£º0-¶¨Ê±×¥Í¼£¬1-ÒÆ¶¯Õì²â×¥Í¼£¬2-±¨¾¯×¥Í¼£¬3-ÒÆ¶¯Õì²â»ò±¨¾¯×¥Í¼£¬4-ÒÆ¶¯Õì²âºÍ±¨¾¯×¥Í¼£¬6-ÖÇÄÜ±¨¾¯×¥Í¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           // ±£Áô×Ö½Ú
        }

        //Í¨µÀ×¥Í¼¼Æ»®
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCHED_CAPTURECFG
        {
            public uint dwSize;     //½á¹¹Ìå
            public byte byEnable;	//ÊÇ·ñ×¥Í¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_DAY[] struCaptureDay;//È«Ìì×¥Í¼¼Æ»®
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_SCHED[] struCaptureSched;//Ê±¼ä¶Î×¥Í¼²¼·À¼Æ»®
            public NET_DVR_CAPTURE_DAY struCaptureHoliday;	//¼ÙÈÕ×¥Í¼¼Æ»®
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_SCHED[] struHolidaySched;	//Ê±¼ä¶Î¼ÙÈÕ×¥Í¼²¼·À¼Æ»®
            public uint dwRecorderDuration;	//×¥Í¼±£´æ×î³¤Ê±¼ä 0xffffffff±íÊ¾¸ÃÖµÎÞÐ§ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			//±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLOW_TEST_PARAM
        {
            public uint dwSize;              //½á¹¹´óÐ¡
            public int lCardIndex;         //Íø¿¨Ë÷Òý
            public uint dwInterval;         //Éè±¸ÉÏ´«Á÷Á¿Ê±¼ä¼ä¸ô, µ¥Î»:100ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLOW_INFO
        {
            public uint dwSize;             //½á¹¹´óÐ¡
            public uint dwSendFlowSize;     //·¢ËÍÁ÷Á¿´óÐ¡,µ¥Î»kbps
            public uint dwRecvFlowSize;     //½ÓÊÕÁ÷Á¿´óÐ¡,µ¥Î»kbps
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±£Áô 
        }

        //Â¼Ïñ±êÇ©
        public const int LABEL_NAME_LEN = 40;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_LABEL
        {
            public uint dwSize;					// ½á¹¹Ìå´óÐ¡
            public NET_DVR_TIME struTimeLabel;			// ±êÇ©µÄÊ±¼ä 
            public byte byQuickAdd;				// ÊÇ·ñ¿ìËÙÌí¼Ó ¿ìËÙÌí¼ÓÊ±±êÇ©Ãû³ÆÎÞÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;				// ±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	// ±êÇ©µÄÃû³Æ ³¤¶ÈÎª40×Ö½Ú  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				// ±£Áô×Ö½Ú
        }

        public const int LABEL_IDENTIFY_LEN = 64;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LABEL_IDENTIFY
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_IDENTIFY_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelIdentify;    // 64×Ö½Ú±êÊ¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;               // ±£Áô×Ö½Ú
        }

        public const int MAX_DEL_LABEL_IDENTIFY = 20;// É¾³ýµÄ×î´ó±êÇ©±êÊ¶¸öÊý

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEL_LABEL_PARAM
        {
            public uint dwSize;       // ½á¹¹Ìå´óÐ¡
            public byte byMode;   // °´Î»±íÊ¾,0x01±íÊ¾°´±êÊ¶É¾³ý
            public byte byRes1;
            public ushort wLabelNum;      // ±êÇ©ÊýÄ¿   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DEL_LABEL_IDENTIFY, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LABEL_IDENTIFY[] struIndentify; // ±êÇ©±êÊ¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±£Áô×Ö½Ú    
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MOD_LABEL_PARAM
        {
            public NET_DVR_LABEL_IDENTIFY struIndentify; //ÒªÐÞ¸ÄµÄ±êÇ©±êÊ¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	//ÐÞ¸ÄºóµÄ±êÇ©Ãû³Æ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //±êÇ©ËÑË÷½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_LABEL
        {
            public uint dwSize;          // ½á¹¹Ìå´óÐ¡
            public int lChannel;		// ²éÕÒµÄÍ¨µÀ
            public NET_DVR_TIME struStartTime;	// ¿ªÊ¼Ê±¼ä
            public NET_DVR_TIME struStopTime;	// ½áÊøÊ±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	//  Â¼Ïñ±êÇ©Ãû³Æ Èç¹û±êÇ©Ãû³ÆÎª¿Õ£¬ÔòËÑË÷ÆðÖ¹Ê±¼äËùÓÐ±êÇ©
            public byte byDrawFrame;		//0:²»³éÖ¡£¬1£º³éÖ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£Áô×Ö½Ú
        }

        //±êÇ©ÐÅÏ¢½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FINDLABEL_DATA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	// ±êÇ©Ãû³Æ
            public NET_DVR_TIME struTimeLabel;		// ±êÇ©Ê±¼ä
            public NET_DVR_LABEL_IDENTIFY struLabelIdentify; // ±êÇ©±êÊ¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// ±£Áô×Ö½Ú
        }

        public const int CARDNUM_LEN_V30 = 40;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_PICTURE_PARAM
        {
            public uint dwSize;        //½á¹¹Ìå´óÐ¡ 
            public int lChannel;       //Í¨µÀºÅ
            public byte byFileType;   /* ²éÕÒµÄÍ¼Æ¬ÀàÐÍ:0¶¨Ê±×¥Í¼1 ÒÆ¶¯Õì²â×¥Í¼ 2 ±¨¾¯×¥Í¼3  ±¨¾¯ | ÒÆ¶¯Õì²â×¥Í¼ 4 ±¨¾¯ & ÒÆ¶¯Õì²â×¥Í¼
                                       * 6 ÊÖ¶¯×¥Í¼ ,9-ÖÇÄÜÍ¼Æ¬,10- PIR±¨¾¯£¬11- ÎÞÏß±¨¾¯£¬12- ºô¾È±¨¾¯,0xa Ô¤ÀÀÊ±½ØÍ¼£¬0xd ÈËÁ³Õì²â, 
                                       * 0xe Ô½½çÕì²â£¬0xf ÈëÇÖÇøÓòÕì²â£¬0x10 ³¡¾°±ä¸üÕì²â, 0x11-Éè±¸±¾µØ»Ø·ÅÊ±½ØÍ¼, 0x12-ÖÇÄÜÕì²â£¬
                                       * 0xff- È«²¿ÀàÐÍ 2013-07-16*/
            public byte byNeedCard;     //ÊÇ·ñÐèÒª¿¨ºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      // ±£Áô×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARDNUM_LEN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNum;     // ¿¨ºÅ
            public NET_DVR_TIME struStartTime;//²éÕÒÍ¼Æ¬µÄ¿ªÊ¼Ê±¼ä
            public NET_DVR_TIME struStopTime;// ²éÕÒÍ¼Æ¬µÄ½áÊøÊ±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     // ±£Áô×Ö½Ú
        }

        public const int PICTURE_NAME_LEN = 64;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_PICTURE
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PICTURE_NAME_LEN)]
            public string sFileName;//Í¼Æ¬Ãû
            public NET_DVR_TIME struTime;//Í¼Æ¬µÄÊ±¼ä
            public uint dwFileSize;//Í¼Æ¬µÄ´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = CARDNUM_LEN_V30)]
            public string sCardNum;	//¿¨ºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		//  ±£Áô×Ö½Ú
        }

        public const int MAX_RECORD_PICTURE_NUM = 50;   //×î´ó±¸·ÝÍ¼Æ¬ÕÅÊý  

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_PICTURE_PARAM
        {
            public uint dwSize;         // ½á¹¹Ìå´óÐ¡   
            public uint dwPicNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECORD_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FIND_PICTURE[] struPicture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;
            public byte byWithPlayer;
            public byte byContinue;    /*ÊÇ·ñ¼ÌÐø±¸·Ý 0²»¼ÌÐø 1¼ÌÐø*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_LIMIT
        {
            public uint dwSize;           //½á¹¹Ìå´óÐ¡
            public uint dwChannel;        //Í¨µÀºÅ
            public byte byCompressType;   //´ý»ñÈ¡µÄÑ¹Ëõ²ÎÊýÀàÐÍ1,Ö÷ÂëÁ÷2,×ÓÂëÁ÷3,ÊÂ¼þ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±£Áô
            public NET_DVR_COMPRESSIONCFG_V30 struCurrentCfg; //µ±Ç°Ñ¹Ëõ²ÎÊýÅäÖÃ
        }

        public const int STEP_READY = 0;    //×¼±¸Éý¼¶
        public const int STEP_RECV_DATA = 1;    //½ÓÊÕÉý¼¶°üÊý¾Ý
        public const int STEP_UPGRADE = 2;    //Éý¼¶ÏµÍ³
        public const int STEP_BACKUP = 3;    //±¸·ÝÏµÍ³
        public const int STEP_SEARCH = 255;  //ËÑË÷Éý¼¶ÎÄ¼þ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_EFFECT
        {
            public uint dwBrightValue;      //ÁÁ¶È[0,255]
            public uint dwContrastValue;    //¶Ô±È¶È[0,255]
            public uint dwSaturationValue;  //±¥ºÍ¶È[0,255]
            public uint dwHueValue;         //É«µ÷[0,255]
            public uint dwSharpness;		  //Èñ¶È[0,255]
            public uint dwDenoising;		  //È¥Ôë[0,255]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_INPUT_EFFECT
        {
            public uint dwSize;				//½á¹¹Ìå´óÐ¡
            public ushort wEffectMode;        //Ä£Ê½ 0-±ê×¼ 1-ÊÒÄÚ 2-Èõ¹â 3-ÊÒÍâ  255-×Ô¶¨Òå
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 146, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        //±£Áô
            public NET_DVR_VIDEO_EFFECT struVideoEffect;	//ÊÓÆµÐ§¹û²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			//±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPARA_V40
        {
            public uint dwChannel;			// Í¨µÀºÅ
            public uint dwVideoParamType;  	// ÊÓÆµ²ÎÊýÀàÐÍ 0-ÁÁ¶È 1-¶Ô±È¶È 2-±¥ºÍ¶È 3-É«¶È 4-Èñ¶È 5-È¥Ôë
            public uint dwVideoParamValue;  //¶ÔÓ¦µÄÊÓÆµ²ÎÊýÖµ£¬·¶Î§ÒÀ¾ÝÄÜÁ¦¼¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFAULT_VIDEO_COND
        {
            public uint dwSize;			// ½á¹¹Ìå´óÐ¡
            public uint dwChannel;		// Í¨µÀºÅ
            public uint dwVideoMode;	// Ä£Ê½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ENCODE_JOINT_PARAM
        {
            public uint dwSize;			// ½á¹¹Ìå´óÐ¡
            public byte byJointed;		//  0 Ã»ÓÐ¹ØÁª 1 ÒÑ¾­¹ØÁª
            public byte byDevType;		// ±»¹ØÁªµÄÉè±¸ÀàÐÍ  1 ´ú±íÖÇÄÜÉè±¸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;		// ±£Áô×Ö½Ú
            public NET_DVR_IPADDR struIP;			// ¹ØÁªµÄ±»È¡Á÷Éè±¸IPµØÖ·
            public ushort wPort;			// ¹ØÁªµÄ±»È¡Á÷Éè±¸¶Ë¿ÚºÅ
            public ushort wChannel;		// ¹ØÁªµÄ±»È¡Á÷Éè±¸Í¨µÀºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CHAN_WORKSTATUS
        {
            public byte byJointed;				// 0-Ã»ÓÐ¹ØÁª  1-ÒÑ¾­¹ØÁª
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struIP;					// ¹ØÁªµÄÈ¡Á÷Éè±¸IPµØÖ·
            public ushort wPort;					// ¹ØÁªµÄÈ¡Á÷Éè±¸¶Ë¿ÚºÅ
            public ushort wChannel;				// ¹ØÁªµÄÈ¡Á÷Éè±¸Í¨µÀºÅ
            public byte byVcaChanStatus;		// 0 - Î´ÆôÓÃ 1 - ÆôÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				// ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_DEV_WORKSTATUS
        {
            public uint dwSize;			// ½á¹¹Ìå´óÐ¡
            public byte byDeviceStatus;	// Éè±¸µÄ×´Ì¬0 - Õý³£¹¤×÷ 1- ²»Õý³£¹¤×÷
            public byte byCpuLoad;		// CPUÊ¹ÓÃÂÊ0-100 ·Ö±ð´ú±íÊ¹ÓÃ°Ù·ÖÂÊ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VCA_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VCA_CHAN_WORKSTATUS[] struVcaChanStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;		// ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_VIDEOPLATFORM_V40
        {
            /*¸÷¸ö×Ó´°¿Ú¶ÔÓ¦½âÂëÍ¨µÀËù¶ÔÓ¦µÄ½âÂë×ÓÏµÍ³µÄ²ÛÎ»ºÅ(¶ÔÓÚÊÓÆµ×ÛºÏÆ½Ì¨ÖÐ½âÂë×ÓÏµÍ³ÓÐÐ§)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
            //ÏÔÊ¾´°¿ÚËù½âÊÓÆµ·Ö±æÂÊ£¬1-D1,2-720P,3-1080P£¬Éè±¸¶ËÐèÒª¸ù¾Ý´Ë//·Ö±æÂÊ½øÐÐ½âÂëÍ¨µÀµÄ·ÖÅä£¬Èç1·ÖÆÁÅäÖÃ³É1080P£¬ÔòÉè±¸»á°Ñ4¸ö½âÂëÍ¨
            //µÀ¶¼·ÖÅä¸ø´Ë½âÂëÍ¨µÀ
            public byte byDecResolution;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 143, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_NOTVIDEOPLATFORM_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGA_DISP_CHAN_CFG_V40
        {
            public uint dwSize;
            public byte byAudio;			/*ÒôÆµÊÇ·ñ¿ªÆô*/
            public byte byAudioWindowIdx;      /*ÒôÆµ¿ªÆô×Ó´°¿Ú*/
            public byte byVgaResolution;      /*·Ö±æÂÊ£¬´ÓÄÜÁ¦¼¯»ñÈ¡*/
            public byte byVedioFormat;         /*1:NTSC,2:PAL£¬0-NULL*/
            public uint dwWindowMode;       /*»­ÃæÄ£Ê½£¬ÄÜÁ¦¼¯»ñÈ¡*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*¸÷¸ö×Ó´°¿Ú¹ØÁªµÄ½âÂëÍ¨µÀ*/
            public byte byEnlargeStatus;          /*ÊÇ·ñ´¦ÓÚ·Å´ó×´Ì¬£¬0£º²»·Å´ó£¬1£º·Å´ó*/
            public byte byEnlargeSubWindowIndex;//·Å´óµÄ×Ó´°¿ÚºÅ
            public byte byScale; /*ÏÔÊ¾Ä£Ê½£¬0---ÕæÊµÏÔÊ¾£¬1---Ëõ·ÅÏÔÊ¾( Õë¶ÔBNC )*/
            /*Çø·Ö¹²ÓÃÌå£¬0-ÊÓÆµ×ÛºÏÆ½Ì¨ÄÚ²¿½âÂëÆ÷ÏÔÊ¾Í¨µÀÅäÖÃ£¬1-ÆäËû½âÂëÆ÷ÏÔÊ¾Í¨µÀÅäÖÃ*/
            public byte byUnionType;

            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct struDiff
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
                public byte[] byRes;

                /*[FieldOffsetAttribute(0)]
                public UNION_VIDEOPLATFORM_V40 struVideoPlatform;

                [FieldOffsetAttribute(0)]
                public UNION_NOTVIDEOPLATFORM_V40 struNotVideoPlatform;
                 * */
            }
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_V6SUBSYSTEMPARAM
        {
            public byte bySerialTrans;//ÊÇ·ñÍ¸´«£¬0-·ñ£¬1-ÊÇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_DVR_V6PSUBSYSTEMARAM_GET = 1501;//»ñÈ¡V6×ÓÏµÍ³ÅäÖÃ
        public const int NET_DVR_V6PSUBSYSTEMARAM_SET = 1502;//ÉèÖÃV6×ÓÏµÍ³ÅäÖÃ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CORRECT_DEADPIXEL_PARAM
        {
            public uint dwSize;
            public uint dwCommand; //ÃüÁî£º0-½øÈë»µµãÄ£Ê½£¬1-Ìí¼Ó»µµã£¬2-±£´æ»µµã£¬3-ÍË³ö»µµã
            public uint dwDeadPixelX; //»µµãX×ø±ê
            public uint dwDeadPixelY; //»µµãY×ø±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }

        public const int MAX_REDAREA_NUM = 6;   //×î´óºìÂÌµÆÇøÓò¸öÊý

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REDAREACFG
        {
            public uint dwSize;
            public uint dwCorrectEnable; //ÊÇ·ñ¿ªÆôÐ£Õý¹¦ÄÜ£¬0-¹Ø±Õ£¬1-¿ªÆô
            public uint dwCorrectLevel; //Ð£Õý¼¶±ð£¬1(Ð£Õý¶È×îµÍ)-10(Ð£Õý¶È×î¸ß),Ä¬ÈÏÎª5
            public uint dwAreaNum; //Ð£ÕýÇøÓò¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_REDAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struLaneRect; //Ð£ÕýÇøÓò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HISTORICDATACFG
        {
            public uint dwSize;
            public uint dwTotalNum;  //ÀúÊ·Êý¾Ý¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int INQUEST_MESSAGE_LEN = 44;    //ÉóÑ¶ÖØµã±ê¼ÇÐÅÏ¢³¤¶È
        public const int INQUEST_MAX_ROOM_NUM = 2;    //×î´óÉóÑ¶ÊÒ¸öÊý
        public const int MAX_RESUME_SEGMENT = 2;     //Ö§³ÖÍ¬Ê±»Ö¸´µÄÆ¬¶ÎÊýÄ¿

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_ROOM
        {
            public byte byRoomIndex;     //ÉóÑ¶ÊÒ±àºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_MESSAGE
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = INQUEST_MESSAGE_LEN)]
            public string sMessage; //ÖØµã±ê¼ÇÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                     //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SENSOR_DEVICE
        {
            public ushort wDeviceType;	//Êý¾Ý²É¼¯Éè±¸ÐÍºÅ:0-ÎÞ 1-Ã×ÀÖ 2-ÀØ²Ê 3-ÓÅÁ¦ 4-¼ÑÃË 5-ÓÀ¿Ø¡¢6-ÛâÉÏ¡¢7-Î¬ÄÉË¹´ï
            public ushort wDeviceAddr;	//Êý¾Ý²É¼¯Éè±¸µØÖ·	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	    //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SENSOR_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = INQUEST_MAX_ROOM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_SENSOR_DEVICE[] struSensorDevice;
            public uint dwSupportPro;      //Ö§³ÖÐ­ÒéÀàÐÍ,°´Î»±íÊ¾, ÐÂ°æ±¾×ßÄÜÁ¦¼¯£¬²»ÔÙÀ©Õ¹´Ë×Ö¶Î
                                           //0x1:Ã×ÀÖ 0x2:ÀØ²Ê 0x4:ÓÅÁ¦
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_ROOM_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string szCDName;	//¹âÅÌÃû³Æ£¬µ¥ÊÒË«¿Ì¹âÅÌÃû³ÆÊÇÒ»ÑùµÄ
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uCalcMode
            {
                [FieldOffsetAttribute(0)]
                public byte byBitRate;  // byCalcTypeÎª0Ê±ÓÐÐ§£¬(0-32¡¢1-48¡¢2-64¡¢3-80¡¢4-96¡¢5-128¡¢
                                        //6-160¡¢7-192¡¢8-224¡¢9-256¡¢10-320¡¢11-384¡¢12-448¡¢
                                        //13-512¡¢14-640¡¢15-768¡¢16-896Ç°16¸öÖµ±£Áô)17-1024¡¢18-1280¡¢19-1536¡¢
                                        //20-1792¡¢21-2048¡¢22-3072¡¢23-4096¡¢24-8192
                [FieldOffsetAttribute(0)]
                public byte byInquestTime;  // byCalcTypeÎª1Ê±ÓÐÐ§£¬0-1Ð¡Ê±, 1-2Ð¡Ê±,2-3Ð¡Ê±,3-4Ð¡Ê±, 4-6Ð¡Ê±,5-8Ð¡Ê±
                                            //8-16Ð¡Ê±, 9-20Ð¡Ê±,10-22Ð¡Ê±,11-24Ð¡Ê±
            }
            public byte byCalcType;			//¿ÌÂ¼¼ÆËãÀàÐÍ0-°´ÂëÂÊ 1-°´Ê±¼ä
            public byte byAutoDelRecord;	// ÊÇ·ñ×Ô¶¯É¾³ýÂ¼Ïñ£¬0-²»É¾³ý£¬¼´½áÊøÊ±±£´æÂ¼Ïñ 1-É¾³ý
            public byte byAlarmThreshold;		// ÉùÒô±¨¾¯·§Öµ
            public byte byInquestChannelResolution;     //ÉóÑ¶Í¨µÀ·Ö±æÂÊ£¬0:720P  1:1080P
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SYSTEM_INFO
        {
            public uint dwRecordMode;         //¿ÌÂ¼Ä£Ê½:1 µ¥ÊÒË«¿ÌÄ£Ê½ 2 µ¥ÊÒÂÖ¿ÌÄ£Ê½ 3 Ë«ÊÒË«¿ÌÄ£Ê½£¨ÐÞ¸ÄÐèÒªÖØÆôÉè±¸£©
            public uint dwWorkMode;           //¹¤×÷Ä£Ê½:0 ±ê×¼Ä£Ê½ 1 Í¨ÓÃÄ£Ê½(±£Áô£¬Ä¿Ç°Ö»ÓÐ±ê×¼Ä£Ê½)
            public uint dwResolutionMode;     //Éè±¸·Ö±æÂÊ£¬0:±êÇå 1:D1 2:720P 3:1080P£¨¸ßÇåÉóÑ¶»ú²»ÓÃ´Ë×Ö¶Î£©
            public NET_DVR_INQUEST_SENSOR_INFO struSensorInfo;  //ÎÂÊª¶È´«¸ÐÆ÷ÅäÖÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = INQUEST_MAX_ROOM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_ROOM_INFO[] struInquestRoomInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_RESUME_SEGMENT
        {
            public NET_DVR_TIME struStartTime; //ÊÂ¼þÆðÊ¼Ê±¼ä
            public NET_DVR_TIME struStopTime;  //ÊÂ¼þÖÕÖ¹Ê±¼ä
            public byte byRoomIndex;         //ÉóÑ¶ÊÒ±àºÅ,´Ó1¿ªÊ¼
            public byte byDriveIndex;        //¿ÌÂ¼»ú±àºÅ,´Ó1¿ªÊ¼
            public ushort wSegmetSize;         //±¾Æ¬¶ÏµÄ´óÐ¡, µ¥Î»M 
            public uint dwSegmentNo;         //±¾Æ¬¶ÏÔÚ±¾´ÎÉóÑ¶ÖÐµÄÐòºÅ,´Ó1¿ªÊ¼ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_RESUME_EVENT
        {
            public uint dwResumeNum;       //Ðè»Ö¸´µÄÊÂ¼þ¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RESUME_SEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_RESUME_SEGMENT[] struResumeSegment;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_DEVICE_VERSION
        {
            public byte byMainVersion;         /*»ùÏßÖ÷°æ±¾.
								   0 : Î´Öª
								   1 : 8000ÉóÑ¶DVR
								       ´Î°æ±¾: 1 : 8000HD-S
								   2 : 8100ÉóÑ¶DVR 
									   ´Î°æ±¾: 1 : ÉóÑ¶81SNL
											   2 : ÉóÑ¶81SH
											   3 : ÉóÑ¶81SFH
								   3 : 8608¸ßÇåÉóÑ¶»úNVR 
									   ´Î°æ±¾: 1 : DS-8608SN-SP
											   2 : DS-8608SN-ST
									  */
            public byte bySubVersion;          //»ùÏß´Î°æ±¾
            public byte byUpgradeVersion;      //Éý¼¶°æ±¾,Î´Éý¼¶Îª0
            public byte byCustomizeVersion;     //¶¨ÖÆ°æ±¾,·Ç¶¨ÖÆÎª0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;             //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_RAID_INFO
        {
            public uint dwSize;   //½á¹¹Ìå´óÐ¡
            public byte byEnable;  //´ÅÅÌRaidÊÇ·ñ½ûÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SYNCHRONOUS_IPC
        {
            public uint dwSize;    //½á¹¹Ìå´óÐ¡
            public byte byEnable;  //ÊÇ·ñÆôÓÃ£ºÎªÇ°¶ËIPCÍ¬²½Éè±¸²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_PASSWD
        {
            public uint dwSize;    //½á¹¹Ìå´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sOldPasswd;  //IPCµÄ¾ÉÃÜÂë£¬´«¸øDVRÈÃDVRÑéÖ¤
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sNewPasswd;  //IPCµÄÐÂÃÜÂë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Í¨¹ý»ñÈ¡DVRµÄÍøÂç×´Ì¬£ºµ¥Î»bps
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DEVICE_NET_USING_INFO
        {
            public uint dwSize;    //½á¹¹Ìå´óÐ¡
            public uint dwPreview;   //Ô¤ÀÀ
            public uint dwPlayback;  //»Ø·Å
            public uint dwIPCModule; //IPC½ÓÈë
            public uint dwNetDiskRW; //ÍøÅÌ¶ÁÐ´
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //Í¨¹ýDVRÉèÖÃÇ°¶ËIPCµÄIPµØÖ·
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_NETCFG
        {
            public uint dwSize;      //½á¹¹Ìå´óÐ¡
            public NET_DVR_IPADDR struIP;       //IPCµÄIPµØÖ·
            public ushort wPort;       //IPCµÄ¶Ë¿Ú
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 126)]
            public string res;
        }

        //°´Ê±¼äËø¶¨
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_LOCK
        {
            public uint dwSize;      //½á¹¹Ìå´óÐ¡
            public NET_DVR_TIME strBeginTime;
            public NET_DVR_TIME strEndTime;
            public uint dwChannel;        //Í¨µÀºÅ, 0xff±íÊ¾ËùÓÐÍ¨µÀ
            public uint dwRecordType;     //Â¼ÏñÀàÐÍ:  0xffffffff£­È«²¿£¬0£­¶¨Ê±Â¼Ïñ£¬1-ÒÆ¶¯Õì²â£¬2£­±¨¾¯´¥·¢£¬3-±¨¾¯´¥·¢»òÒÆ¶¯Õì²â£¬4-±¨¾¯´¥·¢ºÍÒÆ¶¯Õì²â£¬5-ÃüÁî´¥·¢£¬6-ÊÖ¶¯Â¼Ïñ£¬7-ÖÇÄÜÂ¼Ïñ(Í¬ÎÄ¼þ²éÕÒ)
            public uint dwLockDuration;   //Ëø¶¨³ÖÐøÊ±¼ä,µ¥Î»Ãë,0xffffffff±íÊ¾ÓÀ¾ÃËø¶¨
            public NET_DVR_TIME_EX strUnlockTimePoint;	//¼ÓËøÊ±ÓÐÐ§£¬µ±dwLockDuration²»ÎªÓÀ¾ÃËø¶¨Ê±£¬Ëø¶¨³ÖÐøµÄÊ±¼äµ½´ËÊ±¼äµã¾Í×Ô¶¯½âËø
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOCK_RETURN
        {
            public uint dwSize;      //½á¹¹Ìå´óÐ¡
            public NET_DVR_TIME strBeginTime;
            public NET_DVR_TIME strEndTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //67DVS
        //Ö¤ÊéÏÂÔØÀàÐÍ
        public enum NET_SDK_UPLOAD_TYPE
        {
            UPGRADE_CERT_FILE = 0,
            UPLOAD_CERT_FILE = 1,
            TRIAL_CERT_FILE = 2,
            CONFIGURATION_FILE = 3
        }

        public enum NET_SDK_DOWNLOAD_TYPE
        {
            NET_SDK_DOWNLOAD_CERT = 0,      //ÏÂÔØÖ¤Êé
            NET_SDK_DOWNLOAD_IPC_CFG_FILE = 1,//ÏÂÔØIPCÅäÖÃÎÄ¼þ
            NET_SDK_DOWNLOAD_BASELINE_SCENE_PIC = 2, //ÏÂÔØ»ù×¼³¡¾°Í¼Æ¬
            NET_SDK_DOWNLOAD_VQD_ALARM_PIC = 3,       //ÏÂÔØVQD±¨¾¯Í¼Æ¬
            NET_SDK_DOWNLOAD_CONFIGURATION_FILE = 4   //ÏÂÔØÅäÖÃÎÄ¼þ
        }

        //ÏÂÔØ×´Ì¬
        public enum NET_SDK_DOWNLOAD_STATUS
        {
            NET_SDK_DOWNLOAD_STATUS_SUCCESS = 1,    //ÏÂÔØ³É¹¦
            NET_SDK_DOWNLOAD_STATUS_PROCESSING,     //ÕýÔÚÏÂÔØ
            NET_SDK_DOWNLOAD_STATUS_FAILED,         //ÏÂÔØÊ§°Ü
            NET_SDK_DOWNLOAD_STATUS_UNKOWN_ERROR    //Î´Öª´íÎó 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BONJOUR_CFG
        {
            public uint dwSize;				// ½á¹¹Ìå´óÐ¡
            public byte byEnableBonjour;		// BonjourÊ¹ÄÜ 0 £º¿ªÆô 1£º¹Ø±Õ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byFriendlyName; 	// ·þÎñÃû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SOCKS_CFG
        {
            public uint dwSize;				// ½á¹¹Ìå´óÐ¡
            public byte byEnableSocks;  		// Ê¹ÄÜ 0£º¹Ø±Õ 1£º¿ªÆô
            public byte byVersion;  			// SOCKS°æ±¾ 4£ºSOCKS4   5£ºSOCKS5
            public ushort wProxyPort;				// ´úÀí¶Ë¿Ú£¬Ä¬ÈÏ1080
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byProxyaddr;  	// ´úÀíIPµØÖ·£¬¿ÉÒÔÊÇÓòÃû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; 	// ÓÃ»§Ãû SOCKS²ÅÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword;			// ÃÜÂëSOCKS5²ÅÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LOCAL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalAddr;  //²»Ê¹ÓÃsocks´úÀíµÄÍø¶Î£¬¸ñÊ½Îª"ip/netmask;ip/netmask;¡­"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_QOS_CFG
        {
            public uint dwSize;
            public byte byManageDscp;   // ¹ÜÀíÊý¾ÝµÄDSCPÖµ [0-63]
            public byte byAlarmDscp;    // ±¨¾¯Êý¾ÝµÄDSCPÖµ [0-63]
            public byte byVideoDscp;    // ÊÓÆµÊý¾ÝµÄDSCPÖµ [0-63]£¬byFlagÎª0Ê±£¬±íÊ¾ÒôÊÓÆµ
            public byte byAudioDscp;    // ÒôÆµÊý¾ÝµÄDSCPÖµ [0-63]£¬byFlagÎª1Ê±ÓÐÐ§
            public byte byFlag;			// 0£ºÒôÊÓÆµºÏÒ»£¬1£ºÒôÊÓÆµ·Ö¿ª
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HTTPS_CFG
        {
            public uint dwSize;
            public ushort wHttpsPort;		// HTTPS¶Ë¿Ú
            public byte byEnable;		// Ê¹ÄÜ 0£º¹Ø±Õ 1£º¿ªÆô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 125, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Ö¤ÊéÏà¹Ø
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_NAME
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_COUNTRY_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCountry;  			//¹ú¼Ò´úºÅ CNµÈ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byState;				//ÖÞ»òÊ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocality;			//µØÇø
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byOrganization;		//×éÖ¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnit;				//µ¥Î»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byCommonName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byEmail;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_PARAM
        {
            public uint dwSize;
            public ushort wCertFunc; //Ö¤ÊéÖÖÀà£¬0-802.1x,1-HTTPS
            public ushort wCertType; //Ö¤ÊéÀàÐÍ£¬0-CA£¬1-Certificate,2-Ë½Ô¿ÎÄ¼þ
            public byte byFileType; //Ö¤ÊéÎÄ¼þÀàÐÍ£¬0-PEM,1-PFX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int UPLOAD_CERTIFICATE = 1; //ÉÏ´«Ö¤Êé

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_INFO
        {
            public uint dwSize;
            public NET_DVR_CERT_PARAM struCertParam;	//Ö¤Êé²ÎÊý
            public uint dwValidDays;   //ÓÐÐ§ÌìÊý£¬ÀàÐÍÎª×ÔÇ©ÃûÊ±ÓÐÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPasswd;   //Ë½Ô¿ÃÜÂë
            public NET_DVR_CERT_NAME struCertName;    // Ö¤ÊéÃû³Æ
            public NET_DVR_CERT_NAME struIssuerName;    // Ö¤Êé·¢ÐÐÕßÃû³Æ£¨×ÔÇ©ÃûÖ¤ÊéÐÅÏ¢»ñÈ¡Ê±ÓÐÐ§£©
            public NET_DVR_TIME_EX struBeginTime;   //Ö¤Êé´´½¨Ê±¼ä£¨×ÔÇ©ÃûÖ¤ÊéÐÅÏ¢»ñÈ¡Ê±ÓÐÐ§£©
            public NET_DVR_TIME_EX struEndTime;   //Ö¤Êé½ØÖ¹Ê±¼ä£¨×ÔÇ©ÃûÖ¤ÊéÐÅÏ¢»ñÈ¡Ê±ÓÐÐ§£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] serialNumber;   //Ö¤Êé±êÊ¶Âë£¨×ÔÇ©ÃûÖ¤ÊéÐÅÏ¢»ñÈ¡Ê±ÓÐÐ§£©
            public byte byVersion;
            public byte byKeyAlgorithm;			//¼ÓÃÜÀàÐÍ 0-RSA  1-DSA
            public byte byKeyLen;				//¼ÓÃÜ³¤¶È 0-512  1-1024¡¢ 2-2048
            public byte bySignatureAlgorithm; //Ç©ÃûËã·¨ÀàÐÍ£¨×ÔÇ©ÃûÖ¤ÊéÐÅÏ¢»ñÈ¡Ê±ÓÐÐ§£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //channel record status
        //***Í¨µÀÂ¼Ïñ×´Ì¬*****//
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANS_RECORD_STATUS
        {
            public byte byValid;       //ÊÇ·ñÓÐÐ§
            public byte byRecord;      /*(Ö»¶Á)Â¼ÏñÀàÐÍ, °´Î»±íÊ¾:0: ²»ÔÚÂ¼Ïñ£»1£ºÔÚÂ¼Ïñ 2-¿ÕÏÐ 
						3-ÎÞÁ¬½Ó 4-ÎÞÊäÈëÊÓÆµ 5-Î´¼ÓÔØ 6-´æµµÖÐ
							7-»Ø´«ÖÐ 8-ÓÃ»§Ãû»òÃÜÂë´í 9-Î´ÑéÖ¤
							10-´æµµÖÐºÍÂ¼ÏñÖÐ 11-Â¼Ïñ»Ø´«ÖÐºÍÂ¼ÏñÖÐ*/
            public ushort wChannelNO;   //Í¨µÀºÅ
            public uint dwRelatedHD;  //¹ØÁª´ÅÅÌ
            public byte byOffLineRecord;  //¶ÏÍøÂ¼Ïñ¹¦ÄÜ 0-¹Ø±Õ 1-¿ªÆô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IP_ALARM_GROUP_NUM
        {
            public uint dwSize;
            public uint dwIPAlarmInGroup;      //IPÍ¨µÀ±¨¾¯ÊäÈë×éÊý
            public uint dwIPAlarmInNum;       //IPÍ¨µÀ±¨¾¯ÊäÈë¸öÊý
            public uint dwIPAlarmOutGroup;     //IPÍ¨µÀ±¨¾¯Êä³ö×éÊý
            public uint dwIPAlarmOutNum;      //IPÍ¨µÀ±¨¾¯Êä³ö¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //****NVR end***//
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHAN_GROUP_RECORD_STATUS
        {
            public uint dwSize; //½á¹¹Ìå´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANS_RECORD_STATUS[] struChanStatus; //Ò»×é64¸ö
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECTCFG
        {
            public ushort wXCoordinate; /*¾ØÐÎ×óÉÏ½ÇÆðÊ¼µãX×ø±ê*/
            public ushort wYCoordinate; /*¾ØÐÎ×óÉÏ½ÇY×ø±ê*/
            public ushort wWidth;       /*¾ØÐÎ¿í¶È*/
            public ushort wHeight;      /*¾ØÐÎ¸ß¶È*/
        }

        /*´°¿ÚÐÅÏ¢*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WINCFG
        {
            public uint dwSize;
            public byte byVaild;
            public byte byInputIdx;          /*ÊäÈëÔ´Ë÷Òý*/
            public byte byLayerIdx;          /*Í¼²ã£¬0Îª×îµ×²ã*/
            public byte byTransparency; //Í¸Ã÷¶È£¬0¡«100 
            public NET_DVR_RECTCFG struWin;//Ä¿µÄ´°¿Ú(Ïà¶ÔÏÔÊ¾Ç½)
            public ushort wScreenHeight;//´óÆÁ¸ß
            public ushort wScreenWidth;//´óÆÁ¿í
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALLWINCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYERNUMS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_WINCFG[] struWinCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENZOOM
        {
            public uint dwSize;
            public uint dwScreenNum;//´óÆÁºÅ
            public NET_DVR_POINT_FRAME struPointFrame;
            public byte byLayer;//Í¼²ãºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //2011-04-18
        /*ÉãÏñ»úÐÅÏ¢,×î¶à9999¸ö£¬´Ó1¿ªÊ¼ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_CAMERAINFO
        {
            public uint dwGlobalCamId;      /* camµÄÈ«¾Ö±àºÅ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCamName; /*camµÄÃû³Æ*/
            public uint dwMatrixId;          /*cam¶ÔÓ¦¾ØÕóµÄ±àºÅ*/
            public uint dwLocCamId;         /*cam¶ÔÓ¦¾ØÕóµÄÄÚ²¿±àºÅ*/
            public byte byValid;    /*ÊÇ·ñÓÐÐ§£¬0-·ñ£¬1-ÊÇ*/
            public byte byPtzCtrl; /* ÊÇ·ñ¿É¿Ø£¬0-·ñ£¬1-ÊÇ*/
            public byte byUseType; //*Ê¹ÓÃÀàÐÍ£¬0-²»×÷Îª¸ÉÏßÊ¹ÓÃ£¬1-BNC£¬2-SP3,3-V6¹âÏË£¬4-ÆäËû¹âÏË*/ 
            public byte byUsedByTrunk;//µ±Ç°Ê¹ÓÃ×´Ì¬£¬0-Ã»ÓÐ±»Ê¹ÓÃ£¬1-±»¸ÉÏßÊ¹ÓÃ 
            public byte byTrunkReq; /*ÉãÏñ»ú·Ö±æÂÊ,ÒÔD1Îªµ¥Î»£º1 - 1¸öD1£¬2- 2¸öD1£¬×÷Îª¸ÉÏßÊ¹ÓÃÊ±£¬Ö¸µÄÊÇ¸ÉÏßµÄ´ø¿í*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_TIME struInstallTime;//°²×°Ê±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*ÓÃÍ¾ÃèÊö*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*¼àÊÓÆ÷ÐÅÏ¢£¬×î¶à2048¸ö*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_MONITORINFO
        {
            public uint dwGloalMonId; /*mon µÄÍ³Ò»±àºÅ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sMonName;
            public uint dwMatrixId;  /*monËùÔÚ¾ØÕóµÄ±àºÅ*/
            public uint dwLocalMonId; /*monµÄÄÚ²¿±àºÅ*/
            public byte byValid;    /*ÊÇ·ñÓÐÐ§£¬0-·ñ£¬1-ÊÇ*/
            public byte byTrunkType; /*Ê¹ÓÃÀàÐÍ£¬0-²»×÷Îª¸ÉÏßÊ¹ÓÃ£¬1-BNC£¬2-SP3,3-V6¹âÏË£¬4-ÆäËû¹âÏË*/
            public byte byUsedByTrunk;//µ±Ç°Ê¹ÓÃ×´Ì¬£¬0-Ã»ÓÐ±»Ê¹ÓÃ£¬1-±»¸ÉÏßÊ¹ÓÃ 
            public byte byTrunkReq; /*·Ö±æÂÊ, ÒÔD1Îªµ¥Î»£º1- 1¸öD1£¬2- 2¸öD1£¬×÷Îª¸ÉÏßÊ¹ÓÃÊ±£¬Ö¸µÄÊÇ¸ÉÏßµÄ´ø¿í*/
            public NET_DVR_TIME struInstallTime;//°²×°Ê±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*ÓÃÍ¾ÃèÊö*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_DIGITALMATRIX
        {
            public NET_DVR_IPADDR struAddress; /*Éè±¸ÎªÊý×ÖÉè±¸Ê±µÄIPÐÅÏ¢*/
            public ushort wPort;
            public byte byNicNum; /*0 - eth0, 1 - eth1, ¿¼ÂÇË«Íø¿ÚÈçºÎÍ¨ÐÅ¼ÓÈë°ó¶¨µÄÍø¿Ú*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_ANALOGMATRIX
        {
            public byte bySerPortNum;   /*Á¬½ÓµÄ´®¿ÚºÅ*/
            public byte byMatrixSerPortType;/* ¾ØÕó½ÓÈëÍø¹ØµÄ´®¿ÚÓëÄ£Äâ¾ØÕóµÄ¼üÅÌ¿Ú(¼üÅÌÐ­Òé)Á¬½Ó»¹ÊÇÓë¾ØÕóÍ¨ÐÅ¿Ú£¨¾ØÕóÐ­Òé£©Á¬½Ó £¬0 --- ¾ØÕóÐ­ÒéÍ¨Ñ¶¿Ú 1 --- ¼üÅÌÍ¨Ñ¶¿Ú*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_SINGLE_RS232 struRS232;	//232´®¿Ú²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXLIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwMatrixNum;//Éè±¸·µ»ØµÄ¾ØÕóÊýÁ¿
            public IntPtr pBuffer;//¾ØÕóÐÅÏ¢»º³åÇø
            public uint dwBufLen;//Ëù·ÖÅäÖ¸Õë³¤¶È£¬ÊäÈë²ÎÊý
        }

        /*´®¿ÚÅäÖÃÐÅÏ¢*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_UARTPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPortName;
            public ushort wUserId; /*ÓÃ»§±àºÅ£¬µ±Á¬½ÓÉè±¸Îª¼üÅÌÊ±£¬°ó¶¨Ò»¸öÓÃ»§£¬ÓÃÓÚÈ¨ÏÞ¹ÜÀí*/
            public byte byPortType;    /*´®¿ÚÀàÐÍ£¬ÈýÖÖ0-RS232/1-RS485/2-RS422*/
            public byte byFuncType; /*´®¿ÚÁ¬½ÓµÄÉè±¸µÄÀàÐÍ0-¿ÕÏÐ£¬1-¼üÅÌ£¬2-ÓÃ×÷Í¸Ã÷Í¨µÀ(485´®¿Ú²»¿ÉÅäÖÃ³ÉÍ¸Ã÷Í¨µÀ),3-Ä£Äâ¾ØÕó*/
            public byte byProtocolType;  /*´®¿ÚÖ§³ÖµÄÐ­ÒéÀàÐÍ, µ±Á¬½Ó¼üÅÌÉè±¸Ê±ÐèÒª¸ÃÐÅÏ¢,»ñÈ¡¼üÅÌÖ§³ÖÐ­ÒéµÄ±àºÅ¼°ÃèÊö·û*/
            public byte byBaudRate;
            public byte byDataBits;
            public byte byStopBits;   /*Í£Ö¹Î»*/
            public byte byParity;      /*Ð£Ñé*/
            public byte byFlowCtrl;   /*Á÷¿Ø£¬Èí¼þÁ÷¿Ø£¬ÎÞÁ÷¿Ø*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     /*Ô¤Áô*/
        }

        //×î¶à256¸öÓÃ»§£¬1¡«256
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_USERPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            public byte byRole;/*ÓÃ»§½ÇÉ«:0-¹ÜÀíÔ±,1-²Ù×÷Ô±£»Ö»ÓÐÒ»¸öÏµÍ³¹ÜÀíÔ±£¬255¸ö²Ù×÷Ô±*/
            public byte byLevel;  /*Í³Ò»¼¶±ð£¬ÓÃÓÚ²Ù×÷¼¶±ð¹ÜÀí,1- 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //×î¶à255¸ö×ÊÔ´×é
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_RESOURSEGROUPPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byGroupName;
            public byte byGroupType;/*0-ÉãÏñ»úCAM×é£¬1-¼àÊÓÆ÷MON×é*/
            public byte byRes1;
            public ushort wMemNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.U4)]
            public uint[] dwGlobalId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //×î¶à255¸öÓÃ»§×é
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_USERGROUPPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sGroupName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
            public ushort[] wUserMember;  /*°üº¬µÄÓÃ»§³ÉÔ±*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
            public ushort[] wResorceGroupMember; /*°üº¬µÄ×ÊÔ´×é³ÉÔ±*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byPermission;//È¨ÏÞ£¬Êý×é0-ptzÈ¨ÏÞ¡¢ÇÐ»»È¨ÏÞ¡¢²éÑ¯È¨ÏÞ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_TRUNKPARAM
        {
            public uint dwSize;
            public uint dwTrunkId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sTrunkName;
            public uint dwSrcMonId;
            public uint dwDstCamId;
            public byte byTrunkType;  /*Ê¹ÓÃÀàÐÍ  1-BNC£¬2-SP3¹âÏË¸ßÇå£¬3-SP3¹âÏËD1£¬ 4-V6¹âÏË£¬5-ÆäËû¹âÏË*/
            public byte byAbility;     /*±íÊ¾¹âÏËµÄ´ø¿í£¬¿ÉÒÔ´«Êä¼¸Â·*/
            public byte bySubChan;   /*Õë¶Ô¹âÏË¸ÉÏß¶øÑÔ£¬±íÊ¾×ÓÍ¨µÀºÅ*/
            public byte byLevel;		/* ¸ÉÏß¼¶±ð 1-255*/
            public ushort wReserveUserID;	//Ô¤ÁôµÄÓÃ»§ID£º 1~256 £¬0±íÊ¾ÊÍ·ÅÔ¤Áô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRUNKLIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwTrunkNum;//Éè±¸·µ»ØµÄ¸ÉÏßÊýÁ¿
            public IntPtr pBuffer;//¸ÉÏßÐÅÏ¢»º³åÇø
            public uint dwBufLen;//Ëù·ÖÅäÖ¸Õë³¤¶È£¬ÊäÈë²ÎÊý
        }

        public const int MATRIX_PROTOCOL_NUM = 20;    //Ö§³ÖµÄ×î´ó¾ØÕóÐ­ÒéÊý
        public const int KEYBOARD_PROTOCOL_NUM = 20;    //Ö§³ÖµÄ×î´ó¼üÅÌÐ­ÒéÊý

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PROTO_TYPE_EX
        {
            public ushort wType;               /*ipcÐ­ÒéÖµ*/
            public ushort wCommunitionType;		/*0£ºÄ£Äâ 1£ºÊý×Ö 2£º¼æÈÝÄ£Äâ¡¢Êý×Ö*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; /*Ð­ÒéÃèÊö×Ö¶Î*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXMANAGE_ABIILITY
        {
            public uint dwSize;
            public uint dwMaxCameraNum;//×î´óCameraÊýÁ¿
            public uint dwMaxMonitorNum;//×î´ó¼àÊÓÆ÷ÊýÁ¿
            public ushort wMaxMatrixNum;//×î´ó¾ØÕóÊýÁ¿
            public ushort wMaxSerialNum;//´®¿ÚÊýÁ¿
            public ushort wMaxUser;//×î´óÓÃ»§Êý
            public ushort wMaxResourceArrayNum;//×î´ó×ÊÔ´×éÊý
            public ushort wMaxUserArrayNum;//×î´óÓÃ»§×éÊý
            public ushort wMaxTrunkNum;//×î´ó¸ÉÏßÊý
            public byte nStartUserNum;//ÆðÊ¼ÓÃ»§ºÅ
            public byte nStartUserGroupNum;//ÆðÊ¼ÓÃ»§×éºÅ
            public byte nStartResourceGroupNum;//ÆðÊ¼×ÊÔ´×éºÅ
            public byte nStartSerialNum;//ÆðÊ¼´®¿ÚºÅ
            public uint dwMatrixProtoNum;     /*ÓÐÐ§µÄ¾ØÕóÐ­ÒéÊýÄ¿£¬´Ó0¿ªÊ¼*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MATRIX_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE_EX[] struMatrixProto;/*×î´óÐ­ÒéÁÐ±í³¤¶È*/
            public uint dwKeyBoardProtoNum;     /*ÓÐÐ§µÄ¼üÅÌÐ­ÒéÊýÄ¿£¬´Ó0¿ªÊ¼*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MATRIX_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE_EX[] struKeyBoardProto;/*×î´óÐ­ÒéÁÐ±í³¤¶È*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÈËÁ³×¥ÅÄ¹æÔò(µ¥Ìõ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SINGLE_FACESNAPCFG
        {
            public byte byActive;				//ÊÇ·ñ¼¤»î¹æÔò£º0-·ñ£¬1-ÊÇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£Áô
            public NET_VCA_SIZE_FILTER struSizeFilter;   //³ß´ç¹ýÂËÆ÷
            public NET_VCA_POLYGON struVcaPolygon;		//ÈËÁ³Ê¶±ðÇøÓò
        }

        //ÈËÁ³×¥ÅÄ¹æÔò²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAPCFG
        {
            public uint dwSize;
            public byte bySnapTime;					//µ¥¸öÄ¿±êÈËÁ³µÄ×¥ÅÄ´ÎÊý0-10
            public byte bySnapInterval;                 //×¥ÅÄ¼ä¸ô£¬µ¥Î»£ºÖ¡
            public byte bySnapThreshold;               //×¥ÅÄãÐÖµ£¬0-100
            public byte byGenerateRate; 		//Ä¿±êÉú³ÉËÙ¶È,·¶Î§[1, 5]	
            public byte bySensitive;			//Ä¿±ê¼ì²âÁéÃô¶È£¬·¶Î§[1, 5]
            public byte byReferenceBright; //2012-3-27²Î¿¼ÁÁ¶È[0,100]
            public byte byMatchType;         //2012-5-3±È¶Ô±¨¾¯Ä£Ê½£¬0-Ä¿±êÏûÊ§ºó±¨¾¯£¬1-ÊµÊ±±¨¾¯
            public byte byMatchThreshold;  //2012-5-3ÊµÊ±±È¶ÔãÐÖµ£¬0~100
            public NET_DVR_JPEGPARA struPictureParam; //Í¼Æ¬¹æ¸ñ½á¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SINGLE_FACESNAPCFG[] struRule; //ÈËÁ³×¥ÅÄ¹æÔò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //ÈËÌåÌØÕ÷Ê¶±ð½á¹û½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_FEATURE
        {
            public byte byAgeGroup;    //ÄêÁä¶Î,²Î¼û HUMAN_AGE_GROUP_ENUM
            public byte bySex;         //ÐÔ±ð, 1 - ÄÐ , 2 - Å®
            public byte byEyeGlass;    //ÊÇ·ñ´÷ÑÛ¾µ 1 - ²»´÷, 2 - ´÷
            //×¥ÅÄÍ¼Æ¬ÈËÁ³ÄêÁäµÄÊ¹ÓÃ·½Ê½£¬ÈçbyAgeÎª15,byAgeDeviationÎª1,±íÊ¾£¬Êµ¼ÊÈËÁ³Í¼Æ¬ÄêÁäµÄÎª14-16Ö®¼ä
            public byte byAge;//ÄêÁä
            public byte byAgeDeviation;//ÄêÁäÎó²îÖµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±£Áô
        }

        //ÈËÁ³×¥ÅÄ½á¹û±¨¾¯ÉÏ´«
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_RESULT
        {
            public uint dwSize;
            public uint dwRelativeTime;
            public uint dwAbsTime;
            public uint dwFacePicID;
            public uint dwFaceScore;
            public NET_VCA_TARGET_INFO struTargetInfo;
            public NET_VCA_RECT struRect;
            public NET_VCA_DEV_INFO struDevInfo;
            public uint dwFacePicLen;
            public uint dwBackgroundPicLen;
            public byte bySmart;            //IDSÉè±¸·µ»Ø0(Ä¬ÈÏÖµ)£¬Smart Functiom Return 1
            public byte byAlarmEndMark;//±¨¾¯½áÊø±ê¼Ç0-±£Áô£¬1-½áÊø±ê¼Ç£¨¸Ã×Ö¶Î½áºÏÈËÁ³ID×Ö¶ÎÊ¹ÓÃ£¬±íÊ¾¸ÃID¶ÔÓ¦µÄÏÂ±¨¾¯½áÊø£¬Ö÷ÒªÌá¹©¸øNVRÊ¹ÓÃ£¬ÓÃÓÚÅÐ¶Ï±¨¾¯½áÊø£¬ÌáÈ¡Ê¶±ðÍ¼Æ¬Êý¾ÝÖÐ£¬ÇåÎú¶È×î¸ßµÄÍ¼Æ¬£©
            public byte byRepeatTimes;   //ÖØ¸´±¨¾¯´ÎÊý£¬0-ÎÞÒâÒå
            public byte byUploadEventDataType;//ÈËÁ³Í¼Æ¬Êý¾Ý³¤´«·½Ê½£º0-¶þ½øÖÆÊý¾Ý£¬1-URL
            public NET_VCA_HUMAN_FEATURE struFeature;  //ÈËÌåÊôÐÔ
            public float fStayDuration;  //Í£Áô»­ÃæÖÐÊ±¼ä(µ¥Î»: Ãë)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sStorageIP;        //´æ´¢·þÎñIPµØÖ·
            public ushort wStoragePort;            //´æ´¢·þÎñ¶Ë¿ÚºÅ
            public ushort wDevInfoIvmsChannelEx;     //ÓëNET_VCA_DEV_INFOÀïµÄbyIvmsChannelº¬ÒåÏàÍ¬£¬ÄÜ±íÊ¾¸ü´óµÄÖµ¡£ÀÏ¿Í»§¶ËÓÃbyIvmsChannelÄÜ¼ÌÐø¼æÈÝ£¬µ«ÊÇ×î´óµ½255¡£ÐÂ¿Í»§¶Ë°æ±¾ÇëÊ¹ÓÃwDevInfoIvmsChannelEx¡£
            public byte byFacePicQuality;
            public byte byUIDLen;     // ÉÏ´«±¨¾¯µÄ±êÊ¶³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;     // ±£Áô×Ö½Ú
            public IntPtr pUIDBuffer;  //±êÊ¶Ö¸Õë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;              // ±£Áô×Ö½Ú
            public byte byBrokenNetHttp;     //¶ÏÍøÐø´«±êÖ¾Î»£¬0-²»ÊÇÖØ´«Êý¾Ý£¬1-ÖØ´«Êý¾Ý
            public IntPtr pBuffer1;//Ö¸ÏòÈËÁ³×ÓÍ¼µÄÍ¼Æ¬Êý¾Ý
            public IntPtr pBuffer2;//±³¾°Í¼µÄÍ¼Æ¬Êý¾Ý£¨±£Áô£¬Í¨¹ý²éÕÒ±³¾°Í¼½Ó¿Ú¿ÉÒÔ»ñÈ¡±³¾°Í¼£©
        }

        //ÈËÁ³Õì²â±¨¾¯ÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_DETECTION
        {
            public uint dwSize;
            public uint dwRelativeTime;
            public uint dwAbsTime;
            public uint dwBackgroundPicLen;
            public NET_VCA_DEV_INFO struDevInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struFacePic; //ÈËÁ³×ÓÍ¼ÇøÓò£¬¹éÒ»»¯Öµ£¬Ïà¶ÔÓÚ´óÍ¼£¨±³¾°Í¼)µÄ·Ö±æÂÊ
            public byte byFacePicNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô
            public IntPtr pBackgroundPicpBuffer;//±³¾°Í¼µÄÍ¼Æ¬Êý¾Ý
        }

        //Ðé½¹Õì²â½á¹û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFOCUS_ALARM
        {
            public uint dwSize;     /*½á¹¹³¤¶È*/
            public NET_VCA_DEV_INFO struDevInfo;/*Éè±¸ÐÅÏ¢*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIOEXCEPTION_ALARM
        {
            public uint dwSize;     /*½á¹¹³¤¶È*/
            public byte byAlarmType;//±¨¾¯ÀàÐÍ£¬1-ÒôÆµÊäÈëÒì³££¬2-ÒôÆµÊäÈëÍ»±ä
            public byte byRes1;
            public ushort wAudioDecibel;//ÉùÒôÇ¿¶È£¨ÒôÆµÊäÈëÍ»±äÊ±ÓÃµ½£©
            public NET_VCA_DEV_INFO struDevInfo;/*Éè±¸ÐÅÏ¢*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_BUTTON_DOWN_EXCEPTION_ALARM
        {
            public uint dwSize;     /*½á¹¹³¤¶È*/
            public NET_VCA_DEV_INFO struDevInfo;/*Éè±¸ÐÅÏ¢*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_IMAGE_CFG
        {
            public uint dwWidth;                  //»Ò¶ÈÍ¼ÏñÊý¾Ý¿í¶È
            public uint dwHeight;                 //»Ò¶ÈÍ¼Ïñ¸ß¶È
            public uint dwImageLen;  //»Ò¶ÈÍ¼ÏñÊý¾Ý³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£Áô
            public IntPtr pImage;    //»Ò¶ÈÍ¼ÏñÊý¾Ý
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_PROCIMG_CFG
        {
            public uint dwSize;           //½á¹¹´óÐ¡
            public byte byEnable;         //ÊÇ·ñ¼¤»î¹æÔò;
            public byte bySensitivity;      //¼ì²âÁéÃô¶È£¬[0,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       //±£Áô×Ö½Ú 
            public NET_VCA_SIZE_FILTER struSizeFilter;  //³ß´ç¹ýÂËÆ÷
            public NET_VCA_POLYGON struPolygon;    //¶à±ßÐÎ
            public NET_VCA_FD_IMAGE_CFG struFDImage;  //Í¼Æ¬ÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SUB_PROCIMG
        {
            public uint dwImageLen;  //Í¼Æ¬Êý¾Ý³¤¶È
            public uint dwFaceScore;		//ÈËÁ³ÆÀ·Ö,0-100
            public NET_VCA_RECT struVcaRect; //ÈËÁ³×ÓÍ¼ÇøÓò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£Áô
            public IntPtr pImage;  //Í¼Æ¬Êý¾Ý
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_PROCIMG_RESULT
        {
            public uint dwSize;   //½á¹¹´óÐ¡
            public uint dwImageId; //´óÍ¼ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
            public uint dwSubImageNum;  //ÈËÁ³×ÓÍ¼ÕÅÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TARGET_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SUB_PROCIMG[] struProcImg;  //µ¥ÕÅ×ÓÍ¼ÐÅÏ¢
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PICMODEL_RESULT
        {
            public uint dwImageLen;  //Í¼Æ¬Êý¾Ý³¤¶È
            public uint dwModelLen;  //Ä£ÐÍÊý¾Ý³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
            public IntPtr pImage;  //ÈËÁ³Í¼Æ¬Êý¾ÝÖ¸Õë
            public IntPtr pModel;  //Ä£ÐÍÊý¾ÝÖ¸Õë
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_REGISTER_PIC
        {
            public uint dwImageID; //´óÍ¼ID
            public uint dwFaceScore;		//ÈËÁ³ÆÀ·Ö,0-100
            public NET_VCA_RECT struVcaRect;  //ÈËÁ³×ÓÍ¼ÇøÓò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£Áô
        }

        //¼®¹á²ÎÊý½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AREAINFOCFG
        {
            public ushort wNationalityID;//¹ú¼®
            public ushort wProvinceID;//Ê¡
            public ushort wCityID;//ÊÐ
            public ushort wCountyID;//ÏØ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô
        }

        //ÈËÔ±ÐÅÏ¢½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_ATTRIBUTE
        {
            public byte bySex;//ÐÔ±ð£º0-ÄÐ£¬1-Å®
            public byte byCertificateType;//Ö¤¼þÀàÐÍ£º0-Éí·ÝÖ¤£¬1-¾¯¹ÙÖ¤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byBirthDate;//³öÉúÄêÔÂ£¬Èç£º201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName; //ÐÕÃû
            public NET_DVR_AREAINFOCFG struNativePlace;//¼®¹á²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCertificateNumber; //Ö¤¼þºÅ
            public uint dwPersonInfoExtendLen;// ÈËÔ±±êÇ©ÐÅÏ¢À©Õ¹³¤¶È
            public IntPtr pPersonInfoExtend;  //ÈËÔ±±êÇ©ÐÅÏ¢À©Õ¹ÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMANATTRIBUTE_COND
        {
            public byte bySex; //ÐÔ±ð£º0-²»ÆôÓÃ£¬1-ÄÐ£¬2-Å®
            public byte byCertificateType; //Ö¤¼þÀàÐÍ£º0-²»ÆôÓÃ£¬1-Éí·ÝÖ¤£¬2-¾¯¹ÙÖ¤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byStartBirthDate; //ÆðÊ¼³öÉúÄêÔÂ£¬Èç£º201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byEndBirthDate; //½ØÖ¹³öÉúÄêÔÂ£¬Èç201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName; //ÐÕÃû
            public NET_DVR_AREAINFOCFG struNativePlace; //¼®¹á²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCertificateNumber;  //Ö¤¼þºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ºÚÃûµ¥ÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO
        {
            public uint dwSize;//½á¹¹´óÐ¡
            public uint dwRegisterID;//Ãûµ¥×¢²áIDºÅ£¨Ö»¶Á£©
            public uint dwGroupNo;//·Ö×éºÅ
            public byte byType;//ºÚ°×Ãûµ¥±êÖ¾£º0-È«²¿£¬1-°×Ãûµ¥£¬2-ºÚÃûµ¥
            public byte byLevel;//ºÚÃûµ¥µÈ¼¶£¬0-È«²¿£¬1-µÍ£¬2-ÖÐ£¬3-¸ß
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£Áô
            public NET_VCA_HUMAN_ATTRIBUTE struAttribute;//ÈËÔ±ÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemark;//±¸×¢ÐÅÏ¢
            public uint dwFDDescriptionLen;//ÈËÁ³¿âÃèÊöÊý¾Ý³¤¶È
            public IntPtr pFDDescriptionBuffer;//ÈËÁ³¿âÃèÊöÊý¾ÝÖ¸Õë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_PARA
        {
            public uint dwSize;   //½á¹¹´óÐ¡
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;  //ºÚÃûµ¥»ù±¾²ÎÊý
            public uint dwRegisterPicNum;  //ºÚÃûµ¥Í¼¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PICMODEL_RESULT[] struRegisterPic;  //ºÚÃûµ¥Í¼Æ¬ÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_COND
        {
            public Int32 lChannel; //Í¨µÀºÅ
            public uint dwGroupNo; //·Ö×éºÅ
            public byte byType; //ºÚ°×Ãûµ¥±êÖ¾£º0-È«²¿£¬1-°×Ãûµ¥£¬2-ºÚÃûµ¥
            public byte byLevel; //ºÚÃûµ¥µÈ¼¶£¬0-È«²¿£¬1-µÍ£¬2-ÖÐ£¬3-¸ß
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±£Áô
            public NET_VCA_HUMAN_ATTRIBUTE struAttribute; //ÈËÔ±ÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_PIC
        {
            public uint dwSize;   //½á¹¹´óÐ¡
            public uint dwFacePicNum;  //ÈËÁ³Í¼¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PICMODEL_RESULT[] struBlackListPic;  //µ¥ÕÅÕÕÆ¬ÐÅÏ¢
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FIND_PICTURECOND
        {
            public Int32 lChannel;//Í¨µÀºÅ
            public NET_DVR_TIME struStartTime;//¿ªÊ¼Ê±¼ä
            public NET_DVR_TIME struStopTime;//½áÊøÊ±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }

        public const int MAX_FACE_PIC_LEN = 6144;   //×î´óÈËÁ³Í¼Æ¬Êý¾Ý³¤¶È

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SUB_SNAPPIC_DATA
        {
            public uint dwFacePicID; //ÈËÁ³Í¼ID
            public uint dwFacePicLen;  //ÈËÁ³Í¼Êý¾Ý³¤¶È
            public NET_DVR_TIME struSnapTime;  //×¥ÅÄÊ±¼ä
            public uint dwSimilarity; //ÏàËÆ¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£Áô
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_FACE_PIC_LEN)]
            public string sPicBuf;  //Í¼Æ¬Êý¾Ý
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADVANCE_FIND
        {
            public uint dwFacePicID; //ÈËÁ³Í¼Æ¬ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_NORMAL_FIND
        {
            public uint dwImageID; //´óÍ¼ID
            public uint dwFaceScore;  //ÈËÁ³ÆÀ·Ö
            public NET_VCA_RECT struVcaRect; //ÈËÁ³×ÓÍ¼ÇøÓò
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_VCA_FIND_SNAPPIC_UNION
        {
            //ÁªºÏÌå´óÐ¡Îª44×Ö½Ú
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            /*[FieldOffsetAttribute(0)]
            public NET_VCA_NORMAL_FIND  struNormalFind; //ÆÕÍ¨¼ìË÷
            [FieldOffsetAttribute(0)]
            public NET_VCA_ADVANCE_FIND struAdvanceFind; //¸ß¼¶¼ìË÷
             * */
        }

        public enum VCA_FIND_SNAPPIC_TYPE
        {
            VCA_NORMAL_FIND = 0x00000000,   //ÆÕÍ¨¼ìË÷
            VCA_ADVANCE_FIND = 0x00000001  //¸ß¼¶¼ìË÷
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FIND_PICTURECOND_ADVANCE
        {
            public Int32 lChannel;//Í¨µÀºÅ
            public NET_DVR_TIME struStartTime;//¿ªÊ¼Ê±¼ä
            public NET_DVR_TIME struStopTime;//½áÊøÊ±¼ä
            public byte byThreshold;  //ãÐÖµ£¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
            public VCA_FIND_SNAPPIC_TYPE dwFindType;//¼ìË÷ÀàÐÍ£¬Ïê¼ûVCA_FIND_SNAPPIC_TYPE
            public NET_VCA_FIND_SNAPPIC_UNION uFindParam; //¼ìË÷²ÎÊý
        }

        //ÈËÁ³×¥ÅÄÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_INFO_ALARM
        {
            public uint dwRelativeTime;     // Ïà¶ÔÊ±±ê
            public uint dwAbsTime;            // ¾ø¶ÔÊ±±ê
            public uint dwSnapFacePicID;       //×¥ÅÄÈËÁ³Í¼ID
            public uint dwSnapFacePicLen;        //×¥ÅÄÈËÁ³×ÓÍ¼µÄ³¤¶È£¬Îª0±íÊ¾Ã»ÓÐÍ¼Æ¬£¬´óÓÚ0±íÊ¾ÓÐÍ¼Æ¬
            public NET_VCA_DEV_INFO struDevInfo;   //Ç°¶ËÉè±¸ÐÅÏ¢
            public byte byFaceScore;        //ÈËÁ³ÆÀ·Ö£¬Ö¸ÈËÁ³×ÓÍ¼µÄÖÊÁ¿µÄÆÀ·Ö,0-100
            public byte bySex;//ÐÔ±ð£¬0-Î´Öª£¬1-ÄÐ£¬2-Å®
            public byte byGlasses;//ÊÇ·ñ´øÑÛ¾µ£¬0-Î´Öª£¬1-ÊÇ£¬2-·ñ
            /*
             * Ê¶±ðÈËÁ³µÄÄêÁä¶Î·¶Î§[byAge-byAgeDeviation,byAge+byAgeDeviation]
             */
            public byte byAge;//ÄêÁä
            public byte byAgeDeviation;//ÄêÁäÎó²îÖµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;              // ±£Áô×Ö½Ú
            public uint dwUIDLen; // ÉÏ´«±¨¾¯µÄ±êÊ¶³¤¶È
            public IntPtr pUIDBuffer;  //±êÊ¶Ö¸Õë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±£Áô×Ö½Ú
            public IntPtr pBuffer1;  //×¥ÅÄÈËÁ³×ÓÍ¼µÄÍ¼Æ¬Êý¾Ý
        }

        //ºÚÃûµ¥±¨¾¯ÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO_ALARM
        {
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;
            public uint dwBlackListPicLen;       //ºÚÃûµ¥ÈËÁ³×ÓÍ¼µÄ³¤¶È£¬Îª0±íÊ¾Ã»ÓÐÍ¼Æ¬£¬´óÓÚ0±íÊ¾ÓÐÍ¼Æ¬
            public uint dwFDIDLen;// ÈËÁ³¿âID³¤¶È
            public IntPtr pFDID;  //ÈËÁ³¿âIdÖ¸Õë
            public uint dwPIDLen;// ÈËÁ³¿âÍ¼Æ¬ID³¤¶È
            public IntPtr pPID;  //ÈËÁ³¿âÍ¼Æ¬IDÖ¸Õë
            public ushort wThresholdValue; //ÈËÁ³¿âãÐÖµ[0,100]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô
            public IntPtr pBuffer1;//Ö¸ÏòÍ¼Æ¬µÄÖ¸Õë
        }

        //ºÚÃûµ¥±È¶Ô½á¹û±¨¾¯ÉÏ´«
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_MATCH_ALARM
        {
            public uint dwSize;             // ½á¹¹´óÐ¡
            public float fSimilarity; //ÏàËÆ¶È£¬[0.001,1]
            public NET_VCA_FACESNAP_INFO_ALARM struSnapInfo; //×¥ÅÄÐÅÏ¢
            public NET_VCA_BLACKLIST_INFO_ALARM struBlackListInfo; //ºÚÃûµ¥ÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sStorageIP;        //´æ´¢·þÎñIPµØÖ·
            public ushort wStoragePort;            //´æ´¢·þÎñ¶Ë¿ÚºÅ
            public byte byMatchPicNum; //Æ¥ÅäÍ¼Æ¬µÄÊýÁ¿£¬0-±£Áô£¨ÀÏÉè±¸Õâ¸öÖµÄ¬ÈÏ0£¬ÐÂÉè±¸Õâ¸öÖµÎª0Ê±±íÊ¾ºóÐøÃ»ÓÐÆ¥ÅäµÄÍ¼Æ¬ÐÅÏ¢£©
            public byte byPicTransType;//Í¼Æ¬Êý¾Ý´«Êä·½Ê½: 0-¶þ½øÖÆ£»1-url
            public uint dwSnapPicLen;//Éè±¸Ê¶±ð×¥ÅÄÍ¼Æ¬³¤¶È
            public IntPtr pSnapPicBuffer;//Éè±¸Ê¶±ð×¥ÅÄÍ¼Æ¬Ö¸Õë
            public NET_VCA_RECT struRegion;//Ä¿±ê±ß½ç¿ò£¬Éè±¸Ê¶±ð×¥ÅÄÍ¼Æ¬ÖÐ£¬ÈËÁ³×ÓÍ¼×ø±ê
            public uint dwModelDataLen;//½¨Ä£Êý¾Ý³¤¶È
            public IntPtr pModelDataBuffer;// ½¨Ä£Êý¾ÝÖ¸Õë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO_ALARM_LOG
        {
            public NET_VCA_BLACKLIST_INFO struBlackListInfo; //ºÚÃûµ¥»ù±¾ÐÅÏ¢
            public uint dwBlackListPicID;       //ºÚÃûµ¥ÈËÁ³×ÓÍ¼ID£¬ÓÃÓÚ²éÕÒÍ¼Æ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_INFO_ALARM_LOG
        {
            public uint dwRelativeTime;     // Ïà¶ÔÊ±±ê
            public uint dwAbsTime;			// ¾ø¶ÔÊ±±ê
            public uint dwSnapFacePicID;       //×¥ÅÄÈËÁ³Í¼ID
            public NET_VCA_DEV_INFO struDevInfo;		//Ç°¶ËÉè±¸ÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_MATCH_ALARM_LOG
        {
            public uint dwSize;     		// ½á¹¹´óÐ¡
            public float fSimilarity; //ÏàËÆ¶È£¬[0.001,1]
            public NET_VCA_FACESNAP_INFO_ALARM_LOG struSnapInfoLog; //×¥ÅÄÐÅÏ¢
            public NET_VCA_BLACKLIST_INFO_ALARM_LOG struBlackListInfoLog; //ºÚÃûµ¥ÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACEMATCH_PICCOND
        {
            public uint dwSize;     		// ½á¹¹´óÐ¡
            public uint dwSnapFaceID; //×¥ÅÄÈËÁ³×ÓÍ¼ID
            public uint dwBlackListID; //Æ¥ÅäµÄºÚÃûµ¥ID
            public uint dwBlackListFaceID; //±È¶ÔµÄºÚÃûµ¥ÈËÁ³×ÓÍ¼ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±£Áô×Ö½Ú
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACEMATCH_PICTURE
        {
            public uint dwSize;     		// ½á¹¹´óÐ¡
            public uint dwSnapFaceLen; //×¥ÅÄÈËÁ³×ÓÍ¼³¤¶È
            public uint dwBlackListFaceLen; //±È¶ÔµÄºÚÃûµ¥ÈËÁ³×ÓÍ¼³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              //±£Áô×Ö½Ú
            public IntPtr pSnapFace;  //×¥ÅÄÈËÁ³×ÓÍ¼µÄÍ¼Æ¬Êý¾Ý
            public IntPtr pBlackListFace;  //±È¶ÔµÄºÚÃûµ¥ÈËÁ³×ÓÍ¼Êý¾Ý
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_FASTREGISTER_PARA
        {
            public uint dwSize;   //½á¹¹´óÐ¡
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;  //ºÚÃûµ¥»ù±¾²ÎÊý
            public uint dwImageLen;  //Í¼ÏñÊý¾Ý³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£Áô
            public IntPtr pImage;    //Í¼ÏñÊý¾Ý
        }

        //µ¥¸ö·ÖÇøÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SINGLE_PATH
        {
            public byte byActive;  // ÊÇ·ñ¿ÉÓÃ,0-·ñ,1-ÊÇ 
            public byte byType;   //0-´æ´¢×¥ÅÄ£¬1-´æ´¢ºÚÃûµ¥±È¶Ô±¨¾¯£¬2-´æ´¢×¥ÅÄºÍºÚÃûµ¥±È¶Ô±¨¾¯£¬0xff-ÎÞÐ§
            public byte bySaveAlarmPic; //ÊÇ·ñÓÃÓÚ±£´æ¶ÏÍøµÄ±¨¾¯Í¼Æ¬£¬0-·ñ£¬1-ÊÇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1; //±£Áô
            public uint dwDiskDriver;   //ÅÌ·ûºÅ£¬´Ó0¿ªÊ¼
            public uint dwLeftSpace;   //Ô¤ÁôÈÝÁ¿£¨µ¥Î»ÎªG£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£Áô
        }

        //´æ´¢Â·¾¶ÉèÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SAVE_PATH_CFG
        {
            public uint dwSize;   //½á¹¹´óÐ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SINGLE_PATH[] struPathInfo; //µ¥¸ö·ÖÇø
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_ACCESS_CFG
        {
            public uint dwSize;
            public NET_DVR_IPADDR struIP;		//½ÓÈëÉè±¸µÄIPµØÖ·
            public ushort wDevicePort;			 	//¶Ë¿ÚºÅ
            public byte byEnable;		         //ÊÇ·ñÆôÓÃ£¬0-·ñ£¬1-ÊÇ
            public byte byRes1;				//±£Áô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	//½ÓÈëÉè±¸µÄµÇÂ¼ÕÊºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	//½ÓÈëÉè±¸µÄµÇÂ¼ÃÜÂë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        /********************************ÖÇÄÜÈËÁ³Ê¶±ð end****************************/
        //·Ö±æÂÊ
        public const int NOT_AVALIABLE = 0;
        public const int SVGA_60HZ = 52505660;
        public const int SVGA_75HZ = 52505675;
        public const int XGA_60HZ = 67207228;
        public const int XGA_75HZ = 67207243;
        public const int SXGA_60HZ = 84017212;
        public const int SXGA2_60HZ = 84009020;
        public const int _720P_60HZ = 83978300;
        public const int _720P_50HZ = 83978290;
        public const int _1080I_60HZ = 394402876;
        public const int _1080I_50HZ = 394402866;
        public const int _1080P_60HZ = 125967420;
        public const int _1080P_50HZ = 125967410;
        public const int _1080P_30HZ = 125967390;
        public const int _1080P_25HZ = 125967385;
        public const int _1080P_24HZ = 125967384;
        public const int UXGA_60HZ = 105011260;
        public const int UXGA_30HZ = 105011230;
        public const int WSXGA_60HZ = 110234940;
        public const int WUXGA_60HZ = 125982780;
        public const int WUXGA_30HZ = 125982750;
        public const int WXGA_60HZ = 89227324;
        public const int SXGA_PLUS_60HZ = 91884860;

        //ÏÔÊ¾Í¨µÀ»­Ãæ·Ö¸îÄ£Ê½
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPWINDOWMODE
        {
            public byte byDispChanType;//ÏÔÊ¾Í¨µÀÀàÐÍ£º0-VGA, 1-BNC, 2-HDMI, 3-DVI
            public byte byDispChanSeq;//ÏÔÊ¾Í¨µÀÐòºÅ,´Ó1¿ªÊ¼£¬Èç¹ûÀàÐÍÊÇVGA£¬Ôò±íÊ¾µÚ¼¸¸öVGA
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDispMode;
        }

        //ÏÔÊ¾Í¨µÀÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPINFO
        {
            public byte byChanNums;//Í¨µÀ¸öÊý
            public byte byStartChan;//ÆðÊ¼Í¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUPPORT_RES, ArraySubType = UnmanagedType.U1)]
            public uint[] dwSupportResolution;//Ö§³ÖµÄ·Ö±æÂÊ
        }

        //´óÆÁÆ´½ÓÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENINFO
        {
            public byte bySupportBigScreenNums;//×î¶à´óÆÁÆ´½ÓÊýÁ¿
            public byte byStartBigScreenNum;//´óÆÁÆ´½ÓÆðÊ¼ºÅ
            public byte byMaxScreenX;//´óÆÁÆ´½ÓÄ£Ê½
            public byte byMaxScreenY;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_ABILITY_V41
        {
            public uint dwSize;
            public byte byDspNums;//DSP¸öÊý  
            public byte byDecChanNums;//½âÂëÍ¨µÀÊý
            public byte byStartChan;//ÆðÊ¼½âÂëÍ¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;

            public NET_DVR_DISPINFO struVgaInfo;//VGAÏÔÊ¾Í¨µÀÐÅÏ¢
            public NET_DVR_DISPINFO struBncInfo;//BNCÏÔÊ¾Í¨µÀÐÅÏ¢
            public NET_DVR_DISPINFO struHdmiInfo;//HDMIÏÔÊ¾Í¨µÀÐÅÏ¢
            public NET_DVR_DISPINFO struDviInfo;//DVIÏÔÊ¾Í¨µÀÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPNUM_V41, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISPWINDOWMODE[] struDispMode;
            public NET_DVR_SCREENINFO struBigScreenInfo;
            public byte bySupportAutoReboot; //ÊÇ·ñÖ§³Ö×Ô¶¯ÖØÆô£¬0-²»Ö§³Ö£¬1-Ö§³Ö
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 119, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_WINDOWS = 16;//×î´ó´°¿ÚÊý
        public const int MAX_WINDOWS_V41 = 36;

        public const int STARTDISPCHAN_VGA = 1;
        public const int STARTDISPCHAN_BNC = 9;
        public const int STARTDISPCHAN_HDMI = 25;
        public const int STARTDISPCHAN_DVI = 29;

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_VIDEO_PLATFORM
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            /*[FieldOffsetAttribute(0)]
            public VideoPlatform struVideoPlatform;
            [FieldOffsetAttribute(0)]
            public NotVideoPlatform struNotVideoPlatform;
             * */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VideoPlatform
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byDecResolution;
            public NET_DVR_RECTCFG struPosition; //ÏÔÊ¾Í¨µÀÔÚµçÊÓÇ½ÖÐÎ»ÖÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NotVideoPlatform
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*ÏÔÊ¾Í¨µÀÅäÖÃ½á¹¹Ìå*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_VOUTCFG
        {
            public uint dwSize;
            public byte byAudio;			/*ÒôÆµÊÇ·ñ¿ªÆô*/
            public byte byAudioWindowIdx;      /*ÒôÆµ¿ªÆô×Ó´°¿Ú*/
            public byte byDispChanType;      /*ÏÔÊ¾Í¨µÀÀàÐÍ£º0-BNC£¬1-VGA£¬2-HDMI£¬3-DVI£¬4-YPbPr(½âÂë¿¨·þÎñÆ÷DECODER_SERVER×¨ÓÃ)*/
            public byte byVedioFormat;         /*1:NTSC,2:PAL£¬0-NULL*/
            public uint dwResolution;//·Ö±æÂÊ
            public uint dwWindowMode;		/*»­ÃæÄ£Ê½£¬ÄÜÁ¦¼¯»ñÈ¡*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*¸÷¸ö×Ó´°¿Ú¹ØÁªµÄ½âÂëÍ¨µÀ,Éè±¸Ö§³Ö½âÂë×ÊÔ´×Ô¶¯·ÖÅäÊ±´Ë²ÎÊý²»ÓÃÌî³ä*/
            public byte byEnlargeStatus;          /*ÊÇ·ñ´¦ÓÚ·Å´ó×´Ì¬£¬0£º²»·Å´ó£¬1£º·Å´ó*/
            public byte byEnlargeSubWindowIndex;//·Å´óµÄ×Ó´°¿ÚºÅ
            public byte byScale; /*ÏÔÊ¾Ä£Ê½£¬0---ÕæÊµÏÔÊ¾£¬1---Ëõ·ÅÏÔÊ¾( Õë¶ÔBNC )*/
            public byte byUnionType;/*Çø·Ö¹²ÓÃÌå,0-ÊÓÆµ×ÛºÏÆ½Ì¨ÄÚ²¿½âÂëÆ÷ÏÔÊ¾Í¨µÀÅäÖÃ£¬1-ÆäËû½âÂëÆ÷ÏÔÊ¾Í¨µÀÅäÖÃ*/
            public NET_DVR_VIDEO_PLATFORM struDiff;
            public uint dwDispChanNum; //ÏÔÊ¾Êä³öºÅ£¬´Ë²ÎÊýÔÚÈ«²¿»ñÈ¡Ê±ÓÐÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*½âÂëÆ÷Éè±¸×´Ì¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_CHAN_STATUS_V41
        {
            public byte byDispStatus;      /*ÏÔÊ¾×´Ì¬£º0£ºÎ´ÏÔÊ¾£¬1£ºÆô¶¯ÏÔÊ¾*/
            public byte byBVGA;              /*0-BNC£¬1-VGA£¬ 2-HDMI£¬3-DVI£¬0xff-ÎÞÐ§*/
            public byte byVideoFormat;     /*ÊÓÆµÖÆÊ½£¬1:NTSC,2:PAL,0-NON*/
            public byte byWindowMode;       /*»­ÃæÄ£Ê½*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;   /*¸÷¸ö×Ó»­Ãæ¹ØÁªµÄ½âÂëÍ¨µÀ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byFpsDisp;        /*Ã¿¸ö×Ó»­ÃæµÄÏÔÊ¾Ö¡ÂÊ*/
            public byte byScreenMode;		/*ÆÁÄ»Ä£Ê½0-ÆÕÍ¨ 1-´óÆÁ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDispChan; /*»ñÈ¡È«²¿ÏÔÊ¾Í¨µÀ×´Ì¬Ê±ÓÐÐ§£¬ÉèÖÃÊ±¿ÉÌî0*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*½âÂëÆ÷Éè±¸×´Ì¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODER_WORK_STATUS_V41
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_STATUS[] struDecChanStatus;     /*½âÂëÍ¨µÀ×´Ì¬*/
            /*ÏÔÊ¾Í¨µÀ×´Ì¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPNUM_V41, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISP_CHAN_STATUS_V41[] struDispChanStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatus;         /*±¨¾¯ÊäÈë×´Ì¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatus;       /*±¨¾¯Êä³ö×´Ì¬*/
            public byte byAudioInChanStatus;          /*ÓïÒô¶Ô½²×´Ì¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************ÎÄ¼þ»Ø·Å-Ô¶³Ì»Ø·ÅÉèÖÃ*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_V41
        {
            public uint dwSize;
            public NET_DVR_IPADDR struIP;       /* DVR IPµØÖ· */
            public ushort wDVRPort;         /* ¶Ë¿ÚºÅ */
            public byte byChannel;			/* Í¨µÀºÅ */
            public byte byReserve;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;		/* ÓÃ»§Ãû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;		/* ÃÜÂë */
            public uint dwPlayMode;     /* 0£­°´ÎÄ¼þ 1£­°´Ê±¼ä*/
            public NET_DVR_TIME StartTime;
            public NET_DVR_TIME StopTime;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		/*±£Áô*/
        }

        public const int MAX_BIGSCREENNUM_SCENE = 100;

        //ÏÔÊ¾Í¨µÀÅäÖÃ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECTCFG_SCENE
        {
            public ushort wXCoordinate; /*¾ØÐÎ×óÉÏ½ÇÆðÊ¼µãX×ø±ê*/
            public ushort wYCoordinate; /*¾ØÐÎ×óÉÏ½ÇY×ø±ê*/
            public ushort wWidth;       /*¾ØÐÎ¿í¶È*/
            public ushort wHeight;      /*¾ØÐÎ¸ß¶È*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENEDISPCFG
        {
            public byte byEnable;//ÊÇ·ñÆôÓÃ£¬0-²»ÆôÓÃ£¬1-ÆôÓÃ
            public byte bySoltNum;//²ÛÎ»ºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byDispChanNum;
            public byte byAudio;				/*ÒôÆµÊÇ·ñ¿ªÆô,0-·ñ£¬1-ÊÇ*/
            public byte byAudioWindowIdx;      /*ÒôÆµ¿ªÆô×Ó´°¿Ú*/
            public byte byVedioFormat;          /*1:NTSC,2:PAL£¬0-NULL*/
            public byte byWindowMode;			/*»­ÃæÄ£Ê½£¬´ÓÄÜÁ¦¼¯»ñÈ¡*/
            public byte byEnlargeStatus;         /*ÊÇ·ñ´¦ÓÚ·Å´ó×´Ì¬£¬0£º²»·Å´ó£¬1£º·Å´ó*/
            public byte byEnlargeSubWindowIndex;//·Å´óµÄ×Ó´°¿ÚºÅ    
            public byte byScale; /*ÏÔÊ¾Ä£Ê½£¬0-ÕæÊµÏÔÊ¾£¬1-Ëõ·ÅÏÔÊ¾( Õë¶ÔBNC )*/
            public uint dwResolution;//·Ö±æÂÊ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*¸÷¸ö×Ó´°¿Ú¹ØÁªµÄ½âÂëÍ¨µÀ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;/*²ÛÎ»ºÅ*/
            //ÏÔÊ¾´°¿ÚËù½âÊÓÆµ·Ö±æÂÊ£¬1-D1,2-720P,3-1080P£¬Éè±¸¶ËÐèÒª¸ù¾Ý´Ë//·Ö±æÂÊ½øÐÐ½âÂëÍ¨µÀµÄ·ÖÅä£¬Èç1·ÖÆÁÅäÖÃ³É1080P£¬ÔòÉè±¸»á°Ñ4¸ö½âÂëÍ¨µÀ¶¼·ÖÅä¸ø´Ë½âÂëÍ¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byDecResolution;
            public byte byRow;//´óÆÁËùÔÚµÄÐÐµÄÐòºÅ
            public byte byColumn;//´óÆÁËùÔÚµÄÁÐµÄÐòºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_RECTCFG struDisp; //µçÊÓÇ½ÏÔÊ¾Î»ÖÃ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_CHAN_INFO_SCENE
        {
            public NET_DVR_IPADDR struIP;				/* DVR IPµØÖ· */
            public ushort wDVRPort;			 	/* ¶Ë¿ÚºÅ */
            public byte byChannel;		/* Í¨µÀºÅ£¬¶ÔÓÚ9000µÈÉè±¸µÄIPC½ÓÈë£¬Í¨µÀºÅ´Ó33¿ªÊ¼ */
            public byte byTransProtocol;		/* ´«ÊäÐ­ÒéÀàÐÍ0-TCP£¬1-UDP £¬2-MCAST£¬3-RTP*/
            public byte byTransMode;			/* ´«ÊäÂëÁ÷Ä£Ê½ 0£­Ö÷ÂëÁ÷ 1£­×ÓÂëÁ÷*/
            public byte byFactoryType;				/*Ç°¶ËÉè±¸³§¼ÒÀàÐÍ*/
            public byte byDeviceType;			//Éè±¸ÀàÐÍ£¬1-IPC£¬2- ENCODER
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/* ¼à¿ØÖ÷»úµÇÂ½ÕÊºÅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	/* ¼à¿ØÖ÷»úÃÜÂë */
        }

        /*Á÷Ã½Ìå·þÎñÆ÷»ù±¾ÅäÖÃ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE
        {
            public byte byValid;			/*ÊÇ·ñÆôÓÃÁ÷Ã½Ìå·þÎñÆ÷È¡Á÷,0±íÊ¾ÎÞÐ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struDevIP;	/*Á÷Ã½Ìå·þÎñÆ÷µØÖ·*/
            public ushort wDevPort;			/*Á÷Ã½Ìå·þÎñÆ÷¶Ë¿Ú*/
            public byte byTransmitType;		/*´«ÊäÐ­ÒéÀàÐÍ0-TCP£¬1-UDP */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_CFG_SCENE
        {
            public NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE streamMediaServerCfg;
            public NET_DVR_DEV_CHAN_INFO_SCENE struDevChanInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CYC_SUR_CHAN_ELE_SCENE
        {
            public byte byEnable;	/* ÊÇ·ñÆôÓÃ 0£­·ñ 1£­ÆôÓÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE struStreamMediaSvrCfg;
            public NET_DVR_DEV_CHAN_INFO_SCENE struDecChanInfo;	/*ÂÖÑ²½âÂëÍ¨µÀÐÅÏ¢*/
        }

        //ÂÖÑ²½âÂë½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO_SCENE
        {
            public ushort wPoolTime;		/*ÂÖÑ¯¼ä¸ô*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CYC_SUR_CHAN_ELE_SCENE[] struChanArray;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENCFG_SCENE
        {
            public byte byAllValid; /*ÂþÓÎÊ¹ÄÜ±êÖ¾ */
            public byte byAssociateBaseMap;//¹ØÁªµÄµ×Í¼ÐòºÅ£¬0´ú±í²»¹ØÁª
            public byte byEnableSpartan;//´óÆÁ³©ÏÔÊ¹ÄÜ£¬1-¿ª£¬0-¹Ø
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYERNUMS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_WINCFG[] struWinCfg;
            public NET_DVR_BIGSCREENCFG struBigScreen;

            public void Init()
            {
                struBigScreen = new NET_DVR_BIGSCREENCFG();
                struWinCfg = new NET_DVR_WINCFG[MAX_LAYERNUMS];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_SCENECFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSceneName;
            public byte byBigScreenNums;//´óÆÁµÄ¸öÊý£¬×î´óÖµÍ¨¹ýÄÜÁ¦¼¯»ñÈ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public ushort wDecChanNums;//³¡¾°ÖÐ½âÂëÍ¨µÀµÄ¸öÊý
            public ushort wDispChanNums;//³¡¾°ÖÐÏÔÊ¾Í¨µÀµÄ¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public IntPtr pBigScreenBuffer;//´óÆÁÅäÖÃ»º³åÇø, byBigScreenNums¡Ásizeof(NET_DVR_BIGSCREENCFG_SCENE)
            public IntPtr pDecChanBuffer;//½âÂëÍ¨µÀÅäÖÃ»º³åÇø, wDecChanNums¡Ásizeof(NET_DVR_DECODECHANCFG_SCENE)
            public IntPtr pDispChanBuffer;//ÏÔÊ¾Í¨µÀÅäÖÃ»º³åÇø, wDispChanNums¡Ásizeof(NET_DVR_SCENEDISPCFG)
            public void Init()
            {
                sSceneName = new byte[NAME_LEN];
                byRes1 = new byte[3];
                byRes1 = new byte[12];
            }
        }
        public const int NET_DVR_GET_ALLWINCFG = 1503; //´°¿Ú²ÎÊý»ñÈ¡

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENASSOCIATECFG
        {
            public uint dwSize;
            public byte byEnableBaseMap;//Ê¹ÄÜµ×Í¼ÏÔÊ¾
            public byte byAssociateBaseMap;//¹ØÁªµÄµ×Í¼ÐòºÅ£¬0´ú±í²»¹ØÁª
            public byte byEnableSpartan;//´óÆÁ³©ÏÔÊ¹ÄÜ£¬1-¿ª£¬0-¹Ø
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************´°¿ÚÉèÖÃ*******************************/
        public const int MAX_WIN_COUNT = 224; //Ö§³ÖµÄ×î´ó¿ª´°Êý

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_WINCFG
        {
            public uint dwSize;
            public byte byVaild;
            public byte byInputType;		//¼ûCAM_MDOE
            public ushort wInputIdx;			/*ÊäÈëÔ´Ë÷Òý*/
            public uint dwLayerIdx;			/*Í¼²ã£¬0Îª×îµ×²ã*/
            public NET_DVR_RECTCFG struWin;	//Ä¿µÄ´°¿Ú(Ïà¶ÔÏÔÊ¾Ç½)
            public byte byWndIndex;			//´°¿ÚºÅ
            public byte byCBD;				//0-ÎÞ£¬1-´ø±³¾°£¬2-²»´ø±³¾°
            public byte bySubWnd;			//0²»ÊÇ£¬1ÊÇ
            public byte byRes1;
            public uint dwDeviceIndex;//Éè±¸ÐòºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WINLIST
        {
            public uint dwSize;
            public ushort wScreenSeq;	//Éè±¸ÐòºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwWinNum;	//Éè±¸·µ»ØµÄ´°¿ÚÊýÁ¿
            public IntPtr pBuffer;	//´°¿ÚÐÅÏ¢»º³åÇø£¬×î´óÎª224*sizeof(NET_DVR_WINCFG)
            public uint dwBufLen;	//Ëù·ÖÅäÖ¸Õë³¤¶È
        }

        public const int MAX_LAYOUT_COUNT = 16;		//×î´ó²¼¾ÖÊý

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LAYOUTCFG
        {
            public uint dwSize;
            public byte byValid;								//²¼¾ÖÊÇ·ñÓÐÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLayoutName;			//²¼¾ÖÃû³Æ			
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WIN_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCREEN_WINCFG[] struWinCfg;	//²¼¾ÖÄÚ´°¿Ú²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LAYOUT_LIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYOUT_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LAYOUTCFG[] struLayoutInfo;   //ËùÓÐ²¼¾Ö
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_CAM_COUNT = 224;

        public enum NET_DVR_CAM_MODE
        {
            NET_DVR_UNKNOW = 0,//ÎÞÐ§
            NET_DVR_CAM_BNC,
            NET_DVR_CAM_VGA,
            NET_DVR_CAM_DVI,
            NET_DVR_CAM_HDMI,
            NET_DVR_CAM_IP,
            NET_DVR_CAM_RGB,
            NET_DVR_CAM_DECODER,
            NET_DVR_CAM_MATRIX,
            NET_DVR_CAM_YPBPR,
            NET_DVR_CAM_USB,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTREAMCFG
        {
            public uint dwSize;
            public byte byValid;
            public byte byCamMode;						//ÐÅºÅÊäÈëÔ´ÀàÐÍ£¬¼ûNET_DVR_CAM_MODE
            public ushort wInputNo;						//ÐÅºÅÔ´ÐòºÅ0-224
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCamName;			//ÐÅºÅÊäÈëÔ´Ãû³Æ
            public NET_DVR_VIDEOEFFECT struVideoEffect;	//ÊÓÆµ²ÎÊý
            public NET_DVR_PU_STREAM_CFG struPuStream;	//ipÊäÈëÊ±Ê¹ÓÃ
            public ushort wBoardNum;						//ÐÅºÅÔ´ËùÔÚµÄ°å¿¨ºÅ
            public ushort wInputIdxOnBoard;				//ÐÅºÅÔ´ÔÚ°å¿¨ÉÏµÄÎ»ÖÃ
            public ushort wResolutionX;					//·Ö±æÂÊ
            public ushort wResolutionY;
            public byte byVideoFormat;					//ÊÓÆµÖÆÊ½£¬0-ÎÞ£¬1-NTSC£¬2-PAL
            public byte byNetSignalResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500wp ¡£ÍøÂçÐÅºÅÔ´µÄ·Ö±æÂÊ£¬ÔÚÌí¼ÓÍøÂçÐÅºÅÔ´Ê±´«¸øÉè±¸£¬Éè±¸¸ù¾ÝÕâ¸ö·Ö±æÂÊÀ´·ÖÅä½âÂë×ÊÔ´¡£
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sGroupName;	//ÍøÂçÐÅºÅÔ´·Ö×é ×éÃû
            public byte byJointMatrix;			//  ¹ØÁª¾ØÕó £¬0-²»¹ØÁª  1-¹ØÁª
            public byte byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTREAM_LIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CAM_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INPUTSTREAMCFG[] struInputStreamInfo; //ËùÓÐÐÅºÅÔ´
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************Êä³ö²ÎÊýÅäÖÃ*******************************/
        /*Êä³öÍ¨µÀ¹ÜÀí*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUTPARAM
        {
            public uint dwSize;
            public byte byMonMode;		/*Êä³öÁ¬½ÓÄ£Ê½,1-BNC,2-VGA,3-DVI,4-HDMI*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwResolution;	/*·Ö±æÂÊ£¬¸ù¾ÝÄÜÁ¦¼¯»ñÈ¡ËùÖ§³ÖµÄ½øÐÐÉèÖÃ*/
            public NET_DVR_VIDEOEFFECT struVideoEffect;	/*Êä³öÍ¨µÀÊÓÆµ²ÎÊýÅäÖÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUTCFG
        {
            public uint dwSize;
            public byte byScreenLayX;						//´óÆÁ²¼¾Ö-ºá×ø±ê
            public byte byScreenLayY;						//´óÆÁ²¼¾Ö-×Ý×ø±ê
            public ushort wOutputChanNum;					//Êä³öÍ¨µÀ¸öÊý£¬0±íÊ¾Éè±¸Ö§³ÖµÄ×î´óÊä³öÍ¨µÀ¸öÊý£¬×î´ó¸öÊý´ÓÄÜÁ¦¼¯»ñÈ¡£¬ÆäËûÖµ±íÊ¾Êµ¼ÊÊä³öÍ¨µÀ¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_OUTPUTPARAM struOutputParam;	/*Êä³öÍ¨µÀÊÓÆµ²ÎÊýÅäÖÃ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sWallName;					//µçÊÓÇ½Ãû³Æ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************ÄÜÁ¦¼¯*******************************/
        public const int SCREEN_PROTOCOL_NUM = 20;   //Ö§³ÖµÄ×î´ó´óÆÁ¿ØÖÆÆ÷Ð­ÒéÊý

        //¶àÆÁ·þÎñÆ÷ÄÜÁ¦¼¯
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENSERVER_ABILITY
        {
            public uint dwSize;   			/*½á¹¹³¤¶È*/
            public byte byIsSupportScreenNum; /*ËùÖ§³Ö´óÆÁ¿ØÖÆÆ÷µÄÊýÄ¿*/
            public byte bySerialNums;			//´®¿Ú¸öÊý
            public byte byMaxInputNums;
            public byte byMaxLayoutNums;
            public byte byMaxWinNums;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byMaxScreenLayX;//´óÆÁ²¼¾Ö-×î´óºá×ø±ê´óÆÁÊý
            public byte byMaxScreenLayY;//´óÆÁ²¼¾Ö-×î´ó×Ý×ø±ê´óÆÁÊý
            public ushort wMatrixProtoNum; /*ÓÐÐ§µÄ´óÆÁÐ­ÒéÊýÄ¿*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SCREEN_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE[] struScreenProto;/*×î´óÐ­ÒéÁÐ±í*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //¶àÆÁ¿ØÖÆÆ÷ÄÜÁ¦¼¯
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENCONTROL_ABILITY
        {
            public uint dwSize;   		/*½á¹¹³¤¶È*/
            public byte byLayoutNum; 		/* ²¼¾Ö¸öÊý*/
            public byte byWinNum; 			/*ÆÁÄ»´°¿Ú¸öÊý*/
            public byte byOsdNum;  		/*OSD¸öÊý*/
            public byte byLogoNum; 		/*Logo¸öÊý*/
            public byte byInputStreamNum;  //ÊäÈëÔ´¸öÊý ---Éè±¸Ö§³Ö×î´óÊäÈëÍ¨µÀ¸öÊý£¨°üÀ¨±¾µØÊäÈëÔ´ºÍÍøÂçÊäÈëÔ´£©
            public byte byOutputChanNum;	//Êä³öÍ¨µÀ¸öÊý---Éè±¸Ö§³Ö×î´óÊä³öÍ¨µÀ¸öÊý
            public byte byCamGroupNum;		/*·Ö×é¸öÊý*/
            public byte byPlanNum;    		/*Ô¤°¸¸öÊý*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byIsSupportPlayBack;  /*ÊÇ·ñÖ§³Ö»Ø·Å*/
            public byte byMatrixInputNum;  //Ö§³ÖÊäÈë¾ØÕó×î´ó¸öÊý
            public byte byMatrixOutputNum; //Ö§³ÖÊä³ö¾ØÕó×î´ó¸öÊý
            public NET_DVR_DISPINFO struVgaInfo;//VGAÊä³öÐÅÏ¢
            public NET_DVR_DISPINFO struBncInfo;//BNCÊä³öÐÅÏ¢
            public NET_DVR_DISPINFO struHdmiInfo;//HDMIÊä³öÐÅÏ¢
            public NET_DVR_DISPINFO struDviInfo;//DVIÊä³öÐÅÏ¢
            public byte byMaxUserNums;//Ö§³ÖÓÃ»§Êý
            public byte byPicSpan;		//µ×Í¼¿ç¶È£¬Ò»ÕÅµ×Í¼×î¶à¿É¸²¸ÇµÄÆÁÄ»Êý
            public ushort wDVCSDevNum;	//·Ö²¼Ê½´óÆÁ¿ØÖÆÆ÷×î´óÉè±¸Êý
            public ushort wNetSignalNum;	//×î´óÍøÂçÊäÈëÔ´¸öÊý
            public ushort wBaseCoordinateX;//»ù×¼×ø±ê
            public ushort wBaseCoordinateY;
            public byte byExternalMatrixNum;	//×î´óÍâ½Ó¾ØÕó¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 49, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************ÊäÈëÐÅºÅ×´Ì¬*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOGINPUTSTATUS
        {
            public uint dwLostFrame;		/*ÊÓÆµÊäÈë¶ªÖ¡Êý*/
            public byte byHaveSignal;		/*ÊÇ·ñÓÐÊÓÆµÐÅºÅÊäÈë*/
            public byte byVideoFormat;		/*ÊÓÆµÖÆÊ½£¬1£ºNTSC,2£ºPAL,0£ºÎÞ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_INPUTSTATUS_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            /*[FieldOffsetAttribute(0)]
            public NET_DVR_MATRIX_CHAN_STATUS struIpInputStatus;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ANALOGINPUTSTATUS struAnalogInputStatus;
             * */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTATUS
        {
            public ushort wInputNo;		/*ÐÅºÅÔ´ÐòºÅ*/
            public byte byInputType;	//¼ûNET_DVR_CAM_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_INPUTSTATUS_UNION struStatusUnion;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENINPUTSTATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwNums;		//Éè±¸·µ»ØµÄÊäÈëÔ´×´Ì¬µÄÊýÁ¿
            public IntPtr pBuffer;	//»º³åÇø
            public uint dwBufLen;	//Ëù·ÖÅäÖ¸Õë³¤¶È£¬ÊäÈë²ÎÊý
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENALARMCFG
        {
            public uint dwSize;
            public byte byAlarmType;	//±¨¾¯ÀàÐÍ£¬1-×Ó°å°Î³ö£¬2-×Ó°å²åÈë£¬3-×ÓÏµÍ³×´Ì¬Òì³££¬4-×ÓÏµÍ³»Ö¸´»Ö¸´ 5-ÊäÈëÔ´Òì³£   6-ÎÂ¶È±¨¾¯ 7-FPGA°æ±¾²»Æ¥Åä 8-Ô¤°¸¿ªÊ¼ 9-Ô¤°¸½áÊø 10-½âÂë°å¶ÏÍø 11-½âÂë°åIPµØÖ·³åÍ»£¬12-·çÉÈÒì³£
            public byte byBoardType;	// 1-ÊäÈë°å 2-Êä³ö°å £¬3-Ö÷°å£¬4-±³°å£¬±¨¾¯ÀàÐÍÎª1£¬2£¬3£¬6µÄÊ±ºòÊ¹ÓÃ 
            public byte bySubException;	//ÊäÈëÒì³£Ê±¾ßÌå×ÓÒì³£ 1- ·Ö±æÂÊÕý³£¸Ä±ä 2-ÊäÈë¶Ë¿ÚÀàÐÍ¸Ä±ä3-·Ö±æÂÊ´íÎó4-·Ö±æÂÊ¸Ä±äµ¼ÖÂ½âÂë×ÊÔ´²»×ã£¬¹Ø±Õ¸ÃÊäÈëÔ´¶ÔÓ¦´°¿Ú¡£5-·Ö±æÂÊ¸Ä±ä£¬µ¼ÖÂÒÑ¿ª´°µÄËõ·Å±ÈÀý²»ÔÚ1/8µ½8±¶·¶Î§¡£6-·Ö±æÂÊ»Ö¸´Õý³£,7-·Ö±æÂÊ¸Ä±äµ¼ÖÂÊä³ö°åÊý¾ÝÁ¿³¬ÏÞ,Éè±¸¹Ø±Õ´°¿Ú 
            public byte byRes1;
            public ushort wStartInputNum; // Òì³£ÊäÈëÔ´£¨Òì³£Æðµã£© 
            public ushort wEndInputNum;	// Òì³£ÊäÈëÔ´£¨Òì³£ÖÕµã£© 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CFG
        {
            public byte byValid;				//ÅÐ¶ÏÊÇ·ñÊÇÄ£Äâ¾ØÕó£¨ÊÇ·ñÓÐÐ§£©
            public byte byCommandProtocol;	//Ä£Äâ¾ØÕóµÄÖ¸Áî£¨4ÖÖ£©
            public byte byScreenType;			//±£Áô	
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byScreenToMatrix;	//Ä£Äâ¾ØÕóµÄÊä³öÓëÆÁÄ»µÄ¶ÔÓ¦¹ØÏµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIGITALSCREEN
        {
            public NET_DVR_IPADDR struAddress;/*Éè±¸ÎªÊý×ÖÉè±¸Ê±µÄIPÐÅÏ¢*/
            public ushort wPort;		//Í¨µÀºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 26, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOGSCREEN
        {
            public byte byDevSerPortNum;   /*Á¬½ÓÉè±¸µÄ´®¿ÚºÅ*/
            public byte byScreenSerPort;  /*Á¬½Ó´óÆÁµÄ´®¿ÚºÅ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_MATRIX_CFG struMatrixCfg;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SCREEN_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 172, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            /*[FieldOffsetAttribute(0)]
            public NET_DVR_DIGITALSCREEN struDigitalScreen;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ANALOGSCREEN struAnalogScreen;
             * */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_SCREENINFO
        {
            public uint dwSize;
            public byte byValid;				//ÊÇ·ñÓÐÐ§
            public byte nLinkMode;				//Á¬½Ó·½Ê½£¬0-´®¿Ú£¬1-Íø¿Ú
            public byte byDeviceType;			//Éè±¸ÐÍºÅ£¬ÄÜÁ¦¼¯»ñÈ¡
            public byte byScreenLayX;			//´óÆÁ²¼¾Ö-ºá×ø±ê
            public byte byScreenLayY;			//´óÆÁ²¼¾Ö-×Ý×ø±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/*µÇÂ¼ÓÃ»§Ãû*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword; /*µÇÂ¼ÃÜÂë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDevName;	/*Éè±¸Ãû³Æ*/
            public NET_DVR_SCREEN_UNION struScreenUnion;
            public byte byInputNum;			// ÊäÈëÔ´¸öÊý
            public byte byOutputNum;			// Êä³öÔ´¸öÊý
            public byte byCBDNum;				//CBD¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 29, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************µ×Í¼ÉÏ´«*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BASEMAP_CFG
        {
            public byte byScreenIndex;         //ÆÁÄ»µÄÐòºÅ
            public byte byMapNum;				/*±»·Ö¸î³ÉÁË¶àÉÙ¿é*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
            public ushort wSourWidth;			/* Ô­Í¼Æ¬µÄ¿í¶È */
            public ushort wSourHeight;			/* Ô­Í¼Æ¬µÄ¸ß¶È */
        }

        /*******************************OSD*******************************/
        public const int MAX_OSDCHAR_NUM = 256;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OSDCFG
        {
            public uint dwSize;
            public byte byValid;    /*ÊÇ·ñÓÐÐ§ 0ÎÞÐ§ 1ÓÐÐ§*/
            public byte byDispMode;  //ÏÔÊ¾Ä£Ê½£¬1-Í¸Ã÷£¬2-°ëÍ¸Ã÷£¬3-¸²¸ÇÈýÖÖÄ£Ê½
            public byte byFontColorY; /*×ÖÌåÑÕÉ«Y,0-255*/
            public byte byFontColorU; /*×ÖÌåÑÕÉ«U,0-255*/
            public byte byFontColorV; /*×ÖÌåÑÕÉ«V,0-255*/
            public byte byBackColorY; /*±³¾°ÑÕÉ«Y,0-255*/
            public byte byBackColorU; /*±³¾°ÑÕÉ«U,0-255*/
            public byte byBackColorV; /*±³¾°ÑÕÉ«V,0-255*/
            public ushort wXCoordinate;   /*OSDÔÚÆÁÄ»×óÉÏ½ÇÎ»ÖÃx*/
            public ushort wYCoordinate;   /*OSDÔÚÆÁÄ»×óÉÏ½ÇÎ»ÖÃy*/
            public ushort wWidth;       /*OSD¿í¶È*/
            public ushort wHeight;      /*OSD¸ß¶È*/
            public uint dwCharCnt;     /*×Ö·ûµÄ¸öÊý*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_OSDCHAR_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wOSDChar;       /*OSD×Ö·ûÄÚÈÝ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************»ñÈ¡´®¿ÚÐÅÏ¢*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SERIAL_CONTROL
        {
            public uint dwSize;
            public byte bySerialNum;        // ´®¿Ú¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] bySerial;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************ÆÁÄ»¿ØÖÆ*******************************/
        //ÆÁÄ»ÊäÈëÔ´¿ØÖÆ
        public enum INPUT_INTERFACE_TYPE
        {
            INTERFACE_VGA = 0,
            INTERFACE_SVIDEO, // 2046NL²»Ö§³Ö£¬2046NHÖ§³Ö
            INTERFACE_YPBPR,
            INTERFACE_DVI,
            INTERFACE_BNC,
            INTERFACE_DVI_LOOP,//(»·Í¨) 2046NH²»Ö§³Ö£¬2046NLÖ§³Ö
            INTERFACE_BNC_LOOP, //(»·Í¨) 2046NH²»Ö§³Ö£¬2046NL.Ö§³Ö
            INTERFACE_HDMI,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUT_INTERFACE_CTRL
        {
            public byte byInputSourceType;	//¼ûINPUT_INTERFACE_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÏÔÊ¾µ¥ÔªÑÕÉ«¿ØÖÆ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_COLOR_CTRL
        {
            public byte byColorType;		//1-ÁÁ¶È 2-¶Ô±È¶È 3-±¥ºÍ¶È 4-ÇåÎú¶È
            public char byScale;			//-1 ¡¢0¡¢+1Èý¸öÖµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ÏÔÊ¾µ¥ÔªÎ»ÖÃ¿ØÖÆ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_POSITION_CTRL
        {
            public byte byPositionType;	//1-Ë®Æ½Î»ÖÃ 2-´¹Ö±Î»ÖÃ£¬
            public char byScale;			//-1 ¡¢0¡¢+1Èý¸öÖµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SCREEN_CONTROL_PARAM
        {
            /*[FieldOffsetAttribute(0)]
            public NET_DVR_INPUT_INTERFACE_CTRL struInputCtrl;
            [FieldOffsetAttribute(0)]
            public NET_DVR_DISPLAY_COLOR_CTRL struDisplayCtrl;
            [FieldOffsetAttribute(0)]
            public NET_DVR_DISPLAY_POSITION_CTRL struPositionCtrl;
            [FieldOffsetAttribute(0)]
             * */
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_CONTROL
        {
            public uint dwSize;
            public uint dwCommand;      /* ¿ØÖÆ·½·¨ 1-¿ª 2-¹Ø 3-ÆÁÄ»ÊäÈëÔ´Ñ¡Ôñ 4-ÏÔÊ¾µ¥ÔªÑÕÉ«¿ØÖÆ 5-ÏÔÊ¾µ¥ÔªÎ»ÖÃ¿ØÖÆ*/
            public byte byProtocol;      //´®¿ÚÐ­ÒéÀàÐÍ,1:LCD-S1,2:LCD-S2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_SCREEN_CONTROL_PARAM struControlParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************ÆÁÄ»¿ØÖÆV41*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_CONTROL_V41
        {
            public uint dwSize;
            public byte bySerialNo;		//´®¿ÚºÅ
            public byte byBeginAddress;	//×óÉÏ½ÇÆÁÄ»ºÅ£¬´Ó1¿ªÊ¼
            public byte byEndAddress;	//ÓÒÏÂ½ÇÆÁÄ»ºÅ£¬´Ó1¿ªÊ¼
            public byte byProtocol;      	   // ´®¿ÚÐ­ÒéÀàÐÍ  1-LCD-S1 , 2-LCD-S2 , 3-LCD-L1 £¬ 4-LCD-DLP£¬ 5-LCD-S3 , 6-LCD-H1 
            public uint dwCommand;      /* ¿ØÖÆ·½·¨ 1-¿ª 2-¹Ø 3-ÆÁÄ»ÊäÈëÔ´Ñ¡Ôñ 4-ÏÔÊ¾µ¥ÔªÑÕÉ«¿ØÖÆ 5-ÏÔÊ¾µ¥ÔªÎ»ÖÃ¿ØÖÆ*/
            public NET_DVR_SCREEN_CONTROL_PARAM struControlParam;
            public byte byWallNo;		// µçÊÓÇ½ºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 51, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************Ô¤°¸¹ÜÀí*******************************/
        public const int MAX_PLAN_ACTION_NUM = 32; 	//Ô¤°¸¶¯×÷¸öÊý
        public const int DAYS_A_WEEK = 7;	//Ò»ÖÜ7Ìì
        public const int MAX_PLAN_COUNT = 16;	//Ô¤°¸¸öÊý

        public enum NET_DVR_PLAN_OPERATE_TYPE
        {
            NET_DVR_SWITCH_LAYOUT = 1,      // ²¼¾ÖÇÐ»» Ä¬ÈÏ
            NET_DVR_SCREEN_POWER_OFF,       // ¹Ø±Õ´óÆÁÄ»ÏÔÊ¾
            NET_DVR_SCREEN_POWER_ON,   		// ´ò¿ª´óÆÁÄ»ÏÔÊ¾
        }

        /*Ô¤°¸ÏîÐÅÏ¢*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_INFO
        {
            public byte byValid;      	// ¸ÃÏîÊÇ·ñÓÐÐ§
            public byte byType;       	// ¼û¶¨ÒåNET_DVR_PLAN_OPERATE_TYPE
            public ushort wLayoutNo;  	// ²¼¾ÖºÅ
            public byte byScreenStyle;    //ÆÁÄ»ÐÍºÅ£¬¿ª¹Ø»úËùÓÃ£¬1ÊÇµÍÁÁ£¬2ÊÇ¸ßÁÁ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDelayTime;  	// Ò»¸öÏîµÄÔËÐÐÊ±¼ä, µ¥Î»Ãë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CYCLE_TIME
        {
            public byte byValid;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_TIME_EX struTime;
        }

        /*Ô¤°¸¹ÜÀí*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_CFG
        {
            public uint dwSize;
            public byte byValid;      	// ¸ÃÔ¤°¸ÊÇ·ñÓÐÐ§
            public byte byWorkMode;  	// Ô¤°¸¹¤×÷Ä£Ê½ 1±íÊ¾ÊÖ¶¯£¬2×Ô¶¯£¬3Ô¤°¸Ñ­»·
            public byte byWallNo;		//µçÊÓÇ½ºÅ£¬´Ó1¿ªÊ¼
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPlanName; //Ô¤°¸Ãû³Æ
            public NET_DVR_TIME_EX struTime; // ¹¤×÷Ä£Ê½Îª×Ô¶¯Ê±Ê¹ÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DAYS_A_WEEK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CYCLE_TIME[] struTimeCycle; /*Ñ­»·Ê±¼ä£¬ÖÜÆÚÎªÒ»¸öÐÇÆÚ£¬Äê¡¢ÔÂ¡¢ÈÕÈý¸ö²ÎÊý²»Ê¹ÓÃ¡£Èç£ºstruTimeCycle[0]ÖÐµÄbyValidµÄÖµÊÇ1£¬±íÊ¾ÐÇÆÚÌìÖ´ÐÐ¸ÃÔ¤°¸¡£ÐÇÆÚÈ¡ÖµÇø¼äÎª[0,6]£¬ÆäÖÐ0´ú±íÐÇÆÚÌì£¬1´ú±íÐÇÆÚÒ»£¬ÒÔ´ËÀàÍÆ*/
            public uint dwWorkCount;  	// Ô¤°¸ÄÚÈÝÖ´ÐÐ´ÎÊý£¬0ÎªÒ»Ö±Ñ­»·²¥·Å£¬ÆäËûÖµ±íÊ¾´ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PLAN_ACTION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PLAN_INFO[] strPlanEntry;  // Ô¤°¸Ö´ÐÐµÄÄÚÈÝ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************»ñÈ¡Éè±¸×´Ì¬*******************************/
        /*Ô¤°¸ÁÐ±í*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_LIST
        {
            public uint dwSize;
            public uint dwPlanNums;			//Éè±¸ÊäÈëÐÅºÅÔ´ÊýÁ¿
            public IntPtr pBuffer;			//Ö¸ÏòdwInputSignalNums¸öNET_DVR_PLAN_CFG½á¹¹´óÐ¡µÄ»º³åÇø
            public byte byWallNo;			//Ç½ºÅ£¬´Ó1¿ªÊ¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwBufLen;			//Ëù·ÖÅä»º³åÇø³¤¶È£¬ÊäÈë²ÎÊý£¨´óÓÚµÈÓÚdwInputSignalNums¸öNET_DVR_PLAN_CFG½á¹¹´óÐ¡£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************Ô¤°¸¿ØÖÆ*******************************/
        //¸Ã½á¹¹Ìå¿É×÷ÎªÍ¨ÓÃ¿ØÖÆ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CONTROL_PARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDeviceID; //±»¿ØÉè±¸µÄÉè±¸ID
            public ushort wChan;				 //±»¿ØÍ¨µÀ
            public byte byIndex;			 //¿ØÖÆË÷Òý£¬¸ù¾ÝÃüÁîÈ·¶¨¾ßÌå±íÊ¾Ê²Ã´Ë÷Òý
            public byte byRes1;
            public uint dwControlParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************»ñÈ¡Éè±¸×´Ì¬*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICE_RUN_STATUS
        {
            public uint dwSize;
            public uint dwMemoryTotal;		//ÄÚ´æ×ÜÁ¿	µ¥Î»Kbyte
            public uint dwMemoryUsage;		//ÄÚ´æÊ¹ÓÃÁ¿ µ¥Î»Kbyte
            public byte byCPUUsage;			//CPUÊ¹ÓÃÂÊ 0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //91ÏµÁÐHD-SDI¸ßÇåDVR Ïà»úÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACCESS_CAMERA_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCameraInfo;		// Ç°¶ËÏà»úÐÅÏ¢
            public byte byInterfaceType;		// Ç°¶Ë½ÓÈë½Ó¿ÚÀàÐÍ£¬1:VGA, 2:HDMI, 3:YPbPr 4:SDI 5:FC
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIO_INPUT_PARAM
        {
            public byte byAudioInputType;  //ÒôÆµÊäÈëÀàÐÍ£¬0-mic in£¬1-line in
            public byte byVolume; //volume,[0-100]
            public byte byEnableNoiseFilter; //ÊÇ·ñ¿ªÆôÉùÒô¹ýÂË-¹Ø£¬-¿ª
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERA_DEHAZE_CFG
        {
            public uint dwSize;
            public byte byDehazeMode; //0-²»ÆôÓÃ£¬1-×Ô¶¯Ä£Ê½£¬2-¿ª
            public byte byLevel; //µÈ¼¶£¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUT_SIGNAL_LIST
        {
            public uint dwSize;
            public uint dwInputSignalNums;	//Éè±¸ÊäÈëÐÅºÅÔ´ÊýÁ¿
            public IntPtr pBuffer;			//Ö¸ÏòdwInputSignalNums¸öNET_DVR_INPUTSTREAMCFG½á¹¹´óÐ¡µÄ»º³åÇø
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwBufLen;			//Ëù·ÖÅä»º³åÇø³¤¶È£¬ÊäÈë²ÎÊý£¨´óÓÚµÈÓÚdwInputSignalNums¸öNET_DVR_INPUTSTREAMCFG½á¹¹´óÐ¡£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //°²È«°ÎÅÌ×´Ì¬
        public const int PULL_DISK_SUCCESS = 1;     // °²È«°ÎÅÌ³É¹¦
        public const int PULL_DISK_FAIL = 2;        // °²È«°ÎÅÌÊ§°Ü
        public const int PULL_DISK_PROCESSING = 3;  // ÕýÔÚÍ£Ö¹ÕóÁÐ
        public const int PULL_DISK_NO_ARRAY = 4;	// ÕóÁÐ²»´æÔÚ 
        public const int PULL_DISK_NOT_SUPPORT = 5; // ²»Ö§³Ö°²È«°ÎÅÌ

        //É¨ÃèÕóÁÐ×´Ì¬
        public const int SCAN_RAID_SUC = 1; 	// É¨ÃèÕóÁÐ³É¹¦
        public const int SCAN_RAID_FAIL = 2; 	// É¨ÃèÕóÁÐÊ§°Ü
        public const int SCAN_RAID_PROCESSING = 3;	// ÕýÔÚÉ¨ÃèÕóÁÐ
        public const int SCAN_RAID_NOT_SUPPORT = 4; // ²»Ö§³ÖÕóÁÐÉ¨Ãè

        //ÉèÖÃÇ°¶ËÏà»úÀàÐÍ×´Ì¬
        public const int SET_CAMERA_TYPE_SUCCESS = 1;  // ³É¹¦
        public const int SET_CAMERA_TYPE_FAIL = 2;  // Ê§°Ü
        public const int SET_CAMERA_TYPE_PROCESSING = 3;   // ÕýÔÚ´¦Àí

        //9000 2.2
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_TIME_SPAN_INQUIRY
        {
            public uint dwSize;    //½á¹¹Ìå´óÐ¡
            public byte byType;    //0 Õý³£ÒôÊÓÆµÂ¼Ïñ, 1Í¼Æ¬Í¨µÀÂ¼Ïñ, 2ANRÍ¨µÀÂ¼Ïñ, 3³éÖ¡Í¨µÀÂ¼Ïñ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_TIME_SPAN
        {
            public uint dwSize;        //½á¹¹Ìå´óÐ¡
            public NET_DVR_TIME strBeginTime;  //¿ªÊ¼Ê±¼ä
            public NET_DVR_TIME strEndTime;    //½áÊøÊ±¼ä
            public byte byType;        //0 Õý³£ÒôÊÓÆµÂ¼Ïñ, 1Í¼Æ¬Í¨µÀÂ¼Ïñ, 2ANRÍ¨µÀÂ¼Ïñ, 3³éÖ¡Í¨µÀÂ¼Ïñ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DRAWFRAME_DISK_QUOTA_CFG
        {
            public uint dwSize;					//½á¹¹Ìå´óÐ¡
            public byte byPicQuota;				//Í¼Æ¬°Ù·Ö±È	 [0%,  30%]
            public byte byRecordQuota;				//ÆÕÍ¨Â¼Ïñ°Ù·Ö±È [20%, 40%]
            public byte byDrawFrameRecordQuota;	//³éÖ¡Â¼Ïñ°Ù·Ö±È [30%, 80%]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 61, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;					//±£Áô×Ö½Ú
        }

        //¶Ë¿ÚÓ³ÉäÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAT_PORT
        {
            public ushort wEnable;
            public ushort wExtPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¶Ë¿ÚÓ³ÉäÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAT_CFG
        {
            public uint dwSize;
            public ushort wEnableUpnp;
            public ushort wEnableNat;
            public NET_DVR_IPADDR struIpAddr;//ÏÄÊ±ÖÆÍ£Ö¹Ê±¼ä
            public NET_DVR_NAT_PORT struHttpPort;//ÏÄÊ±ÖÆÍ£Ö¹Ê±¼ä
            public NET_DVR_NAT_PORT struCmdPort;//ÏÄÊ±ÖÆÍ£Ö¹Ê±¼ä
            public NET_DVR_NAT_PORT struRtspPort;//ÏÄÊ±ÖÆÍ£Ö¹Ê±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byFriendName;
            public byte byNatType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_NAT_PORT struHttpsPort;//ÏÄÊ±ÖÆÍ£Ö¹Ê±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Upnp¶Ë¿ÚÓ³Éä×´Ì¬½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UPNP_PORT_STATE
        {
            public uint dwEnabled;//¸Ã¶Ë¿ÚÊÇ·ñ±»Ê¹ÄÜÓ³Éä
            public ushort wInternalPort;//Ó³ÉäÇ°µÄ¶Ë¿Ú
            public ushort wExternalPort;//Ó³ÉäºóµÄ¶Ë¿Ú
            public uint dwStatus;//¶Ë¿ÚÓ³Éä×´Ì¬£º0- Î´ÉúÐ§£»1- Î´ÉúÐ§£ºÓ³ÉäÔ´¶Ë¿ÚÓëÄ¿µÄ¶Ë¿ÚÐèÒ»ÖÂ£»2- Î´ÉúÐ§£ºÓ³Éä¶Ë¿ÚºÅÒÑ±»Ê¹ÓÃ£»3- ÉúÐ§
            public NET_DVR_IPADDR struNatExternalIp;//Ó³ÉäºóµÄÍâ²¿µØÖ·
            public NET_DVR_IPADDR struNatInternalIp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô
        }

        //Upnp¶Ë¿ÚÓ³Éä×´Ì¬½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UPNP_NAT_STATE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_UPNP_PORT_STATE[] strUpnpPort;//¶Ë¿ÚÓ³Éä×´Ì¬:£ºÊý×é0- web server¶Ë¿Ú£¬Êý×é1- ¹ÜÀí¶Ë¿Ú£¬Êý×é2- rtsp¶Ë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAYCOND
        {
            public uint dwChannel;
            public NET_DVR_TIME struStartTime;
            public NET_DVR_TIME struStopTime;
            public byte byDrawFrame;  //0:²»³éÖ¡£¬1£º³éÖ¡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±£Áô
        }

        //Â¼Ïñ»Ø·Å½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VOD_PARA
        {
            public uint dwSize; //½á¹¹Ìå´óÐ¡
            public NET_DVR_STREAM_INFO struIDInfo; //Á÷IDÐÅÏ¢
            public NET_DVR_TIME struBeginTime;//»Ø·Å¿ªÊ¼Ê±¼ä
            public NET_DVR_TIME struEndTime;//»Ø·Å½áÊøÊ±¼ä
            public IntPtr hWnd;//»Ø·Å´°¿Ú
            public byte byDrawFrame;//ÊÇ·ñ³éÖ¡£º0- ²»³éÖ¡£¬1- ³éÖ¡
            public byte byVolumeType;//0-ÆÕÍ¨Â¼Ïñ¾í£¬1-´æµµ¾í£¬ÊÊÓÃÓÚCVRÉè±¸£¬ÆÕÍ¨¾íÓÃÓÚÍ¨µÀÂ¼Ïñ£¬´æµµ¾íÓÃÓÚ±¸·ÝÂ¼Ïñ
            public byte byVolumeNum;//´æµµ¾íºÅ 
            public byte byRes1;//±£Áô
            public uint dwFileIndex;//´æµµ¾íÉÏµÄÂ¼ÏñÎÄ¼þË÷Òý£¬ËÑË÷´æµµ¾íÂ¼ÏñÊ±·µ»ØµÄÖµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATMFINDINFO
        {
            public byte byTransactionType;       //½»Ò×ÀàÐÍ 0-È«²¿£¬1-²éÑ¯£¬ 2-È¡¿î£¬ 3-´æ¿î£¬ 4-ÐÞ¸ÄÃÜÂë£¬5-×ªÕË£¬ 6-ÎÞ¿¨²éÑ¯ 7-ÎÞ¿¨´æ¿î£¬ 8-ÍÌ³® 9-ÍÌ¿¨ 10-×Ô¶¨Òå
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±£Áô
            public uint dwTransationAmount;     //½»Ò×½ð¶î ;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SPECIAL_FINDINFO_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byLenth;
            /* [FieldOffsetAttribute(0)]
             public NET_DVR_ATMFINDINFO struATMFindInfo;	       //ATM²éÑ¯
             * */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILECOND_V40
        {
            public Int32 lChannel;
            public uint dwFileType;
            public uint dwIsLocked;
            public uint dwUseCardNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARDNUM_LEN_OUT, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNumber;
            public NET_DVR_TIME struStartTime;
            public NET_DVR_TIME struStopTime;
            public byte byDrawFrame; //0:²»³éÖ¡£¬1£º³éÖ¡
            public byte byFindType; //0:²éÑ¯ÆÕÍ¨¾í£¬1£º²éÑ¯´æµµ¾í
            public byte byQuickSearch; //0:ÆÕÍ¨²éÑ¯£¬1£º¿ìËÙ£¨ÈÕÀú£©²éÑ¯
            public byte bySpecialFindInfoType;    //×¨ÓÐ²éÑ¯Ìõ¼þÀàÐÍ 0-ÎÞÐ§£¬ 1-´øATM²éÑ¯Ìõ¼þ  
            public uint dwVolumeNum;  //´æµµ¾íºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = GUID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWorkingDeviceGUID;    //¹¤×÷»úGUID£¬Í¨¹ý»ñÈ¡N+1µÃµ½
            public NET_DVR_SPECIAL_FINDINFO_UNION uSpecialFindInfo;   //×¨ÓÐ²éÑ¯Ìõ¼þ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£Áô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AES_KEY_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sAESKey;  /*ÂëÁ÷¼ÓÃÜÃÜÔ¿*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  /*±£Áô×Ö½Ú*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POE_CFG
        {
            public NET_DVR_IPADDR struIP;     //IPµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£Áô
        }

        public const int MAX_PRO_PATH = 256; //×î´óÐ­ÒéÂ·¾¶³¤¶È

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CUSTOM_PROTOCAL
        {
            public uint dwSize;              //½á¹¹Ìå´óÐ¡
            public uint dwEnabled;           //ÊÇ·ñÆôÓÃ¸ÃÐ­Òé0 ²»ÆôÓÃ 1 ÆôÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = DESC_LEN)]
            public string sProtocalName;   //×Ô¶¨ÒåÐ­ÒéÃû³Æ, 16Î»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;          //±£Áô,ÓÃÓÚÐ­ÒéÃû³ÆÀ©Õ¹
            public uint dwEnableSubStream;   //×ÓÂëÁ÷ÊÇ·ñÆôÓÃ0 ²»ÆôÓÃ 1 ÆôÓÃ	
            public byte byMainProType;        //Ö÷ÂëÁ÷Ð­ÒéÀàÐÍ 1 RTSP
            public byte byMainTransType;		//Ö÷ÂëÁ÷´«ÊäÀàÐÍ 0£ºAuto 1£ºudp 2£ºrtp over rtsp
            public ushort wMainPort;           //Ö÷ÂëÁ÷¶Ë¿Ú	
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PRO_PATH)]
            public string sMainPath;  //Ö÷ÂëÁ÷Â·¾¶	
            public byte bySubProType;         //×ÓÂëÁ÷Ð­ÒéÀàÐÍ 1 RTSP
            public byte bySubTransType;		//×ÓÂëÁ÷´«ÊäÀàÐÍ 0£ºAuto 1£ºudp 2£ºrtp over rtsp
            public ushort wSubPort;   //×ÓÂëÁ÷¶Ë¿Ú
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PRO_PATH)]
            public string sSubPath;   //×ÓÂëÁ÷Â·¾¶ 	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;          //±£Áô
        }

        //Ô¤ÀÀV40½Ó¿Ú
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWINFO
        {
            public Int32 lChannel;//Í¨µÀºÅ
            public uint dwStreamType;	// ÂëÁ÷ÀàÐÍ£¬0-Ö÷ÂëÁ÷£¬1-×ÓÂëÁ÷£¬2-ÂëÁ÷3£¬3-ÂëÁ÷4 µÈÒÔ´ËÀàÍÆ
            public uint dwLinkMode;// 0£ºTCP·½Ê½,1£ºUDP·½Ê½,2£º¶à²¥·½Ê½,3 - RTP·½Ê½£¬4-RTP/RTSP,5-RSTP/HTTP 
            public IntPtr hPlayWnd;//²¥·Å´°¿ÚµÄ¾ä±ú,ÎªNULL±íÊ¾²»²¥·ÅÍ¼Ïó
            public bool bBlocked;  //0-·Ç×èÈûÈ¡Á÷, 1-×èÈûÈ¡Á÷, Èç¹û×èÈûSDKÄÚ²¿connectÊ§°Ü½«»áÓÐ5sµÄ³¬Ê±²ÅÄÜ¹»·µ»Ø,²»ÊÊºÏÓÚÂÖÑ¯È¡Á÷²Ù×÷.
            public bool bPassbackRecord; //0-²»ÆôÓÃÂ¼Ïñ»Ø´«,1ÆôÓÃÂ¼Ïñ»Ø´«
            public byte byPreviewMode;//Ô¤ÀÀÄ£Ê½£¬0-Õý³£Ô¤ÀÀ£¬1-ÑÓ³ÙÔ¤ÀÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = STREAM_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byStreamID;//Á÷ID£¬lChannelÎª0xffffffffÊ±ÆôÓÃ´Ë²ÎÊý
            public byte byProtoType; //Ó¦ÓÃ²ãÈ¡Á÷Ð­Òé£¬0-Ë½ÓÐÐ­Òé£¬1-RTSPÐ­Òé
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 222, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        ///×¥ÅÄ»ú
        ///
        public const int MAX_OVERLAP_ITEM_NUM = 50;       //×î´ó×Ö·ûµþ¼ÓÖÖÊý
        public const int NET_ITS_GET_OVERLAP_CFG = 5072;//»ñÈ¡×Ö·ûµþ¼Ó²ÎÊýÅäÖÃ£¨Ïà»ú»òITSÖÕ¶Ë£©
        public const int NET_ITS_SET_OVERLAP_CFG = 5073;//ÉèÖÃ×Ö·ûµþ¼Ó²ÎÊýÅäÖÃ£¨Ïà»ú»òITSÖÕ¶Ë£©

        //×Ö·ûµþ¼ÓÅäÖÃÌõ¼þ²ÎÊý½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAPCFG_COND
        {
            public uint dwSize;
            public uint dwChannel;//Í¨µÀºÅ 
            public uint dwConfigMode;//ÅäÖÃÄ£Ê½£º0- ÖÕ¶Ë£¬1- Ç°¶Ë(Ö±Á¬Ç°¶Ë»òÖÕ¶Ë½ÓÇ°¶Ë)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô
        }

        //µ¥Ìõ×Ö·ûµþ¼ÓÐÅÏ¢½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_SINGLE_ITEM_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£Áô
            public byte byItemType;//ÀàÐÍ
            public byte byChangeLineNum;//µþ¼ÓÏîºóµÄ»»ÐÐÊý£¬È¡Öµ·¶Î§£º[0,10]£¬Ä¬ÈÏ£º0 
            public byte bySpaceNum;//µþ¼ÓÏîºóµÄ¿Õ¸ñÊý£¬È¡Öµ·¶Î§£º[0-255]£¬Ä¬ÈÏ£º0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô
        }

        //×Ö·û´®²ÎÊýÅäÖÃ½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_ITEM_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_OVERLAP_ITEM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_OVERLAP_SINGLE_ITEM_PARAM[] struSingleItem;//×Ö·û´®ÄÚÈÝÐÅÏ¢
            public uint dwLinePercent;
            public uint dwItemsStlye;
            public ushort wStartPosTop;
            public ushort wStartPosLeft;
            public ushort wCharStyle;
            public ushort wCharSize;
            public ushort wCharInterval;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£Áô
            public uint dwForeClorRGB;//Ç°¾°É«µÄRGBÖµ£¬bit0~bit7: B£¬bit8~bit15: G£¬bit16~bit23: R£¬Ä¬ÈÏ£ºx00FFFFFF-°×
            public uint dwBackClorRGB;//±³¾°É«µÄRGBÖµ£¬Ö»¶ÔÍ¼Æ¬Íâµþ¼ÓÓÐÐ§£¬bit0~bit7: B£¬bit8~bit15: G£¬bit16~bit23: R£¬Ä¬ÈÏ£ºx00000000-ºÚ 
            public byte byColorAdapt;//ÑÕÉ«ÊÇ·ñ×ÔÊÊÓ¦£º0-·ñ£¬1-ÊÇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô
        }

        //×Ö·ûµþ¼ÓÄÚÈÝÐÅÏ¢½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_INFO_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] bySite;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRoadNum;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byInstrumentNum;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirection;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirectionDesc;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byLaneDes;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//ÕâÀï±£ÁôÒôÆµµÄÑ¹Ëõ²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSite1;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSite2;//ÕâÀï±£ÁôÒôÆµµÄÑ¹Ëõ²ÎÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//ÕâÀï±£ÁôÒôÆµµÄÑ¹Ëõ²ÎÊý 
        }

        //×Ö·ûµþ¼ÓÅäÖÃÌõ¼þ²ÎÊý½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_CFG
        {
            public uint dwSize;
            public byte byEnable;//ÊÇ·ñÆôÓÃ£º0- ²»ÆôÓÃ£¬1- ÆôÓÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//ÕâÀï±£ÁôÒôÆµµÄÑ¹Ëõ²ÎÊý
            public NET_ITS_OVERLAP_ITEM_PARAM struOverLapItem;//×Ö·û´®²ÎÊý
            public NET_ITS_OVERLAP_INFO_PARAM struOverLapInfo;//×Ö·û´®ÄÚÈÝÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//ÕâÀï±£ÁôÒôÆµµÄÑ¹Ëõ²ÎÊý 
        }

        //±¨¾¯²¼·À²ÎÊý½á¹¹Ìå
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SETUPALARM_PARAM
        {
            public uint dwSize;
            public byte byLevel;//²¼·ÀÓÅÏÈ¼¶£º0- Ò»µÈ¼¶£¨¸ß£©£¬1- ¶þµÈ¼¶£¨ÖÐ£©£¬2- ÈýµÈ¼¶£¨µÍ£¬±£Áô£©
            public byte byAlarmInfoType;//ÉÏ´«±¨¾¯ÐÅÏ¢ÀàÐÍ£¨ÖÇÄÜ½»Í¨ÉãÏñ»úÖ§³Ö£©£º0- ÀÏ±¨¾¯ÐÅÏ¢£¨NET_DVR_PLATE_RESULT£©£¬1- ÐÂ±¨¾¯ÐÅÏ¢(NET_ITS_PLATE_RESULT) 
            public byte byRetAlarmTypeV40;
            public byte byRetDevInfoVersion;
            public byte byRetVQDAlarmType;
            public byte byFaceAlarmDetection;
            public byte bySupport;
            public byte byBrokenNetHttp;
            public ushort wTaskNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//ÕâÀï±£ÁôÒôÆµµÄÑ¹Ëõ²ÎÊý 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_GATE_VEHICLE
        {
            public uint dwSize;
            public uint dwMatchNo;
            public byte byGroupNum;
            public byte byPicNo;
            public byte bySecondCam;

            public byte byRes;
            public ushort wLaneid;
            public byte byCamLaneId;
            public byte byRes1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] byAlarmReason;

            public ushort wBackList;
            public ushort wSpeedLimit;
            public uint dwChanIndex;


            public NET_DVR_PLATE_INFO struPlateInfo;

            public NET_DVR_VEHICLE_INFO struVehicleInfo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] byMonitoringSiteID;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] byDeviceID;


            public byte byDir;
            public byte byDetectType;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] byRes2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] byCardNo;

            public uint dwPicNum;

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_PICTURE_INFO[] struPicInfo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] bySwipeTime;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 224)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_PICTURE_INFO
        {
            public uint dwDataLen;
            public byte byType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byRes1;
            public uint dwRedLightTime;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] byAbsTime;
            public NET_VCA_RECT struPlateRect;
            public NET_VCA_RECT struPlateRecgRect;
            public IntPtr pBuffer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_PLATE_RESULT
        {
            public uint dwSize;        //½á¹¹³¤¶È
            public uint dwMatchNo;        //Æ¥ÅäÐòºÅ,ÓÉ(³µÁ¾ÐòºÅ,Êý¾ÝÀàÐÍ,³µµÀºÅ)×é³ÉÆ¥ÅäÂë
            public byte byGroupNum;    //Í¼Æ¬×éÊýÁ¿£¨Ò»Á¾¹ý³µÏà»ú¶à´Î×¥ÅÄµÄÊýÁ¿£¬´ú±íÒ»×éÍ¼Æ¬µÄ×ÜÊý£¬ÓÃÓÚÑÓÊ±Æ¥ÅäÊý¾Ý£©
            public byte byPicNo;        //Á¬ÅÄµÄÍ¼Æ¬ÐòºÅ£¨½ÓÊÕµ½Í¼Æ¬×éÊýÁ¿ºó£¬±íÊ¾½ÓÊÕÍê³É;½ÓÊÕ³¬Ê±²»×ãÍ¼Æ¬×éÊýÁ¿Ê±£¬¸ù¾ÝÐèÒª±£Áô»òÉ¾³ý£©
            public byte bySecondCam;    //ÊÇ·ñµÚ¶þÏà»ú×¥ÅÄ£¨ÈçÔ¶½ü¾°×¥ÅÄµÄÔ¶¾°Ïà»ú£¬»òÇ°ºó×¥ÅÄµÄºóÏà»ú£¬ÌØÊâÏîÄ¿ÖÐ»áÓÃµ½£©
            public byte byFeaturePicNo; //´³ºìµÆµç¾¯£¬È¡µÚ¼¸ÕÅÍ¼×÷ÎªÌØÐ´Í¼,0xff-±íÊ¾²»È¡
            public byte byDriveChan;        //´¥·¢³µµÀºÅ
            public byte byVehicleType;     //³µÁ¾ÀàÐÍ£¬²Î¿¼VTR_RESULT
            public byte byDetSceneID;//¼ì²â³¡¾°ºÅ[1,4], IPCÄ¬ÈÏÊÇ0
            //³µÁ¾ÊôÐÔ£¬°´Î»±íÊ¾£¬0- ÎÞ¸½¼ÓÊôÐÔ(ÆÕÍ¨³µ)£¬bit1- »Æ±ê³µ(ÀàËÆÄê¼ìµÄ±êÖ¾)£¬bit2- Î£ÏÕÆ·³µÁ¾£¬Öµ£º0- ·ñ£¬1- ÊÇ
            //¸Ã½ÚµãÒÑ²»ÔÙÊ¹ÓÃ,Ê¹ÓÃÏÂÃæµÄbyYellowLabelCarºÍbyDangerousVehiclesÅÐ¶ÏÊÇ·ñ»Æ±ê³µºÍÎ£ÏÕÆ·³µ
            public byte byVehicleAttribute;
            public ushort wIllegalType;       //Î¥ÕÂÀàÐÍ²ÉÓÃ¹ú±ê¶¨Òå
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byIllegalSubType;   //Î¥ÕÂ×ÓÀàÐÍ
            public byte byPostPicNo;    //Î¥ÕÂÊ±È¡µÚ¼¸ÕÅÍ¼Æ¬×÷Îª¿¨¿ÚÍ¼,0xff-±íÊ¾²»È¡
            //Í¨µÀºÅ(ÓÐÐ§£¬±¨¾¯Í¨µÀºÅºÍËùÔÚÉè±¸ÉÏ´«±¨¾¯Í¨µÀºÅÒ»ÖÂ£¬ÔÚºó¶ËºÍËù½ÓÈëµÄ Í¨µÀºÅÒ»ÖÂ)
            public byte byChanIndex;
            public ushort wSpeedLimit;        //ÏÞËÙÉÏÏÞ£¨³¬ËÙÊ±ÓÐÐ§£©
            public byte byChanIndexEx;      //byChanIndexEx*256+byChanIndex±íÊ¾ÕæÊµÍ¨µÀºÅ¡£
            public byte byRes2;
            public NET_DVR_PLATE_INFO struPlateInfo;     //³µÅÆÐÅÏ¢½á¹¹
            public NET_DVR_VEHICLE_INFO struVehicleInfo;    //³µÁ¾ÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSiteID;        //¼à²âµã±àºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byDeviceID;                //Éè±¸±àºÅ
            public byte byDir;            //¼à²â·½Ïò£¬1-ÉÏÐÐ£¨·´Ïò£©£¬2-ÏÂÐÐ(ÕýÏò)£¬3-Ë«Ïò£¬4-ÓÉ¶«ÏòÎ÷£¬5-ÓÉÄÏÏò±±,6-ÓÉÎ÷Ïò¶«£¬7-ÓÉ±±ÏòÄÏ£¬8-ÆäËü
            public byte byDetectType;    //¼ì²â·½Ê½,1-µØ¸Ð´¥·¢£¬2-ÊÓÆµ´¥·¢£¬3-¶àÖ¡Ê¶±ð£¬4-À×´ï´¥·¢
            //¹ØÁª³µµÀ·½ÏòÀàÐÍ£¬²Î¿¼ITC_RELA_LANE_DIRECTION_TYPE
            //¸Ã²ÎÊýÎª³µµÀ·½Ïò²ÎÊý£¬Óë¹ØÁª³µµÀºÅ¶ÔÓ¦£¬È·±£³µµÀÎ¨Ò»ÐÔ¡£
            public byte byRelaLaneDirectionType;
            public byte byCarDirectionType; //³µÁ¾¾ßÌåÐÐÊ»µÄ·½Ïò£¬0±íÊ¾´ÓÉÏÍùÏÂ£¬1±íÊ¾´ÓÏÂÍùÉÏ£¨¸ù¾ÝÊµ¼Ê³µÁ¾µÄÐÐÊ»·½ÏòÀ´µÄÇø·Ö£©
            //µ±wIllegalType²ÎÊýÎª¿ÕÊ±£¬Ê¹ÓÃ¸Ã²ÎÊý¡£ÈôwIllegalType²ÎÊýÎªÓÐÖµÊ±£¬ÒÔwIllegalType²ÎÊýÎª×¼£¬¸Ã²ÎÊýÎÞÐ§¡£
            public uint dwCustomIllegalType; //Î¥ÕÂÀàÐÍ¶¨Òå(ÓÃ»§×Ô¶¨Òå)
            /*Îª0~Êý×Ö¸ñÊ½Ê±£¬ÎªÀÏµÄÎ¥ÕÂÀàÐÍ£¬wIllegalType¡¢dwCustomIllegalType²ÎÊýÉúÐ§£¬¸³Öµ¹ú±êÎ¥·¨´úÂë¡£
             * Îª1~×Ö·û¸ñÊ½Ê±£¬pIllegalInfoBuf²ÎÊýÉúÐ§¡£ÀÏµÄÎ¥ÕÂÀàÐÍ£¬wIllegalType¡¢dwCustomIllegalType²ÎÊýÒÀÈ»¸³Öµ¹ú±êÎ¥·¨´úÂë*/
            public IntPtr pIllegalInfoBuf;    //Î¥·¨´úÂë×Ö·ûÐÅÏ¢½á¹¹ÌåÖ¸Õë£»Ö¸ÏòNET_ITS_ILLEGAL_INFO 
            public byte byIllegalFromatType; //Î¥ÕÂÐÅÏ¢¸ñÊ½ÀàÐÍ£» 0~Êý×Ö¸ñÊ½£¬ 1~×Ö·û¸ñÊ½
            public byte byPendant;// 0-±íÊ¾Î´Öª,1-³µ´°ÓÐÐü¹ÒÎï£¬2-³µ´°ÎÞÐü¹ÒÎï
            public byte byDataAnalysis;            //0-Êý¾ÝÎ´·ÖÎö, 1-Êý¾ÝÒÑ·ÖÎö
            public byte byYellowLabelCar;        //0-±íÊ¾Î´Öª, 1-·Ç»Æ±ê³µ,2-»Æ±ê³µ
            public byte byDangerousVehicles;    //0-±íÊ¾Î´Öª, 1-·ÇÎ£ÏÕÆ·³µ,2-Î£ÏÕÆ·³µ
            //ÒÔÏÂ×Ö¶Î°üº¬Pilot×Ö·û¾ùÎªÖ÷¼ÝÊ»£¬º¬Copilot×Ö·û¾ùÎª¸±¼ÝÊ»
            public byte byPilotSafebelt;//0-±íÊ¾Î´Öª,1-Ïµ°²È«´ø,2-²»Ïµ°²È«´ø
            public byte byCopilotSafebelt;//0-±íÊ¾Î´Öª,1-Ïµ°²È«´ø,2-²»Ïµ°²È«´ø
            public byte byPilotSunVisor;//0-±íÊ¾Î´Öª,1-²»´ò¿ªÕÚÑô°å,2-´ò¿ªÕÚÑô°å
            public byte byCopilotSunVisor;//0-±íÊ¾Î´Öª, 1-²»´ò¿ªÕÚÑô°å,2-´ò¿ªÕÚÑô°å
            public byte byPilotCall;// 0-±íÊ¾Î´Öª, 1-²»´òµç»°,2-´òµç»°
            //0-¿ªÕ¢£¬1-Î´¿ªÕ¢ (×¨ÓÃÓÚÀúÊ·Êý¾ÝÖÐÏà»ú¸ù¾ÝºÚ°×Ãûµ¥Æ¥Åäºó£¬ÊÇ·ñ¿ªÕ¢³É¹¦µÄ±êÖ¾)
            public byte byBarrierGateCtrlType;
            public byte byAlarmDataType;//0-ÊµÊ±Êý¾Ý£¬1-ÀúÊ·Êý¾Ý
            public NET_DVR_TIME_V30 struSnapFirstPicTime;//¶ËµãÊ±¼ä(ms)£¨×¥ÅÄµÚÒ»ÕÅÍ¼Æ¬µÄÊ±¼ä£©
            public uint dwIllegalTime;//Î¥·¨³ÖÐøÊ±¼ä£¨ms£© = ×¥ÅÄ×îºóÒ»ÕÅÍ¼Æ¬µÄÊ±¼ä - ×¥ÅÄµÚÒ»ÕÅÍ¼Æ¬µÄÊ±¼ä
            public uint dwPicNum;        //Í¼Æ¬ÊýÁ¿£¨ÓëpicGroupNum²»Í¬£¬´ú±í±¾ÌõÐÅÏ¢¸½´øµÄÍ¼Æ¬ÊýÁ¿£¬Í¼Æ¬ÐÅÏ¢ÓÉstruVehicleInfoEx¶¨Òå    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_PICTURE_INFO[] struPicInfo;         //Í¼Æ¬ÐÅÏ¢,µ¥ÕÅ»Øµ÷£¬×î¶à6ÕÅÍ¼£¬ÓÉÐòºÅÇø·Ö
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_PARK_VEHICLE
        {
            public uint dwSize;
            public byte byGroupNum;
            public byte byPicNo;
            public byte byLocationNum;
            public byte byParkError;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PARKNO_LEN)]
            public string byParkingNo;
            public byte byLocationStatus;
            public byte bylogicalLaneNum;
            public ushort wUpLoadType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwChanIndex;
            public NET_DVR_PLATE_INFO struPlateInfo;
            public NET_DVR_VEHICLE_INFO struVehicleInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSiteID;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDeviceID;
            public uint dwPicNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_PICTURE_INFO[] struPicInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIAGNOSIS_UPLOAD
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = STREAM_ID_LEN)]
            public string sStreamID;	///< Á÷ID£¬³¤¶ÈÐ¡ÓÚ32¸ö×Ö½Ú
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string sMonitorIP;  ///< ¼à¿Øµãip
            public uint dwChanIndex;  ///< ¼à¿ØµãÍ¨µÀºÅ  
            public uint dwWidth;  ///< Í¼Ïñ¿í¶È
            public uint dwHeight;  ///< Í¼Ïñ¸ß¶È
            public NET_DVR_TIME struCheckTime;  ///< ¼ì²âÊ±¼ä(ºÏ²¢ÈÕÆÚºÍÊ±¼ä×Ö¶Î)£¬¸ñÊ½£º2012-08-06 13:00:00
            public byte byResult;  ///0-Î´¼ì²â 1-Õý³£ 2-Òì³£ 3-µÇÂ¼Ê§°Ü 4-È¡Á÷Òì³£
            public byte bySignalResult; ///< ÊÓÆµ¶ªÊ§¼ì²â½á¹û 0-Î´¼ì²â 1-Õý³£ 2-Òì³£
            public byte byBlurResult;  ///< Í¼ÏñÄ£ºý¼ì²â½á¹û£¬0-Î´¼ì²â 1-Õý³£ 2-Òì³£
            public byte byLumaResult;  ///< Í¼Ïñ¹ýÁÁ¼ì²â½á¹û£¬0-Î´¼ì²â 1-Õý³£ 2-Òì³£
            public byte byChromaResult;  ///< Æ«É«¼ì²â½á¹û£¬0-Î´¼ì²â 1-Õý³£ 2-Òì³£
            public byte bySnowResult;  ///< ÔëÉù¸ÉÈÅ¼ì²â½á¹û£¬0-Î´¼ì²â 1-Õý³£ 2-Òì³£
            public byte byStreakResult;  ///< ÌõÎÆ¸ÉÈÅ¼ì²â½á¹û£¬0-Î´¼ì²â 1-Õý³£ 2-Òì³£
            public byte byFreezeResult;  ///< »­Ãæ¶³½á¼ì²â½á¹û£¬0-Î´¼ì²â 1-Õý³£ 2-Òì³£
            public byte byPTZResult;  ///< ÔÆÌ¨¼ì²â½á¹û£¬0-Î´¼ì²â 1-Õý³£ 2-Òì³£
            public byte byContrastResult;     //¶Ô±È¶ÈÒì³£¼ì²â½á¹û£¬0-Î´¼ì²â£¬1-Õý³££¬2-Òì³£
            public byte byMonoResult;         //ºÚ°×Í¼Ïñ¼ì²â½á¹û£¬0-Î´¼ì²â£¬1-Õý³££¬2-Òì³£
            public byte byShakeResult;        //ÊÓÆµ¶¶¶¯¼ì²â½á¹û£¬0-Î´¼ì²â£¬1-Õý³££¬2-Òì³£
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string sSNapShotURL;	///<Í¼Æ¬URLµØÖ·
            public byte byFlashResult;        //ÊÓÆµ¾ç±ä¼ì²â½á¹û£¬0-Î´¼ì²â£¬1-Õý³££¬2-Òì³£
            public byte byCoverResult;        //ÊÓÆµÕÚµ²¼ì²â½á¹û£¬0-Î´¼ì²â£¬1-Õý³££¬2-Òì³£
            public byte bySceneResult;        //³¡¾°±ä¸ü¼ì²â½á¹û£¬0-Î´¼ì²â£¬1-Õý³££¬2-Òì³£
            public byte byDarkResult;         //Í¼Ïñ¹ý°µ¼ì²â½á¹û£¬0-Î´¼ì²â£¬1-Õý³££¬2-Òì³£
            public byte byStreamType;		//ÂëÁ÷ÀàÐÍ£¬0-ÎÞÐ§£¬1-Î´Öª£¬2-¹ú±êÀàÐÍ£¬3-·Ç¹ú±êÀàÐÍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int CID_CODE_LEN = 4;
        public const int ACCOUNTNUM_LEN = 6;
        public const int ACCOUNTNUM_LEN_32 = 32;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CID_ALARM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CID_CODE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCIDCode;    //CIDÊÂ¼þºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCIDDescribe;    //CIDÊÂ¼þÃû
            public NET_DVR_TIME_EX struTriggerTime;            //´¥·¢±¨¾¯µÄÊ±¼äµã
            public NET_DVR_TIME_EX struUploadTime;                //ÉÏ´«±¨¾¯µÄÊ±¼äµã
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACCOUNTNUM_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCenterAccount;    //ÖÐÐÄÕÊºÅ
            public byte byReportType;                    //¼û¶¨ÒåNET_DVR_ALARMHOST_REPORT_TYPE
            public byte byUserType;                        //ÓÃ»§ÀàÐÍ£¬0-ÍøÂçÓÃ»§ 1-¼üÅÌÓÃ»§,2-ÊÖ»úÓÃ»§,3-ÏµÍ³ÓÃ»§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;        //ÍøÂçÓÃ»§ÓÃ»§Ãû
            public ushort wKeyUserNo;                        //¼üÅÌÓÃ»§ºÅ    0xFFFF±íÊ¾ÎÞÐ§
            public byte byKeypadNo;                        //¼üÅÌºÅ        0xFF±íÊ¾ÎÞÐ§
            public byte bySubSysNo;                        //×ÓÏµÍ³ºÅ        0xFF±íÊ¾ÎÞÐ§
            public ushort wDefenceNo;                        //·ÀÇøºÅ        0xFFFF±íÊ¾ÎÞÐ§
            public byte byVideoChanNo;                    //ÊÓÆµÍ¨µÀºÅ    0xFF±íÊ¾ÎÞÐ§
            public byte byDiskNo;                        //Ó²ÅÌºÅ        0xFF±íÊ¾ÎÞÐ§
            public ushort wModuleAddr;                    //Ä£¿éµØÖ·        0xFFFF±íÊ¾ÎÞÐ§
            public byte byCenterType;                    //0-ÎÞÐ§, 1-ÖÐÐÄÕËºÅ(³¤¶È6),2-À©Õ¹µÄÖÐÐÄÕËºÅ(³¤¶È9)
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACCOUNTNUM_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] sCenterAccountV40;    //ÖÐÐÄÕËºÅV40,Ê¹ÓÃ´Ë×Ö¶ÎÊ±sCenterAccountÎÞÐ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_PTZ_INFO
        {
            public float fPan;
            public float fTilt;
            public float fZoom;
            public uint dwFocus;// ¾Û½¹²ÎÊý£¬¾Û½¹·¶Î§£º¹éÒ»»¯0-100000
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //»ðµã¼ì²â±¨¾¯
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIREDETECTION_ALARM
        {
            public uint dwSize; //½á¹¹´óÐ¡
            public uint dwRelativeTime; //Ïà¶ÔÊ±±ê
            public uint dwAbsTime; //¾ø¶ÔÊ±±ê
            public NET_VCA_DEV_INFO struDevInfo;   //Ç°¶ËÉè±¸ÐÅÏ¢
            public ushort wPanPos;
            public ushort wTiltPos;
            public ushort wZoomPos;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPicDataLen;//±¨¾¯×¥ÅÄÍ¼Æ¬³¤¶È
            public IntPtr pBuffer;    //Êý¾ÝÖ¸Õë
            public NET_VCA_RECT struRect;//»ðµã¿ò 
            public NET_VCA_POINT struPoint;//»ðµã¿òÄÚ×î¸ßÎÂ¶Èµã×ø±ê
            public ushort wFireMaxTemperature;//»ðµã×î¸ßÎÂ¶È[300¡æ~4000¡æ]
            public ushort wTargetDistance;//Ä¿±ê¾àÀë[100m ~ 10000m]
            public byte byStrategyType;//²ßÂÔÀàÐÍ£»0~ÈÎÒâ±¨¾¯£¬1~Ð­Í¬±¨¾¯£¬2~¶àÏµÍ³±¨¾¯£¬3~Ö¸¶¨»ðµã±¨¾¯£¬4~Ö¸¶¨ÑÌÎí±¨¾¯
            public byte byAlarmSubType;//±¨¾¯×ÓÀàÐÍ¡£0~»ðµã¼ì²â±¨¾¯£¬1~ÑÌÎí¼ì²â±¨¾¯£¬2~ÑÌ»ð±¨¾¯
            /*ÊÇ·ñÆôÓÃPTZ×ø±êÀ©Õ¹£¬
            0~²»ÆôÓÃ£¬PTZ×ø±êÖµÒÔwPanPos¡¢wTiltPos¡¢wZoomPosÎª×¼¡£
            1~ÆôÓÃ£¬PTZ×ø±êÖµÒÔstruPtzPosExÎª×¼¡£µ«ÊÇÐÂÀÏPTZ¶¼Ðè·µ»Ø¡£struPtzPosExµÄÖµÐè×ª»¯ÎªwPanPos¡¢wTiltPos¡¢wZoomPosÖµ¡£
            */
            public byte byPTZPosExEnable;
            public byte byRes2;
            public NET_PTZ_INFO struPtzPosEx;// ptz×ø±êÀ©Õ¹(Ö§³Ö¸ß¾«¶ÈPTZÖµ£¬¾«È·µ½Ð¡ÊýµãºóÈýÎ»)
            public uint dwVisiblePicLen;//¿É¼û¹âÍ¼Æ¬³¤¶È
            public IntPtr pVisiblePicBuf;    //¿É¼û¹âÍ¼Æ¬Êý¾ÝÖ¸Õë
            // pSmokeBuf²ÎÊýµ±byAlarmSubType±¨¾¯×ÓÀàÐÍÎª1£¨ÑÌÎí¼ì²â±¨¾¯£©¡¢2£¨ÑÌ»ð±¨¾¯£©Ê±ÉúÐ§¡£
            public IntPtr pSmokeBuf;    //ÑÌÎí¼ì²â±¨¾¯Êý¾ÝÖ¸Õë£¬Ö¸ÏòÒ»¸öNET_DVR_SMOKEDETECTION_ALARM½á¹¹Ìå
            public ushort wDevInfoIvmsChannelEx;     //ÓëNET_VCA_DEV_INFOÀïµÄbyIvmsChannelº¬ÒåÏàÍ¬£¬ÄÜ±íÊ¾¸ü´óµÄÖµ¡£ÀÏ¿Í»§¶ËÓÃbyIvmsChannelÄÜ¼ÌÐø¼æÈÝ£¬µ«ÊÇ×î´óµ½255¡£ÐÂ¿Í»§¶Ë°æ±¾ÇëÊ¹ÓÃwDevInfoIvmsChannelEx¡£
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 58, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int ACS_CARD_NO_LEN = 32; //ÃÅ½û¿¨ºÅ³¤¶È    
        public const int MAX_ID_NUM_LEN = 32;  //×î´óÉí·ÝÖ¤ºÅ³¤¶È
        public const int MAX_ID_NAME_LEN = 128;   //×î´óÐÕÃû³¤¶È
        public const int MAX_ID_ADDR_LEN = 280;   //×î´ó×¡Ö·³¤¶È
        public const int MAX_ID_ISSUING_AUTHORITY_LEN = 128; //×î´óÇ©·¢»ú¹Ø³¤¶È

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACS_EVENT_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = ACS_CARD_NO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCardNo; //¿¨ºÅ£¬Îª0ÎÞÐ§
            public byte byCardType; //¿¨ÀàÐÍ£¬1-ÆÕÍ¨¿¨£¬2-²Ð¼²ÈË¿¨£¬3-ºÚÃûµ¥¿¨£¬4-Ñ²¸ü¿¨£¬5-Ð²ÆÈ¿¨£¬6-³¬¼¶¿¨£¬7-À´±ö¿¨£¬Îª0ÎÞÐ§
            public byte byWhiteListNo; //°×Ãûµ¥µ¥ºÅ,1-8£¬Îª0ÎÞÐ§
            public byte byReportChannel; //±¨¸æÉÏ´«Í¨µÀ£¬1-²¼·ÀÉÏ´«£¬2-ÖÐÐÄ×é1ÉÏ´«£¬3-ÖÐÐÄ×é2ÉÏ´«£¬Îª0ÎÞÐ§
            public byte byCardReaderKind; //¶Á¿¨Æ÷ÊôÓÚÄÄÒ»Àà£¬0-ÎÞÐ§£¬1-IC¶Á¿¨Æ÷£¬2-Éí·ÝÖ¤¶Á¿¨Æ÷£¬3-¶þÎ¬Âë¶Á¿¨Æ÷,4-Ö¸ÎÆÍ·
            public uint dwCardReaderNo; //¶Á¿¨Æ÷±àºÅ£¬Îª0ÎÞÐ§
            public uint dwDoorNo; //ÃÅ±àºÅ(Â¥²ã±àºÅ)£¬Îª0ÎÞÐ§
            public uint dwVerifyNo; //¶àÖØ¿¨ÈÏÖ¤ÐòºÅ£¬Îª0ÎÞÐ§
            public uint dwAlarmInNo;  //±¨¾¯ÊäÈëºÅ£¬Îª0ÎÞÐ§
            public uint dwAlarmOutNo; //±¨¾¯Êä³öºÅ£¬Îª0ÎÞÐ§
            public uint dwCaseSensorNo; //ÊÂ¼þ´¥·¢Æ÷±àºÅ
            public uint dwRs485No;    //RS485Í¨µÀºÅ£¬Îª0ÎÞÐ§
            public uint dwMultiCardGroupNo; //Èº×é±àºÅ
            public ushort wAccessChannel;    //ÈËÔ±Í¨µÀºÅ
            public byte byDeviceNo;    //Éè±¸±àºÅ£¬Îª0ÎÞÐ§
            public byte byDistractControlNo;//·Ö¿ØÆ÷±àºÅ£¬Îª0ÎÞÐ§
            public uint dwEmployeeNo; //¹¤ºÅ£¬Îª0ÎÞÐ§
            public ushort wLocalControllerID; //¾ÍµØ¿ØÖÆÆ÷±àºÅ£¬0-ÃÅ½ûÖ÷»ú£¬1-64´ú±í¾ÍµØ¿ØÖÆÆ÷
            public byte byInternetAccess; //Íø¿ÚID£º£¨1-ÉÏÐÐÍø¿Ú1,2-ÉÏÐÐÍø¿Ú2,3-ÏÂÐÐÍø¿Ú1£©
            public byte byType;     //·ÀÇøÀàÐÍ£¬0:¼´Ê±·ÀÇø,1-24Ð¡Ê±·ÀÇø,2-ÑÓÊ±·ÀÇø ,3-ÄÚ²¿·ÀÇø£¬4-Ô¿³×·ÀÇø 5-»ð¾¯·ÀÇø 6-ÖÜ½ç·ÀÇø 7-24Ð¡Ê±ÎÞÉù·ÀÇø  8-24Ð¡Ê±¸¨Öú·ÀÇø£¬9-24Ð¡Ê±Õð¶¯·ÀÇø,10-ÃÅ½û½ô¼±¿ªÃÅ·ÀÇø£¬11-ÃÅ½û½ô¼±¹ØÃÅ·ÀÇø 0xff-ÎÞ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr; //ÎïÀíµØÖ·£¬Îª0ÎÞÐ§
            public byte bySwipeCardType;//Ë¢¿¨ÀàÐÍ£¬0-ÎÞÐ§£¬1-¶þÎ¬Âë
            public byte byRes2;
            public uint dwSerialNo; //ÊÂ¼þÁ÷Ë®ºÅ£¬Îª0ÎÞÐ§
            public byte byChannelControllerID; //Í¨µÀ¿ØÖÆÆ÷ID£¬Îª0ÎÞÐ§£¬1-Ö÷Í¨µÀ¿ØÖÆÆ÷£¬2-´ÓÍ¨µÀ¿ØÖÆÆ÷
            public byte byChannelControllerLampID; //Í¨µÀ¿ØÖÆÆ÷µÆ°åID£¬Îª0ÎÞÐ§£¨ÓÐÐ§·¶Î§1-255£©
            public byte byChannelControllerIRAdaptorID; //Í¨µÀ¿ØÖÆÆ÷ºìÍâ×ª½Ó°åID£¬Îª0ÎÞÐ§£¨ÓÐÐ§·¶Î§1-255£©
            public byte byChannelControllerIREmitterID; //Í¨µÀ¿ØÖÆÆ÷ºìÍâ¶ÔÉäID£¬Îª0ÎÞÐ§£¨ÓÐÐ§·¶Î§1-255£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACS_ALARM_INFO
        {
            public uint dwSize;
            public uint dwMajor; //±¨¾¯Ö÷ÀàÐÍ£¬²Î¿¼ºê¶¨Òå
            public uint dwMinor; //±¨¾¯´ÎÀàÐÍ£¬²Î¿¼ºê¶¨Òå
            public NET_DVR_TIME struTime; //Ê±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//ÍøÂç²Ù×÷µÄÓÃ»§Ãû
            public NET_DVR_IPADDR struRemoteHostAddr;//Ô¶³ÌÖ÷»úµØÖ·
            public NET_DVR_ACS_EVENT_INFO struAcsEventInfo; //ÏêÏ¸²ÎÊý
            public uint dwPicDataLen;   //Í¼Æ¬Êý¾Ý´óÐ¡£¬²»Îª0ÊÇ±íÊ¾ºóÃæ´øÊý¾Ý
            public IntPtr pPicData;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DATE
        {
            public ushort wYear;        //Äê
            public byte byMonth;        //ÔÂ    
            public byte byDay;        //ÈÕ                        
        }

        //Éí·ÝÖ¤ÐÅÏ¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ID_CARD_INFO
        {
            public uint dwSize;        //½á¹¹³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName;   //ÐÕÃû
            public NET_DVR_DATE struBirth; //³öÉúÈÕÆÚ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAddr;  //×¡Ö·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_NUM_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byIDNum;   //Éí·ÝÖ¤ºÅÂë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ID_ISSUING_AUTHORITY_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byIssuingAuthority;  //Ç©·¢»ú¹Ø
            public NET_DVR_DATE struStartDate;  //ÓÐÐ§¿ªÊ¼ÈÕÆÚ
            public NET_DVR_DATE struEndDate;  //ÓÐÐ§½ØÖ¹ÈÕÆÚ
            public byte byTermOfValidity;  //ÊÇ·ñ³¤ÆÚÓÐÐ§£¬ 0-·ñ£¬1-ÊÇ£¨ÓÐÐ§½ØÖ¹ÈÕÆÚÎÞÐ§£©
            public byte bySex;  //ÐÔ±ð£¬1-ÄÐ£¬2-Å®
            public byte byNation;    //Ãñ×å£¬1-"ºº"£¬2-"ÃÉ¹Å"£¬3-"»Ø",4-"²Ø",5-"Î¬Îá¶û",6-"Ãç",7-"ÒÍ",8-"×³",9-"²¼ÒÀ",10-"³¯ÏÊ",
                                     //11-"Âú",12-"¶±",13-"Ñþ",14-"°×",15-"ÍÁ¼Ò",16-"¹þÄá",17-"¹þÈø¿Ë",18-"´ö",19-"Àè",20-"ÀüËÛ",
                                     //21-"Øô",22-"î´",23-"¸ßÉ½",24-"À­ìï",25-"Ë®",26-"¶«Ïç",27-"ÄÉÎ÷",28-"¾°ÆÄ",29-"¿Â¶û¿Ë×Î",30-"ÍÁ",
                                     //31-"´ïÎÓ¶û",32-"ØïÀÐ",33-"Ç¼",34-"²¼ÀÊ",35-"ÈöÀ­",36-"Ã«ÄÏ",37-"ØîÀÐ",38-"Îý²®",39-"°¢²ý",40-"ÆÕÃ×",
                                     //41-"Ëþ¼ª¿Ë",42-"Å­",43-"ÎÚ×Î±ð¿Ë",44-"¶íÂÞË¹",45-"¶õÎÂ¿Ë",46-"µÂ°º",47-"±£°²",48-"Ô£¹Ì",49-"¾©",50-"ËþËþ¶û",
                                     //51-"¶ÀÁú",52-"¶õÂ×´º",53-"ºÕÕÜ",54-"ÃÅ°Í",55-"çó°Í",56-"»ùÅµ"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 101, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Éí·ÝÖ¤ÐÅÏ¢±¨¾¯
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ID_CARD_INFO_ALARM
        {
            public uint dwSize;        //½á¹¹³¤¶È
            public NET_DVR_ID_CARD_INFO struIDCardCfg;//Éí·ÝÖ¤ÐÅÏ¢
            public uint dwMajor; //±¨¾¯Ö÷ÀàÐÍ£¬²Î¿¼ºê¶¨Òå
            public uint dwMinor; //±¨¾¯´ÎÀàÐÍ£¬²Î¿¼ºê¶¨Òå
            public NET_DVR_TIME_V30 struSwipeTime; //Ê±¼ä
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetUser;//ÍøÂç²Ù×÷µÄÓÃ»§Ãû
            public NET_DVR_IPADDR struRemoteHostAddr;//Ô¶³ÌÖ÷»úµØÖ·
            public uint dwCardReaderNo; //¶Á¿¨Æ÷±àºÅ£¬Îª0ÎÞÐ§
            public uint dwDoorNo; //ÃÅ±àºÅ£¬Îª0ÎÞÐ§
            public uint dwPicDataLen;   //Í¼Æ¬Êý¾Ý´óÐ¡£¬²»Îª0ÊÇ±íÊ¾ºóÃæ´øÊý¾Ý
            public IntPtr pPicData;
            public byte byCardType; //¿¨ÀàÐÍ£¬1-ÆÕÍ¨¿¨£¬2-²Ð¼²ÈË¿¨£¬3-ºÚÃûµ¥¿¨£¬4-Ñ²¸ü¿¨£¬5-Ð²ÆÈ¿¨£¬6-³¬¼¶¿¨£¬7-À´±ö¿¨£¬8-½â³ý¿¨£¬Îª0ÎÞÐ§
            public byte byDeviceNo;                             // Éè±¸±àºÅ£¬Îª0Ê±ÎÞÐ§£¨ÓÐÐ§·¶Î§1-255£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwFingerPrintDataLen;                  // Ö¸ÎÆÊý¾Ý´óÐ¡£¬²»Îª0ÊÇ±íÊ¾ºóÃæ´øÊý¾Ý
            public IntPtr pFingerPrintData;
            public uint dwCapturePicDataLen;                   // ×¥ÅÄÍ¼Æ¬Êý¾Ý´óÐ¡£¬²»Îª0ÊÇ±íÊ¾ºóÃæ´øÊý¾Ý
            public IntPtr pCapturePicData;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 188, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /********************************½Ó¿Ú²ÎÊý½á¹¹(end)*********************************/


        /********************************SDK½Ó¿Úº¯ÊýÉùÃ÷*********************************/

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetDllDirectory(string lpPathName);

        /*********************************************************
        Function:	NET_DVR_Init
        Desc:		³õÊ¼»¯SDK£¬µ÷ÓÃÆäËûSDKº¯ÊýµÄÇ°Ìá¡£
        Input:	
        Output:	
        Return:	TRUE±íÊ¾³É¹¦£¬FALSE±íÊ¾Ê§°Ü¡£
        **********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_Init();

        /*********************************************************
        Function:	NET_DVR_Cleanup
        Desc:		ÊÍ·ÅSDK×ÊÔ´£¬ÔÚ½áÊøÖ®Ç°×îºóµ÷ÓÃ
        Input:	
        Output:	
        Return:	TRUE±íÊ¾³É¹¦£¬FALSE±íÊ¾Ê§°Ü
        **********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_Cleanup();



        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessage(uint nMessage, IntPtr hWnd);

        /*********************************************************
        Function:	EXCEPYIONCALLBACK
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void EXCEPYIONCALLBACK(uint dwType, int lUserID, int lHandle, IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetExceptionCallBack_V30(uint nMessage, IntPtr hWnd, EXCEPYIONCALLBACK fExceptionCallBack, IntPtr pUser);


        /*********************************************************
        Function:	MESSCALLBACK
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACK(int lCommand, string sDVRIP, string pBuf, uint dwBufLen);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack(MESSCALLBACK fMessCallBack);

        /*********************************************************
        Function:	MESSCALLBACKEX
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACKEX(int iCommand, int iUserID, string pBuf, uint dwBufLen);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack_EX(MESSCALLBACKEX fMessCallBack_EX);

        /*********************************************************
        Function:	MESSCALLBACKNEW
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACKNEW(int lCommand, string sDVRIP, string pBuf, uint dwBufLen, ushort dwLinkDVRPort);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack_NEW(MESSCALLBACKNEW fMessCallBack_NEW);

        /*********************************************************
        Function:	MESSAGECALLBACK
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSAGECALLBACK(int lCommand, System.IntPtr sDVRIP, System.IntPtr pBuf, uint dwBufLen, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessageCallBack(MESSAGECALLBACK fMessageCallBack, uint dwUser);


        /*********************************************************
        Function:	MSGCallBack
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void MSGCallBack(int lCommand, ref NET_DVR_ALARMER pAlarmer, IntPtr pAlarmInfo, uint dwBufLen, IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessageCallBack_V30(MSGCallBack fMessageCallBack, IntPtr pUser);

        public delegate bool MSGCallBack_V31(int lCommand, ref NET_DVR_ALARMER pAlarmer, IntPtr pAlarmInfo, uint dwBufLen, IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessageCallBack_V31(MSGCallBack_V31 fMessageCallBack, IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConnectTime(uint dwWaitTime, uint dwTryTimes);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetReconnect(uint dwInterval, int bEnableRecon);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetLocalIP(byte[] strIP, ref uint pValidNum, ref Boolean pEnableBind);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetValidIP(uint dwIPIndex, Boolean bEnableBind);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern uint NET_DVR_GetSDKVersion();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern uint NET_DVR_GetSDKBuildVersion();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern Int32 NET_DVR_IsSupport();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartListen(string sLocalIP, ushort wLocalPort);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopListen();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_StartListen_V30(String sLocalIP, ushort wLocalPort, MSGCallBack DataCallback, IntPtr pUserData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopListen_V30(Int32 lListenHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern Int32 NET_DVR_Login(string sDVRIP, ushort wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO lpDeviceInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout(int iUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern uint NET_DVR_GetLastError();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern string NET_DVR_GetErrorMsg(ref int pErrorNo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetShowMode(uint dwShowType, uint colorKey);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr(string sServerIP, ushort wServerPort, string sDVRName, ushort wDVRNameLen, string sDVRSerialNumber, ushort wDVRSerialLen, IntPtr pGetIP);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr_EX(string sServerIP, ushort wServerPort, byte[] sDVRName, ushort wDVRNameLen, byte[] sDVRSerialNumber, ushort wDVRSerialLen, byte[] sGetIP, ref uint dwPort);
        //Ô¤ÀÀÏà¹Ø½Ó¿Ú
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern Int32 NET_DVR_RealPlay(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern Int32 NET_SDK_RealPlay(int iUserLogID, ref NET_DVR_CLIENTINFO lpDVRClientInfo);
        /*********************************************************
		Function:	REALDATACALLBACK
		Desc:		Ô¤ÀÀ»Øµ÷
		Input:	lRealHandle µ±Ç°µÄÔ¤ÀÀ¾ä±ú 
				dwDataType Êý¾ÝÀàÐÍ
				pBuffer ´æ·ÅÊý¾ÝµÄ»º³åÇøÖ¸Õë 
				dwBufSize »º³åÇø´óÐ¡ 
				pUser ÓÃ»§Êý¾Ý 
		Output:	
		Return:	void
		**********************************************************/
        public delegate void REALDATACALLBACK(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser);
        [DllImport(@"..\bin\HCNetSDK.dll")]

        /*********************************************************
        Function:	NET_DVR_RealPlay_V30
        Desc:		ÊµÊ±Ô¤ÀÀ¡£
        Input:	lUserID [in] NET_DVR_Login()»òNET_DVR_Login_V30()µÄ·µ»ØÖµ 
                lpClientInfo [in] Ô¤ÀÀ²ÎÊý 
                cbRealDataCallBack [in] ÂëÁ÷Êý¾Ý»Øµ÷º¯Êý 
                pUser [in] ÓÃ»§Êý¾Ý 
                bBlocked [in] ÇëÇóÂëÁ÷¹ý³ÌÊÇ·ñ×èÈû£º0£­·ñ£»1£­ÊÇ 
        Output:	
        Return:	1±íÊ¾Ê§°Ü£¬ÆäËûÖµ×÷ÎªNET_DVR_StopRealPlayµÈº¯ÊýµÄ¾ä±ú²ÎÊý
        **********************************************************/
        public static extern int NET_DVR_RealPlay_V30(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser, UInt32 bBlocked);

        /*********************************************************
        Function:	NET_DVR_RealPlay_V40
        Desc:		ÊµÊ±Ô¤ÀÀÀ©Õ¹½Ó¿Ú¡£
        Input:	lUserID [in] NET_DVR_Login()»òNET_DVR_Login_V30()µÄ·µ»ØÖµ 
                lpPreviewInfo [in] Ô¤ÀÀ²ÎÊý 
                fRealDataCallBack_V30 [in] ÂëÁ÷Êý¾Ý»Øµ÷º¯Êý 
                pUser [in] ÓÃ»§Êý¾Ý 
        Output:	
        Return:	1±íÊ¾Ê§°Ü£¬ÆäËûÖµ×÷ÎªNET_DVR_StopRealPlayµÈº¯ÊýµÄ¾ä±ú²ÎÊý
        **********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay_V40(int iUserID, ref NET_DVR_PREVIEWINFO lpPreviewInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser);

        // [DllImport(@"..\bin\HCNetSDK.dll")]
        // public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);
        /*********************************************************
		Function:	NET_DVR_StopRealPlay
		Desc:		Í£Ö¹Ô¤ÀÀ¡£
		Input:	lRealHandle [in] Ô¤ÀÀ¾ä±ú£¬NET_DVR_RealPlay»òÕßNET_DVR_RealPlay_V30µÄ·µ»ØÖµ 
		Output:	
		Return:	
		**********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopRealPlay(int iRealHandle);

        /*********************************************************
        Function:	DRAWFUN
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void DRAWFUN(int lRealHandle, IntPtr hDc, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RigisterDrawFun(int lRealHandle, DRAWFUN fDrawFun, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayerBufNumber(Int32 lRealHandle, uint dwBufNum);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ThrowBFrame(Int32 lRealHandle, uint dwNum);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAudioMode(uint dwMode);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSound(Int32 lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSound();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSoundShare(Int32 lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSoundShare(Int32 lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_Volume(Int32 lRealHandle, ushort wVolume);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveRealData(Int32 lRealHandle, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopSaveRealData(Int32 lRealHandle);

        /*********************************************************
        Function:	REALDATACALLBACK
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void SETREALDATACALLBACK(int lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetRealDataCallBack(int lRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint dwUser);

        /*********************************************************
        Function:	STDDATACALLBACK
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void STDDATACALLBACK(int lRealHandle, uint dwDataType, ref byte pBuffer, uint dwBufSize, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetStandardDataCallBack(int lRealHandle, STDDATACALLBACK fStdDataCallBack, uint dwUser);


        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CapturePicture(Int32 lRealHandle, string sPicFileName);

        //¶¯Ì¬Éú³ÉIÖ¡
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MakeKeyFrame(Int32 lUserID, Int32 lChannel);//Ö÷ÂëÁ÷

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MakeKeyFrameSub(Int32 lUserID, Int32 lChannel);//×ÓÂëÁ÷

        //ÔÆÌ¨¿ØÖÆÏà¹Ø½Ó¿Ú
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCtrl(Int32 lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCtrl_Other(Int32 lUserID, int lChannel);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl(Int32 lRealHandle, uint dwPTZCommand, uint dwStop);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_Other(Int32 lUserID, Int32 lChannel, uint dwPTZCommand, uint dwStop);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ(Int32 lRealHandle, string pPTZCodeBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_Other(int lUserID, int lChannel, string pPTZCodeBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_Other(int lUserID, int lChannel, uint dwPTZPresetCmd, uint dwPresetIndex);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_EX(int lRealHandle, string pPTZCodeBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_EX(int lRealHandle, uint dwPTZCommand, uint dwStop);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_EX(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_Other(int lUserID, int lChannel, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_EX(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack(int lRealHandle, uint dwPTZTrackCmd);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_EX(int lRealHandle, uint dwPTZTrackCmd);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed_Other(int lUserID, int lChannel, int dwPTZCommand, int dwStop, int dwSpeed);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed_EX(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCruise(int lUserID, int lChannel, int lCruiseRoute, ref NET_DVR_CRUISE_RET lpCruiseRet);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd, uint dwTrackIndex);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack_EX(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);

        //ÎÄ¼þ²éÕÒÓë»Ø·Å
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile(int lFindHandle, ref NET_DVR_FIND_DATA lpFindData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose(int lFindHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_V30(int lFindHandle, ref NET_DVR_FINDDATA_V30 lpFindData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_V40(int lFindHandle, ref NET_DVR_FINDDATA_V40 lpFindData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_V30(int lUserID, ref NET_DVR_FILECOND pFindCond);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_V40(int lUserID, ref NET_DVR_FILECOND_V40 pFindCond);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose_V30(int lFindHandle);

        //2007-04-16Ôö¼Ó²éÑ¯½á¹û´ø¿¨ºÅµÄÎÄ¼þ²éÕÒ
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_Card(int lFindHandle, ref NET_DVR_FINDDATA_CARD lpFindData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_Card(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_LockFileByName(int lUserID, string sLockFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_UnlockFileByName(int lUserID, string sUnlockFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByName(int lUserID, string sPlayBackFileName, IntPtr hWnd);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, System.IntPtr hWnd);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime_V40(int lUserID, ref NET_DVR_VOD_PARA pVodPara);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackControl(int lPlayHandle, uint dwControlCode, uint dwInValue, ref uint LPOutValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackControl_V40(int lPlayHandle, uint dwControlCode, IntPtr lpInBuffer, uint dwInValue, IntPtr lpOutBuffer, ref uint LPOutValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBack(int lPlayHandle);

        /*********************************************************
        Function:	PLAYDATACALLBACK
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void PLAYDATACALLBACK(int lPlayHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayDataCallBack(int lPlayHandle, PLAYDATACALLBACK fPlayDataCallBack, uint dwUser);


        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackSaveData(int lPlayHandle, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBackSave(int lPlayHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPlayBackOsdTime(int lPlayHandle, ref NET_DVR_TIME lpOsdTime);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackCaptureFile(int lPlayHandle, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByName(int lUserID, string sDVRFileName, string sSavedFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, string sSavedFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByTime_V40(int lUserID, string sSavedFileName, ref NET_DVR_PLAYCOND pDownloadCond);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopGetFile(int lFileHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetDownloadPos(int lFileHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetPlayBackPos(int lPlayHandle);

        //Éý¼¶
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_Upgrade(int lUserID, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetUpgradeState(int lUpgradeHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetUpgradeProgress(int lUpgradeHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseUpgradeHandle(int lUpgradeHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetNetworkEnvironment(uint dwEnvironmentLevel);

        //Ô¶³Ì¸ñÊ½»¯Ó²ÅÌ
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FormatDisk(int lUserID, int lDiskNumber);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetFormatProgress(int lFormatHandle, ref int pCurrentFormatDisk, ref int pCurrentDiskPos, ref int pFormatStatic);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseFormatHandle(int lFormatHandle);

        //±¨¾¯
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseAlarmChan(int lAlarmHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan_V30(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan_V41(int lUserID, ref NET_DVR_SETUPALARM_PARAM lpSetupParam);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseAlarmChan_V30(int lAlarmHandle);

        //ÓïÒô¶Ô½²
        /*********************************************************
        Function:	VOICEDATACALLBACK
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEDATACALLBACK(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser);

        /*********************************************************
        Function:	VOICEDATACALLBACKV30
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEDATACALLBACKV30(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, System.IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_V30(int lUserID, uint dwVoiceChan, bool bNeedCBNoEncData, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser);


        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVoiceComClientVolume(int lVoiceComHandle, ushort wVolume);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopVoiceCom(int lVoiceComHandle);

        //ÓïÒô×ª·¢
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_MR(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_MR_V30(int lUserID, uint dwVoiceChan, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_VoiceComSendData(int lVoiceComHandle, string pSendBuf, uint dwBufSize);

        //ÓïÒô¹ã²¥
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStart();

        /*********************************************************
        Function:	VOICEAUDIOSTART
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEAUDIOSTART(string pRecvDataBuffer, uint dwBufSize, IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStart_V30(VOICEAUDIOSTART fVoiceAudioStart, IntPtr pUser);


        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStop();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_AddDVR(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_AddDVR_V30(int lUserID, uint dwVoiceChan);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DelDVR(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DelDVR_V30(int lVoiceHandle);


        //Í¸Ã÷Í¨µÀÉèÖÃ
        /*********************************************************
        Function:	SERIALDATACALLBACK
        Desc:		(»Øµ÷º¯Êý)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void SERIALDATACALLBACK(int lSerialHandle, string pRecvDataBuffer, uint dwBufSize, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialStart(int lUserID, int lSerialPort, SERIALDATACALLBACK fSerialDataCallBack, uint dwUser);

        //485×÷ÎªÍ¸Ã÷Í¨µÀÊ±£¬ÐèÒªÖ¸Ã÷Í¨µÀºÅ£¬ÒòÎª²»Í¬Í¨µÀºÅ485µÄÉèÖÃ¿ÉÒÔ²»Í¬(±ÈÈç²¨ÌØÂÊ)
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialSend(int lSerialHandle, int lChannel, string pSendBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialStop(int lSerialHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SendTo232Port(int lUserID, string pSendBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SendToSerialPort(int lUserID, uint dwSerialPort, uint dwSerialIndex, string pSendBuf, uint dwBufSize);

        //½âÂë nBitrate = 16000
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern System.IntPtr NET_DVR_InitG722Decoder(int nBitrate);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern void NET_DVR_ReleaseG722Decoder(IntPtr pDecHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecodeG722Frame(IntPtr pDecHandle, ref byte pInBuffer, ref byte pOutBuffer);

        //±àÂë
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern IntPtr NET_DVR_InitG722Encoder();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_EncodeG722Frame(IntPtr pEncodeHandle, ref byte pInBuffer, ref byte pOutBuffer);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern void NET_DVR_ReleaseG722Encoder(IntPtr pEncodeHandle);

        //Ô¶³Ì¿ØÖÆ±¾µØÏÔÊ¾
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClickKey(int lUserID, int lKeyIndex);

        //Ô¶³Ì¿ØÖÆÉè±¸¶ËÊÖ¶¯Â¼Ïñ
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDVRRecord(int lUserID, int lChannel, int lRecordType);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDVRRecord(int lUserID, int lChannel);

        //½âÂë¿¨
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDevice_Card(ref int pDeviceTotalChan);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDevice_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDDraw_Card(IntPtr hParent, uint colorKey);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDDraw_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay_Card(int lUserID, ref NET_DVR_CARDINFO lpCardInfo, int lChannelNum);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ResetPara_Card(int lRealHandle, ref NET_DVR_DISPLAY_PARA lpDisplayPara);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RefreshSurface_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClearSurface_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RestoreSurface_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSound_Card(int lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSound_Card(int lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVolume_Card(int lRealHandle, ushort wVolume);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_AudioPreview_Card(int lRealHandle, int bEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetCardLastError_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern System.IntPtr NET_DVR_GetChanHandle_Card(int lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CapturePicture_Card(int lRealHandle, string sPicFileName);

        //»ñÈ¡½âÂë¿¨ÐòÁÐºÅ´Ë½Ó¿ÚÎÞÐ§£¬¸ÄÓÃGetBoardDetail½Ó¿Ú»ñµÃ(2005-12-08Ö§³Ö)
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSerialNum_Card(int lChannelNum, ref uint pDeviceSerialNo);

        //ÈÕÖ¾
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog(int lLogHandle, ref NET_DVR_LOG lpLogData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindLogClose(int lLogHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog_V30(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, bool bOnlySmart);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog_V30(int lLogHandle, ref NET_DVR_LOG_V30 lpLogData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindLogClose_V30(int lLogHandle);

        //½ØÖ¹2004Äê8ÔÂ5ÈÕ,¹²113¸ö½Ó¿Ú
        //ATM DVR
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFileByCard(int lUserID, int lChannel, uint dwFileType, int nFindType, ref byte sCardNumber, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);


        //2005-09-15
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CaptureJPEGPicture(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, string sPicFileName);

        //JPEG×¥Í¼µ½ÄÚ´æ
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CaptureJPEGPicture_NEW(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, byte[] sJpegPicBuffer, uint dwPicSize, ref uint lpSizeReturned);

        //2006-02-16
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetPlayBackPlayerIndex(int lPlayHandle);

        //2006-08-28 704-640 Ëõ·ÅÅäÖÃ
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetScaleCFG(int lUserID, uint dwScale);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetScaleCFG(int lUserID, ref uint lpOutScale);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg);

        //2006-08-28 ATM»ú¶Ë¿ÚÉèÖÃ
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetATMPortCFG(int lUserID, ushort wATMPort);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetATMPortCFG(int lUserID, ref ushort LPOutATMPort);

        //2006-11-10 Ö§³ÖÏÔ¿¨¸¨ÖúÊä³ö
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDDrawDevice();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDDrawDevice();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetDDrawDeviceTotalNums();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDDrawDevice(int lPlayPort, uint nDeviceNum);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZSelZoomIn(int lRealHandle, ref NET_DVR_POINT_FRAME pStruPointFrame);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZSelZoomIn_EX(int lUserID, int lChannel, ref NET_DVR_POINT_FRAME pStruPointFrame);

        //½âÂëÉè±¸DS-6001D/DS-6001F
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDecode(int lUserID, int lChannel, ref NET_DVR_DECODERINFO lpDecoderinfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDecode(int lUserID, int lChannel);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecoderState(int lUserID, int lChannel, ref NET_DVR_DECODERSTATE lpDecoderState);

        //2005-08-01
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecPlayBackCtrl(int lUserID, int lChannel, uint dwControlCode, uint dwInValue, ref uint LPOutValue, ref NET_DVR_PLAYREMOTEFILE lpRemoteFileInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecCtrlDec(int lUserID, int lChannel, uint dwControlCode);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecCtrlScreen(int lUserID, int lChannel, uint dwControl);

        //¶àÂ·½âÂëÆ÷
        //2007-11-30 V211Ö§³ÖÒÔÏÂ½Ó¿Ú //11
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStartDynamic(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DYNAMIC_DEC lpDynamicInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStopDynamic(int lUserID, uint dwDecChanNum);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecEnable(int lUserID, ref uint lpdwEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_STATUS lpInter);

        //2007-12-22 Ôö¼ÓÖ§³Ö½Ó¿Ú //18
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetRemotePlay(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetRemotePlayControl(int lUserID, uint dwDecChanNum, uint dwControlCode, uint dwInValue, ref uint LPOutValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetRemotePlayStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS lpOuter);

        //2009-4-13 ÐÂÔö
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStartDynamic_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_PU_STREAM_CFG lpDynamicInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO_V30 lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetTranInfo_V30(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetTranInfo_V30(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDisplayCfg(int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetDisplayCfg(int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg);


        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_MatrixStartPassiveDecode(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_PASSIVEMODE lpPassiveMode);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSendData(int lPassiveHandle, System.IntPtr pSendBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStopPassiveDecode(int lPassiveHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_UploadLogo(int lUserID, uint dwDispChanNum, ref NET_DVR_DISP_LOGOCFG lpDispLogoCfg, System.IntPtr sLogoBuffer);

        public const int NET_DVR_SHOWLOGO = 1;/*ÏÔÊ¾LOGO*/
        public const int NET_DVR_HIDELOGO = 2;/*Òþ²ØLOGO*/

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_LogoSwitch(int lUserID, uint dwDecChan, uint dwLogoSwitch);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDeviceStatus(int lUserID, ref NET_DVR_DECODER_WORK_STATUS lpDecoderCfg);

        /*ÏÔÊ¾Í¨µÀÃüÁîÂë¶¨Òå*/
        //ÉÏº£ÊÀ²© ¶¨ÖÆ
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RigisterPlayBackDrawFun(int lRealHandle, DRAWFUN fDrawFun, uint dwUser);


        public const int DISP_CMD_ENLARGE_WINDOW = 1;	/*ÏÔÊ¾Í¨µÀ·Å´óÄ³¸ö´°¿Ú*/
        public const int DISP_CMD_RENEW_WINDOW = 2;	/*ÏÔÊ¾Í¨µÀ´°¿Ú»¹Ô­*/

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixDiaplayControl(int lUserID, uint dwDispChanNum, uint dwDispChanCmd, uint dwCmdParam);

        //end
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RefreshPlay(int lPlayHandle);

        //»Ö¸´Ä¬ÈÏÖµ
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RestoreConfig(int lUserID);

        //±£´æ²ÎÊý
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveConfig(int lUserID);

        //ÖØÆô
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RebootDVR(int lUserID);

        //¹Ø±ÕDVR
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ShutDownDVR(int lUserID);

        //²ÎÊýÅäÖÃ begin
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRConfig(int lUserID, uint dwCommand, int lChannel, IntPtr lpOutBuffer, uint dwOutBufferSize, ref uint lpBytesReturned);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRConfig(int lUserID, uint dwCommand, int lChannel, System.IntPtr lpInBuffer, uint dwInBufferSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRWorkState_V30(int lUserID, IntPtr pWorkState);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRWorkState(int lUserID, ref NET_DVR_WORKSTATE lpWorkState);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVideoEffect(int lUserID, int lChannel, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetVideoEffect(int lUserID, int lChannel, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAtmProtocol(int lUserID, ref NET_DVR_ATM_PROTOCOL lpAtmProtocol);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAlarmOut_V30(int lUserID, IntPtr lpAlarmOutState);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAlarmOut(int lUserID, ref NET_DVR_ALARMOUTSTATUS lpAlarmOutState);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAlarmOut(int lUserID, int lAlarmOutPort, int lAlarmOutStatic);

        //»ñÈ¡UPNP¶Ë¿ÚÓ³Éä×´Ì¬
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetUpnpNatState(int lUserID, ref NET_DVR_UPNP_NAT_STATE lpState);

        //ÊÓÆµ²ÎÊýµ÷½Ú
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetVideoEffect(int lRealHandle, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetVideoEffect(int lRealHandle, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);

        //ÅäÖÃÎÄ¼þ
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile(int lUserID, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConfigFile(int lUserID, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile_V30(int lUserID, string sOutBuffer, uint dwOutSize, ref uint pReturnSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile_EX(int lUserID, string sOutBuffer, uint dwOutSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConfigFile_EX(int lUserID, string sInBuffer, uint dwInSize);

        //ÆôÓÃÈÕÖ¾ÎÄ¼þÐ´Èë½Ó¿Ú
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetLogToFile(int bLogEnable, string strLogDir, bool bAutoDel);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSDKState(ref NET_DVR_SDKSTATE pSDKState);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSDKAbility(ref NET_DVR_SDKABL pSDKAbl);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZProtocol(int lUserID, ref NET_DVR_PTZCFG pPtzcfg);

        //Ç°Ãæ°åËø¶¨
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_LockPanel(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_UnLockPanel(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpInBuffer, uint dwInBufferSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpOutBuffer, uint dwOutBufferSize);

        //ÊÓÆµ×ÛºÏÆ½Ì¨
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetSceneCfg(int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg);
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetSceneCfg(int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg);

        //SDK_V222
        //ÖÇÄÜÉè±¸ÀàÐÍ
        public const int DS6001_HF_B = 60;//ÐÐÎª·ÖÎö£ºDS6001-HF/B
        public const int DS6001_HF_P = 61;//³µÅÆÊ¶±ð£ºDS6001-HF/P
        public const int DS6002_HF_B = 62;//Ë«»ú¸ú×Ù£ºDS6002-HF/B
        public const int DS6101_HF_B = 63;//ÐÐÎª·ÖÎö£ºDS6101-HF/B
        public const int IDS52XX = 64;//ÖÇÄÜ·ÖÎöÒÇIVMS
        public const int DS9000_IVS = 65;//9000ÏµÁÐÖÇÄÜDVR
        public const int DS8004_AHL_A = 66;//ÖÇÄÜATM, DS8004AHL-S/A
        public const int DS6101_HF_P = 67;//³µÅÆÊ¶±ð£ºDS6101-HF/P

        //ÄÜÁ¦»ñÈ¡ÃüÁî
        public const int VCA_DEV_ABILITY = 256;//Éè±¸ÖÇÄÜ·ÖÎöµÄ×ÜÄÜÁ¦
        public const int VCA_CHAN_ABILITY = 272;//ÐÐÎª·ÖÎöÄÜÁ¦
        public const int MATRIXDECODER_ABILITY = 512;//¶àÂ·½âÂëÆ÷ÏÔÊ¾¡¢½âÂëÄÜÁ¦
        //»ñÈ¡/ÉèÖÃ´ó½Ó¿Ú²ÎÊýÅäÖÃÃüÁî
        //³µÅÆÊ¶±ð£¨NET_VCA_PLATE_CFG£©
        public const int NET_DVR_SET_PLATECFG = 150;//ÉèÖÃ³µÅÆÊ¶±ð²ÎÊý
        public const int NET_DVR_GET_PLATECFG = 151;//»ñÈ¡³µÅÆÊ¶±ð²ÎÊý
        //ÐÐÎª¶ÔÓ¦£¨NET_VCA_RULECFG£©
        public const int NET_DVR_SET_RULECFG = 152;//ÉèÖÃÐÐÎª·ÖÎö¹æÔò
        public const int NET_DVR_GET_RULECFG = 153;//»ñÈ¡ÐÐÎª·ÖÎö¹æÔò

        //Ë«ÉãÏñ»ú±ê¶¨²ÎÊý£¨NET_DVR_LF_CFG£©
        public const int NET_DVR_SET_LF_CFG = 160;//ÉèÖÃË«ÉãÏñ»úµÄÅäÖÃ²ÎÊý
        public const int NET_DVR_GET_LF_CFG = 161;//»ñÈ¡Ë«ÉãÏñ»úµÄÅäÖÃ²ÎÊý

        //ÖÇÄÜ·ÖÎöÒÇÈ¡Á÷ÅäÖÃ½á¹¹
        public const int NET_DVR_SET_IVMS_STREAMCFG = 162;//ÉèÖÃÖÇÄÜ·ÖÎöÒÇÈ¡Á÷²ÎÊý
        public const int NET_DVR_GET_IVMS_STREAMCFG = 163;//»ñÈ¡ÖÇÄÜ·ÖÎöÒÇÈ¡Á÷²ÎÊý

        //ÖÇÄÜ¿ØÖÆ²ÎÊý½á¹¹
        public const int NET_DVR_SET_VCA_CTRLCFG = 164;//ÉèÖÃÖÇÄÜ¿ØÖÆ²ÎÊý
        public const int NET_DVR_GET_VCA_CTRLCFG = 165;//»ñÈ¡ÖÇÄÜ¿ØÖÆ²ÎÊý

        //ÆÁ±ÎÇøÓòNET_VCA_MASK_REGION_LIST
        public const int NET_DVR_SET_VCA_MASK_REGION = 166;//ÉèÖÃÆÁ±ÎÇøÓò²ÎÊý
        public const int NET_DVR_GET_VCA_MASK_REGION = 167;//»ñÈ¡ÆÁ±ÎÇøÓò²ÎÊý

        //ATM½øÈëÇøÓò NET_VCA_ENTER_REGION
        public const int NET_DVR_SET_VCA_ENTER_REGION = 168;//ÉèÖÃ½øÈëÇøÓò²ÎÊý
        public const int NET_DVR_GET_VCA_ENTER_REGION = 169;//»ñÈ¡½øÈëÇøÓò²ÎÊý

        //±ê¶¨ÏßÅäÖÃNET_VCA_LINE_SEGMENT_LIST
        public const int NET_DVR_SET_VCA_LINE_SEGMENT = 170;//ÉèÖÃ±ê¶¨Ïß
        public const int NET_DVR_GET_VCA_LINE_SEGMENT = 171;//»ñÈ¡±ê¶¨Ïß

        // ivmsÆÁ±ÎÇøÓòNET_IVMS_MASK_REGION_LIST
        public const int NET_DVR_SET_IVMS_MASK_REGION = 172;//ÉèÖÃIVMSÆÁ±ÎÇøÓò²ÎÊý
        public const int NET_DVR_GET_IVMS_MASK_REGION = 173;//»ñÈ¡IVMSÆÁ±ÎÇøÓò²ÎÊý
        // ivms½øÈë¼ì²âÇøÓòNET_IVMS_ENTER_REGION
        public const int NET_DVR_SET_IVMS_ENTER_REGION = 174;//ÉèÖÃIVMS½øÈëÇøÓò²ÎÊý
        public const int NET_DVR_GET_IVMS_ENTER_REGION = 175;//»ñÈ¡IVMS½øÈëÇøÓò²ÎÊý

        public const int NET_DVR_SET_IVMS_BEHAVIORCFG = 176;//ÉèÖÃÖÇÄÜ·ÖÎöÒÇÐÐÎª¹æÔò²ÎÊý
        public const int NET_DVR_GET_IVMS_BEHAVIORCFG = 177;//»ñÈ¡ÖÇÄÜ·ÖÎöÒÇÐÐÎª¹æÔò²ÎÊý

        // IVMS »Ø·Å¼ìË÷
        public const int NET_DVR_IVMS_SET_SEARCHCFG = 178;//ÉèÖÃIVMS»Ø·Å¼ìË÷²ÎÊý
        public const int NET_DVR_IVMS_GET_SEARCHCFG = 179;//»ñÈ¡IVMS»Ø·Å¼ìË÷²ÎÊý        

        //½á¹¹²ÎÊýºê¶¨Òå 
        public const int VCA_MAX_POLYGON_POINT_NUM = 10;//¼ì²âÇøÓò×î¶àÖ§³Ö10¸öµãµÄ¶à±ßÐÎ
        public const int MAX_RULE_NUM = 8;//×î¶à¹æÔòÌõÊý
        public const int MAX_TARGET_NUM = 30;//×î¶àÄ¿±ê¸öÊý
        public const int MAX_CALIB_PT = 6;//×î´ó±ê¶¨µã¸öÊý
        public const int MIN_CALIB_PT = 4;//×îÐ¡±ê¶¨µã¸öÊý
        public const int MAX_TIMESEGMENT_2 = 2;//×î´óÊ±¼ä¶ÎÊý
        public const int MAX_LICENSE_LEN = 16;//³µÅÆºÅ×î´ó³¤¶È
        public const int MAX_PLATE_NUM = 3;//³µÅÆ¸öÊý
        public const int MAX_MASK_REGION_NUM = 4;//×î¶àËÄ¸öÆÁ±ÎÇøÓò
        public const int MAX_SEGMENT_NUM = 6;//ÉãÏñ»ú±ê¶¨×î´óÑù±¾ÏßÊýÄ¿
        public const int MIN_SEGMENT_NUM = 3;//ÉãÏñ»ú±ê¶¨×îÐ¡Ñù±¾ÏßÊýÄ¿   
        public const int MAX_CATEGORY_LEN = 8; //³µÅÆ¸½¼ÓÐÅÏ¢×î´ó×Ö·û
        /*********************************************************
		Function:	NET_DVR_GetDeviceAbility
		Desc:		
		Input:	
		Output:	
		Return:	TRUE±íÊ¾³É¹¦£¬FALSE±íÊ¾Ê§°Ü¡£
		**********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDeviceAbility(int lUserID, uint dwAbilityType, IntPtr pInBuf, uint dwInLength, IntPtr pOutBuf, uint dwOutLength);

        //²ÎÊý¹Ø¼ü×Ö
        public enum IVS_PARAM_KEY
        {
            OBJECT_DETECT_SENSITIVE = 1,//Ä¿±ê¼ì²âÁéÃô¶È
            BACKGROUND_UPDATE_RATE = 2,//±³¾°¸üÐÂËÙ¶È
            SCENE_CHANGE_RATIO = 3,//³¡¾°±ä»¯¼ì²â×îÐ¡Öµ
            SUPPRESS_LAMP = 4,//ÊÇ·ñÒÖÖÆ³µÍ·µÆ
            MIN_OBJECT_SIZE = 5,//ÄÜ¼ì²â³öµÄ×îÐ¡Ä¿±ê´óÐ¡
            OBJECT_GENERATE_RATE = 6,//Ä¿±êÉú³ÉËÙ¶È
            MISSING_OBJECT_HOLD = 7,//Ä¿±êÏûÊ§ºó¼ÌÐø¸ú×ÙÊ±¼ä
            MAX_MISSING_DISTANCE = 8,//Ä¿±êÏûÊ§ºó¼ÌÐø¸ú×Ù¾àÀë
            OBJECT_MERGE_SPEED = 9,//¶à¸öÄ¿±ê½»´íÊ±£¬Ä¿±êµÄÈÚºÏËÙ¶È
            REPEATED_MOTION_SUPPRESS = 10,//ÖØ¸´ÔË¶¯ÒÖÖÆ
            ILLUMINATION_CHANGE = 11,//¹âÓ°±ä»¯ÒÖÖÆ¿ª¹Ø
            TRACK_OUTPUT_MODE = 12,//¹ì¼£Êä³öÄ£Ê½£º0-Êä³öÄ¿±êµÄÖÐÐÄ£¬1-Êä³öÄ¿±êµÄµ×²¿ÖÐÐÄ
            ENTER_CHANGE_HOLD = 13,//¼ì²âÇøÓò±ä»¯ãÐÖµ
            RESUME_DEFAULT_PARAM = 255,//»Ö¸´Ä¬ÈÏ¹Ø¼ü×Ö²ÎÊý
        }

        //ÉèÖÃ/»ñÈ¡²ÎÊý¹Ø¼ü×Ö
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, int nValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, ref int pValue);

        //»ñÈ¡/ÉèÖÃÐÐÎª·ÖÎöÄ¿±êµþ¼Ó½Ó¿Ú
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetVCADrawMode(int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVCADrawMode(int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode);

        //±ê¶¨²ÎÊýÅäÖÃ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_CALIBRATION_PARAM
        {
            public byte byPointNum;//ÓÐÐ§±ê¶¨µã¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CALIB_PT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CB_POINT[] struCBPoint;//±ê¶¨µã×é
        }

        //LFË«ÉãÏñ»úÅäÖÃ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_CFG
        {
            public uint dwSize;//½á¹¹³¤¶È	
            public byte byEnable;//±ê¶¨Ê¹ÄÜ
            public byte byFollowChan;// ±»¿ØÖÆµÄ´ÓÍ¨µÀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_LF_CALIBRATION_PARAM struCalParam;//±ê¶¨µã×é
        }

        //L/FÊÖ¶¯¿ØÖÆ½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_MANUAL_CTRL_INFO
        {
            public NET_VCA_POINT struCtrlPoint;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //L/FÄ¿±ê¸ú×Ù½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_TRACK_TARGET_INFO
        {
            public uint dwTargetID;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_TRACK_MODE
        {
            public uint dwSize;//½á¹¹³¤¶È
            public byte byTrackMode;//¸ú×ÙÄ£Ê½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô£¬ÖÃ0
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uModeParam
            {
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
                [FieldOffsetAttribute(0)]
                public uint[] dwULen;
                /*[FieldOffsetAttribute(0)]
                public NET_DVR_LF_MANUAL_CTRL_INFO struManualCtrl;//ÊÖ¶¯¸ú×Ù½á¹¹
                [FieldOffsetAttribute(0)]
                public NET_DVR_LF_TRACK_TARGET_INFO struTargetTrack;//Ä¿±ê¸ú×Ù½á¹¹
                 * */
            }
        }

        //Ë«ÉãÏñ»ú¸ú×ÙÄ£Ê½ÉèÖÃ½Ó¿Ú
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetLFTrackMode(int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetLFTrackMode(int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode);

        //Ê¶±ð³¡¾°
        public enum VCA_RECOGNIZE_SCENE
        {
            VCA_LOW_SPEED_SCENE = 0,//µÍËÙÍ¨¹ý³¡¾°£¨ÊÕ·ÑÕ¾¡¢Ð¡ÇøÃÅ¿Ú¡¢Í£³µ³¡£©
            VCA_HIGH_SPEED_SCENE = 1,//¸ßËÙÍ¨¹ý³¡¾°£¨¿¨¿Ú¡¢¸ßËÙ¹«Â·¡¢ÒÆ¶¯»ü²é)
            VCA_MOBILE_CAMERA_SCENE = 2,//ÒÆ¶¯ÉãÏñ»úÓ¦ÓÃ£© 
        }

        //Ê¶±ð½á¹û±êÖ¾
        public enum VCA_RECOGNIZE_RESULT
        {
            VCA_RECOGNIZE_FAILURE = 0,//Ê¶±ðÊ§°Ü
            VCA_IMAGE_RECOGNIZE_SUCCESS,//Í¼ÏñÊ¶±ð³É¹¦
            VCA_VIDEO_RECOGNIZE_SUCCESS_OF_BEST_LICENSE,//ÊÓÆµÊ¶±ð¸üÓÅ½á¹û
            VCA_VIDEO_RECOGNIZE_SUCCESS_OF_NEW_LICENSE,//ÊÓÆµÊ¶±ðµ½ÐÂµÄ³µÅÆ
            VCA_VIDEO_RECOGNIZE_FINISH_OF_CUR_LICENSE,//ÊÓÆµÊ¶±ð³µÅÆ½áÊø
        }



        //ÊÓÆµÊ¶±ð´¥·¢ÀàÐÍ
        public enum VCA_TRIGGER_TYPE
        {
            INTER_TRIGGER = 0,// Ä£¿éÄÚ²¿´¥·¢Ê¶±ð
            EXTER_TRIGGER = 1,// Íâ²¿ÎïÀíÐÅºÅ´¥·¢£ºÏßÈ¦¡¢À×´ï¡¢ÊÖ¶¯´¥·¢ÐÅºÅ£»
        }

        public const int MAX_CHINESE_CHAR_NUM = 64;    // ×î´óºº×ÖÀà±ðÊýÁ¿
        //³µÅÆ¿É¶¯Ì¬ÐÞ¸Ä²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATE_PARAM
        {
            public NET_VCA_RECT struSearchRect;//ËÑË÷ÇøÓò(¹éÒ»»¯)
            public NET_VCA_RECT struInvalidateRect;//ÎÞÐ§ÇøÓò£¬ÔÚËÑË÷ÇøÓòÄÚ²¿ (¹éÒ»»¯)
            public ushort wMinPlateWidth;//³µÅÆ×îÐ¡¿í¶È
            public ushort wTriggerDuration;//´¥·¢³ÖÐøÖ¡Êý
            public byte byTriggerType;//´¥·¢Ä£Ê½, VCA_TRIGGER_TYPE
            public byte bySensitivity;//ÁéÃô¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô£¬ÖÃ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byCharPriority;// ºº×ÖÓÅÏÈ¼¶
        }

        /*wMinPlateWidth:¸Ã²ÎÊýÄ¬ÈÏÅäÖÃÎª80ÏñËØ£»¸Ã²ÎÊýµÄÅäÖÃ¶ÔÓÚ³µÅÆº£¿µÍþÊÓ³µÅÆÊ¶±ðËµÃ÷ÎÄµµ 
	    Ê¶±ðÓÐÓ°Ïì£¬Èç¹ûÉèÖÃ¹ý´ó£¬ÄÇÃ´Èç¹û³¡¾°ÖÐ³öÏÖÐ¡³µÅÆ¾Í»áÂ©Ê¶±ð£»Èç¹û³¡¾°ÖÐ³µÅÆ¿í¶ÈÆÕ±é½Ï´ó£¬¿ÉÒÔ°Ñ¸Ã²ÎÊýÉèÖÃÉÔ´ó£¬±ãÓÚ¼õÉÙ¶ÔÐé¼Ù³µÅÆµÄ´¦Àí¡£ÔÚ±êÇåÇé¿öÏÂ½¨ÒéÉèÖÃÎª80£¬ ÔÚ¸ßÇåÇé¿öÏÂ½¨ÒéÉèÖÃÎª120
        wTriggerDuration £­ Íâ²¿´¥·¢ÐÅºÅ³ÖÐøÖ¡ÊýÁ¿£¬Æäº¬ÒåÊÇ´Ó´¥·¢ÐÅºÅ¿ªÊ¼Ê¶±ðµÄÖ¡ÊýÁ¿¡£¸ÃÖµÔÚµÍËÙ³¡¾°½¨ÒéÉèÖÃÎª50¡«100£»¸ßËÙ³¡¾°½¨ÒéÉèÖÃÎª15¡«25£»ÒÆ¶¯Ê¶±ðÊ±Èç¹ûÒ²ÓÐÍâ²¿´¥·¢£¬ÉèÖÃÎª15¡«25£»¾ßÌå¿ÉÒÔ¸ù¾ÝÏÖ³¡Çé¿ö½øÐÐÅäÖÃ
        */
        //³µÅÆÊ¶±ð²ÎÊý×Ó½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATEINFO
        {
            public VCA_RECOGNIZE_SCENE eRecogniseScene;//Ê¶±ð³¡¾°(µÍËÙºÍ¸ßËÙ)
            public NET_VCA_PLATE_PARAM struModifyParam;//³µÅÆ¿É¶¯Ì¬ÐÞ¸Ä²ÎÊý
        }

        //³µÅÆÊ¶±ðÅäÖÃ²ÎÊý
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATECFG
        {
            public uint dwSize;
            public byte byPicProType;//±¨¾¯Ê±Í¼Æ¬´¦Àí·½Ê½ 0-²»´¦Àí 1-ÉÏ´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£Áô£¬ÉèÖÃÎª0
            public NET_DVR_JPEGPARA struPictureParam;//Í¼Æ¬¹æ¸ñ½á¹¹
            public NET_VCA_PLATEINFO struPlateInfo;//³µÅÆÐÅÏ¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ÀÊ±¼ä
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;//´¦Àí·½Ê½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±¨¾¯´¥·¢µÄÂ¼ÏóÍ¨µÀ,Îª1±íÊ¾´¥·¢¸ÃÍ¨µÀ
        }

        //³µÅÆÊ¶±ð½á¹û×Ó½á¹¹
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_VCA_PLATE_INFO
        {
            public VCA_RECOGNIZE_RESULT eResultFlag;//Ê¶±ð½á¹û±êÖ¾ 
            public VCA_PLATE_TYPE ePlateType;//³µÅÆÀàÐÍ
            public VCA_PLATE_COLOR ePlateColor;//³µÅÆÑÕÉ«
            public NET_VCA_RECT struPlateRect;//³µÅÆÎ»ÖÃ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;//±£Áô£¬ÉèÖÃÎª0 
            public uint dwLicenseLen;//³µÅÆ³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sLicense;//³µÅÆºÅÂë 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sBelieve;//¸÷¸öÊ¶±ð×Ö·ûµÄÖÃÐÅ¶È£¬Èç¼ì²âµ½³µÅÆ"ÕãA12345", ÖÃÐÅ¶ÈÎª10,20,30,40,50,60,70£¬Ôò±íÊ¾"Õã"×ÖÕýÈ·µÄ¿ÉÄÜÐÔÖ»ÓÐ10%£¬"A"×ÖµÄÕýÈ·µÄ¿ÉÄÜÐÔÊÇ20%
        }

        //³µÅÆ¼ì²â½á¹û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATE_RESULT
        {
            public uint dwSize;//½á¹¹³¤¶È
            public uint dwRelativeTime;//Ïà¶ÔÊ±±ê
            public uint dwAbsTime;//¾ø¶ÔÊ±±ê
            public byte byPlateNum;//³µÅÆ¸öÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PLATE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PLATE_INFO[] struPlateInfo;//³µÅÆÐÅÏ¢½á¹¹
            public uint dwPicDataLen;//·µ»ØÍ¼Æ¬µÄ³¤¶È Îª0±íÊ¾Ã»ÓÐÍ¼Æ¬£¬´óÓÚ0±íÊ¾¸Ã½á¹¹ºóÃæ½ô¸úÍ¼Æ¬Êý¾Ý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes2;//±£Áô£¬ÉèÖÃÎª0 Í¼Æ¬µÄ¸ß¿í
            public System.IntPtr pImage;//Ö¸ÏòÍ¼Æ¬µÄÖ¸Õë
        }

        //ÖØÆôÖÇÄÜ¿â
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_VCA_RestartLib(int lUserID, int lChannel);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE_SEGMENT
        {
            public NET_VCA_POINT struStartPoint;//±íÊ¾¸ß¶ÈÏßÊ±£¬±íÊ¾Í·²¿µã
            public NET_VCA_POINT struEndPoint;//±íÊ¾¸ß¶ÈÏßÊ±£¬±íÊ¾½Å²¿µã
            public float fValue;//¸ß¶ÈÖµ£¬µ¥Î»Ã×
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±ê¶¨ÏßÁ´±í
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE_SEG_LIST
        {
            public uint dwSize;//½á¹¹³¤¶È
            public byte bySegNum;//±ê¶¨ÏßÌõÊý
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byRes;//±£Áô£¬ÖÃ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SEGMENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_LINE_SEGMENT[] struSeg;
        }

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRealHeight(int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpHeight);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRealLength(int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpLength);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveRealData_V30(int lRealHandle, uint dwTransType, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_EncodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);

        //2009-7-22 end  

        //ÓÊ¼þ·þÎñ²âÊÔ 9000_1.1
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_EmailTest(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFileByEvent(int lUserID, ref NET_DVR_SEARCH_EVENT_PARAM lpSearchEventParam);

        //2009-8-18 ×¥ÅÄ»ú
        public const int PLATE_INFO_LEN = 1024;
        public const int PLATE_NUM_LEN = 16;
        public const int FILE_NAME_LEN = 256;

        //liscense plate result
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_RET
        {
            public uint dwSize;//½á¹¹³¤¶È
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PLATE_NUM_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPlateNum;//³µÅÆºÅ
            public byte byVehicleType;// ³µÀàÐÍ
            public byte byTrafficLight;//0-ÂÌµÆ£»1-ºìµÆ
            public byte byPlateColor;//³µÅÆÑÕÉ«
            public byte byDriveChan;//´¥·¢³µµÀºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byTimeInfo;/*Ê±¼äÐÅÏ¢*///plate_172.6.113.64_20090724155526948_197170484 
            //Ä¿Ç°ÊÇ17Î»£¬¾«È·µ½ms:20090724155526948
            public byte byCarSpeed;/*µ¥Î»km/h*/
            public byte byCarSpeedH;/*cm/s¸ß8Î»*/
            public byte byCarSpeedL;/*cm/sµÍ8Î»*/
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PLATE_INFO_LEN - 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byInfo;
            public uint dwPicLen;
        }
        /*×¢£ººóÃæ½ô¸ú dwPicLen ³¤¶ÈµÄ Í¼Æ¬ ÐÅÏ¢*/

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_INVOKE_PLATE_RECOGNIZE(int lUserID, int lChannel, string pPicFileName, ref NET_DVR_PLATE_RET pPlateRet, string pPicBuf, uint dwPicBufLen);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CCD_CFG
        {
            public uint dwSize;//½á¹¹³¤¶È
            public byte byBlc;/*±³¹â²¹³¥0-off; 1-on*/
            public byte byBlcMode;/*blcÀàÐÍ0-×Ô¶¨Òå1-ÉÏ£»2-ÏÂ£»3-×ó£»4-ÓÒ£»5-ÖÐ£»×¢£º´ËÏîÔÚblcÎª on Ê±²ÅÆðÐ§*/
            public byte byAwb;/*×Ô¶¯°×Æ½ºâ0-×Ô¶¯1; 1-×Ô¶¯2; 2-×Ô¶¯¿ØÖÆ*/
            public byte byAgc;/*×Ô¶¯ÔöÒæ0-¹Ø; 1-µÍ; 2-ÖÐ; 3-¸ß*/
            public byte byDayNight;/*ÈÕÒ¹×ª»»£»0 ²ÊÉ«£»1ºÚ°×£»2×Ô¶¯*/
            public byte byMirror;/*¾µÏñ0-¹Ø;1-×óÓÒ;2-ÉÏÏÂ;3-ÖÐÐÄ*/
            public byte byShutter;/*¿ìÃÅ0-×Ô¶¯; 1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k;*/
            public byte byIrCutTime;/*IRCUTÇÐ»»Ê±¼ä£¬5, 10, 15, 20, 25*/
            public byte byLensType;/*¾µÍ·ÀàÐÍ0-µç×Ó¹âÈ¦; 1-×Ô¶¯¹âÈ¦*/
            public byte byEnVideoTrig;/*ÊÓÆµ´¥·¢Ê¹ÄÜ£º1-Ö§³Ö£»0-²»Ö§³Ö¡£ÊÓÆµ´¥·¢Ä£Ê½ÏÂÊÓÆµ¿ìÃÅËÙ¶È°´ÕÕbyShutterËÙ¶È£¬×¥ÅÄÍ¼Æ¬µÄ¿ìÃÅËÙ¶È°´ÕÕbyCapShutterËÙ¶È£¬×¥ÅÄÍê³Éºó»á×Ô¶¯µ÷½Ú»ØÊÓÆµÄ£Ê½*/
            public byte byCapShutter;/*×¥ÅÄÊ±µÄ¿ìÃÅËÙ¶È£¬1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k; 11-1/150; 12-1/200*/
            public byte byEnRecognise;/*1-Ö§³ÖÊ¶±ð£»0-²»Ö§³ÖÊ¶±ð*/
        }

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetCCDCfg(int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetCCDCfg(int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagCAMERAPARAMCFG
        {
            public uint dwSize;
            public uint dwPowerLineFrequencyMode;/*0-50HZ; 1-60HZ*/
            public uint dwWhiteBalanceMode;/*0ÊÖ¶¯°×Æ½ºâ; 1×Ô¶¯°×Æ½ºâ1£¨·¶Î§Ð¡£©; 2 ×Ô¶¯°×Æ½ºâ2£¨·¶Î§¿í£¬2200K-15000K£©;3×Ô¶¯¿ØÖÆ3*/
            public uint dwWhiteBalanceModeRGain;/*ÊÖ¶¯°×Æ½ºâÊ±ÓÐÐ§£¬ÊÖ¶¯°×Æ½ºâ RÔöÒæ*/
            public uint dwWhiteBalanceModeBGain;/*ÊÖ¶¯°×Æ½ºâÊ±ÓÐÐ§£¬ÊÖ¶¯°×Æ½ºâ BÔöÒæ*/
            public uint dwExposureMode;/*0 ÊÖ¶¯ÆØ¹â 1×Ô¶¯ÆØ¹â*/
            public uint dwExposureSet;/* 0-USERSET, 1-×Ô¶¯x2£¬2-×Ô¶¯4£¬3-×Ô¶¯81/25, 4-1/50, 5-1/100, 6-1/250, 7-1/500, 8-1/750, 9-1/1000, 10-1/2000, 11-1/4000,12-1/10,000; 13-1/100,000*/
            public uint dwExposureUserSet;/* ×Ô¶¯×Ô¶¨ÒåÆØ¹âÊ±¼ä*/
            public uint dwExposureTarget;/*ÊÖ¶¯ÆØ¹âÊ±¼ä ·¶Î§£¨ManumalÓÐÐ§£¬Î¢Ãë£©*/
            public uint dwIrisMode;/*0 ×Ô¶¯¹âÈ¦ 1ÊÖ¶¯¹âÈ¦*/
            public uint dwGainLevel;/*ÔöÒæ£º0-100*/
            public uint dwBrightnessLevel;/*0-100*/
            public uint dwContrastLevel;/*0-100*/
            public uint dwSharpnessLevel;/*0-100*/
            public uint dwSaturationLevel;/*0-100*/
            public uint dwHueLevel;/*0-100£¬£¨±£Áô£©*/
            public uint dwGammaCorrectionEnabled;/*0 dsibale  1 enable*/
            public uint dwGammaCorrectionLevel;/*0-100*/
            public uint dwWDREnabled;/*¿í¶¯Ì¬£º0 dsibale  1 enable*/
            public uint dwWDRLevel1;/*0-F*/
            public uint dwWDRLevel2;/*0-F*/
            public uint dwWDRContrastLevel;/*0-100*/
            public uint dwDayNightFilterType;/*ÈÕÒ¹ÇÐ»»£º0 day,1 night,2 auto */
            public uint dwSwitchScheduleEnabled;/*0 dsibale  1 enable,(±£Áô)*/
            //Ä£Ê½1(±£Áô)
            public uint dwBeginTime;	/*0-100*/
            public uint dwEndTime;/*0-100*/
            //Ä£Ê½2
            public uint dwDayToNightFilterLevel;//0-7
            public uint dwNightToDayFilterLevel;//0-7
            public uint dwDayNightFilterTime;//(60Ãë)
            public uint dwBacklightMode;/*±³¹â²¹³¥:0 USERSET 1 UP¡¢2 DOWN¡¢3 LEFT¡¢4 RIGHT¡¢5MIDDLE*/
            public uint dwPositionX1;//£¨X×ø±ê1£©
            public uint dwPositionY1;//£¨Y×ø±ê1£©
            public uint dwPositionX2;//£¨X×ø±ê2£©
            public uint dwPositionY2;//£¨Y×ø±ê2£©
            public uint dwBacklightLevel;/*0x0-0xF*/
            public uint dwDigitalNoiseRemoveEnable; /*Êý×ÖÈ¥Ôë£º0 dsibale  1 enable*/
            public uint dwDigitalNoiseRemoveLevel;/*0x0-0xF*/
            public uint dwMirror; /* ¾µÏñ£º0 Left;1 Right,;2 Up;3Down */
            public uint dwDigitalZoom;/*Êý×ÖËõ·Å:0 dsibale  1 enable*/
            public uint dwDeadPixelDetect;/*»µµã¼ì²â,0 dsibale  1 enable*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        public const int NET_DVR_GET_CCDPARAMCFG = 1067;       //IPC»ñÈ¡CCD²ÎÊýÅäÖÃ
        public const int NET_DVR_SET_CCDPARAMCFG = 1068;      //IPCÉèÖÃCCD²ÎÊýÅäÖÃ

        //Í¼ÏñÔöÇ¿ÒÇ
        //Í¼ÏñÔöÇ¿È¥ÔïÇøÓòÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGEREGION
        {
            public uint dwSize;//×ÜµÄ½á¹¹³¤¶È
            public ushort wImageRegionTopLeftX;/* Í¼ÏñÔöÇ¿È¥ÔïµÄ×óÉÏx×ø±ê */
            public ushort wImageRegionTopLeftY;/* Í¼ÏñÔöÇ¿È¥ÔïµÄ×óÉÏy×ø±ê */
            public ushort wImageRegionWidth;/* Í¼ÏñÔöÇ¿È¥ÔïÇøÓòµÄ¿í */
            public ushort wImageRegionHeight;/*Í¼ÏñÔöÇ¿È¥ÔïÇøÓòµÄ¸ß*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Í¼ÏñÔöÇ¿¡¢È¥Ôë¼¶±ð¼°ÎÈ¶¨ÐÔÊ¹ÄÜÅäÖÃ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGESUBPARAM
        {
            public NET_DVR_SCHEDTIME struImageStatusTime;//Í¼Ïñ×´Ì¬Ê±¼ä¶Î
            public byte byImageEnhancementLevel;//Í¼ÏñÔöÇ¿µÄ¼¶±ð£¬0-7£¬0±íÊ¾¹Ø±Õ
            public byte byImageDenoiseLevel;//Í¼ÏñÈ¥ÔëµÄ¼¶±ð£¬0-7£¬0±íÊ¾¹Ø±Õ
            public byte byImageStableEnable;//Í¼ÏñÎÈ¶¨ÐÔÊ¹ÄÜ£¬0±íÊ¾¹Ø±Õ£¬1±íÊ¾´ò¿ª
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_DVR_GET_IMAGEREGION = 1062;       //Í¼ÏñÔöÇ¿ÒÇÍ¼ÏñÔöÇ¿È¥ÔïÇøÓò»ñÈ¡
        public const int NET_DVR_SET_IMAGEREGION = 1063;       //Í¼ÏñÔöÇ¿ÒÇÍ¼ÏñÔöÇ¿È¥ÔïÇøÓò»ñÈ¡
        public const int NET_DVR_GET_IMAGEPARAM = 1064;       // Í¼ÏñÔöÇ¿ÒÇÍ¼Ïñ²ÎÊý(È¥Ôë¡¢ÔöÇ¿¼¶±ð£¬ÎÈ¶¨ÐÔÊ¹ÄÜ)»ñÈ¡
        public const int NET_DVR_SET_IMAGEPARAM = 1065;       // Í¼ÏñÔöÇ¿ÒÇÍ¼Ïñ²ÎÊý(È¥Ôë¡¢ÔöÇ¿¼¶±ð£¬ÎÈ¶¨ÐÔÊ¹ÄÜ)ÉèÖÃ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGEPARAM
        {
            public uint dwSize;
            //Í¼ÏñÔöÇ¿Ê±¼ä¶Î²ÎÊýÅäÖÃ£¬ÖÜÈÕ¿ªÊ¼	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public tagIMAGESUBPARAM[] struImageParamSched;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetParamSetMode(int lUserID, ref uint dwParamSetMode);

        /*********************************************************
        Function:	NET_DVR_Login_V30
        Desc:		
        Input:	sDVRIP [in] Éè±¸IPµØÖ· 
                wServerPort [in] Éè±¸¶Ë¿ÚºÅ 
                sUserName [in] µÇÂ¼µÄÓÃ»§Ãû 
                sPassword [in] ÓÃ»§ÃÜÂë 
        Output:	lpDeviceInfo [out] Éè±¸ÐÅÏ¢ 
        Return:	-1±íÊ¾Ê§°Ü£¬ÆäËûÖµ±íÊ¾·µ»ØµÄÓÃ»§IDÖµ
        **********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern Int32 NET_DVR_Login_V30(string sDVRIP, Int32 wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO_V30 lpDeviceInfo);

        /*********************************************************
        Function:	NET_DVR_Logout_V30
        Desc:		ÓÃ»§×¢²áÉè±¸¡£
        Input:	lUserID [in] ÓÃ»§IDºÅ
        Output:	
        Return:	TRUE±íÊ¾³É¹¦£¬FALSE±íÊ¾Ê§°Ü
        **********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout_V30(Int32 lUserID);











        #region  È¡Á÷Ä£¿éÏà¹Ø½á¹¹Óë½Ó¿Ú

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct PLAY_INFO
        {
            public int iUserID;      //×¢²áÓÃ»§ID
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string strDeviceIP;
            public int iDevicePort;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string strDevAdmin;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string strDevPsd;
            public int iChannel;      //²¥·ÅÍ¨µÀºÅ(´Ó0¿ªÊ¼)
            public int iLinkMode;   //×î¸ßÎ»(31)Îª0±íÊ¾Ö÷ÂëÁ÷£¬Îª1±íÊ¾×ÓÂëÁ÷£¬0£­30Î»±íÊ¾ÂëÁ÷Á¬½Ó·½Ê½: 0£ºTCP·½Ê½,1£ºUDP·½Ê½,2£º¶à²¥·½Ê½,3 - RTP·½Ê½£¬4-ÒôÊÓÆµ·Ö¿ª(TCP)
            public bool bUseMedia;     //ÊÇ·ñÆôÓÃÁ÷Ã½Ìå
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string strMediaIP; //Á÷Ã½ÌåIPµØÖ·
            public int iMediaPort;   //Á÷Ã½Ìå¶Ë¿ÚºÅ
        }


        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_Init();

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_UnInit();


        [DllImport("GetStream.dll")]
        public static extern int CLIENT_SDK_GetStream(PLAY_INFO lpPlayInfo); //

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SetRealDataCallBack(int iRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint lUser); //

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_StopStream(int iRealHandle);

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_GetVideoEffect(int iRealHandle, ref int iBrightValue, ref int iContrastValue, ref int iSaturationValue, ref int iHueValue);

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_SetVideoEffect(int iRealHandle, int iBrightValue, int iContrastValue, int iSaturationValue, int iHueValue);

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_MakeKeyFrame(int iRealHandle);

        #endregion


        #region VODµã²¥·Å¿â

        public const int WM_NETERROR = 0x0400 + 102;          //ÍøÂçÒì³£ÏûÏ¢
        public const int WM_STREAMEND = 0x0400 + 103;		  //ÎÄ¼þ²¥·Å½áÊø

        public const int FILE_HEAD = 0;      //ÎÄ¼þÍ·
        public const int VIDEO_I_FRAME = 1;  //ÊÓÆµIÖ¡
        public const int VIDEO_B_FRAME = 2;  //ÊÓÆµBÖ¡
        public const int VIDEO_P_FRAME = 3;  //ÊÓÆµPÖ¡
        public const int VIDEO_BP_FRAME = 4; //ÊÓÆµBPÖ¡
        public const int VIDEO_BBP_FRAME = 5; //ÊÓÆµBÖ¡BÖ¡PÖ¡
        public const int AUDIO_PACKET = 10;   //ÒôÆµ°ü

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct BLOCKTIME
        {
            public ushort wYear;
            public byte bMonth;
            public byte bDay;
            public byte bHour;
            public byte bMinute;
            public byte bSecond;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VODSEARCHPARAM
        {
            public IntPtr sessionHandle;                                    //[in]VOD¿Í»§¶Ë¾ä±ú
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string dvrIP;                                            //	[in]DVRµÄÍøÂçµØÖ·
            public uint dvrPort;                                            //	[in]DVRµÄ¶Ë¿ÚµØÖ·
            public uint channelNum;                                         //  [in]DVRµÄÍ¨µÀºÅ
            public BLOCKTIME startTime;                                     //	[in]²éÑ¯µÄ¿ªÊ¼Ê±¼ä
            public BLOCKTIME stopTime;                                      //	[in]²éÑ¯µÄ½áÊøÊ±¼ä
            public bool bUseIPServer;                                       //  [in]ÊÇ·ñÊ¹ÓÃIPServer 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string SerialNumber;                                     //  [in]Éè±¸µÄÐòÁÐºÅ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SECTIONLIST
        {
            public BLOCKTIME startTime;
            public BLOCKTIME stopTime;
            public byte byRecType;
            public IntPtr pNext;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VODOPENPARAM
        {
            public IntPtr sessionHandle;                                    //[in]VOD¿Í»§¶Ë¾ä±ú
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string dvrIP;                                            //	[in]DVRµÄÍøÂçµØÖ·
            public uint dvrPort;                                            //	[in]DVRµÄ¶Ë¿ÚµØÖ·
            public uint channelNum;                                         //  [in]DVRµÄÍ¨µÀºÅ
            public BLOCKTIME startTime;                                     //	[in]²éÑ¯µÄ¿ªÊ¼Ê±¼ä
            public BLOCKTIME stopTime;                                      //	[in]²éÑ¯µÄ½áÊøÊ±¼ä
            public uint uiUser;
            public bool bUseIPServer;                                       //  [in]ÊÇ·ñÊ¹ÓÃIPServer 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string SerialNumber;                                     //  [in]Éè±¸µÄÐòÁÐºÅ

            public VodStreamFrameData streamFrameData;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CONNPARAM
        {
            public uint uiUser;
            public ErrorCallback errorCB;
        }


        // Òì³£»Øµ÷º¯Êý
        public delegate void ErrorCallback(System.IntPtr hSession, uint dwUser, int lErrorType);
        //Ö¡Êý¾Ý»Øµ÷º¯Êý
        public delegate void VodStreamFrameData(System.IntPtr hStream, uint dwUser, int lFrameType, System.IntPtr pBuffer, uint dwSize);

        //Ä£¿é³õÊ¼»¯
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODServerConnect(string strServerIp, uint uiServerPort, ref IntPtr hSession, ref CONNPARAM struConn, IntPtr hWnd);

        //Ä£¿éÏú»Ù
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODServerDisconnect(IntPtr hSession);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStreamSearch(IntPtr pSearchParam, ref IntPtr pSecList);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODDeleteSectionList(IntPtr pSecList);

        // ¸ù¾ÝID¡¢Ê±¼ä¶Î´ò¿ªÁ÷»ñÈ¡Á÷¾ä±ú
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODOpenStream(IntPtr pOpenParam, ref IntPtr phStream);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODCloseStream(IntPtr hStream);

        //¸ù¾ÝID¡¢Ê±¼ä¶Î´ò¿ªÅúÁ¿ÏÂÔØ
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODOpenDownloadStream(ref VODOPENPARAM struVodParam, ref IntPtr phStream);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODCloseDownloadStream(IntPtr hStream);

        // ¿ªÊ¼Á÷½âÎö£¬·¢ËÍÊý¾ÝÖ¡
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStartStreamData(IntPtr phStream);
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODPauseStreamData(IntPtr hStream, bool bPause);
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStopStreamData(IntPtr hStream);

        // ¸ù¾ÝÊ±¼ä¶¨Î»
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODSeekStreamData(IntPtr hStream, IntPtr pStartTime);


        // ¸ù¾ÝÊ±¼ä¶¨Î»
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODSetStreamSpeed(IntPtr hStream, int iSpeed);

        // ¸ù¾ÝÊ±¼ä¶¨Î»
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODGetStreamCurrentTime(IntPtr hStream, ref BLOCKTIME pCurrentTime);

        #endregion


        #region Ö¡·ÖÎö¿â


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct PACKET_INFO
        {
            public int nPacketType;     // packet type
            // 0:  file head
            // 1:  video I frame
            // 2:  video B frame
            // 3:  video P frame
            // 10: audio frame
            // 11: private frame only for PS


            //      [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
            public IntPtr pPacketBuffer;
            public uint dwPacketSize;
            public int nYear;
            public int nMonth;
            public int nDay;
            public int nHour;
            public int nMinute;
            public int nSecond;
            public uint dwTimeStamp;
        }



        /******************************************************************************
        * function£ºget a empty port number
        * parameters£º
        * return£º 0 - 499 : empty port number
        *          -1      : server is full  			
        * comment£º
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern int AnalyzeDataGetSafeHandle();


        /******************************************************************************
        * function£ºopen standard stream data for analyzing
        * parameters£ºlHandle - working port number
        *             pHeader - pointer to file header or info header
        * return£ºTRUE or FALSE
        * comment£º
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataOpenStreamEx(int iHandle, byte[] pFileHead);


        /******************************************************************************
        * function£ºclose analyzing
        * parameters£ºlHandle - working port number
        * return£º
        * comment£º
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataClose(int iHandle);


        /******************************************************************************
        * function£ºinput stream data
        * parameters£ºlHandle		- working port number
        *			  pBuffer		- data pointer
        *			  dwBuffersize	- data size
        * return£ºTRUE or FALSE
        * comment£º
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataInputData(int iHandle, IntPtr pBuffer, uint uiSize); //byte []


        /******************************************************************************
        * function£ºget analyzed packet
        * parameters£ºlHandle		- working port number
        *			  pPacketInfo	- returned structure
        * return£º-1 : error
        *          0 : succeed
        *		   1 : failed
        *		   2 : file end (only in file mode)				
        * comment£º
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern int AnalyzeDataGetPacket(int iHandle, ref PACKET_INFO pPacketInfo);  //Òª°ÑpPacketInfo×ª»»³ÉPACKET_INFO½á¹¹


        /******************************************************************************
        * function£ºget remain data from input buffer
        * parameters£ºlHandle		- working port number
        *			  pBuf	        - pointer to the mem which stored remain data
        *             dwSize        - size of remain data  
        * return£º TRUE or FALSE				
        * comment£º
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataGetTail(int iHandle, ref IntPtr pBuffer, ref uint uiSize);


        [DllImport("AnalyzeData.dll")]
        public static extern uint AnalyzeDataGetLastError(int iHandle);

        #endregion


        #region Â¼Ïñ¿â

        public const int DATASTREAM_HEAD = 0;		//Êý¾ÝÍ·
        public const int DATASTREAM_BITBLOCK = 1;		//×Ö½ÚÊý¾Ý
        public const int DATASTREAM_KEYFRAME = 2;		//¹Ø¼üÖ¡Êý¾Ý
        public const int DATASTREAM_NORMALFRAME = 3;		//·Ç¹Ø¼üÖ¡Êý¾Ý


        public const int MESSAGEVALUE_DISKFULL = 0x01;
        public const int MESSAGEVALUE_SWITCHDISK = 0x02;
        public const int MESSAGEVALUE_CREATEFILE = 0x03;
        public const int MESSAGEVALUE_DELETEFILE = 0x04;
        public const int MESSAGEVALUE_SWITCHFILE = 0x05;




        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STOREINFO
        {
            public int iMaxChannels;
            public int iDiskGroup;
            public int iStreamType;
            public bool bAnalyze;
            public bool bCycWrite;
            public uint uiFileSize;

            public CALLBACKFUN_MESSAGE funCallback;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CREATEFILE_INFO
        {
            public int iHandle;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strCameraid;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strFileName;

            public BLOCKTIME tFileCreateTime;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CLOSEFILE_INFO
        {
            public int iHandle;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strCameraid;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strFileName;

            public BLOCKTIME tFileSwitchTime;
        }



        public delegate int CALLBACKFUN_MESSAGE(int iMessageType, System.IntPtr pBuf, int iBufLen);


        [DllImport("RecordDLL.dll")]
        public static extern int Initialize(STOREINFO struStoreInfo);

        [DllImport("RecordDLL.dll")]
        public static extern int Release();

        [DllImport("RecordDLL.dll")]
        public static extern int OpenChannelRecord(string strCameraid, IntPtr pHead, uint dwHeadLength);

        [DllImport("RecordDLL.dll")]
        public static extern bool CloseChannelRecord(int iRecordHandle);

        [DllImport("RecordDLL.dll")]
        public static extern int GetData(int iHandle, int iDataType, IntPtr pBuf, uint uiSize);

        #endregion

        //Éè±¸ÇøÓòÉèÖÃ
        public const int REGIONTYPE = 0;//´ú±íÇøÓò
        public const int MATRIXTYPE = 11;//¾ØÕó½Úµã
        public const int DEVICETYPE = 2;//´ú±íÉè±¸
        public const int CHANNELTYPE = 3;//´ú±íÍ¨µÀ
        public const int USERTYPE = 5;//´ú±íÓÃ»§

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOG_MATRIX
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;
            public uint dwMinorType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;
            public NET_DVR_IPADDR struRemoteHostAddr;
            public uint dwParaType;
            public uint dwChannel;
            public uint dwDiskNumber;
            public uint dwAlarmInPort;
            public uint dwAlarmOutPort;
            public uint dwInfoLen;
            public byte byDevSequence;//²ÛÎ»ºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;//MACµØÖ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//ÐòÁÐºÅ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN - SERIALNO_LEN - MACADDR_LEN - 1)]
            public string sInfo;
        }

        //ÊÓÆµ×ÛºÏÆ½Ì¨Èí¼þ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagVEDIOPLATLOG
        {
            public byte bySearchCondition;//ËÑË÷Ìõ¼þ£¬0-°´²ÛÎ»ºÅËÑË÷£¬1-°´ÐòÁÐºÅËÑË÷ 2-°´MACµØÖ·½øÐÐËÑË÷
            public byte byDevSequence;//²ÛÎ»ºÅ£¬0-79£º¶ÔÓ¦×ÓÏµÍ³µÄ²ÛÎ»ºÅ£»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//ÐòÁÐºÅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;//MACµØÖ·
        }

        [DllImportAttribute(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog_MATRIX(int iLogHandle, ref NET_DVR_LOG_MATRIX lpLogData);


        [DllImportAttribute(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog_Matrix(int iUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref tagVEDIOPLATLOG lpVedioPlatLog, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);
    }
}
