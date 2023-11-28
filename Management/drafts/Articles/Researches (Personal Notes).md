<!-- I am thinking of migrating all collection of "research topics" and half-way reserach notes into this document - from both P9 and The Matrix and other aspects. So we have a centralized place to hold such information. one reason for this is that BookmarkNinja is not reliable (it's slow and I don't trust the note-taking feature of it, and at the moment we are using Telegram to hold such temporary notes (I tried to put some comments into Notion in database table format - and now I deeply regret it because I will have to migrate it. Note that ALL LINKS ARE NOT RELIABLE and it would be to our best conscience that we try to quickly save those HTML pages either as printed PDFs or SingleFile HTMLs or even PNG screenshots as soon as possible. -->

<!-- Try your best to make those reserach topics self-contained, and do make more notes and simply copying-pasting links and expect us to have time to re-collect them in the future: most likely, I won't have time. -->

# The Matrix - Simulation of Planetary System

<!-- (We downloaded one of the PDF textbooks and was reading through it; I vaguely remember the book has the issue that it spent too much chapters talking about basic algorithm optimization and not about physics and actual astronomy related fundamentals) -->

https://www.science.org/doi/abs/10.1126/science.1159723
https://royalsocietypublishing.org/doi/full/10.1098/rsos.201271
https://academic.oup.com/mnras/article-abstract/499/1/1212/5911599?login=false
https://www.nature.com/articles/45123
https://academic.oup.com/mnras/article-abstract/512/2/2460/6544646?login=false
https://www.aanda.org/articles/aa/abs/2013/01/aa18792-12/aa18792-12.html
https://ui.adsabs.harvard.edu/abs/2020DDA....5110302V/abstract
https://academic.oup.com/mnras/article-abstract/493/2/1907/5764173?login=false
https://en.wikipedia.org/wiki/Star_formation
https://inspirehep.net/literature/1209527 or https://academic.oup.com/mnras/article/430/3/1599/977555
https://academic.oup.com/mnras/article/380/4/1589/1062391

Casual Read:
https://news.mit.edu/2014/universe-in-a-cube-0507

Direct PDF Download:
https://baas.aas.org/pub/2020n4i103p02/release/1
https://www.researchgate.net/publication/358997267_Birth_cluster_simulations_of_planetary_systems_with_multiple_super-Earths_initial_conditions_for_white_dwarf_pollution_drivers
Gravitational N -Body Simulations - Tools and Algorithms SVERRE J. AARSETH Institute of Astronomy University of Cambridge (https://libgen.is/search.php?req=gravitational+n+body+simulations&lg_topic=libgen&open=0&view=simple&res=25&phrase=1&column=def)

UofT Library Download:
https://libkey.io/libraries/278/articles/13453551/full-text-file?utm_source=api_1212
https://libkey.io/libraries/278/articles/411560826/full-text-file?utm_source=api_1212
https://libkey.io/libraries/278/articles/21276555/full-text-file?utm_source=api_1212
https://libkey.io/libraries/278/articles/519373902/full-text-file?utm_source=api_1212
https://libkey.io/libraries/278/articles/49104045/full-text-file?utm_source=api_1212
https://libkey.io/libraries/278/articles/369884577/full-text-file?utm_source=api_1212
https://libkey.io/libraries/278/articles/62340369/full-text-file?utm_source=api_1212
https://libkey.io/libraries/278/articles/369327941/full-text-file?utm_source=api_1212

# The Matrix - Interesting Procedural Generation Methods

Yesterday (20220913) I was generating my first pure c# procedural bridge using a cross-section and line path, today (20220914) I saw some interesting well-known algorithms that can do wonder. Would be nice if we can spend some time playing with those, then studying notes, then implementing those, and finally integrating and see what we can make of those in The Matrix (and for RTS).

(Must Experiment) (Put as experiment first before collecting into The Matrix)
https://github.com/mxgmn/WaveFunctionCollapse
https://github.com/mxgmn/MarkovJunior
(Those repos are C#!!)
Also collect the research papers from this page: https://jsantell.com/l-systems/

https://diglib.eg.org/bitstream/handle/10.2312/NPH.NPH07.063-070/063-070.pdf?sequence=1
http://algorithmicbotany.org/papers/colonization.egwnp2007.pdf
https://www.amazon.ca/Nature-Code-Simulating-Natural-Processing/dp/0985930802
https://wtf.tw/ref/shiffman.pdf

# The Matrix - RTS - Integration with Houdini

There are two ways to integrate Houdini (Engine): Simply basic command line use - 1) this is the quickest to integrate and the slowest in terms of performance, and we should start with this; 2) Houdini Engine P/Invoke of the underlying C API.

The docs are a bit hard to find directly by keywords, so we might want to save the following links

References:

* https://www.sidefx.com/docs/hengine/_h_a_p_i__fundamentals.html: Mentions which dll files are important and how to initialize the engine.
* Command line use: https://www.sidefx.com/docs/houdini/ref/commandline.html
* Python API: https://www.sidefx.com/docs/houdini/hom/commandline.html

Some guy have some good notes on it (pending recollection if they are worthy):

https://www.deborahrfowler.com/HoudiniResources/HoudiniCommandLine.html
https://www.deborahrfowler.com/HoudiniResources/Overview-CommandLineRendering.html
https://houdinitricks.tumblr.com/post/140476021844/quicktip-command-line-rendering-in-houdini

# The Matrix - BSP, CSG and Boolean Meshes

Notice CSG is a very specific and handy way to construct things, especially for blocking purposes.

https://www.worldofleveldesign.com/categories/ue4/bsp-01-what-is-bsp.php
https://en.wikipedia.org/wiki/Constructive_solid_geometry#Conversion_from_meshes_to_CSG
https://docs.unrealengine.com/udk/Two/BspBrushesTutorial.html
https://docs.unrealengine.com/udk/Three/UsingBspBrushes.html

https://bsp-net.github.io/
https://twobithistory.org/2019/11/06/doom-bsp.html
https://openaccess.thecvf.com/content_CVPR_2020/papers/Chen_BSP-Net_Generating_Compact_Meshes_via_Binary_Space_Partitioning_CVPR_2020_paper.pdf
https://en.wikipedia.org/wiki/Binary_space_partitioning
http://groups.csail.mit.edu/graphics/classes/6.838/S98/meetings/m13/bsp.html
https://www.geeksforgeeks.org/binary-space-partitioning/
https://github.com/andyp123/blender_io_mesh_bsp

https://www.jagregory.com/abrash-black-book/#the-human-element-of-code-optimization
https://www.scielo.br/j/jbsmse/a/WxdW6FYmbnMkKNQzHwrByHb/?format=pdf&lang=en
https://github.com/manthrax/THREE-CSGMesh

In the end we are just integrating with OpenSCAD to quickly solve immediate mesh needs (we found a C# library but its API sucks, good C++ libraries exist but we didn't have time to integrate yet) - this is slow, however, but it works for now.