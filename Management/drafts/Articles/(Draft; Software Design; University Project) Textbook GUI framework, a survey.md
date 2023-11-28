# Survey Article (Portfolio Grade): Textbook GUI framework, a survey.

1. In order to develop a standalone piece of graphical application at a level suitable for the job at hand, various platforms/programming languages/frameworks are available, notable: For native desktop applications, we shall use either Python or Java or C++, and the available corresponding graphical development frameowrks are pyplot and pygame, Swing/JavaFX, Qt/native OS api/OpenGL/SDL/SFML - however Python is usually not used for developing desktop applications due to its slower performance; One might also consider using Matlab and MATLAB App with App Designer; For storage of actual data, several scheme can be used, most basic one would be to host each content in a seperate specialized webpage/window, depending on the framework we are using, other solutions including formalize the contents and allow dynamic generation of presentation based on datasets, in which case a database will be needed, the solution of database are massive, most common free RDMS including SQLite, MySQL. For rapid integrated desktop environment, one could also use electron frameowrk with JS. low level drawin,  + front end framework/engine. For web based applicatoins, we have the option to divide our application into front-end and back-end or use a mixed solutions. The available frameworks and strategies and combinations are so large to enumerate it will be impossible to discuss. In my personal humble opinion, this kind of choice depends more on what is readily available at hand rather than what is "best" suit for the job for this is such a generic kind of software development need, there is no very clear trade offs - unlike rendering intensive applicaitons, the graphics rending part of this project is not going to be very intensive (e.g. like a game engine), so as long as the framework being chosen has decent gneral purpose drawing capabilities, we should be good.

In the end, the efficiency for quick prototyping is considered more important than anything else, in that case higher level scripting language based drawing framework is clearly prefered. For that we have the options of using either OpenFL, Processing 3, or a general purpose game engine that supports Low level 2D drawing (with both real time and export capability). A game engine might be a bit heavier than the actual application itself, but the infrastructures provided by such a software is usually quite intensive and will support all our needs and avoid the effort for tweaking low level graphical issues.

(This article is slightly different from the actual submitted assignment for course fulfillment purpose - some sections below are original)

Let's face it: **learning about circuits** is hard, I mean not simple circuits that involves only resistors, but circuits that continue **a multitude of components**. It's hard especially because most of the time during learning it you don't even see a real circuit, and it is hard to understand it's **behavior** only from theories.

(Project Objective) (Background) Our purpose is to build an application that can give **electronics and electrical** students intuitive understanding of **fundamental principles** and **operation** of electronic devices and electricity. During our own experience and instuctor's advice, we identify that **Op Amps**, **Transformers** along with ... are the hardest concepts to grasp. 

It's quite clear that to intuitively understand the behavior of such circuits, one needs to **experiment** with it (research and citation required), either physically or through simulation (research or citation required), however even for the most trivial circuits, both **building** and **run simulation** can take some time. For instance there can be issues involved with wiring and faulty electrical components, or in case if simulators, the choice of platform, installation of software, assemble of circuits and setting up proper component properties and probing configurations all take time. However such a setup process may or may not be beneficial to the appreciation of the underlying behavior of circuits. What we would want is thus the simulation of **predefined setup** of all kinds of circuits available in **second and third year courses**, ideally also categorized, readily available for inspection and experimentation.

For utmost accuracy and flexibility, we would like to have a **real SPICE simulator** embedded inside our target application if that's possible, but we shall also know that, for any given circuit configuration, it's behavior is **quite specific and well defined**, in which case for simulation purpose - I.e. only a few input parameters are changed and specific target output levels are observed, one can get away with hand calculated simulation formulas embedded in the simulation instead of relying on full blown real scale simulation that may also slow down the interactive experience. The same applies to the configurable range of properties, e.g. for a simple RL circuit, one probably doesn't need more than a slider to be able to specify input values for resistence, inductance and supply voltage, in which case a whole variety of interface elements can be eliminated (when compared with a real SPICE simulator) for the purpose of demonstrating the behavior of **very specific circuits**.

