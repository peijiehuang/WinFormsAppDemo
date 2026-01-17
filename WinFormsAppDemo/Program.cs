using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Sunny.UI;
using WinFormsAppDemo.Forms;
using WinFormsAppDemo.Services;
using WinFormsAppDemo.Common;

namespace WinFormsAppDemo
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            // 全局设置 SunnyUI 配色
            UIStyles.SetStyle(UIStyle.Purple);

            // 初始化多语言
            var loc = ServiceProvider.GetRequiredService<LocalizationManager>();
            loc.LoadLanguage("zh-CN");

            // 循环运行实现注销功能
            while (true)
            {
                // 运行登录窗口
                var loginForm = ServiceProvider.GetRequiredService<LoginForm>();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    break; // 用户关闭登录窗口或取消登录
                }

                // 运行主窗口
                var mainForm = ServiceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);

                // 如果主窗口返回 Retry，说明是注销，继续循环
                if (mainForm.DialogResult != DialogResult.Retry)
                {
                    break; // 用户正常关闭主窗口
                }
            }
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    // 注册服务
                    services.AddSingleton<DatabaseService>();
                    services.AddSingleton<UserService>();
                    services.AddSingleton<LocalizationManager>();
                    
                    // 注册窗体
                    services.AddTransient<LoginForm>();
                    services.AddTransient<MainForm>();
                });
    }
}
