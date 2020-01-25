# Anti-DebugNET
 C# Anti-Debug and Anti-Dumping techniques using Win32/NT API functions.
 There are certain functions/methods like the anti-dump that were created by other people.
 
## Current Anti-Debug methods
* Check for managed debugger
* Check for unmanaged debugger
* Check for remote debugger
* Check debug port
* Detach from debugger process
* Check for kernel debugger
* Hides current process OS thread ( managed threads soon )
* Scan and Kill debuggers (ollydbg, x32dbg, x64dbg, Immunity, MegaDumper, etc)

## Current Anti-Dump methods
* Erase sections - WARNING! It breaks applications which are obfuscated.

## Notes
* You can use these tricks to protect your C# application, however make sure you obfuscate the code. And make no mistake, a skilled reverse engineer will easily bypass these tricks unless used properly. (see tips)
* Do not forget to remove the Console logs before simply copy/pasting files into your project ;)
 
## Tips
* Avoid taking an immediate action, like displaying a message or crashing the application. If you take an immediate action, the cracker will know where the problematic code is located and will focus all his attention at that point, trying to figure out the root of the problem in that code.
* Avoid displaying messages saying that the application has been tampered. Instead, make a "late" crash (see below) or display a strange error message at a later point in your application.
* Produce a "late crash" or malfunction. That is, if you detect that your application has been tampered, you mark special variables (or similar action) in your code. At a later point in your application, you crash your application or initialize further structures in a wrong way, so, your application won't work as expected.

## Contribution
 Feel free to contribute with your own functions/methods. Just make sure you tested it properly.

## Assistance
 In your are in immediate need of commercial help/advice/assistance in protecting your .NET application, I can offer you my assistance for a small fee.
 Please do contact me via my email or if you cannot do so open an issue.
 
## Support me
 Buy me a coffee to give me more energy and write more code :)
 [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](paypal.me/NBoros1337)
