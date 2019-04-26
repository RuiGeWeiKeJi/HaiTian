using System;
using Smobiler . Core;
namespace CodeSan . Layer
{
    partial class SmobilerFormAbout : SmobilerFormBaseBack
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose ( bool disposing )
        {
            base . Dispose ( disposing );
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System . Diagnostics . DebuggerStepThrough ( )]
        private void InitializeComponent ( )
        {
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // label1
            // 
            this.label1.FontSize = 17F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(83, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.Text = "关于我们";
            // 
            // label2
            // 
            this.label2.FontSize = 17F;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 164);
            this.label2.Text = "定制：杭州瑞阁微科技有限公司\r\n\r\n使用：杭州华大海天科技有限公司\r\n\r\n     Tel：(0571)86961522\r\nEmail：my_rgw@163.co" +
    "m";
            // 
            // SmobilerFormAbout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2});
            this.Name = "SmobilerFormAbout";

        }
        #endregion

        private Smobiler . Core . Controls . Label label1;
        private Smobiler . Core . Controls . Label label2;
    }
}