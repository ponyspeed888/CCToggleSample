# CCToggleSample

Update log 

2025/07/24 : Update MAUI Directory.Build.targets, so that you can run it manually



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
Directory.Build.targets for MAUI project is very different from one in wpf project
Modify Directory.Build.targets to specify files to be processed by ccToggle (Lines after <!--Change Below)
Add cctoggle comment blocks to those files
Set/unset your conditional compilation symbol

Important note for MAUI project : Because of the multi-targeting natural of MAUI, ccToggle task can not read defined
  CC symbols, so you have to defined it manually using AndroidSymbols or WindowsSymbols.
  Unfortunately, I have only Android and Windows build target in my PC, so for the MAUI project, I only provide Android and
     Windows in Directory.Build.targets, you have to add other platform to the code yourself



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

