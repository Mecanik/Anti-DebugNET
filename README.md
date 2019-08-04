# Anti-DebugNET
 C# Anti-Debug and Anti-Dumping techniques using Win32 API functions.
 There are certain functions/methods like the anti-dump that were created by other people.
 
## Current Anti-Debug methods
* Check for managed debugger
* Check for unmanaged debugger
* Check for remote debugger
* Check debug port
* Detach from debugger process
* Check for kernel debugger
* Hides current process OS thread ( managed threads soon )

## Current Anti-Dump methods
* Erase sections

## Notes
 You can use these tricks to protect your C# application, however make sure you obfuscate the code. And make no mistake, a skilled reverse engineer will easily bypass these tricks.
 
## Contribution
 Feel free to contribute with your own functions/methods. Just make sure you tested it properly.