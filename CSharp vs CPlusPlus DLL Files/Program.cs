using System;

//ref link:https://www.youtube.com/watch?v=XrOCRem4g_A&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=11
//Creating/Adding Reference Assemblies: MeFarm.dll

// C# --csc--> MSIL --jit--> NATIVE INSTRUCTION
// C++(textFiles) --cl(CompileAndLink)--> Native Instruction
// In C++ classes are gone, but functions is there for procedures

// Dynamic Linking - the code is in the DLL file
// Library File for C++ - a linker for metadata for the DLL

//Creating DLL is native CPU code

/*-----------------------------CMD: MeFarm.dll------------------------------------------------
 * 
C:\Users\sunny\source\repos\DotNet Self Describing Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Self Describing Assemblies

24/09/2023  02:06 am    <DIR>          .
24/09/2023  02:06 am    <DIR>          ..
24/09/2023  02:06 am             2,581 .gitattributes
24/09/2023  02:06 am             6,585 .gitignore
24/09/2023  02:08 am    <DIR>          DotNet Self Describing Assemblies
24/09/2023  02:03 am             1,205 DotNet Self Describing Assemblies.sln
               3 File(s)         10,371 bytes
               3 Dir(s)  490,454,515,712 bytes free

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies>cd DotNet Self Describing Assemblies

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies

24/09/2023  02:08 am    <DIR>          .
24/09/2023  02:08 am    <DIR>          ..
24/09/2023  02:03 am               189 App.config
24/09/2023  02:03 am    <DIR>          bin
24/09/2023  02:03 am             2,416 DotNet Self Describing Assemblies.csproj
24/09/2023  02:03 am    <DIR>          obj
24/09/2023  02:08 am               261 Program.cs
24/09/2023  02:03 am    <DIR>          Properties
               3 File(s)          2,866 bytes
               5 Dir(s)  490,454,515,712 bytes free

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>erase *.*
C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies\*.*, Are you sure (Y/N)? y

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies

24/09/2023  02:09 am    <DIR>          .
24/09/2023  02:09 am    <DIR>          ..
24/09/2023  02:03 am    <DIR>          bin
24/09/2023  02:03 am    <DIR>          obj
24/09/2023  02:03 am    <DIR>          Properties
               0 File(s)              0 bytes
               5 Dir(s)  490,454,233,088 bytes free

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies

24/09/2023  02:09 am    <DIR>          .
24/09/2023  02:09 am    <DIR>          ..
24/09/2023  02:03 am    <DIR>          bin
24/09/2023  02:03 am    <DIR>          obj
24/09/2023  02:09 am               261 Program.cs
24/09/2023  02:03 am    <DIR>          Properties
               1 File(s)            261 bytes
               5 Dir(s)  490,453,938,176 bytes free

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>csc /t:library /out:MeFarm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies

24/09/2023  02:13 am    <DIR>          .
24/09/2023  02:13 am    <DIR>          ..
24/09/2023  02:03 am    <DIR>          bin
24/09/2023  02:13 am             4,096 MeFarm.dll
24/09/2023  02:03 am    <DIR>          obj
24/09/2023  02:10 am             3,438 Program.cs
24/09/2023  02:03 am    <DIR>          Properties
               2 File(s)          7,534 bytes
               5 Dir(s)  490,450,075,648 bytes free

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>ildasm /out:moo.txt MeFarm.dll

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>moo.txt
-----------------------------NOTEPAD: moo.txt-------------------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly MeFarm
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module MeFarm.dll
// MVID: {651F3527-A988-4B95-8FB1-6B9FAFB492EF}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06A30000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class public auto ansi beforefieldinit Farm
       extends [mscorlib]System.Object
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Farm::.ctor

} // end of class Farm

.class public sequential ansi sealed beforefieldinit Cow
       extends [mscorlib]System.ValueType
{
  .pack 0
  .size 1
} // end of class Cow

.class public auto ansi sealed Donkey
       extends [mscorlib]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(object 'object',
                               native int 'method') runtime managed
  {
  } // end of method Donkey::.ctor

  .method public hidebysig newslot virtual 
          instance void  Invoke() runtime managed
  {
  } // end of method Donkey::Invoke

  .method public hidebysig newslot virtual 
          instance class [mscorlib]System.IAsyncResult 
          BeginInvoke(class [mscorlib]System.AsyncCallback callback,
                      object 'object') runtime managed
  {
  } // end of method Donkey::BeginInvoke

  .method public hidebysig newslot virtual 
          instance void  EndInvoke(class [mscorlib]System.IAsyncResult result) runtime managed
  {
  } // end of method Donkey::EndInvoke

} // end of class Donkey

.class public auto ansi sealed Chicken
       extends [mscorlib]System.Enum
{
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype Chicken Eggs = int32(0x00000000)
} // end of class Chicken

.class public auto ansi beforefieldinit Bacon
       extends [mscorlib]System.Object
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Bacon::.ctor

} // end of class Bacon


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file moo.res


-----------------------------NOTEPAD: moo.txt-------------------------------------END
-----------------------------CMD: MeFarm.dll------------------------------------------END

---------------------------CMD: C# vs C++------------------------------------------
C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files

24/09/2023  02:35 am    <DIR>          .
24/09/2023  02:35 am    <DIR>          ..
24/09/2023  02:35 am             2,581 .gitattributes
24/09/2023  02:35 am             6,585 .gitignore
24/09/2023  02:45 am    <DIR>          CSharp vs CPlusPlus DLL Files
24/09/2023  02:33 am             1,193 CSharp vs CPlusPlus DLL Files.sln
               3 File(s)         10,359 bytes
               3 Dir(s)  490,391,449,600 bytes free

C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files>cd CSharp vs CPlusPlus DLL Files

C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files\CSharp vs CPlusPlus DLL Files>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files\CSharp vs CPlusPlus DLL Files

24/09/2023  02:45 am    <DIR>          .
24/09/2023  02:45 am    <DIR>          ..
24/09/2023  02:33 am               189 App.config
24/09/2023  02:33 am    <DIR>          bin
24/09/2023  02:35 am             2,573 CSharp vs CPlusPlus DLL Files.csproj
24/09/2023  02:45 am               198 MyCPlusPlus.cpp
24/09/2023  02:45 am                85 MyCPlusPlus.h
24/09/2023  02:33 am    <DIR>          obj
24/09/2023  02:34 am            11,544 Program.cs
24/09/2023  02:33 am    <DIR>          Properties
               5 File(s)         14,589 bytes
               5 Dir(s)  490,391,449,600 bytes free

////////---------------CREATING DLL FOR C++-------------------------////////////
--------------------the difference of C++ to C# is C++ is all native-------------
-----------cmd type---------------
cl -- compile and link
/LD -- create a DLL(maybe LD means LINKDLL)
/link; -- linking files

----------------------------------
C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files\CSharp vs CPlusPlus DLL Files>cl /LD MyCPlusPlus.cpp
Microsoft (R) C/C++ Optimizing Compiler Version 19.37.32824 for x86
Copyright (C) Microsoft Corporation.  All rights reserved.

MyCPlusPlus.cpp
C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Tools\MSVC\14.37.32822\include\ostream(780): warning C4530: C++ exception handler used, but unwind semantics are not enabled. Specify /EHsc
MyCPlusPlus.cpp(7): note: see reference to function template instantiation 'std::basic_ostream<char,std::char_traits<char>> &std::operator <<<std::char_traits<char>>(std::basic_ostream<char,std::char_traits<char>> &,const char *)' being compiled
Microsoft (R) Incremental Linker Version 14.37.32824.0
Copyright (C) Microsoft Corporation.  All rights reserved.

/out:MyCPlusPlus.dll
/dll
/implib:MyCPlusPlus.lib
MyCPlusPlus.obj
   Creating library MyCPlusPlus.lib and object MyCPlusPlus.exp

C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files\CSharp vs CPlusPlus DLL Files>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files\CSharp vs CPlusPlus DLL Files

24/09/2023  03:06 am    <DIR>          .
24/09/2023  03:06 am    <DIR>          ..
24/09/2023  02:33 am               189 App.config
24/09/2023  02:33 am    <DIR>          bin
24/09/2023  02:50 am             2,688 CSharp vs CPlusPlus DLL Files.csproj
24/09/2023  02:53 am             4,096 MeFarm.dll
24/09/2023  02:54 am               644 moo.res
24/09/2023  02:54 am             6,318 moo.txt
24/09/2023  02:45 am               198 MyCPlusPlus.cpp
24/09/2023  03:05 am           159,744 MyCPlusPlus.dll  <---- has native instructions(dynamic linking) //(recommend knowledge in dynamic and static linking)
24/09/2023  03:05 am             1,198 MyCPlusPlus.exp
24/09/2023  02:45 am                85 MyCPlusPlus.h    <---- MetaData in textual form(only exist in Compiler lever not in Native level)
24/09/2023  03:05 am             2,514 MyCPlusPlus.lib  <---- lib file,  a linker for metadata for the DLL
24/09/2023  03:05 am            78,901 MyCPlusPlus.obj  <----C++ compiling (dont need)
24/09/2023  02:33 am    <DIR>          obj
24/09/2023  03:06 am            14,946 Program.cs
24/09/2023  02:33 am    <DIR>          Properties
              12 File(s)        271,521 bytes
               5 Dir(s)  490,373,033,984 bytes free

///------------------link MyCPlusPlus.lib to ConsumerCPlusPlus.cpp--------------
C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files\CSharp vs CPlusPlus DLL Files>cl ConsumerCPlusPlus.cpp /link MyCPlusPlus.lib
Microsoft (R) C/C++ Optimizing Compiler Version 19.37.32824 for x86
Copyright (C) Microsoft Corporation.  All rights reserved.

ConsumerCPlusPlus.cpp
Microsoft (R) Incremental Linker Version 14.37.32824.0
Copyright (C) Microsoft Corporation.  All rights reserved.

/out:ConsumerCPlusPlus.exe
MyCPlusPlus.lib
ConsumerCPlusPlus.obj
   Creating library ConsumerCPlusPlus.lib and object ConsumerCPlusPlus.exp

C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files\CSharp vs CPlusPlus DLL Files>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files\CSharp vs CPlusPlus DLL Files

24/09/2023  03:19 am    <DIR>          .
24/09/2023  03:19 am    <DIR>          ..
24/09/2023  02:33 am               189 App.config
24/09/2023  02:33 am    <DIR>          bin
24/09/2023  03:16 am               207 ConsumerCPlusPlus.cpp
24/09/2023  03:17 am            85,504 ConsumerCPlusPlus.exe
24/09/2023  03:17 am               944 ConsumerCPlusPlus.exp
24/09/2023  03:17 am             2,230 ConsumerCPlusPlus.lib
24/09/2023  03:17 am             1,144 ConsumerCPlusPlus.obj
24/09/2023  02:50 am             2,688 CSharp vs CPlusPlus DLL Files.csproj
24/09/2023  02:53 am             4,096 MeFarm.dll
24/09/2023  02:54 am               644 moo.res
24/09/2023  02:54 am             6,318 moo.txt
24/09/2023  02:45 am               198 MyCPlusPlus.cpp
24/09/2023  03:05 am           159,744 MyCPlusPlus.dll
24/09/2023  03:05 am             1,198 MyCPlusPlus.exp
24/09/2023  02:45 am                85 MyCPlusPlus.h
24/09/2023  03:05 am             2,514 MyCPlusPlus.lib
24/09/2023  03:05 am            78,901 MyCPlusPlus.obj
24/09/2023  02:33 am    <DIR>          obj
24/09/2023  03:19 am            17,244 Program.cs
24/09/2023  02:33 am    <DIR>          Properties
              17 File(s)        363,848 bytes
               5 Dir(s)  490,360,352,768 bytes free

C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files\CSharp vs CPlusPlus DLL Files>ConsumerCPlusPlus.exe
Moooooo
Num munch num munch...

-------------erase MyCPlusPlus.dll---------------------------
C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files\CSharp vs CPlusPlus DLL Files>erase MyCPlusPlus.dll

C:\Users\sunny\source\repos\CSharp vs CPlusPlus DLL Files\CSharp vs CPlusPlus DLL Files>ConsumerCPlusPlus.exe
ERROR OUTPUT: ConsumerCPlusPlus.exe - System Error .....The program can't start because MyCPlusPlus.dll is missing from your computer. Try reinstalling the program to fix this problem.
----------------DLL HELL-------------------







---------------------------CMD: C# vs C++------------------------------------------END

 * 
 */

// All data in assemblies starts with Dot


//public class Farm { }   // farm inherits from object
//public struct Cow { }   // cow extends value type (Recommend Value type knowledge)
//public delegate void Donkey();  // Donkey delegate
//public enum Chicken { Eggs }    //  Chicken Enum values (Enum value Knowledge)
//public class Bacon { }

class MainClass
{
    static void Main()
    {
        Cow cow = new Cow();
        Farm farm = new Farm();
    }
}