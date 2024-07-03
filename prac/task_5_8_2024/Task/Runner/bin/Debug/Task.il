
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.


// ----- DOS Header:
// Magic:                      0x5a4d
// Bytes on last page:         0x0090
// Pages in file:              0x0003
// Relocations:                0x0000
// Size of header (paragraphs):0x0004
// Min extra paragraphs:       0x0000
// Max extra paragraphs:       0xffff
// Initial (relative) SS:      0x0000
// Initial SP:                 0x00b8
// Checksum:                   0x0000
// Initial IP:                 0x0000
// Initial (relative) CS:      0x0000
// File addr. of reloc table:  0x0040
// Overlay number:             0x0000
// OEM identifier:             0x0000
// OEM info:                   0x0000
// File addr. of COFF header:  0x0080
// ----- COFF/PE Headers:
// Signature:                  0x00004550
// ----- COFF Header:
// Machine:                    0x014c
// Number of sections:         0x0003
// Time-date stamp:            0xeeb51f2f
// Ptr to symbol table:        0x00000000
// Number of symbols:          0x00000000
// Size of optional header:    0x00e0
// Characteristics:            0x2022
// ----- PE Optional Header (32 bit):
// Magic:                          0x010b
// Major linker version:           0x30
// Minor linker version:           0x00
// Size of code:                   0x00000a00
// Size of init.data:              0x00000600
// Size of uninit.data:            0x00000000
// Addr. of entry point:           0x00002872
// Base of code:                   0x00002000
// Base of data:                   0x00004000
// Image base:                     0x10000000
// Section alignment:              0x00002000
// File alignment:                 0x00000200
// Major OS version:               0x0004
// Minor OS version:               0x0000
// Major image version:            0x0000
// Minor image version:            0x0000
// Major subsystem version:        0x0006
// Minor subsystem version:        0x0000
// Size of image:                  0x00008000
// Size of headers:                0x00000200
// Checksum:                       0x0000a459
// Subsystem:                      0x0003
// DLL characteristics:            0x8560
// Size of stack reserve:          0x00100000
// Size of stack commit:           0x00001000
// Size of heap reserve:           0x00100000
// Size of heap commit:            0x00001000
// Loader flags:                   0x00000000
// Directories:                    0x00000010
// 0x00000000 [0x00000000] address [size] of Export Directory:          
// 0x0000281d [0x0000004f] address [size] of Import Directory:          
// 0x00004000 [0x00000358] address [size] of Resource Directory:        
// 0x00000000 [0x00000000] address [size] of Exception Directory:       
// 0x00000000 [0x00000000] address [size] of Security Directory:        
// 0x00006000 [0x0000000c] address [size] of Base Relocation Table:     
// 0x00002774 [0x00000038] address [size] of Debug Directory:           
// 0x00000000 [0x00000000] address [size] of Architecture Specific:     
// 0x00000000 [0x00000000] address [size] of Global Pointer:            
// 0x00000000 [0x00000000] address [size] of TLS Directory:             
// 0x00000000 [0x00000000] address [size] of Load Config Directory:     
// 0x00000000 [0x00000000] address [size] of Bound Import Directory:    
// 0x00002000 [0x00000008] address [size] of Import Address Table:      
// 0x00000000 [0x00000000] address [size] of Delay Load IAT:            
// 0x00002008 [0x00000048] address [size] of CLR Header:                


// Image sections:
//              .text
//              0x00000878 Virtual Size
//              0x00002000 Virtual Address
//              0x00000a00 Size of Raw Data
//              0x00000200 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x60000020 Characteristics
//                         CNT_CODE
//                         MEM_EXECUTE
//                         MEM_READ

//              .rsrc
//              0x00000358 Virtual Size
//              0x00004000 Virtual Address
//              0x00000400 Size of Raw Data
//              0x00000c00 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x40000040 Characteristics
//                         CNT_INITIALIZED_DATA
//                         MEM_READ

