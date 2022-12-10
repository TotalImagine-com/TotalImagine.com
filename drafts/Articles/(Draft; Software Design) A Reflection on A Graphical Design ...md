```
- Coin Dispenser
    + Here is some of my thought on the coin dispenser: this device seemed cumbersome enough to use and due to lack of documentation (though I have documented a few functions I figured out) it doesn't seem very maintainable in the future. I know you guys surely have made the choice ... (although I cannot say that)
    + That looked like some very specialized device and not publically available
    + I am just curious how do their other clients normally use this device - specially consult their engineers? Or maybe does it come with a software/SDK after all?
    + Need async handling of dispensing, because it's taking too long: or execute without waiting
- One thing I really can't help but to mention is the dependency on Windows API and wxWidgets and those stuff: those needs naturally arise during our development process and I tried to isolate them into separate programs because otherwise we lost our original intention to use SFML as a framework for building the application. The scale as we are developing now really isn't suited for SFML given the timeline and unfortunately the short iteration speed at Baycrest. (There is no need to re-propose, "one more time" - we probably should either just do it in grayground or not)
    * On Schedule
    * On Device
    * On Implementation of Features
    * On Future

Notice by design I won't mention the name of Baycrest hospital in this article.    

Also before updating this post on DB, check current version in DB because it took me a while to find this note and it might be complete.
```

### Background

Recently I have been developing a *2D graphics application* for some company's research department. That was a *full-screen* desktop application with some *configurations* on the shape of the objects and a bunch of *animations* depending on target action sequences. In addition to the interactions, the application also need to maintain a **state** so it can be saved and reloaded, and in the end it should generate some **statistics** about the overall session. The application was intended to **target Windows XP and above**.

In this article I will talk about the development process and some of the decisions we/I made along the way, and discuss about the thoughts I had on some aspects of the project. The **summary** of the reflective ideas follows at the end of the article.

### Constraints

The available tools are decided by the manager since the beginning of the project: **C++** with **CodeBlocks** using **SFML** as graphics framework targeting **MinGW**. The goal is to be as *lightweight* and depend on as *little external dependencies* as possible.

The company hired a previous contractor working on a similar project (using the same dev environment) before with less animation requirements, and at that time SFML satisfies their need well for displaying simple **statistics on-screen** in **real time**. I inspected the code from previous contractor - the **graphics** and **data processing logic** of that program was almost handled in entirety inside the *main function*. And the only sophisticated part of that program might be the interaction with some *external device* through **Serial interface (COM Port)**. That provides some background for the choice of this *dev environment*.

**Concept Design**

For me it's natural in order to handle **animations** and **state** of the program in a scalable way an *application framework* is needed. In order to draw all the various shapes of objects and provide basic **input and output** controls - including *labels*, *buttons*, *text fields*, *images* - various corresponding **C++ objects** are defined, and a **graphics manager class** is responsible for managing the graphical state of the application. Besides the display **elements at any given screen** area, sometimes there will involve large change of overall display (including layouts and elements) for instance when *switching* from application main menu to the application logic menu and to other related menus. Besides that we also need some controls (e.g. buttons and labels) to *always be present* no matter which menu interface we are currently in. In order to achieve that I defined two concepts/classes named **Scene** and **HUD** (which is borrowed from **2D game design** concepts), each representing the **collective state** of the any given display screen and the **display elements that's always visible** respectively.

For the *animation*, basic **animation operations** are defined as **descriptive structures** and animations are implemented as a *sequence of animation operations* targeting any given control. Enough talk on the graphics part.

**Development Process**

(**Requirements**) Since the beginning of the development we have the need to allow various forms of **program configurations**, including data-driven **program data** and **display and animation configurations**. I didn't use any csv/ini/database format at that time and instead used: 1) **Custom text file format** for the program data; 2) A custom C++ style syntax **configuration reader** (available in *download link*) I have written a long time ago for program configurations. The custom configuration reader was not super smart, and I agree some parts of it could have been written using *regular expressions*, but it was simple and functional and support **C++ style variable definitions** and **comments**.

