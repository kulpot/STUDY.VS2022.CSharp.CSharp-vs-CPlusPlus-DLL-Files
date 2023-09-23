using System;

//ref link:https://www.youtube.com/watch?v=XrOCRem4g_A&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=11
//Creating/Adding Reference Assemblies: MeFarm.dll

/*-----------------------------CMD------------------------------------------------
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