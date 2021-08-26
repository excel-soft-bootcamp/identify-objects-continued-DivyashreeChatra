##State Management Types :

#Client-side Management
#Server-side Management

#Client-side Management:
1. View State:
 Viewstate is a very useful client side property.Viewstate stores any type of data and used for sending and receiving information.Viewstate is easy to apply and does not need access to any server resources. In a Viewstate, do not store big data, only store small values. Viewstate enables and disables on page level control. It also supports Encryption and Decryption and data/value is stored in hashed format. So we are not storing important data such as password, account information, etc. When more data is stored in this, then the page becomes heavy.
 2. Hidden field:
Hidden fields are used to store value to client side. Hidden field is not displayed on the browser, but it works on a request. This is non visual control in ASP.NET where you can save the value.
We do not show an ID value of table like ProductID, MemberID because users are not concerned with this kind of data. We store that information in HiddenFields and complete our process very easily.
3. Cookies:
Cookies are essentially pieces of code saved by websites onto the user’s web browser when a session is initiated. Cookies have a lot of uses but the most important ones are session management, user personalization, and tracking.The server can read cookies and abstract data.
4. Control State:
Control state technique is developed to maintain data work properly in order. We can use view state but suppose view state is disabled by the user, the control will not work as expected. For expected results of the control we have to use Control State. In application, the Viewstate is by default true. Sometimes we need to use custom control to manage application properly.
5. Query Strings:
Query string stores the value in URL.

##Server-side Management:
1. Session:
Session is a state management technique that is used to manage the state of a page or control throughout the application. So, using the session we can store the value and access it in another page or throughout the application.
2. Application State:
Application State is a server side management state. It is also called application level state management. In this mainly store user activity in server memory and application event shown in Global.asax file.Application variable is an object that is shared by the multiple sessions.