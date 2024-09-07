# ExplorerOpen

This is a simple program I made out of necessity to use for a project I was involved in.

It allows you to open a windows explorer window in a predetermined path by clicking on a link.

It works by installing an executable to open the explorer and some registry keys so that you can call the program from a custom browser protocol.
Windows only.

Syntax:<br/>
**openexplorer:\<path\>**

When you try to open a link to a url like this on a browser, it will run the program and try to open a file explorer with the path specified on the link.
Works differently depending on the browser.

Examples:<br/>
**openexplorer:C:\users\youruser\desktop**<br/>
**openexplorer:\\\\server\serverfolder**
