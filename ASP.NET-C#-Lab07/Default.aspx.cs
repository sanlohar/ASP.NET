﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    public void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
         udcNameAndAddress.MakeVisible(CheckBox1.Checked);
    }
            
        
        
    

    

    

    

}