As the available **configuration options** and **configuration files** grow, we have the need of some **configuration program** in order to avoid manual changes because it's error prone and not easy to navigate. That was the first *challenge* to our existing tool set because even though I could add and expand on existing controls to support *radio button* (for boolean) or *range-fixed* int/float point values, or I could just provide a generic text box and parse the input and add warning and notifications when input values are not as expected. But things like *color selection*, *drop-down list*, and *list layout* with scroll support or multiple pages of configurations can be time-consuming to implement and tricky to get it look and feel and work right. Remember we were using SFML directly with C++ so there is no suitable library for these graphics tasks handily available. At that time I suggested the second time using **Visual Studio** so I could use **C#/WPF** because it's quick and well-suited for this kind of tasks instead of doing it inside the existing program, but that will introduce dependency on **C#.Net** runtime and dramatically increase the size of current program (which is only *4.5MB* including all the configurations and assets in a standalone folder). Instead I have to explore other *C++-based* solutions. I could have used **WinAPI** directly but in the end I found **WxWidget** and CodeBlocks supports creating project for it directly. With the help of a separate program called **WxFormBuilder** for UI layout, the *configurator program* was written. I compiled it as a standalone program with no external dll dependency, but its size is *7 MB* for something as simple as reading and writing a bunch of configuration files. That was quick and easy, and that worked.

There are other aspects of effort involved during the process but they are less relevant to the topic I want to talk about so let me stop here on the development itself.

### Reflection on The Process

One thing concerns me most nowadays is **what is the best way to approach** some given task? For instance a graphical application like such can be done in at least 3 fashions: 1) Using SFML and draw shapes manually; 2) Using WPF and library animation functions; 3) Use a game engine and mostly just drag-n-drop. Later during the development process when the program's functions are almost finished we thought about exploring adding 3D capabilities to the graphics. SFML was written in OpenGL so I managed to create OpenGL context and created some drawing routines. But the original custom controls and animation framework was designed to operate in 2D space - a lot of existing animation codes need update if we want to change the rendering of existing shapes and objects. In the end we stopped pursing in that direction.

