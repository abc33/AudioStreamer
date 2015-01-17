# __AudioStreamer__
### Introduction
__AudioStreamer__ is a simple, intuitive and easy to use _audio multiplier software_.  
It allows to _get sound from windows_ and directly _play it through other output_ devices  
such as speakers, phones, headsets, bluetooth speakers, digital output, etc.

---

### Installation
The following prerequisites are required:
 - Microsoft .NET Framework 4.5 (x86 and x64)

---

### How to use
Follow this simple guide to get started:
 1. Set a device, which you do not want to use as output, as default windows  
    output; otherwise you will hear delay between this and other outputs
 2. Download the project from this GitHub page
 3. Unzip it into one folder
 4. Navigate to __/builds/alpha/&lt;current_version&gt;__ folder  
    _NOTE: (replace __&lt;current_version&gt;__ with the version you want to run)_
 5. Open __AudioStreamer.exe__
 6. Choose a device from the dropdown list and click __Add Output__
 7. Repeat __step 6__ to add as much devices as you want
 8. Press __Start__ button to start real-time streaming

Anytime you can disable each input without removing it,  
by pressing the checkbox before the device name.

NOTE: If you want to move the runnable file to another folder,  
make sure you also copy the __Naudio.dll__ file, otherwise  
the application will not start.

---

### Versions
Latest version: v0.1  
All __alpha__ versions:
 - __v0.1__ - _current_

All __beta__ versions:
 - _none_

All __release__ versions:
 - _none_

---

### Todo's
Here there is a list of features I wish to add:
 - Make an icon :D
 - Allow to _edit current audio output settings_ without removing and adding it again
 - _Import/export_ output mapping
 - _Better GUI_

Any suggestion is really appreciated, so if you have any idea you can [drop me a message].

---

### Development
Want to contribute? Great!  
Just fork project, make your changes and make a pull request.

---

### External Libraries
To build this project I used these free open source libraries, so a really  
big thanks goes to authors of these libraries listed below:
 - [NAudio] - Audio utils library

---

###License
**AudioStreamer** under the Apache License, Version 2.0:

> Copyright 2015 Davide Marchetti ([@dvdmarchetti])  
> Licensed under the Apache License, Version 2.0 (the "License");  
> you may not use this file except in compliance with the License.  
> You may obtain a copy of the License at  
> &nbsp;    
> http://www.apache.org/licenses/LICENSE-2.0  
> &nbsp;  
> Unless required by applicable law or agreed to in writing, software  
> distributed under the License is distributed on an "AS IS" BASIS,  
> WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
> See the License for the specific language governing permissions and  
> limitations under the License. 

[drop me a message]:mailto:dvdmarchetti663@gmail.com
[@dvdmarchetti]:https://twitter.com/dvdmarchetti
