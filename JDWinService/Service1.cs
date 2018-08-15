using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Dal;
using JDWinService.Utils;
namespace JDWinService
{
    public partial class Service1 : ServiceBase
    {
        public Common common = new Common();
        public Service1()
        {
            InitializeComponent();
        }
        //轮询机制 从数据库层面获取数据 操作比平台方便
        System.Timers.Timer _timer = new System.Timers.Timer();
        private bool isRun = false;
        protected override void OnStart(string[] args)
        {
            try
            {
                int _interval = 5 * 1000;
                _timer.Interval = _interval;
                _timer.AutoReset = true;
                _timer.Enabled = true;
                _timer.Elapsed += new System.Timers.ElapsedEventHandler(ActionRun);  
                common.WriteLogs("服务已启动"); 
            
            }
            catch (Exception ex)
            {
                common.WriteLogs(ex.Message);
            }
        }

        private void ActionRun(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (!isRun)
                {
                    Server.ActionRun(ref isRun);
                }
            }
            catch (Exception ex)
            {
                common.WriteLogs("Error:"+ex.Message); 
            }
        }

        protected override void OnStop()
        {
            _timer.AutoReset = false;
            _timer.Enabled = false;
            _timer.Stop();
            common.WriteLogs("服务已停止");
           
        }
    }
}