[//]: # (No need to talk about why it bothers me or reference to other relevant experience projects e.g. MULTITUDE; But for personal reference: it's because sometimes it matters more the approach rather than what we are trying to achieve)

/In some cases it's easy to think of "expensive/fancy" ways to implement a given task, in other cases it might be better to go with the most basic tools and just get the work done. My manager helped a lot in terms of discipline. What I learnt during the process is to instead of replying on larger and larger external libraries, thinking of utilizing existing tools and simplify tasks first. This project had some practical constraints for me and my manager not in terms of time and money but mostly coordination and scoping - the program was designed to satisfy the researcher's need and for that purpose we would like to simplify the presentation as fat as possible, and build the pgoram with less dependency so it's most reliable and can last long. / The same mindset (Seeking better word) occurred to me when I was working inside a team at some financial company. As my manager there quoted some famous physist: "In theory there is no difference between theory and practice, in practice there is". When I was doing personal projects usually my ideas can constantly **expand** and turns out requiring more and more **features**. Doing the project in an Agile fashions helps bring up **stepwise progress** but still that cannot help "controlling" my personal projects. Working with my managers are however, quite different. My manager for the graphics application limits **toolset** and requires minimal dependency and small and fast executable with less than decent development machine, while my manager at the financial firm wants **rapid prototype**, quick iteration, fast turnaround, and permits using a variety of tools most suitable for the job. The financial company has its resources in terms of hardware, but it turns out the price for developing a self-contained minimal size C++ graphics application was not cheap at all. *What does that mean*?

### The Big Question

What would happen if I implement the animations using ...; What would happen if we used UE4/WPF as a starting point?

Well hopefully the world would not end - but wait, it might: if my manager and me and at that time had made a different choice then none of the current development would have happened and me at the present time would cease to exist. When I think about it, I have spent more than 12 months there and there is quite something going on for this whole year. But that's for the time-space aspect of the choice.

(Maybe like many other things in life, when everything taken together, there could be no right or wrong choice without getting opinionated. If we have used WPF we would develop things the WPF way, maybe paying a premium for professional version of VS as a price; If we have used UE4 we would need to upgrade the dev environment which is a debatable one-time cost because nothing have been done yet and the cost can be high; all in all, we used open source solutions and things work and we don't risk have unpredictable performance issues. Initial setup takes some effort, after that, things will unfold itself. It's like Harry could have married Hermione judging from the movie only but Hermione and Ron get together because of the novels, or I could have eaten fries instead of onion rings for today's lunch. Whatever the choice, whatever the story, it's just a different paths towards different ends.)

But this is software development, and we can have a very clear idea regarding what kind of ending we are expecting - whether or not to make this clear distinction is one question, but once the goals are clear, we should be able to measure the criteria and available resources and make the decision numerically. I am not the decision maker in this project so let's just stop it here.

### Personal Reflection

Talking about my part only, did I Overcomplication of design to satisfy simple needs...; For instance we have a few different "modes" to run the application and I spent a lot of effort figuring out and abstracting.. . - what would happen if I just wrote completely custom logic for each of the modes instead? Will that allow max flexibility or does it actually break one program into 3? To be more specific, when I handle the animations for all the modes, I defined a base class...

One other way to handle the task is to make the animation system even more sophisticated and completely data driven instead of having program logics built in during constructor.... The difficulty is that some animations happen only at specific states/conditions of the program/program flow.

If you are willing to leave a comment, this article is also available on my repository of active writings - (sanweishuwu)[link].

Other articles: My desire for becoming more organized and the effect of it; A reflection on the 12-month development work at OTPP; "Clue" Based Desktop Environment and An Attempt to Reason about Personal Documents (SIS) ; Dream Editor and Mid-Scale C++ OpenGL Application; Turing Pattern Generator and Research-Oriented Programming Thinking (Turing Pattern); Strong Artificial Intelligence and The Computability of Human Minds (SIS and AI, Early Chat Bot)

**Another Perspective**

It turns out men start to thinking about what and why problem when they are in trouble. For me that was because we needed to interface with some antique device which hardly had any documentation except a test program and corresponding configuration file.

....

In the end I managed to compare functional call effects with test program COM interface log outputs to figure out the behavior of the device interface.

### Summary

1. Do try to minimize the dependency of the programs, but only in so far as the functionalities are already somehow provided by the runtime; Otherwise don't re-invent the wheel.
2. There seem no such a thing as **"over-complication"**, there is only: 1) Not **enough development** for something to really work well, probably due to time constraint and a need for rapid prototype/progress; 2) There is not **clear goal** as to what we really need, what kind of workflow we expect, and what we should focus on and what we should not bother with.
3. A man's **ability** really is not limited by the tool he's using; **Patience** (requires planning) and **proficiency** (requires practice) is the key. When you are not feeling comfortable with some tool/environment/workflow, **spend time** to familiarize yourself with it, and really spend time on it. It will benefit a lot later.
4. Create sample projects, use version control, add documentation along the way; Tooling helps.

# Clarification

Below parts are a word in progresss

# How to create a 2D graphics application?

**Concepts**

To create a 2D graphics application, first we need to understand two concepts: 1) What is graphics? 2) What is application?

Graphics can be a simple drawing, can be a parametric curve, can also be LED display - those concerns respectively with shape forms, data representation, and pixel manipulations. There are also infographics and 3D graphics, which concerns repsectively with presentation of numerical or categorical data and vector space calculations. From those examples, we can see graphics concern with at least the following areas: 1) Color theory and visual design; 2) Patterns and pattern generation; 3) Graphical data representation and shape parameters; 4) Graphical measures; 5) Pixel and shape manipulation (transformation and filtering); 6) Vector space calculations; 7) Color spaces and computer display types; 8) Virtual reality. There is also something called holographics which I presently don't understand a bit about.

