# CCToggleSample

CCToggle is a package that act like a conditional compilation for non language files like xml, xaml, razor.
It does so by by comment/uncomment section of code depend on whether a conditional compilation is defined or not

A CCToggle is defined as (for xml):


	<!--@@if yoursymbol-->
	
	
	<!--@@else-->


	<!--@@endif-->

Please change the comment start/end depend on your file type.

To see what are changed for cctoggle in the sample project, search for @@if string in the files


How to use :

The development of the package ponyspeed888.MSBuildTasks.ccToggle is paused, due to difficulty in single project
     multi-targeting MAUI project type, which is a important use case.  Sample targets file and dlls should be copied
	  from MyPackageContent in the WpfCore Sample project
Move the file MyPackageContent\Directory.Build.targets to project root
For MAUI project, Move the file MyPackageContent\Directory.Build.targets.Maui to project root and remove .Maui extension
Modify Directory.Build.targets to specify files to be processed by ccToggle (ccfiles property)
Add cctoggle comment blocks to those files
Set/unset your conditional compilation symbol

Important note for MAUI project : Because of the multi-targeting natural of MAUI, ccToggle task can not read defined
  CC symbols, so you have to defined it manually using Const="ANDROID;A;B" task attribute, and set BeforeTargets="BeforeCompile"
  Unfortunately, this mean that when you switch build between mobile and desktop, you have to update the Const="xxx"
  manually.


Limitaions :

Current version does not support nesting. If support only if else endif, it does NOT support if endif, nor if elseif elsif endif
The content with if or else must be property content of the corresponding file. For example
Each of the if, else block must be in separate lines


<!--@@if jy1-->
        <Button Content="jy1 true" />
<!--@@else-->
        <Button Content="jy1 false" />
<!--@@endif-->

works, while

<Button 
<!--@@if jy1-->
        Content="jy1 true" 
<!--@@else-->
        Content="jy1 false" 
<!--@@endif-->

/>

does not work

