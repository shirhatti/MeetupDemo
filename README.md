# MeetupDemo
Sample App for http://www.meetup.com/Seattle-Web-App-Developers-Group/events/226280408/

These instructions are concise. Detailed instructions can be found [here](https://docs.asp.net/en/latest/getting-started/index.html)

1. Install DNVM (.NET Version Manager)

  On Windows, open a **Command Prompt** and type in the following:
  ````
  @powershell -NoProfile -ExecutionPolicy unrestricted -Command "&{iex ((new-object net.webclient).DownloadString('https://dist.asp.net/dnvm/dnvminstall.ps1'))}"
  ````
  
  On Mac/Linux,
  ````
  curl -sSL https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.sh | DNX_BRANCH=dev sh && source ~/.dnx/dnvm/dnvm.sh
  ````

2. Install a DNX (.NET Execution Environment)
  ````
  dnvm install latest -r coreclr
  ````

3. [Install Visual Studio Code](https://code.visualstudio.com/)

4. Install [Node.js](https://nodejs.org/en/)

5. Install some command-line tools (details [here](https://docs.asp.net/en/latest/client-side/yeoman.html))
  ````
  npm install -g yo bower generator-aspnet
  ````
  

