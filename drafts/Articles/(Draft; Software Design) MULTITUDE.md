# MULTITUDE, or Part of the SIS Initiative

It has been quite a long time ago and I can barely recall that "**SIS**" stands for **Structural Information System**, an initiative to organize **everything** I have in a **structural and accessible** manner. The exact meaning of this will be proposed in dedicated article for SIS in **Concept Design** category as a theory some time later.

## Background

**MULTITUDE** is a magnificent **whole-desktop working environment** intended to substitute **Windows Explorer** for personal use. It contains integrated *text editor* (using rich text editor), *media player* (using VLC media player), *web browser* (chromium) and *image viewer* (WPF native) - all with customized (i.e. by me, rather than being "customizable") and integrated interface. The motivation of this project was deeply concerned with how I *took notes* and how I *managed personal files*. Some may think it's too far reach, however I did find comfort when I found out I am not the only person frustrated by existing operating system's **hierarchy based file system** (see Project Nayuki's [article](https://www.nayuki.io/page/designing-better-file-organization-around-tags-not-hierarchies)). Talking about that, the focus on mouse based GUI also seemed a bad idea nowadays - however at the time of development, it's mostly focused on GUI. It is my practice project for learning practical **C#.Net** desktop development skills with **WPF framework**, and it gets paused when I went back to school.

When I say "**integrated**" and "**whole-desktop environment**", I don't mean a desktop software package like Ubuntu or X windows system, I mean something more like **windows explorer**, but with a much more advanced preview and editing capabilities... (Bad justification).... The central problem involved ... I was frustrated by ever growing amount of ever deeper file hierarchies and not being able to quickly navigate to and open various files I needs - imagine you need to write a book, or biography, then you will need to go to /Notes/Personal/DailyJournal.txt, and open /Writings/Biography/MyBook.docx, and open a web browser .Play some music...... With all those annoying windows scattered around your desktop, and windows have no virtual desktop (at that time) and you need to keep all those media player open while you don't really need it. . . At that time I don't know CYPlorer yet so no working sessions of folders, and no SearchEverything for quickly locating any specific file..... 

(Regarding the central problem) I was not that academical, so I couldn't formulate around the concept, but rather a series of attempt have been made (and failed) in order to solve the problem. For my notes I had several small dedicated editors which I later found not that useful, and one larger (and turns out to have more profound impact on my software design skill than note managing capability is Dream Editor). 

In 2017 summer, I decided to build my personal desktop enviobment and file management system on top of existing windows infrastructure and in term optimize my windows usage experience, since at that time I have acquired WPF for a while and desktop programming skills had becoming more practical (compared with dealing with raw Windows API).

# The Scope

The project had one intention: ditch windows explorer and remove its dependency completely (again, for personal use. I didn't consider how this plays with other softwares or how this fits others workflows), but desktop environment is not just about browsing files (actually nowadays I find text based command s on Linux more efficient for this purpose).  Rather I would also want to be able to perform some daily tasks directly on my desktop in an integrated way - hense the name "Integrated Desktop Environment". 

Looking back to what I concpetualized 2 years ago, this project is quite non-trivial - I would say this project has the scope and scale comparable to my Dream Editor project. Even though when compared with later many-year projects it's not that big deal, it still surprises me the involvement of many distinct software libraries and how I even managed to develop a workflow between local PC and Andriod phone for note synchronization - all of which are not used after development because the functionalities and features are not complete so they are not really usable. What also surprised me is the emphasis on integration with Airi, and I vaguely remember a seperate project - the Structural Regular Pattern parser - is conceived and implemented 3 times using manual parsing, regular expression parsing and Ruby and most recently I was thinking about the possibility of  re-implementing it using the techniques I learnt while working on Universal Construction Language project using existing parser libraries for Domain Specific Languages. It was still great pleasure to just open the application and see familiar interface, even though I feel totally uncertain about it because I forgot how it worked. If I had a chance, a revamp of the project using SQLite as backstore and everything else tested properly will follow. 

It certainly is a brave attempt to integrate the process, and the bold move to re-implement everything that doesn't fit the style and methodology, including folder browsers, and matain states of desktop environemnt (including multi-media objects) is really a very cool idea. I remember working on named virtual workspaces and pages, those are some essential features that no one bothers to implement but so essential and meaningful - only if it could have completely finished. Much much effort is needed to simply review implementation, collect notes, elaborate on methodology and concepts and theory, and work on details of implementation to get everything right, and finally clean up repository and organize files well. Hopefully after that have done, the project can last a few more years.

# The Development Process


...

One big issue I had once was the loss of hundreds of text note file...

Then I went to scholl, this project gets halted...

I am busy with other projects right now. Some are of a smaller scale some are as imaginable as it can be. I figured it's not a good investment to spend too much time perfectionize a product - after all I am not a business man and I intend to grow fast and server myself. It's actually easier to find some existing tools, and instead of rewriting or designing new stuff, find and professionalize a ''workflow''.

Deprecation of clue based system; Too much effort on UI integration and workflow programming; Discovery of everything; Intention to drop clues altogether and use tags instead.

Mistake in approach: In software development there is something called "brownfield approach". I don't knwo what other approaches are there but it is illustrative to have some comparsion before we dig into the details: .... In my implementation because I started with augmenting existing files, the appraoch was document based, changing and adapting raw files, developing custom formats. Instead we can use metadata instead and make it annotation based. The problem with this issue is exactly the problem with shell integration and that is a lot of mess with programming against OS api. For instance: in order to known when and how things are changed you have several appraoches: 1) Go though system API and look into maybe NTFS file journal and abck-trace changed files; 2) Keep a note of important files and optimize the searching process by focusing only on those files; 3) ???? Use XYPlorer's appraoch; 4) define a custom folder and use git's approach to identify changed files however this cannot solve issues with renaming ....

Let me talk about another, very very big issue: no version control. Nowadays it is hard to imagine start doing anything non-trivial without a version control, keeping track of progress at every step, but my very first medium scale or 20k C++ program was written entirely with the help of manual backup and text journal. Things gets messy quickly this way if no proper descipline is imposed, even so sometimes the bookkeeping cost is too high it hurdles development.

''Remark on Design''

Problems:

1. Not modular, making the thing either work or not work at all -- well we shall focus on one at a time and make them just work
2. Tools are not standalone problems that can be utilized for other purposes e.g. graph editor -- make those tools stand along so we can use them when needed
3. The Home structure is not compatible tiwht existing file system, which can be useful from tiem to time -- well utilize Everything and other methods to work with existing folder structure, along with out tag structure; If files are changed outside the application, we shall give options to update links
4. Don't read or even touch contents of files all at a time to avoid data lose -- require thorough logic check; Be very specific and explicit to users when and how contents are changed etc.
5. FOr now we just need the node editor like scapple, with multilayerd/grouped nodes; And a tag system that hopefully extendes windows shell and works in the beckground keeping track of file changes.

Now, those issues are partly a design issue, but another important motivation for choosing to design it this way due to the consideration of a software component that was actually important since the very beginning of the project, which I will talk about next.

# Integration with Airi

My first serious attemp to solve issues with managing personal notes was actually not a custom text editor, it was called "Quick Match", a tool for searching indexed files and intended to also search indexed text contents. That name descibes its function well but the ambition behind it was to actually build the foundation for something bigger - Airi.

Airi was conceptualized as a storng AI since the very begining when I first perceived the idea of AI fantasy. Or as my friend joke about it: Charles intended to build an AI girl friend for himself. Not quite girl friend, but an customized assitant might be more appropriate.

So when I started to build MULTITUDE - the foundataion project has another name, it's called "SIS".

...

Airi is still a dream, or as I realize it now - not enough data/tools are available in order to realize it in a ''trivially efficient'' manner yet. So it's better to ''focus on foundations'' now.

# The Theory

# The Conclusion

As a summary.

**Methodology**

1. I just want something that does something, I don't care how it's implemented, what it looks like, who developed it, how does it handle the files;I do expect it understand my files.

I just wish to open images, play music, play videos. Windows operating system, when compared with other Linux packages let's say Ubuntu, fall short on this aspect miserably. It's .... it's fancy, but weak.

No I this is not simple task, but that's exactly made the world messy and why from a users perspective an integrated environment is critically important.

…

How much can we learn from our past? Well if you have taken notes, you might be surprised how much you have forgotten, and how much you thought you didn't know.

# Future Proposal

**The Integrated Environment**

Borrowing ideas from object-oriented programming and building on top of above Nayuki's tag-base system, I identify one possible implementation of an integrated file system with a focus on information organizability and retrievability with 3 types of information management system: 1) Entity-based System; 2) Categorization System; 3) Tag Based System. The meaning of each are defined below:

1. Entity-based sytem: Database table, structure, object instance
2. Tag for specific object/subject/terminology name
3. Categorization system governing both entity and tags

For instance...


How efficient is each?

''Component based object model files ''

Now this is a fantasy, but it's a cool one so let me tell it:

# A ''datablock'' stores one particular piece of information
# A datablock can be of any size, its content is application specific
# A ''meta structure'' is used to describe and identify the data block in any of the means mentioned above
# The data block itself can be stored on storage medium (e.g. disk) in whatever way that's suitable or even just as old-plain-files
# An ''object'' consists of multiple such datablocks, which describes the ''components'' of it
# The object can be optionally constrained by an ''object model'' like in a relational databse
# This implementation of this system is super simple and it suits all the needs as proposed above
# For programming purpose depending on the application's needs it can option to each of the ways
# A manager service must be provided either by OS directly or as a separate layer built on top of exisint OS systems 

''Programming model and usage model, file type and application association:''


(Organize and collect SIS notes)

''Implementation''

The idea of an integrated desktop environment should ideally, be really provided at the operating system level and provided as a framework, a platform and a suite of APIs for programmers. This will obviously be another huge layer of abstraction on top of existing file system infrastures, letting alone the difficulty of standardizing the way things look, the way they interact with users and with each other and provide functions. However this is something interesting to think about - what would the most ideal OS/Desktop environment be if we were to redevelop an OS from ground up? 

I think it safe to skip all the complexity of low level hardware and operating system stuff and focus in user data and daily task, so instead let's ask: if we are going to build on top of some existing OS kernel core, what would be the ideal framework for desktop takes?

The implementation doesn't need to be on the system level, because a software called XYPlorer almost implemented the hardest part - tagging system purely based on shell integration. Although it would be nice to have system level notification and file binding mechanisms exposred .... (details...)

 ....

# Misc. Topics

## The Correct Way to Manage Browser Bookmarks

One thing that is so sick about modern browser (I don't blame the internet) that it makes me vomit (I have so much resent for existing schemes that I am actually using a lot of negative words in this sentence) is that it doesn't have a proper support for **Bookmarks**. Chrome is rudimentary, Vivaldi took it further but still is child's play. No one seems to care about proper organization - the internet is full of shit and if we don't take care ourselves organizing those shit the whole world will be burried deeper under shit and no one can save us. (Remark: if you don't like the wording of this paragraph one thing you can do is to replace the word "shit" with something more delightful e.g. "flowers", "jewels", or "love")

Now as mentioned above (hierarchical) category based approaches failed miserably when it comes to managing bookmarks: the sheer amount of web addresses and the very un-self-contained and minimal-data nature of such "items" demand for some organization scheme much more lightweight and much more efficient for quick annotation. Folders and directories don't work - please new browser developers stop providing folder as a solution for bookmarks of web addresses, not even providing as an optional approach - it's like asking a child to eat shit while forcing him to categorize the shit he eats rather than tell how he actually feels - just stop doing it!

A partial example of this approach is implemented by a tool called Bookmark Ninja...

For presentation purpose, one thing we can do is to build hierarchical structures using filter expressions...

I ask myself why those people using tags not realizing the "correct way" of implementing and using it? It feels like the obsession with tradition and bad old approaches really drags us down. Coming up with a clever idea is no simple task. 

You want to know why other intellectual extraterrestrial species call us humans single-minded? Just look at how we organize information! Hierarchical mutually exclusive categorization scheme is devised due to physical limitation of non-simutaneous existence of solid objects, it's utterly against the nature of how human minds can optimally work! Use tags, use graphs and neuron-like links for organization of information and documents, stop using libraries and bookshelves!

## The Possibility with Filename Augment File Organization Scheme with Everything on Windows

A Linux KDE counterpart is called ...

# Article Development Notes

1. **To Finish Reading and Collecting**: Windows Internals Chapter parts on NTFS and CLFS, do some elaboration, take some notes, practice a bit if possible.

# Research

1. Efficiency of Text Searching algorithm - how can Everything be so fast and Microsoft index be so slow?


# Part 1 - The Development Process

# Part 2 - The concepts (This should present first, try to define your conception/idealization crystally clear)

Imagine a Windows which satisfies all your daily needs (with confined scope) without needing to deal with any "software" - an environment, much like an IDE, but dedicated for managing all your daily matters rather than programming.

# Part 3 - Everything Else

**Other Solutions**

1. It turns out Windows Explorer is not just an "Explorer-Style" windows application for people to browse files and drives in a hierarchical fashion - windows has such a thing called **Shell Extention** that people can program against to extend current abilities of Windows Explorer, some examples are seen here in [SharpShell](https://github.com/dwmkerr/sharpshell) library. Clearly **Backup and Sync from Google** and **OneDrive** uses this technology.

# Part 4 - Conclusion

I came up with one way to perform **software modification** while working on this article: To make it **file centric**, use a database for meta; And to make it **"Home" centric** - achieved in Somewhere; Think about integration instead, hopefully we don't provide a redundant interface - discussed in **"Futures"** section.

# Misc Notes

1. Solution for Enterprise Level nonlinear tag based file sharing and collaboration: use a text language (e.g. markdown or some extension) and single file text based presentation, then use tools to generate presentation mediums on the fly (e.g. PDF and Excel).

# Reference

1. (Pending) https://github.com/nayuki/Relational-File-System
2. (Pending) https://www.nayuki.io/page/designing-better-file-organization-around-tags-not-hierarchies