using System;
using System.IO;

public class sharpes_os
{
    void mkdir(string name_mkdir) { Directory.CreateDirectory(name_mkdir); }
    void rmdir(string name_rmdir) { Directory.Delete(name_rmdir); }
    void mkfil(string name_mkfil) { File.Create(name_mkfil); }
    void rmfil(string name_rmfil) { File.Delete(name_rmfil); }
    void systemd(string command) { system.Diagnostics.Process.Start(command); }
}