# OTPP ????? ????-?? Reflection

...

## Data Source Change and Preparing for Next Co-Op

More than 40% of codes are cleaned, either modules are deleted, or legacy functions and less-frequent and less-clean structures are completely redefined. Less library modules are used, more are condensed together. This is partly in accordance to my previous discovery and concept of using a "solution level" modularization instead of "program level" modularization. A new module/program called Service Manager is used to control all those aspects of coordination directly on the process level, and lots of code originally devised to handle complicated object or task management are removed from the original program. 

Most of the code removed also involve reading and writing from files, testing services, old web front end views and controllers and models. It's either not sophisticated enough (for automatic reflection-based type and format discivery), or its too complicated (generalization is not helpful) and not specific enough (which is more than efficient). Reducing a few thousand lines of code, modifying and deleting around 300 files (most of which are generated).

....

After the changed files reach 530, and install have two whole modules of worth to change, I realized it might be be too much.

In the end I decided to give up, for the simple reason of being easy and approach it slowly. Is it morally bad? I think it is, but at least it's more healthy and manageable. The truth being that, it's not just this project that it will affect, the resulting change after removing all other old files will also require changing of existing data preparation layer, which is already implemented in another solution. I made a branch, just to save the change, and decide to make beer documentation, mentioning the potential change instead.

What I realized: MVC and Software Layering can be a burden of further development - that's likely the danger of over planning. The same in City Skyline? 
