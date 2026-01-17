# WinFormsAppDemo - 现代化 .NET 8 WinForms 开发模板

这是一个基于 **.NET 8.0** 和 **SunnyUI** 的 Windows Forms 桌面应用程序开发模板。它预置了企业级应用所需的关键基础设施，旨在帮助开发者快速启动项目。

## ✨ 核心特性

*   **现代化 UI**: 深度集成 [SunnyUI](https://gitee.com/yhuse/SunnyUI)，提供扁平化、美观的控件库和主题系统。
*   **分层架构**: 清晰分离 `Forms` (UI), `Services` (业务逻辑), `Models` (数据模型)。
*   **依赖注入 (DI)**: 使用 `Microsoft.Extensions.DependencyInjection` 管理服务生命周期。
*   **ORM 集成**: 内置 [SqlSugar](https://www.donet5.com/Home/Doc) (支持 SQLite/MySQL/SQLServer)，实现高效数据访问。
*   **多语言支持**: 基于 JSON 文件的轻量级国际化 (I18n) 方案，支持运行时热切换。
*   **配置管理**: 支持 `appsettings.json` 配置。

## 📂 目录结构

```text
WinFormsAppDemo/
├── 📂 Common/               # 基础设施 (如 LocalizationManager)
├── 📂 Forms/                # UI 界面
│   ├── 📂 Pages/            # 子页面 (用户控件，嵌入主窗口)
│   ├── LoginForm.cs        # 登录窗口
│   ├── MainForm.cs         # 主窗口框架
│   └── UserEditForm.cs     # 模态对话框示例
├── 📂 Models/               # 数据库实体类
├── 📂 Resources/            # 静态资源 & 语言包 (JSON)
├── 📂 Services/             # 业务逻辑层
├── Program.cs              # 程序入口 (DI 容器配置)
└── appsettings.json        # 配置文件
```

## 🚀 快速上手

1.  **环境要求**: Visual Studio 2022, .NET 8 SDK。
2.  **构建**: 打开解决方案，还原 NuGet 包并编译。
3.  **运行**: 启动项目，默认会自动生成 SQLite 数据库文件 `bin/.../app.db`。默认账号: `admin`, 密码: `123456`。

---

## 📖 详细开发指南

### 1. 如何添加新页面 (Page)

本模板使用 `UIPage` + `UITabControl` 的方式进行导航。假设你要添加一个 **"产品管理" (ProductPage)** 页面：

#### 第一步：创建页面文件
1.  在 `Forms/Pages` 目录下新建 **用户控件 (UserControl)**，命名为 `ProductPage.cs`。
2.  修改代码继承自 `UIPage` (需引用 `Sunny.UI`)，并支持依赖注入：

```csharp
using Sunny.UI;
using WinFormsAppDemo.Common;

namespace WinFormsAppDemo.Forms.Pages
{
    // 继承自 UIPage
    public partial class ProductPage : UIPage
    {
        private readonly LocalizationManager _localization;

        // 支持构造函数注入服务
        public ProductPage(LocalizationManager localization)
        {
            InitializeComponent();
            _localization = localization;
            
            // 建议：在此处订阅语言变更事件
        }
    }
}
```

#### 第二步：注册到依赖注入容器
打开 `Program.cs`，在 `ConfigureServices` 方法中注册新页面：

```csharp
services.AddTransient<ProductPage>();
```

#### 第三步：配置导航菜单
打开 `Forms/MainForm.cs`，找到 `InitNavigation` 方法，添加菜单节点并关联页面：

```csharp
// 1. 在 MainForm 构造函数参数中添加新页面的依赖
// public MainForm(..., ProductPage productPage) { ... }

// 2. 添加到页面容器
pageContainer.AddPage(productPage);

// 3. 创建左侧菜单节点
// 参数: 菜单显示文本, 图标(FontAwesome ID), 图标大小, 页面索引(PageIndex)
// 注意: PageIndex 必须全局唯一，建议从 100x 开始递增
var node = NavMenu.CreateNode("产品管理", 61451, 24, 1003); 
```

### 2. 如何添加多语言支持

1.  打开 `Resources/lang-zh-CN.json` 和 `lang-en-US.json`。
2.  添加对应的键值对：
    ```json
    // zh-CN
    "ProductManagement": "产品管理"
    
    // en-US
    "ProductManagement": "Products"
    ```
3.  在代码中使用：
    ```csharp
    _localization.GetString("ProductManagement")
    ```

### 3. 如何操作数据库

1.  在 `Models` 文件夹定义实体类 (使用 SqlSugar 特性)：
    ```csharp
    [SugarTable("Products")]
    public class Product
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
    ```
2.  在 `Services` 文件夹创建 `ProductService`。
3.  在 `Program.cs` 中注册 Service。
4.  在 UI 中注入并使用 Service。

## 💡 常见问题

*   **Q: 编译报错 "UIStyle 无法转换为 bool"**
    *   A: 请检查 `UIMessageBox.Show` 的参数。`ShowAsk` 等方法不需要传递 `UIStyle`，且不再支持部分旧版重载。请参考 `UserManagementPage.cs` 中的最新写法。