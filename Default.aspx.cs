using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBoton_Click(object sender, EventArgs e)
    {
        var a = HttpContext.Current.Request.PhysicalApplicationPath + "Bin\\cpp_exe.exe";
        var processStartInfo = new ProcessStartInfo
        {
            FileName = a,
            Arguments = txtArgumentos.Text,
            RedirectStandardOutput = true,
            UseShellExecute = false
        };
        var process = Process.Start(processStartInfo);
        lblSalida.Text = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
    }
}