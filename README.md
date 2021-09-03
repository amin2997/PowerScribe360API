# PowerScribe360API

This is a REST API implementation for Radiology Nuance PowerScribe 360 dictation system. This API will allow you to send and retrieve data points into pre-built custom fields that populates radiologist final report. For example, you can push radiation dose information into custom field that will populate the radiologist final report.

## Installation Options

1. Import nuget to your project

[https://www.nuget.org/packages/PowerScribe360Api/](https://www.nuget.org/packages/PowerScribe360Api/)
```
Install-Package PowerScribe360Api -Version 1.0.0
```

2. Clone GitHub code
```
cd folder/to/clone-into/ 
git clone https://github.com/amin2997/PowerScribe360API.git
```
3. Download GitHub Zip
https://codeload.github.com/amin2997/PowerScribe360API/zip/master



## Sample Implementation

The following will allow you to connect to PowerScribe 360 server and send custom field to the radiologist report.
``` csharp
static void Main()
{
	using(PowerScribe360Api.Powerscribe ps360 = new PowerScribe360Api.Powerscribe("http://ps360/RadPortal"))
	{
		if(ps360.SignIn("username", "***password***"))
		{
			Console.WriteLine("Connectd to PS360 server");
			
			string accessionNumber = "123546";
			string customFieldName = "CT_RAD_DOSE";
			string customFieldValue = "501";
			
			if(ps360.SetCustomField(accessionNumber, customFieldName, customFieldValue))
			{
				Console.WriteLine("Data was sent successfully to PS360");
			}
			else
			{
				Console.WriteLine("Error sending data to PS360");
			}

			ps360.SignOut();
		}
		else
		{
			Console.WriteLine("Error Unable  to connect to PS360 Server.");
		}				
	}
}		
	
```

For further details please refer to the test file and sample application.

API Test Code:
[https://github.com/amin2997/PowerScribe360API/blob/master/PowerScribe360ApiTests/PowerscribeTests.cs](https://github.com/amin2997/PowerScribe360API/blob/master/PowerScribe360ApiTests/PowerscribeTests.cs)

Sample App Code:
[https://github.com/amin2997/PowerScribe360API/blob/master/PowerScribe360SampleApp/Form1.cs](https://github.com/amin2997/PowerScribe360API/blob/master/PowerScribe360SampleApp/Form1.cs)
