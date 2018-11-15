<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/SimpleHtmlEdit/Form1.cs) (VB: [Form1.vb](./VB/SimpleHtmlEdit/Form1.vb))
* [Program.cs](./CS/SimpleHtmlEdit/Program.cs) (VB: [Program.vb](./VB/SimpleHtmlEdit/Program.vb))
* [SimpleHtmlEdit.cs](./CS/SimpleHtmlEdit/SimpleHtmlEdit.cs) (VB: [SimpleHtmlEdit.vb](./VB/SimpleHtmlEdit/SimpleHtmlEdit.vb))
<!-- default file list end -->
# How to show simple HTML text in cells


This sample illustrates how to implement a custom editor to visualize simple HTML. You can use HTML tags (e.g. &lt;b&gt;, &lt;i&gt;, &lt;u&gt;, &lt;s&gt;, &lt;href&gt;) to make your text more informative and interactive.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-show-simple-html-text-in-cells-t398866/16.1.4+/media/6e0b8bb0-41b3-11e6-80bf-00155d62480c.png"><br><br>The editor was inherited from TextEdit, which already allows drawing simple HTML strings. But, this capability is disabled in TextEdit. To implement it  in our custom editor, override TextEdit's <strong>AllowHtmlString</strong> property to return "true" all the time.<br>


```cs
public override bool AllowHtmlString { get { return true; } }
```


So now, our SimpleHtmlEdit can draw HTML strings. To make it more interactive, a few lines of code were added to handle the cursor's changing capability and open links in a browser.<br><br>See also:<br><a href="https://documentation.devexpress.com/#windowsforms/CustomDocument4874">HTML Text Formatting</a><br>General information about <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument4716">custom editors</a>

<br/>


