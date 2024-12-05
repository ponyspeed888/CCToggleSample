# CCToggleSample

CCToggle is a package that act like a conditional compilation for non language files like xml, xaml, razor.
It does so by by comment/uncomment section of code depend on whether a conditional compilation is defined or not

A CCToggle is defined as (for xml):

<!--@@if yoursymbol-->


<!--@@else-->


<!--@@endif-->

Please change the comment start/end depend on your file type.  Do not add any white space

To see what are changed for cctoggle in the sample project, search for @@if string in the files


How to use :

Install cctoggle package
Modify Directory.Build.targets to specify files containing cctoggle
Add cctoggle comment block to those files
Set/unset your conditional compilation symbol