//              .reloc
//              0x0000000c Virtual Size
//              0x00006000 Virtual Address
//              0x00000200 Size of Raw Data
//              0x00001000 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x42000040 Characteristics
//                         CNT_INITIALIZED_DATA
//                         MEM_DISCARDABLE
//                         MEM_READ

// Base Relocation Table
//              0x00002000 Page RVA
//              0x0000000c Block Size
//              0x00000002 Number of Entries
//              Entry 1: Type 0x3 Offset 0x00000874
//              Entry 2: Type 0x0 Offset 0x00000000

// Import Address Table
//     DLL : mscoree.dll
//              0x00002000 Import Address Table
//              0x0000285f Import Name Table
//              0          Time Date Stamp
//              0          Index of First Forwarder Reference
//
//              0x0000  _CorDllMain

// Delay Load Import Address Table
// No data.

// Entry point code:
//FF 25 00 20 00 10 


// ----- CLR Header:
// Header size:                        0x00000048
// Major runtime version:              0x0002
// Minor runtime version:              0x0005
// 0x00002088 [0x0000066c] address [size] of Metadata Directory:        
// Flags:                              0x00000009
// Entry point token:                  0x00000000
// 0x00000000 [0x00000000] address [size] of Resources Directory:       
// 0x000026f4 [0x00000080] address [size] of Strong Name Signature:     
// 0x00000000 [0x00000000] address [size] of CodeManager Table:         
// 0x00000000 [0x00000000] address [size] of VTableFixups Directory:    
// 0x00000000 [0x00000000] address [size] of Export Address Table:      
// 0x00000000 [0x00000000] address [size] of Precompile Header:         

// Metadata Header
//    Storage Signature:
//              0x424a5342 Signature
//                  0x0001 Major Version
//                  0x0001 Minor Version
//              0x00000000 Extra Data Offset
//              0x0000000c Version String Length
//              'v4.0.30319' Version String
//    Storage Header:
//                    0x00 Flags
//                  0x0005 Number of Streams
//    Stream 1:
//              0x0000006c Offset
//              0x000001f4 Size
//              '#~' Name
//    Stream 2:
//              0x00000260 Offset
//              0x00000248 Size
//              '#Strings' Name
//    Stream 3:
//              0x000004a8 Offset
//              0x00000004 Size
//              '#US' Name
//    Stream 4:
//              0x000004ac Offset
//              0x00000010 Size
//              '#GUID' Name
//    Stream 5:
//              0x000004bc Offset
//              0x000001b0 Size
//              '#Blob' Name

//    Metadata Stream Header:
//              0x00000000 Reserved
//                    0x02 Major
//                    0x00 Minor
//                    0x00 Heaps
//                    0x01 Rid
//      0x0000000900021557 MaskValid
//      0x000016003301fa00 Sorted

// Code Manager Table:
//  default


// Export Address Table Jumps:
// No data.

// File size            : 4608
// PE header size       : 512 (496 used)    (11.11%)
// PE additional info   : 1083              (23.50%)
// Num.of PE sections   : 3
// CLR header size     : 72                 ( 1.56%)
// CLR meta-data size  : 1644               (35.68%)
// CLR additional info : 128                ( 2.78%)
// CLR method headers  : 25                 ( 0.54%)
// Managed code         : 26                ( 0.56%)
// Data                 : 1536              (33.33%)
// Unaccounted          : -418              (-9.07%)

// Num.of PE sections   : 3
//   .text    - 2560
//   .rsrc    - 1024
//   .reloc   - 512

// CLR meta-data size  : 1644
//   Module        -    1 (10 bytes)
//   TypeDef       -    2 (28 bytes)      0 interfaces, 0 explicit layout
//   TypeRef       -   16 (96 bytes)
//   MethodDef     -    3 (42 bytes)      0 abstract, 0 native, 3 bodies
//   FieldDef      -    2 (12 bytes)      0 constant
//   MemberRef     -   15 (90 bytes)
//   ParamDef      -    4 (24 bytes)
//   CustomAttribute-   14 (84 bytes)
//   StandAloneSig -    1 (2 bytes)
//   Assembly      -    1 (22 bytes)
//   AssemblyRef   -    1 (20 bytes)
//   Strings       -   582 bytes
//   Blobs         -   432 bytes
//   UserStrings   -     4 bytes
//   Guids         -    16 bytes
//   Uncategorized -   180 bytes

