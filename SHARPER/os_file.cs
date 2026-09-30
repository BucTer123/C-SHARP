using System;
using System.IO;

public class Sharpes_os
{
    void Mkdir(string name_mkdir) { Directory.CreateDirectory(name_mkdir); }
    void Rmdir(string name_rmdir) { Directory.Delete(name_rmdir); }
    void Mkfil(string name_mkfil) { File.Create(name_mkfil); }
    void Rmfil(string name_rmfil) { File.Delete(name_rmfil); }
    void Systemd(string command) { system.Diagnostics.Process.Start(command); }
}
