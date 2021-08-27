<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631843/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T398866)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Main.cs](./CS/SimpleHtmlEdit/Main.cs) (VB: [Main.vb](./VB/SimpleHtmlEdit/Main.vb))
* [Program.cs](./CS/SimpleHtmlEdit/Program.cs) (VB: [Program.vb](./VB/SimpleHtmlEdit/Program.vb))
<!-- default file list end -->
# How to show simple HTML text in cells


This sample illustrates how to implement a custom editor to visualize simple HTML. You can use HTML tags (e.g. &lt;b&gt;, &lt;i&gt;, &lt;u&gt;, &lt;s&gt;, &lt;href&gt;) to make your text more informative and interactive.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-show-simple-html-text-in-cells-t398866/17.2.3+/media/6e0b8bb0-41b3-11e6-80bf-00155d62480c.png"><br><br>The editor was inherited from TextEdit, which already allows drawing simple HTML strings. But, this capability is disabled in TextEdit. To implement it  in our custom editor, override TextEdit's <strong>AllowHtmlString</strong> property to return "true" all the time.<br>


```cs
public override bool AllowHtmlString { get { return true; } }
```


So now, our SimpleHtmlEdit can draw HTML strings. To make it more interactive, a few lines of code were added to handle the cursor's changing capability and open links in a browser.<br><br>See also:<br><a href="https://documentation.devexpress.com/#windowsforms/CustomDocument4874">HTML Text Formatting</a><br>General information about <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument4716">custom editors</a>


<h3>Description</h3>

<p>Starting from version 17.2, a new&nbsp;<strong>RepositoryItemHypertextLabel</strong>&nbsp;was added. This repository item should be used when it is necessary to show read-only HTML formatted text.&nbsp;</p>

<br/>