// CLR additional info : 128

// CLR method headers : 25
//   Num.of method bodies  - 3
//   Num.of fat headers    - 2
//   Num.of tiny headers   - 1

// Managed code : 26
//   Ave method size - 8
// Classes defined in this module:
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Class MathsOperations                (public) (auto) (ansi) 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


// Metadata version: v4.0.30319
.assembly extern /*23000001*/ mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly /*20000001*/ Task
{
  .custom /*0C000001:0A000001*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.CompilationRelaxationsAttribute/*01000001*/::.ctor(int32) /* 0A000001 */ = ( 01 00 08 00 00 00 00 00 ) 
  .custom /*0C000002:0A000002*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute/*01000002*/::.ctor() /* 0A000002 */ = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                                                                          63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom /*0C000003:0A000003*/ instance void [mscorlib/*23000001*/]System.Diagnostics.DebuggableAttribute/*01000003*/::.ctor(valuetype [mscorlib/*23000001*/]System.Diagnostics.DebuggableAttribute/*01000003*//DebuggingModes/*01000004*/) /* 0A000003 */ = ( 01 00 07 01 00 00 00 00 ) 

  .custom /*0C000004:0A000004*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyTitleAttribute/*01000005*/::.ctor(string) /* 0A000004 */ = ( 01 00 04 54 61 73 6B 00 00 )                      // ...Task..
  .custom /*0C000005:0A000005*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyDescriptionAttribute/*01000006*/::.ctor(string) /* 0A000005 */ = ( 01 00 00 00 00 ) 
  .custom /*0C000006:0A000006*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyConfigurationAttribute/*01000007*/::.ctor(string) /* 0A000006 */ = ( 01 00 00 00 00 ) 
  .custom /*0C000007:0A000007*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyCompanyAttribute/*01000008*/::.ctor(string) /* 0A000007 */ = ( 01 00 00 00 00 ) 
  .custom /*0C000008:0A000008*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyProductAttribute/*01000009*/::.ctor(string) /* 0A000008 */ = ( 01 00 04 54 61 73 6B 00 00 )                      // ...Task..
  .custom /*0C000009:0A000009*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyCopyrightAttribute/*0100000A*/::.ctor(string) /* 0A000009 */ = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                                                                               20 32 30 32 34 00 00 )                            //  2024..
  .custom /*0C00000A:0A00000A*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyTrademarkAttribute/*0100000B*/::.ctor(string) /* 0A00000A */ = ( 01 00 00 00 00 ) 
  .custom /*0C00000B:0A00000B*/ instance void [mscorlib/*23000001*/]System.Runtime.InteropServices.ComVisibleAttribute/*0100000C*/::.ctor(bool) /* 0A00000B */ = ( 01 00 00 00 00 ) 
  .custom /*0C00000C:0A00000C*/ instance void [mscorlib/*23000001*/]System.Runtime.InteropServices.GuidAttribute/*0100000D*/::.ctor(string) /* 0A00000C */ = ( 01 00 24 30 65 65 63 32 35 32 38 2D 31 34 30 61   // ..$0eec2528-140a
                                                                                                                                                               2D 34 39 35 64 2D 38 31 35 65 2D 37 64 66 66 64   // -495d-815e-7dffd
                                                                                                                                                               64 62 37 37 31 65 34 00 00 )                      // db771e4..
  .custom /*0C00000D:0A00000D*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyFileVersionAttribute/*0100000E*/::.ctor(string) /* 0A00000D */ = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom /*0C00000E:0A00000E*/ instance void [mscorlib/*23000001*/]System.Runtime.Versioning.TargetFrameworkAttribute/*0100000F*/::.ctor(string) /* 0A00000E */ = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                                                                                     2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                                                                                     00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                                                                                     70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                                                                                     61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .publickey = (00 24 00 00 04 80 00 00 94 00 00 00 06 02 00 00   // .$..............
                00 24 00 00 52 53 41 31 00 04 00 00 01 00 01 00   // .$..RSA1........
                05 B2 10 7E FF F3 2F 67 FD 69 84 1D 62 E9 13 12   // ...~../g.i..b...
                ED 9D 5D E5 42 5A DF F7 4B 6B B7 4D EB 7F FC 9F   // ..].BZ..Kk.M....
                E9 84 18 6D 91 19 5D 07 6E 33 20 B2 39 0B CB 90   // ...m..].n3 .9...
                F5 D1 F0 9F E4 14 86 FF 19 F3 E3 0A 54 77 6A E6   // ............Twj.
                3B D1 07 C5 A5 F3 AD 12 F0 D0 41 EA 7B C2 80 FD   // ;.........A.{...
                EB 32 89 0F CD 0C B2 D5 B2 10 36 3A 1E 81 43 6A   // .2........6:..Cj
                36 F0 F3 0E 4C DA 9E D6 91 03 3D 82 29 1D 99 C5   // 6...L.....=.)...
                B5 BB FB B4 B5 B2 2A 1E B1 8E 5B E2 D0 3C 23 A2 ) // ......*...[..<#.
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Task.dll
// MVID: {A0E2CD9D-432B-4145-9E12-CBEF5DDC7DCB}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000009    //  ILONLY
// Image base: 0x05C00000


