# Getting started

_Assuming you've already installed dotnet on your Pi_

Target platform is **ARM64**.

Create a deploy PS script, similar to this, and `. .\deploy.ps1` each time you want to deploy a change:

**deploy.ps1**:

```powershell
scp -r /C:\Users\<user>\source\RaspPiNet6LED\bin\Debug\net6.0/* <username>@<ip-address>:/home/<username>/dotnet6/RaspPiNet6LED/
```

To run:

**Pi**:

```bash
cd /home/<username>/dotnet6/RaspPiNet6LED/
sudo dotnet RaspPiNet6LED.dll
```

output:

```
LED Demo started
..................
```
