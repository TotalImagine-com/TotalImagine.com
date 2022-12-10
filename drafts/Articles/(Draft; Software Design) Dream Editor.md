# (Software Design) Dream Editor

Oh, dream, sweet dreams.

People say **Pieces♓** people like to imagine, I don't know whether it's always true, but it certainly applies to me - when I think about it, most of the time I was not occupied with something, I was doing my own project or imagininhnloving in a different world.. ... We on the other hand, are of course aware that as per [Wikipedia page](#) it's defined as a pseudoscience - but no one actually believes it, it's more of the sincere wishes we have associated with our own 微不足道的 lives with stellar objects....

For the record, this project was partly why I nearly failed my second year. It took 9 months from inception to functional finish (i.e. without fixing all the bugs and publish and maintain it). Did I mention I didn't know how to use a version control at that time? If I was anything, I guess it's bravery and impulse. I can nowadays design a system 10 times more sophisticated than this, but I would hesitate implementing it right away and strive to the end - what a youth!

## Background and Purpose

## Development Process

## Software Components

No software design patterns. With only guess work, I managed to devise the following components and software layers after 2 to 3 iterations. I stil remember the first one and half months was writing and iterating on headers only - without writing a single line of implementation. That was my attempt to modularize this program. At that time I thought that was the only way to write C++ code. Turns out that is more of a "waterfall" approach, and even for large piece of complex softwares one can still design and implement it one piece at a time. And conceptual design doesn't need to happen in header, for instance drawings and documentation helps. I guess one rationale was because at that time I typed slower, so it was simply more economical to write headers as a design method.


## Conclusion

A **custom rendering engine** is really good only for **learning**, **optimized and stylized rendering**, and **experimentation** purpose. For **quick real-time 3D scene** setup, I recommend using UE4/Unity or Xenko, otherwise if drag-n-drop **floating image and text** is needed, use Blender or Houdini for static or animated results. Per latest Blender 2.8, Eevee rendering also allows pretty stunning real-time visuals.

For **efficient dream journaling**, I recommend a *seriously custom-designed text and P&P workflow* to start with, and *only turn to softwares when we are satisfied with draft results*, other wise softwares slows us down, and **developing a custom software for the purpose of producing some content** is especially so. By the way by **"text"** I specifically means using Markdown or TiddlyWiki, and by **P&P** I mean sketching using **Pen and Paper**. So we should use softwares for dream journaling purpose only when we intend to prepare our ideas into **presentation level outputs**, in which case as I am currently training myself to use specialized **existing tools** for **specialized purposes**: use TerraGen for natural outdoor **landscape** and **cloud effect** rendering, use Character Creator for **figures**, use Affinity creative suites for **retouching** and **graphics design**, use Blender for **modeling**, **2D hand-drawn animation** and **rendering**, use ZB for **scuplting**, using Moho for **2D vector animation**, use Studio One for **compositing**, use a recorder for live **sound and music capture**. I guess a life lesson learnt from this experience (and later inspired during the period I work at OTPP) is that, *one really shouldn't be limited to the tools (i.e. softwares) available*, and the power of **"raw" fundamental methods** can still be *very very useful and efficient* - all we need to do is to find a **proper workflow**. It really isn't about whether we can clearly identify so-called goals or purpose - one might argue if I had known at that time my *true goal* was to *efficiently record dreams* rather than *design a 3D environment for it*, or my true goal was to *present dreams in a professional manner* rather than *recording it in ever more sophisticated forms*, then I could have avoided all those - well the fact is no **I couldn't**. At that time I simply *didn't know what I wanted* - or I would argue I simply *could have wanted all of those*: both a casual-feeling 3D editing environment for notes, and a medium for thinking and elaborating my dreams. *One is greatly limited only by his talents and skills*, and at that time I own neither, so I try to explore and expand my own skills, doing whatever I could at that time.

**Remarks on Program Design**

1. Separating components and files actually requires a little bit of initial and bookkeeping efforts. But it turns out very useful for code viewing and navigation purpose. From this point of view, modularization of code by files and folders serves not just to more efficiently allow recompilation (because the smallest translation unit is a file), but also for **semantics purpose**. Be careful *not to abuse it* (when scale is clearly visible, it's more efficient for all purpose to keep things self-contained and condense to avoid bookkeeping cost, just like making notes - it's very very bad to write many many small notes in many many separate files).

## Downloads

1. [Source Code](https://github.com/szinubuntu/NodeEditor)
2. [Release](https://github.com/szinubuntu/NodeEditor/releases)
