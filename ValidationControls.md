# Validation Controls
   ### ASP.NET validation controls define an important role in validating the user input data. Whenever the user gives the input, it must always be validated before sending it across to various layers of an application. If we get the user input with validation, then chances are that we are sending the wrong data. So, validation is a good idea to do whenever we are taking input from the user.

   There are the following two types of validation in ASP.NET:
1. Client-Side Validation
2. Server-Side Validation

### Client-Side Validation:<br>
When validation is done on the client browser, then it is known as Client-Side Validation. We use JavaScript to do the Client-Side Validation. Client-Side Validation is responsive and quick for end users, but not a secure form of validation. Client-Side Validation is faster, typically looks good, often association among messages and input.

### Server-Side Validation:<br>
When validation occurs on the server, then its known as Server-Side Validation. Server-Side Validation is a secure form of validation. The main advantage of Server-Side Validation is that if the user somehow bypasses the Client-Side Validation, we can still catch the problem on server-side. Server-side provides more security and ensures that no invalid data is processed by the application. Server-Side Validation is done by writing the custom logic for validating all the input.

The following are the Validation Controls in ASP.NET:

1. RequiredFieldValidator Control
2. CompareValidator Control
3. RangeValidator Control
4. RegularExpressionValidator Control
5. CustomFieldValidator Control
6. ValidationSummary

## RequiredFieldValidator Control:<br>
Required Field Validator control is used to make the input field a required field in the application. The control raises an error if the input value is not entered by the user. By default, the initial value is an empty string.<br>
Example:<br>
<asp:Label ID=”Label1” runat=”server” Text=”Name” ></asp:Label><br>
<asp:TextBox ID=”TextBox1” runat=”server”></asp:TextBox><br>
<asp:RequiredFieldValidator ID=”RequiredFieldValidator1” runat=”server” ControlToValidate=”TextBox1” ErrorMessage=”Values are must” BackColor=”Red”>
</asp:RequiredFieldValidator><br>
<asp:Button ID=”Button1” runat=”server” Text=”Show” />
  
## CompareValidator Control:<br>
The Compare Validator is used to compare the values of one input control to the another input control or to a fixed value. If the input control value is empty then no validation occurs.<br>
Example:<br>
 <asp:Label ID=”Label1” runat=”server” Text=”Number1” ></asp:Label><br>
       <asp:TextBox ID=”TextBox1” runat=”server”></asp:TextBox><br/>
       <asp:Label ID=”Label2” runat=”server” Text=”Number2” ></asp:Label><br>
       <asp:TextBox ID=”TextBox2” runat=”server”></asp:TextBox><br/>
       <asp:CompareValidator ID=”CompareValidator1” runat=”server” ErrorMessage=”Values     
are not equal“ ControlToCompare=”TextBox2” ControlToValidate=”TextBox1” Type=”Integer” Operator=”Equal” BackColor=”Pink” >
       </asp:CompareValidator>
       <br/>
       <asp:Button ID=”Button1” runat=”server” Text=”Show” />

## RangeValidator Control:<br>
 The Range Validator control is used to check that the user enters an input between two values. User can check between numbers, dates and characters. The control will not fail if the input value is not converted to the specific type.<br>
 Example:<br>
<asp:Label ID=”Label1” runat=”server” Text=”Age” ></asp:Label><br>
<asp:TextBox ID=”TextBox1” runat=”server”></asp:TextBox><br/>
<asp:RangeValidator ID=”RangeValidator1” runat=”server” ErrorMessgae=”Values are not in the specified range” ControlToValidate=”Textbox1” Type=”Integer” MinimumValue=”18” MaximumValue=”25” BackColor=”Aqua” >
</asp:RangeValidator>
 <br/>
<asp:Button ID=”Button1” runat=”server” Text=”Show” />

## RegularExpressionValidator Control:<br>
The Regular Expression validator control is used to ensure that an input value matches a specifies pattern. It is useful for checking email address, phone numbers, zip codes,etc. The validation will not fail is the input control is empty.<br>
Example:<br>
  <asp:Label ID=”Label1” runat=”server” Text=”Email address”></asp:Label><br>
      <asp:TextBox ID=”TextBox1” runat=”server”></asp:TextBox><br>
      <asp:RegularExpressionValidator ID=”RegularExpressionValidator1” runat=”server” 
      ControlToValidate=”TextBox1” ErrorMessage=”Email is not in correct format” BackColor=”Blue” ValidationExpression=”\w+([-+.’]\w+)*@\w+([-.])\w+([-.]\w+)*” >
      </asp:RegularExpressionValidator>
      <br/>
      <asp:Button ID=”Button1” runat=”server” Text=”Show” />

## CustomFieldValidator Control:<br>
The custom validator allows the user to write a method to handle the validation of the value entered. It is used to compare the users input to a value in the database or the arithmetic validations for the controls.<br>
Example:<br>
  <asp:Label ID=”Label1” runat=”server” Text=”Name” ></asp”Label><br>
    <asp:TextBox ID=”TextBox1” runat=”server”></asp:TextBox><br/>
    <asp:CustomValidator ID=”CustomValidator1” runat=”server” ErrorMessage=”Value entered is incorrect” ControlToValidate=”TextBox1” BackColor=”Aqua” OnServerValidate=”CustomValidate_value” >
    </asp:CustomValidator><br>
    <asp:Button ID=”btn1” runat=”server” Text=”Show” />

## ValidationSummary:<br>
The Validation Summary control is used to display the summary of all validation errors in a web page. The error message displayed in this control is specified by the Error Message property for every validation control. The summary can be displayed as a list, bulleted list, single paragraph depending on the DisplayMode property.<br>
Example:<br>
 <asp:Label ID=”Label1” runat=”server” Text=”Email address”></asp:Label><br>
    <asp:TextBox ID=”TextBox1” runat=”server”></asp:TextBox><br>
    <asp:RegularExpressionValidator ID=”RegularExpressionValidator1” runat=”server” ControlToValidate=”TextBox1” ErrorMessage=”Email is not in correct format” BackColor=”Blue” ValidationExpression=”\w+([-+.’]\w+)*\.\w+([ -. ] \w+)*” >
    </asp:RegularExpressionValidator>
    <br/>
    <asp:Label ID=”Label2” runat=”server” Text=”Course” ></asp:Label><br>
    <asp:TextBox ID=”TextBox2” runat=”server” ></asp:TextBox>
    <br/>
    <asp:RequiredFieldValidator ID=”RequiredFieldValidator1” runat=”server” ControlToValidate=”TextBox2” BackColor=”Red” ErrorMessage=”Values should be present” >
    </asp:RequiredFieldValidator>
    <br/>
    <asp:ValidationSummary ID=”ValidationSummary1” runat=”server” /><br>
    <asp:Button ID=”Button1” runat=”server” Text=”Show” />
