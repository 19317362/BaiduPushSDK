﻿using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_9_创建标签组 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string tag = "basketball";

        App_Create_Tag_Mod qtm = new App_Create_Tag_Mod(apikKey, tag);
        App_Create_Tag qt = new App_Create_Tag(secretKey, qtm);
        string result = qt.PushMessage();
        Response.Write(result);
    }
}