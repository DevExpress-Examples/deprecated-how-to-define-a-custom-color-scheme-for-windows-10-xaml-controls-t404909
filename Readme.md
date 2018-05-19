# [Deprecated] How to define a custom Color Scheme for Windows 10 XAML controls


<p>Starting with <strong>v17.1</strong>, we provide a more powerful and flexible way of overriding predefined colors. Refer to the updated example for more information: <a href="https://www.devexpress.com/Support/Center/p/T510124">T510124 - How to define a custom Color Scheme for Windows 10 XAML controls</a>.<br><br><br>This example illustrates how to implement a custom Color Scheme and use it in your application. In the current implementation, the application supports two themes (Generic and Custom), which can be changed by using the corresponding ComboBox. <br><br>The <strong>Custom </strong>theme is defined as a separate ResourceDictionary with the corresponding value in the x:Key property. This ResourceDictionary is declared within a separate file and then used in the <strong>Source </strong>property of the <strong>GlobalColorSchemeOverrider</strong> class.<br><br>All colors available for overriding are listed in separate files within the installation folder with our controls: <DevExpress Installation Folder><strong><u>\Components\System\UAP\ColorThemes</u></strong></p>

<br/>