Then what is an application? Anything we do can be applied. It can be for fun, for gaining insights into data, for immersive experience, for presentation purpose, for printing, and for solving problems that are simply too hard/tedious to do by hand, or simply for digital storage. Computers are especially good at handling tedious tasks, iterating through an array billions of times without even feeling tired (maybe a bit hot).

**Perspective**

Now let's put this question into perspective and why at the first place it's a question at all to some people who thought they have programming experience from school. Let's say you are a University of Toronto Computer Engineering student, here is what you will likely get in terms of programming experience throughout 3 years of education, which are likely relevant to graphics application:

1. Introduction to Programming: Python/Java/C++ programming with command line interface
    * This is actually very relevant to computer grpahics because have you ever heard of **ASCII art** and **Functional programming**?
    * If you are using Python/C++, you can also use
    * The whole **VIM** program works in terminal and to me it's one of the most astonishing graphics application I have ever seem
    * I have a personal colorful console program for one of the ECE assignments related to network programming here ....
    * To be any useful at this, knowledge about binary representation of numbers, Character encoding, ASCII, CJK character, UNICODE, XTerm Colors (which I don't understand yet)
    * More terminal graphical examples/libraries: schachmat/wego, wttr.in, libfort, RxTerm, GNU ncurses, Termbox, tcell, nicrohobak/AnsiGL, also see [This page](https://medium.freecodecamp.org/coding-like-a-hacker-in-the-terminal-79e22954968e) and [This page](https://hackernoon.com/building-reactive-terminal-interfaces-in-c-d392ce34e649), and [CLI libraries](https://github.com/fffaraz/awesome-cpp#cli); You get the point
2. During algorithm or communication and design course you might have chance to use EasyGL, which provides very basic yet functional shape drawing capabilities but it's for linux and nothing is taught for packging for usable purposes
3. Learnt no matter how roughly programming by setting RAM memory address values using FPGA and magically through a VGA controller to update the display on a VGA display.
4. Learnt to use MatLab to generate frequency analysis diagrams and alike and export to PDF, with proper automation and scripting this is the closest to a functional graphics application.
5. In Computer Graphics course learn about writting simple shaders on top of an already-built WebGL framework without bothering much about the details of setup of the service for yourself. Or writing a custom C++ based ray tracing shader from scratch which barely functions and have broken pieces here and there, but it's completely functional and this is a true graphics application based on simulation of light and interaction on object surfaces.

**Tools**

There should be a million tools and domain-specific applications out there, here I provide an exaustive list of the useful ones (repeating myself a bit when necessary) for reference purpose:

1. General Purpose: Math - specifically linear algebra and geometry, calculus can also occasionally be useful; Discrete logic; Programming language - specifically syntax and underlyings of C++, Python, Processing, Javascript, C#, Lua, ActionScript; Specifications: specifcially jpeg, png, gif, svg, html, css, xml, json, yaml, mp3, wmv, avi; Concepts: voxel, vector shape, coordinate systems
2. File formats: include some mentioned above, there are also: psd, pdf
3. File Editors: word (document), excel (diagram), notepad++/vs code/sublime text/vim
4. Environments: Windows 7/8/10, Visual Studio, Chrome Browser
5. Learning Resources: The Battle for Wesnoth, OpenGameArt.org, Blender Swap, Google Poly, Unity Asset Store, Unreal Store, TUrbo Squid, CGTextures, GameTextures.Com, Polligon; RPG Game Maker; CGArtist
6. 2D Image Editors: ProMotion, Affinity Photo, Affinity Design; InkScape, Paint.Net, Krita; Spine; Pixen, asprite, GrafX2, GraphicsGale
7. 3D Image Creators: MagicaVoxel, Blender; Daz Studio, Character Creator/Make Human, TerraGen, Houdini, SketchUp, Sculptris, ZBrush; MineCraft, No Man Sky
8. Game Engines: Godot, Defold, LÖVE, PlayCanvas, Unity, Unreal, CryEngine,
6. Domains: 2D Graphics Game, 3D Graphics Game, Data Visualization, Physics Simulation, Document Processing, Machine Learning, Drawing and Digital Processing, Pixel Art (WOW, this is a huge topic, and I am still working on it)
7. Libraries and Frameworks: Python Arcade, Java 2D; C++ SFML, AssImp, DevIL, GLFW, FreeGLUT, wjakob/nanogui, LibRocket, CEGUI; JS Awesomium; C# WPF, WinForm, Excel Add-In
8. Libraries to Investigate: C++ FlateUI, GWEN, Turbo Badger
9. Programming Tools for Programmatically Generated Graphics (basically all games and graphical applications): CMake, Visual Studio, OpenGL/DirectX/Vulkan?!, SDL/Qt, MFC, NodeJS
10. To Check out: https://mollyrocket.com/games

Things I am are of but didn't mention:

1. GDI, Qt, VB
2. WindowsAPI
3. Maya, 3DMax, Photoshop, Illustrator, Gimp, InDesign

# How to Interface with External Devices?

**Background**

Computer alone can only generate graphics, or maybe generate sounds, or maybe generate data... But anything was digital. In order to do anything practical, destructive, impactaful, we need ways to drive external devices (e.g. a car). Suffice to get started with small stuff, for instance a motor fan or digital door. When communication happens at this level, it concerns mostly three things: **operating system**, **communication protocols**, and **hardware drivers**.

Everthing that can be possibly controlled by a computer is defined on the operating system level, specifically this means OS API, on linux it's called **Linux API**, on windows it's called **WinAPI**.

Several fundamental communication methods on the OS level: piping, sockets, file based polling.

Notice I am still considered getting started in this respect so the following list is likely to expand. I found: 1) Resource are plentiful but too much, textbooks help little, experiment is more useful for insights; 2) Keywords help guide ways better than textbook (names).