Our purpose is thus to provide a library of such circuits so that people can **learn by experiment**. That is, our purpose is not to rewrite a SPICE simulator or textbook, but to provide such circuit configurations that the behaviors of the circuits can seem intuitive. We think/identify to properly **understand** a circuits behavior, one would need the following information: 1. Name of circuit, if available; 2) All changeable parameters of the circuit; 3) A text description of the behavior of the circuit; 4) The circuit itself; 5) Output waveform of the measured voltage levels at all cases including extreme values of the inputs as realistic as possible e.g. for Op Amps it should cap at saturation level, or otherwise indicate the circuit is assumed to be ideal.
It's essential **we cover as much as possible**, however all examples in a second/third year course can be very large. thus it's evident that we need.... **The more the better**, but the (software) engineering chanllenge part of this project resides in the fact that we need to be able to do this **efficiently**.

The simplest solution is to: 1) get all the diagrams on the textbook, either through scanning or hand drawn (I.e. use a software of by hand), which may take around 5min to 1hr each diagram; 2) Get the core formula for the circuit configuration, which may be more than one, this takes less than 1 hour; 3) Generate using MATLAB a table of varied inputs and outputs , depending on setup this may take around 1hr each. 4) Create a static PDF or website containing all above data. This will work and it serves our purpose of "....".

Two things from above are not ideal, which directly affects the efficiency of the process: 1. Collection.... 2) interaction.... 3) Compactness.... 4) Redundancy.... 

We identify the key aspect of developing intuition as being able to quickly test your prediction - if everytime one makes a prediction it takes more than an hour to verify it then he won't be able to experiment enough times form any useful intuition. Ideally one should be able to just open the app, go directly to the circuit of interest, and setup a few parameters and immediately see it's effect.

For this application to be usable, a decent coverage of knowledge is necessary, so people can actually rely on it rather than constantly switching receiving soirces. It must be in a sense self contained (this is even more important than any other performance criteria!) .If we would like to have 500 examples from second year book, and 500 examples from third year book, and we have 200 hours for 8 months for each of the team member. We much get all of the above process done in 600 hours efficiently...

With all that settled, another issue concerns navigation. Still using the printable PDF format as an example, there are those basic ways to navigate a book: . 

For reasons that will not be covered here, we will also providing a tagging scheme. (See reference for some ddtails), and replace the index format. Though an index shall be provided if appropriate (with reduced level of navigation).

( Also depending in purpose - Content is what makes a tool usable, not technology)

```markdown
Items:

1. Research and setup practice for specific tools.
```

(Tradeoffs) After careful examination of doc and setup test of the various tools available, below solutions seem most viable: 1. Qt, 2. Processing, 3. JavaScript. A brief summary of approaches of those tools are mentioned:

1. 
2.
3. 

Talk about Superior launcher design.

Talk about real client as Tate. Assessment. Better if he actually use the tools and provide feedback so we can improve it throughout the course.

## Formal Treatment

**Definitions**

We define below terms to clearly identify the need, criteria and metrics used to be design and evaluate our system.

1. Accuracy: Accuracy is simply defined as the margin of error within the allowable range of input parameters between the generated results from our applicaiton and that of the benchmark (e.g. LTSPICE) software.
2. Completeness: As an educational software, the amount of information users can gain directly affects its value. Completeness is thus defined in terms of the amount of explicit knowledge points, explicit mentioning of electrical circuit formulas, and the amount of example circuits that is convered by our application.
3. Efficiency: Efficiency is defined in terms of development the amount of time needed to obtain a finished product; In terms of user experience, efficiency is deifned as the amount o ftime needed to access the tool (including opening, downloading, running) and the amount of time needed to navigate to a specific circuit, and the amot of time needed to start experimenting with various parameters; In terms of software performance, efficience is defined in terms of the amount of time or delay it takes for any given change of the input parameter to generate new output waveforms or diagrams. For real time application (as in our case), we expect response from changing parameters to take less than 33ms (as is standard in real time software applications - citation needed).
4. Portability: The amount of (OS) platforms supported, the amount of devices reachable.
5. Interactive Experiment: An interactive experiment is defined as a diagram that allows user changing parameters either by typing or clicking/dragging on the diagram, which then immediately updates its results (e.g. element shapes and output waveforms).

We do not use terms like "Ease of use", which are just marketing ????

**Solution Components**

The whole suite of solution will be composed of the following major components, notice some components will be handled by framework/existing free programs/libraries. What matters is the end result that we present: a website that allows people to experiment with predefined circuit illustrations from the chosen textbooks.