// =============== CLASS MEMBERS DECLARATION ===================

.class /*02000002*/ public auto ansi beforefieldinit Task.MathsOperations
       extends [mscorlib/*23000001*/]System.Object/*01000010*/
{
  .field /*04000001*/ public int32 a
  .field /*04000002*/ public int32 b
  .method /*06000001*/ public hidebysig instance int32 
          'add'(int32 a,
                int32 b) cil managed
  // SIG: 20 02 08 08 08
  {
    // Method begins at RVA 0x2050
    // Code size       9 (0x9)
    .maxstack  2
    .locals /*11000001*/ init ([0] int32 V_0)
    IL_0000:  /* 00   |                  */ nop
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 04   |                  */ ldarg.2
    IL_0003:  /* 58   |                  */ add
    IL_0004:  /* 0A   |                  */ stloc.0
    IL_0005:  /* 2B   | 00               */ br.s       IL_0007

    IL_0007:  /* 06   |                  */ ldloc.0
    IL_0008:  /* 2A   |                  */ ret
  } // end of method MathsOperations::'add'

  .method /*06000002*/ public hidebysig instance int32 
          multiply(int32 a,
                   int32 b) cil managed
  // SIG: 20 02 08 08 08
  {
    // Method begins at RVA 0x2068
    // Code size       9 (0x9)
    .maxstack  2
    .locals /*11000001*/ init ([0] int32 V_0)
    IL_0000:  /* 00   |                  */ nop
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 04   |                  */ ldarg.2
    IL_0003:  /* 5A   |                  */ mul
    IL_0004:  /* 0A   |                  */ stloc.0
    IL_0005:  /* 2B   | 00               */ br.s       IL_0007

    IL_0007:  /* 06   |                  */ ldloc.0
    IL_0008:  /* 2A   |                  */ ret
  } // end of method MathsOperations::multiply

  .method /*06000003*/ public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  // SIG: 20 00 01
  {
    // Method begins at RVA 0x207d
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (0A)00000F       */ call       instance void [mscorlib/*23000001*/]System.Object/*01000010*/::.ctor() /* 0A00000F */
    IL_0006:  /* 00   |                  */ nop
    IL_0007:  /* 2A   |                  */ ret
  } // end of method MathsOperations::.ctor

} // end of class Task.MathsOperations


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file Task.res