One thing for sure, in this realm you got to deal with **bits** and use **C/C++**. Unless, of course if you build on top of high level solutions e.g. programming against Google Home and Amazon Alexa or alike. This [page](https://www.codeproject.com/Articles/43458/Control-Physical-World-Through-Computer-Step-by-St) seems to provide a good overview, although sufficient background is needed for the patience to consume the article.

Notice if you are programming against a very specific piece of device, e.g. Oculus Rift, then the hardware interface is likely already developed by the device vendor, and you will get a ready-to use programming library (likely in the form of either C++ library or ActiveX/COM object or higher level API) to directly interface with it.

**References**

1. Protocols: RS232, UART
2. Hardwares: USB Cable, TTL, USE Mini-B Cable, Jumper Wire, Breadboard, Serial Cable
3. Intermediate Devices: Arduino, Rasperri Pie,
4. Fundamental Programs (Windows): Device Manager (devmgmt.msc); Terminal
5. Terminology: M/F (Male/Female)
6. Libraries: WinUSB, Windows Driver Kit (WDK)

**References**

References are needed for things I am not very familiar with yet.

1. [Using C++ to Write Automation Controller Software](https://journals.sagepub.com/doi/full/10.1016/j.jala.2006.07.011)
2. [Controlling The Real World With Computers](http://www.learn-c.com/alltoget.htm)
3. [(Background)How do you connect C++ code to, for example, a pice of circuitry?](https://www.daniweb.com/programming/software-development/threads/460127/how-do-you-connect-c-code-to-for-example-a-pice-of-circuitry#post2000152), and [this](https://www.daniweb.com/programming/software-development/threads/163667/using-software-to-control-lights-motors-and-such), and [this](https://www.bogotobogo.com/cplusplus/embeddedSystemsProgramming.php)