1. A front end website for presenting and allowing user intereaction with various circuit diagrams, the front end may also save user sessions; This part may also optionally contain the server if we shall host it ourselves.
2. A diagram sketching language framework based on Processing allowing rapid development and prototype of interactive circuit related diagrams.
3. A large set of either handmade or generated circuit dragrams (i.e. using the description lanauge above) or mixed that are then presented to users.
4. Accompanying explnanations, concept highlights for each interactive experiment.

## Issues and Resolutions

1. A heated discussion about whether to use Google Doc or Github for the interanl documentation is raised during the process of creating this draft, the scope of the problem concerns not just the draft itself, but also where and how to keep track of all the project documentations, specifications, thus some discussion here is worth noting: 
	* Google doc provides version history, remarks, editor names and readily available cloud based browser access; The biggest issue with that is platform/format restriction.
	* Git provide text-based version control, diff...
	* Also worth mentioning is the use a wiki platform for internal documentation.
	* One reason that is not acceptible is the unfamililarity with the tool and comfortness with keyboard/UI/Google doc. In which case the measuring would be: how long will it take to learn about the new tool, and how much performance boost will it provide after we acquire the tool?

## Proposed Milestones and Task Assignment

Below are some of the immediate task items for the scope of the project as described above (The project is divided into 3 stages):

1. Platform customization and deployment (Stage 1): One person is responsible for researching, setup and configure the target web platform suitable for actual deployment; Ideally we should have online server running while we are doing the development, so we can test and see results as close as possible to final production during the development.
2. Scripting/Drawing framework research and design (Stage 1): One person is responsible for drafting the framework for all future creation of the illustrations for the website, specifications, conventions, and some rationale about the framework being chosen/created is expected. Intensive research about available methods/framework for drawing and interactive applications is neeed. As proposed about, such a framework will be constructed based on Processing language, in which case the interactions about component libraries and how we are going to structure our codes (including function calling conventions) need to be established.
3. Content collection and drafting (Stage 1): One person will be mostly responsible for providing an overview (as text document) for the most critical subjects involved in the scope of the project, before other team members participate in specific collection of examples. Most importantly, this stage should cover: 1) All important chapters of book we intend to cover, 2) The key illustration ideas when doing the interactive experiments, 3) Overall design style and graphics development direction etc.; 4) Identificaiton of potentially reusable graphical elements (e.g. shape of the resistor) is also identified at this stage.
4. Infrastructure (Stage 2, Stage 3): Constant modification and optimization of underlying platform and even the scripting framework above is expected, we will need to keep track of all the major changes to the convention, semantics, and components of the scripting framework in a github documentation, written in MD.
5. Specific examples and illustration creation (Stage 2, Stage 3): During this stage most of the effort will be put into drafting, creating, using, testing and optimizing the contents for the website, so it's suitable for the final presentation. Discussion with instructor and testing on various platforms to see actual performance results, and ideally surveying with real second and third grade students to get their feedbacks on the intuitiveness and information of the presentations are expeced.

## References

1. Decision on tag based file system
2. Some famous text books do have an online version of some example problems, for instance... The major problems with those are: 1) Not free; 2) Super ugly, not maintained, Java dependency, not modern, not mobile friendly, no explanation or sluggish interface, look too simple and trivial.
3. For each circuit we provide, we aim at providing a real time simulation that is closest to physical behavior possible, in which case we will be using NGSPICE or LTSPICE simulation for reference, for that purpose, we may also append the corresponding screenshot from the circuit simulation software to each question we upload.
4. Textbooks:
5. Lab assignments:

# Further (Personal) Research Items

* (Proposal) Survey other solutions (including web and graphics engines. Mostly just strengthen jts features that suit our needs: cross platform, UI framework, database support, native performance, instant run. Not dependent on web browser or any other modern dependency (but why do we care?) - simple and approachable, whatelse need to be justified? Cheap and easy, that's it. Maybe add onto: nothing is cheaper and easier, and don't want waste time even thinking - with that time of surveying, half the job would already be done. (Good point, 👍)
    * (Proposal) Maybe what we can do is to justify "you cannot find anything better", e.g. "you might be thinking about Java Applet, etc." Then we will need to talk about native UI and good looking which is hard to justify anyway (unless we learn modern design languages). (Question) how do we quantify aesthetics? Colors, design fashion (80s vs modern metro flat), highlight, visual cleanness, flexible layout, interface interactivity.
