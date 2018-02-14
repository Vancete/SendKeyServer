# SendKeyServer
App to receive SendKey requests on a host machine from http requests

Te app start listening for http requests at port 7537, so you can make requests and keys will be emulated at the active window of the server machine.

For normal keys, like numbers and letters, you can point to:
http://destinationip:7537/n/A
...
http://destinationip:7537/n/Z
http://destinationip:7537/n/0
...
http://destinationip:7537/n/9

For special keys, you should point to:
http://destinationip:7537/s/F1
http://destinationip:7537/s/ENTER
http://destinationip:7537/s/TAB

Or any other keycode included here (without {}):
https://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.send%28v=vs.110%29.aspx
