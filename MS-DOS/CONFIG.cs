using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MS_DOS_UTIL;

namespace MS_DOS_CONFIG
{
    internal class CONFIG
    {
        internal static bool echo;
        internal static string pos;
        internal static string prompt;
        internal static Dictionary<string, string> envVar;
        internal static Partition part;
        
        static CONFIG()
        {
            echo = true;
            pos = "C:\\";
            prompt = $"{pos}>";
            envVar = new Dictionary<string, string>()
            {
                { "COMSPEC", "C:\\DOS\\COMMAND.COM" },
                { "PROMPT", "$p$g" },
                { "PATH", "C:\\DOS" },
                { "TEMP", "C:\\DOS" }
            };
            part = new Partition('C', "MS-DOS", 60 * 1024 * 1024, new List<FileSystem>()
            {
                new MS_DOS_UTIL.Directory("DOS", new List<MS_DOS_UTIL.File>()
                {
                    new MS_DOS_UTIL.File("ANSI.SYS",9065),
                    new MS_DOS_UTIL.File("APPEND.EXE", 10774),
                    new MS_DOS_UTIL.File("ATTRIB.EXE", 11165),
                    new MS_DOS_UTIL.File("CHKDSK.EXE", 12907),
                    new MS_DOS_UTIL.File("CHKSTATE.SYS", 41600),
                    new MS_DOS_UTIL.File("CHOICE.COM", 1754),
                    new MS_DOS_UTIL.File("COMMAND.COM", 52925),
                    new MS_DOS_UTIL.File("COUNTRY.ICE", 12711),
                    new MS_DOS_UTIL.File("COUNTRY.SYS", 17066),
                    new MS_DOS_UTIL.File("DBLSPACE.BIN", 51214),
                    new MS_DOS_UTIL.File("DBLSPACE.EXE", 274388),
                    new MS_DOS_UTIL.File("DBLSPACE.HLP", 72169),
                    new MS_DOS_UTIL.File("DBLSPACE.INF", 2178),
                    new MS_DOS_UTIL.File("DBLSPACE.SYS", 339),
                    new MS_DOS_UTIL.File("DBLWIN.HLP", 8597),
                    new MS_DOS_UTIL.File("DEBUG.EXE", 15715),
                    new MS_DOS_UTIL.File("DEFRAG.EXE", 75033),
                    new MS_DOS_UTIL.File("DEFRAG.HLP", 9227),
                    new MS_DOS_UTIL.File("DELOLDOS.EXE", 17710),
                    new MS_DOS_UTIL.File("DELTREE.EXE", 11113),
                    new MS_DOS_UTIL.File("DISKCOMP.COM", 10620),
                    new MS_DOS_UTIL.File("DISKCOPY.COM", 11879),
                    new MS_DOS_UTIL.File("DISPLAY.SYS", 15789),
                    new MS_DOS_UTIL.File("DOSHELP.HLP", 5667),
                    new MS_DOS_UTIL.File("DOSKEY.COM", 5883),
                    new MS_DOS_UTIL.File("DOSSHELL.COM", 4620),
                    new MS_DOS_UTIL.File("DOSSHELL.EXE", 236378),
                    new MS_DOS_UTIL.File("DOSSHELL.GRB", 4421),
                    new MS_DOS_UTIL.File("DOSSHELL.HLP", 161323),
                    new MS_DOS_UTIL.File("DOSSHELL.INI", 16420),
                    new MS_DOS_UTIL.File("DOSSHELL.SWP", 10033),
                    new MS_DOS_UTIL.File("DOSSHELL.VID", 9462),
                    new MS_DOS_UTIL.File("DOSSWAP.EXE", 18756),
                    new MS_DOS_UTIL.File("DRIVER.SYS", 5406),
                    new MS_DOS_UTIL.File("EDIT.COM", 413),
                    new MS_DOS_UTIL.File("EDIT.HLP", 17898),
                    new MS_DOS_UTIL.File("EGA.CPI", 58870),
                    new MS_DOS_UTIL.File("EGA.ICE", 73404),
                    new MS_DOS_UTIL.File("EGA.SYS", 4885),
                    new MS_DOS_UTIL.File("EMM386.EXE", 115294),
                    new MS_DOS_UTIL.File("EMM412.SYS", 28758),
                    new MS_DOS_UTIL.File("EXPAND.EXE", 16129),
                    new MS_DOS_UTIL.File("FASTHELP.EXE", 11481),
                    new MS_DOS_UTIL.File("FASTOPEN.EXE", 12034),
                    new MS_DOS_UTIL.File("FC.EXE", 18650),
                    new MS_DOS_UTIL.File("FDISK.EXE", 29333),
                    new MS_DOS_UTIL.File("FIND.EXE", 6770),
                    new MS_DOS_UTIL.File("FORMAT.COM", 22717),
                    new MS_DOS_UTIL.File("GRAPHICS.COM", 19694),
                    new MS_DOS_UTIL.File("GRAPHICS.PRO", 21232),
                    new MS_DOS_UTIL.File("HELP.COM", 413),
                    new MS_DOS_UTIL.File("HELP.HLP", 298160),
                    new MS_DOS_UTIL.File("HIMEM.SYS", 14208),
                    new MS_DOS_UTIL.File("INTERLNK.EXE", 17197),
                    new MS_DOS_UTIL.File("INTERSVR.EXE", 37314),
                    new MS_DOS_UTIL.File("KEYB.COM", 14983),
                    new MS_DOS_UTIL.File("KEYBOARD.ICE", 22192),
                    new MS_DOS_UTIL.File("KEYBOARD.SYS", 34694),
                    new MS_DOS_UTIL.File("LABEL.EXE", 9390),
                    new MS_DOS_UTIL.File("LOADFIX.COM", 1131),
                    new MS_DOS_UTIL.File("MEM.EXE", 32150),
                    new MS_DOS_UTIL.File("MEMMAKER.EXE", 118660),
                    new MS_DOS_UTIL.File("MEMMAKER.HLP", 17081),
                    new MS_DOS_UTIL.File("MEMMAKER.INF", 1652),
                    new MS_DOS_UTIL.File("MODE.COM", 23521),
                    new MS_DOS_UTIL.File("MONOUMB.386", 8783),
                    new MS_DOS_UTIL.File("MORE.COM", 2546),
                    new MS_DOS_UTIL.File("MOUSE.SYS", 37288),
                    new MS_DOS_UTIL.File("MOVE.EXE", 17823),
                    new MS_DOS_UTIL.File("MSAV.EXE", 172198),
                    new MS_DOS_UTIL.File("MSAV.HLP", 23891),
                    new MS_DOS_UTIL.File("MSAV.INI", 0),
                    new MS_DOS_UTIL.File("MSAVHELP.OVL", 29828),
                    new MS_DOS_UTIL.File("MSAVIRUS.LST", 35520),
                    new MS_DOS_UTIL.File("MSCDEX.EXE", 25377),
                    new MS_DOS_UTIL.File("MSD.EXE", 158470),
                    new MS_DOS_UTIL.File("MSTOOLS.DLL", 13424),
                    new MS_DOS_UTIL.File("NETWORKS.TXT", 20463),
                    new MS_DOS_UTIL.File("NLSFUNC.EXE", 7036),
                    new MS_DOS_UTIL.File("OS2.TXT", 6358),
                    new MS_DOS_UTIL.File("POWER.EXE", 8052),
                    new MS_DOS_UTIL.File("PRINT.EXE", 15640),
                    new MS_DOS_UTIL.File("QBASIC.EXE", 194309),
                    new MS_DOS_UTIL.File("QBASIC.HLP", 130881),
                    new MS_DOS_UTIL.File("RAMDRIVE.SYS", 5873),
                    new MS_DOS_UTIL.File("README.ICL", 4252),
                    new MS_DOS_UTIL.File("README.TXT", 44990),
                    new MS_DOS_UTIL.File("REPLACE.EXE", 20226),
                    new MS_DOS_UTIL.File("RESTORE.EXE", 38294),
                    new MS_DOS_UTIL.File("SETVER.EXE", 12015),
                    new MS_DOS_UTIL.File("SHARE.EXE", 10912),
                    new MS_DOS_UTIL.File("SIZER.EXE", 7169),
                    new MS_DOS_UTIL.File("SMARTDRV.EXE", 42073),
                    new MS_DOS_UTIL.File("SMARTMON.EXE", 28672),
                    new MS_DOS_UTIL.File("SMARTMON.HLP", 10727),
                    new MS_DOS_UTIL.File("SORT.EXE", 6922),
                    new MS_DOS_UTIL.File("SUBST.EXE", 18478),
                    new MS_DOS_UTIL.File("SYS.COM", 9379),
                    new MS_DOS_UTIL.File("TREE.COM", 6898),
                    new MS_DOS_UTIL.File("UNFORMAT.COM", 12738),
                    new MS_DOS_UTIL.File("VFINTD.386", 5295),
                    new MS_DOS_UTIL.File("VGA.CPI", 58866),
                    new MS_DOS_UTIL.File("VSAFE.COM", 62576),
                    new MS_DOS_UTIL.File("XCOPY.EXE", 15820)
                }),
                new MS_DOS_UTIL.Directory("OLD_DOS.1", new List<MS_DOS_UTIL.File>()
                {
                    new MS_DOS_UTIL.File("README.NOW", 429, @"                           WARNING

All of the files in this directory are needed by the
MS-DOS 6 Uninstall program. If you delete any files
from this directory, you will not be able to completely
return to your previous version of DOS.

If you are sure you will not need to restore your original
DOS, you can have MS-DOS delete these files and remove the 
OLD_DOS.x directory by typing DELOLDOS at the command prompt.
")
                }),
                new MS_DOS_UTIL.File("AUTOEXEC.BAT", 54, DateTime.UtcNow, @"@ECHO OFF
PROMPT $p$g
PATH C:\\DOS
SET TEMP=C:\\DOS
"),
                new MS_DOS_UTIL.File("COMMAND.COM", 52925),
                new MS_DOS_UTIL.File("CONFIG.SYS", 109, DateTime.UtcNow, @"
DEVICE=C:\\DOS\\SETVER.EXE
DEVICE=C:\\DOS\\HIMEM.SYS
DOS=HIGH
FILES=30
SHELL=C:\\DOS\\COMMAND.COM C:\\DOS\\  /p
"),
                new MS_DOS_UTIL.File("IO.SYS", 40470, new List<char> {'S', 'R', 'H'}),
                new MS_DOS_UTIL.File("MS-DOS", 0, new List<char> { 'S', 'R', 'H'}),
                new MS_DOS_UTIL.File("MSDOS.SYS", 38138, new List<char>() { 'S', 'R', 'H' }),
                new MS_DOS_UTIL.File("WINA20.386", 9349)
            });
        }
    }
}
