[↵Home](https://www.totalimagine.com/)

# Turing Pattern Generator

Original Draft Date: Ca. 2017-2018  
Original Publish Date: N/A  
Last Update Date: 2023-10-13  
Tags: Software, Programming, Simulation, Computer Graphics, Synthesized Images, Procedural Generation  
Itch.IO: https://charles-zhang.itch.io/turing-pattern  
Revisions:  
  ?2018-2019 Early article draft.
  2022-08-21 Misc.  
  2023-10-13 Writing first paragraph summary, enhance and make connection to the bigger picture of procedural generation.

(THE TIMING LOOKS WEIRD - 2017 IS A TIME I STARTED USING GITHUB, BUT I CANNOT FIND MY SOURCE CODE FOR THIS PROGRAM)

## Overview

Throughout a person's technical development there will be a few occassions where the initial hurdle was the greated - latter in our life and in random technical practices, we still encounter and solve challenges but the conceptual barrier wasn't that much greater. Turing Pattern generator is a very straightforward and simple program from a software development perspective, but at that time, with very very preliminary knowledge on GPU-based acceleration (though I have already written Dream Editor at this time), WPF development (though I already started learning WPF in 2016), it represented a major challenge in the sense that I needed to study a paper and try to figure out and replicate the author's results. It's also sometime after this I first contacted the author of a published article online through email and that opened door for broader communication on the Internet.

```mermaid
timeline
    title Turing Pattern Generator Development Timeline (WIP)
    2016 : Aquisition of C Sharp and WPF
    2017 : First draft of Turing Pattern Generator
    2018 : First iteration of personal website and discussing the project
    2023 : Latest iteration of TI website hosted using Github Pages
         : Trying to figure out the timeline and find the source code
```

## Process

My first attempt to **computationally generate graphical entities** was using **UDK** for generating **Minecraft scene** back in *2013* while I was still at ICT - that was an untroubled time when all you needed to do was to study, to play games (or for me sometimes it's learning **Maya**), and to watch Harry Potter - what a time! Living was cheap, and the food provided at the school tasted pretty good to me. 

**Minecraft** turned out to be quite elaborate work with **multiple passes of filtering** for scene generation and not very efficient to generate using **StaticMeshes** in UDK during runtime. Or maybe I simply wasn't adept enough to handle it efficiently (well to be honest I would hesitate to try that again even with today's **Unreal Engine 4**, rather it seems more suitable to implement it on *low-level graphics directly* with custom program). 

I remember the first pass was using **noise** to generate a **base distribution**, then gradually applying filters in order to achieve various effects. Even today that still sounds like a very impressive idea and I really enjoys the game, especially the VR version - give a man enough toy blocks and see what he can do! A similar idea is used in newest release of **ZBrush 2019**, where people can use **filters** to achieve **stylized 2D rendering effects** by operating directly on various render passes.

**Turing Pattern**, or more specifically here what  is called **Cyclic Symmetric Turing Pattern** - which means when looking closely the patterns actually repeats itself in a cyclic fashion - is a **simulation based rendering**. It starts with various seeds, with specialized roles called **activators** and **inhibitors**. With clever tweak of the parameters the original author ([link](http://www.jonathanmccabe.com/Cyclic_Symmetric_Multi-Scale_Turing_Patterns.pdf)) was able to generate *organism-like textures* with varying depth on completely 2D images. Don't quote me on the mechanism of this - even after reading Turing's original paper on this idea ([The Chemical Basis of Morphogenesis](http://www.dna.caltech.edu/courses/cs191/paperscs191/turing.pdf)) I still totally don't understand why it can do this. I first saw this in *2013/2014*, and tried to implement the paper using **Processing 3**, but failed due to my *limited practical programming skills* and lack of *understanding of basic mathematical concepts* and related readings at that time. Even though I found a blog talking in detail about the implementation ([Softology's Blog - Multi-Scale Turing Patterns](https://softologyblog.wordpress.com/2011/07/05/multi-scale-turing-patterns/)) and found example **JavaScript** apps that did that online, I failed to implement my own Processing program as early as the second stage.

Then later at *2017/2018* while I was developing **MULTITUDE** and experimenting with **CUDA** based GPU acceleration, I attempted this again - this time with more care and patience, and successfully implemented my own version of Cyclic Symmetric Turing Pattern Generator with GPU acceleration support. Well it turns out it's not too much fater than pure CPU based algorithm. Much can still be improved, but that's some progress for now.

I still haven't figured out all the **intricate logics and behaviors** of this program, and I think I will attempt it again when I find time next time - maybe try it with math😏.

So the goal for next time: talk more about the *foundations* of this thing, try to gain more insight into the subject, and find mathematical representations for it.

## Bigger Picture

On a bigger picture, this brings us to the realm of "procedural generation", which is a topic concerning the love and frustration with Houdini, Project Nine The Matrix, and some ongoing projects.

From basic synthesized images, feeling awe-struck by [Ling Dong](https://github.com/LingDong-)'s procedural arts because he studied Computer Science and Arts (BCSA) (also we should not forget [胡渊鸣](https://yuanming.taichi.graphics/)), to procedural generation in general.

## Images

<img alt="Turing Pattern" max-height="512" src="https://images.totalimagine.com/turing-pattern.png"/>
<img alt="Compound Visual" max-height="512" src="https://images.totalimagine.com/turing-pattern-compound-visual.png"/>

## Discussion

<script src="https://giscus.app/client.js"
        data-repo="TotalImagine-com/TotalImagine.com"
        data-repo-id="R_kgDOH2l9mg"
        data-category="Announcements"
        data-category-id="DIC_kwDOH2l9ms4CQ8MR"
        data-mapping="pathname"
        data-strict="0"
        data-reactions-enabled="1"
        data-emit-metadata="0"
        data-input-position="bottom"
        data-theme="light_tritanopia"
        data-lang="en"
        data-loading="lazy"
        crossorigin="anonymous"
        async>
</script>