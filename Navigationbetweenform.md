# Navigation through Webforms
There are several techniques to navigate between webforms:
## 1. Hyperlink Control:<br>
* A control that displays a link to another Web page.
* The page you want to navigate to is specified by **NavigateURL** property.The hyperlink control is rendered as an HTML anchor tag.
* The hyperlink control does not expose any server side events.
### Example:<br>
<asp:HyperLink id="hyperlink1" ImageUrl="images/pict.jpg" NavigateUrl="https://docs.microsoft.com/en-us/documentation/" Text="Microsoft Official Site" Target="_new" runat="server"/>

## 2. Response.Redirect:<br>
* Response.Redirect() can be used to navigate pages/websites on the same page or on different web server .
* Response.Redirect() causes 2 request/response cycle.<br>
In button click event,call Response.Redirect(),
When user clicks button ,the webserver receives,a request for redirection.The server then sends a response header to the client.The client then automatically issues a new GET request to the webserver.The webserver then serve the new page.
* Response.Redirect causes 2 request/response cycle. 
### Example:<br>
protected void Button1_Click(object sender, EventArgs e)  
{  
  Response.Redirect("updateinfo.aspx");<br>
} 

## 3. Server.Transfer:<br>
* Server.Transfer() is used to navigate to other pages/website running on same web server.
* Server.Transfer() is used to End the current weform and begin executing a new webform. 
* Server.Transfer() can not be used to navigate to sites/pages on different web server. 
* It doesnot change the URL on address bar . Contains one Request/Response cycle.
### Example:<br>
protected void Button1_Click(object sender, EventArgs e)  
{  
  Server.Transfer("updateinfo.aspx");<br>
} 

## 4. Server.Execute:<br>
* Server.Transfer() is used to navigate to other pages/website running on same web server.
* Server.Transfer() is used to End the current weform and begin executing a new webform.
* Server.Transfer() can not be used to navigate to sites/pages on different web server. 
* It doesnot change the URL on address bar . Contains one Request/Response cycle.
### Example:<br>
protected void Button1_Click(object sender, EventArgs e)  
{  
  Server.Execute("updateinfo.aspx");<br>
} 

## 5. Cross-Page postback:<br>
* Server.Execute() is used to begin executing a new webform while still displaying the current web form . The contents of both forms are combined.
*  To use cross-page posting, you have to use the "postBackUrl" attribute to specify the page we want to post.


## 6. Window.Open:<br>
* Window.Open() is used to open a webform in an new window.
* Syntax: window.open(URL,name,features,replace)
### Example:<br>
<asp:linkbutton id="lnkBtn" runat="server" text="linkmeButton" onclientclick="window.open('Default2.aspx')"></asp:linkbutton>

