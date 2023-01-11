<p align="left" width="100%">
  <img height="56" src="img/logo-ait.png"> &nbsp; &nbsp;
  <img height="56" src="img/eth-sip-3l.png">     
</p>

# [Programming], Group 13
#### Matthias Schenk, Ziruo Xiao, Luca Pinggera, Nikhil Sethukumar

## Project description

Develop an interface that would introduce basic concepts in programming to a beginner.

## Ideation

### Evidence:
As for evidence for need, we did research mainly based on different target groups/scenarios and problems in the current programming study process.

Programming is a highly sought after skill in the job market, no matter for professional or non-professional programmers. Statistics have shown that jobs that require programming skills with high pay will grow 22% over the next decade. Companies also realize the value of finding an export in a specific discipline (frontend/backend engineer, AI engineering, etc.) instead of a general computer programming position. This requires programmers to gain more advanced knowledge and skills in specific fields in order to be competitive. Moreover, for non-professional programmers, basic programming skills are also beneficial to use many highly automated tools in various fields like finance, biology. These tools may even be coding free and users do not need to be proficient in a specific language, but basic programming knowledge will help them better build and troubleshoot their works.

We also tried to figure out problems in programming study for beginners or intermediates with current study tools. For beginners, it may be hard for them to figure out their needs, grasping the basic concepts only by self study with the professional coding tools. We’ve found a video that gives a nice approche on how to start learning how to code, from figuring out what you want to do, learning about what tools and languages you would need to learning the basics of the language. It’s also hard for them to set up the environment, to compile, run and debug with current professional tools with commands and messages in low readability. An article also points out that it is important to learn programming rather than only learning a programming language, as syntax may be similar between different languages. How to learn a complex algorithm, for example, is instead what students are struggling from. Therefore, they are in high need of a clear, convenient, not that boring tool to make everything simple. Furthermore, it’s of high importance to build a solid foundation for beginners, and they want a systematic tutorial as well as a comprehensive learning resource. As for intermediate programmers trying to improve their coding ability and find possible jobs, they also may find it hard to determine the skill gap, and find ways to improve in high efficiency.

In a nutshell, evidence shows that we are in high need of tools that make programming study more convenient for various groups in various learning stages.

### User Needs:
We generally separated the user's needs in two dimensions. The first dimension covers the technical and non-technical aspects of learning programming related skills and the second dimension is about the level of experience a user has. The non-technical needs are independent of the skills of a user. No matter how long you may have been coding you always have to deal with frustration, making time to learn, figuring out what to learn, and who to ask for help when you are stuck. On the technical end, the challenges for beginners and experienced programmers differ greatly. Beginners will have more issues with setting up a coding environment, handling error messages, or using debugging tools. However, people with prior knowledge might want to learn something very specific such that there are less learning materials. Or, the available learning materials require you to first understand some other topics before the explanations and tutorials you find are helpful.

### Solutions:
Most solutions fall into one of two broad categories.
 
#### Expanding the know-how of the user:
These solutions often take the form of (Video-) tutorials or online-classes and try to teach the user new skills (the basics of coding, a new language, etc.) and are usually done by self-study. The difficulty of those topics can vary from beginner up to expert. 

#### Making programming more approachable for beginners:
This is mainly done with two different concepts that often go hand in hand.
The first concept is to simplify the programming environment. Generally these environments have limited instructions, are easy to understand from the visuals alone and have a building block based approach to programming. 
The second concept is to gamify the coding experience. The user is given different tasks which can vary greatly, but they are usually visually interesting, quick to accomplish (2-5 min) and the problems build on top of previous tasks. 



### "How might we" statements
    
1. How might we reduce the barrier to entry for people to start out with programming? (Reduce error messages, compile errors, setup of the environment, clear interface etc.)
2. How might we help people to figure out what programming skills they should learn to match their needs?
3. How might we introduce fundamental concepts to beginners and guide them through the learning process (difference between children and adults)? (abstraction of content)
4. How might we deepen or refresh the skills of already experienced programmers?
5. How might we communicate to people that programming is beneficial for their career?
6. How might we make learning programming fun/not boring and challenging? (presentation of content)


#### Brainstorm

Results of the brainstorms at: [Unclusterd Brainstorm](img/Brainstrom%20unclusterd.pdf), [Clusterd Brainstorm](img/Brainstorm.pdf) 
 
Miro link : https://miro.com/app/board/uXjVPQxLcH0=/?share_link_id=159353159023
    
<!-- ## Evaluation

    TODO -->

## Low-fidelity Prototype

### Idea A
There are people who want to start their own project, but don't know where to start. The idea of this app is to guide them step by step through the process of choosing their tools, installing them, and having a collection of guides to those chosen tools.

![project helper](/img/Storyboard_project_helper.jpeg?raw=true )

<img src="/img/paper_prot1.jpeg" width=45% height=40%> <img src="/img/paper_prot2.jpeg" width=45% height=40%> <img src="/img/paper_prot3.jpeg" width=45% height=40%>  <img src="/img/paper_prot4.jpeg" width=45% height=40%> 



### Idea B
The idea is to make a puzzle game, where the user needs to code with command-blocks in order to solve the puzzle. The user gets a higher score if their solution is more "efficient".

![block game](/img/Storyboard_block_game.jpeg?raw=true )


### Idea C
People may want to learn how the program is implemented in a specific language apart from the coding-free blocks OR they want to learn a new language's syntax with knowledge of another. The idea is to have tools to translate between different languages & blocks and to provide tasks in different languages with blanks to fill in. Hints with related knowledge would be provided.

![language_tool](/Deliverables/Low-fi%20prototype/IdeaC/Storyboard.jpg?raw=true ) 
    
### Idea D

The user is a beginner to coding and want to learn about coding methodologies. They are given the building blocks and minimal advice, and are motivated to program a game and in the process familiarize themselves with concepts like control and loop statements, arrays and classes etc. 

![game making](/img/Storyboard_game_making.jpg?raw=true )

The interface for making the game would look like

![game making_interface](/Deliverables/Low-fi%20prototype/IdeaD/Paper/Interface_1.jpg?raw=true )

and the game once completed will look like

![game making_demo](/Deliverables/Low-fi%20prototype/IdeaD/Paper/game_making_demo_GIF.gif?raw=true )

## Mid-fidelity Prototype

### Prototype A

The low-fi prototype Idea D was taken further and developed into an interactable prototype. This was done in Powerpoint as it was easier to implement the idea here. First the user is led to a welcome screen which leads to an interface with the variables and functions on the left and the program logic on the right. Clicking on any of the blocks expands them to show the constituents which the user can implement. Once ready, or if the user wants to see the result of the code they have implemented so far, they can click on the "Simulate" button. We wanted to implement drag and drop functionality for the buttons too, but that does not seem possible in Powerpoint.

![midfi_ptA_1](/img/Midfi_ptA_screenshot1.png)

![midfi_ptA_2](/img/Midfi_ptA_screenshot2.png)

Here is a link to a video illustrating how the prototype works: [Walkthrough video](/Deliverables/Mid-fi%20prototype/Idea%20A/Midfi%20prototype%20A%20walkthrough%20video.mp4)

### Prototype B

The low-fi prototype Idea C was taken further and developed into an interactable prototype. It's a block-code translation programming tool. Users could use the block to build their own program, and here we have the basic program and provide four blocks for user to add to a fix position by click for convenience (which supposed to be dragged). Then user could choose to either translate the block-based program to a certain language (C++ as an example) or try the task in it to learn the syntax. Random section of the code would be left blank for user to fill in as tasks, each with hink on the related knowledge (see by clicking the star next to the blank). The block, translation and task interfaces are connected to each other.

The screenshots on the left demo the two functions with the basic blocks, and on the right is the case with another block added.

![midfi_ptB_1](/img/midfi-ideab.jpg)

## Peer feedback

Testers:

Luca - Group 07

Matthias - Group 01, 04

Nikhil - Group 01

Ziruo - Group 01, 04

### Prototype A

We received mostly positive feedback about the prototype. The testers initially took a while to get hold of the idea behind it. They appreciated the framework and how the prototype looked, and suggested that having an introductory guided tour of what each button is and how it woks would be beneficial to the user, as well as short description of what variables and functions are and how they would work. The TA mentioned an ambiguity between the right and the left panel, about which buttons are "clickable", but this could be easily rectified using a different color theme for each side. Similarly, it was suggested that the dialog boxes for creating new variables and functions looks similar to the code blocks themselves - this could be sorted by using different positions/colors for the former.

In case the user is stuck in the middle, suggestions as to what can be done next can be provided. Also the end block looked empty, like blocks were required to be inserted. Its appearance could be changed as well. We plan to go ahead with this prototype and make the hi-fi prototype incorporating ideas from the other prototype as well.

### Prototype B

The testers got the idea quickly and were mostly content with it. They found the hints a especially usefull feature. The conistant complaint was that they naturaly  first looked at the translated code before starting the task. This they found counterproductive since they already have seen the solution to the task. This could be fixed by either only allowing them to view the translation after the task or by switching the position of the buttons. There was also a slight confusion on which buttons are a part of a code block and which are not. This can be fixed by distinguish the code blocks by making them with rounded corners for example. The TA also mentioned that c++ might not be a good choice for translation. He also felt like the sandbox style left him feeling like he did not know what to do and with a lack of motivation. To fix this the tool might requrie some task that the user is supposed to implenent with the code blocks - this could lead to a natural pairing with Prototype A

### Conclusion Mid-Fi Peer-Feedback

The feedback we received gave us important insight into how the tool guides the user and how design changes make the tool more intuitive to use. 
Concerning how the tool interacts with the user: There should be some introductory tour to familiarize the user with the features of the tool. Upon entering the sandbox mode, the user should be provided with some initial tasks. The tasks will keep the attention and motivation of the user and spark the imagination of what is possible to do. Additionally, there should be some hints if the user is stuck and descriptions of buttons with a short explanation of their function.
Regarding the design and to increase the easiness of use, we should introduce clear visual distinctions between interactable and non-interactable buttons. This can be done on the one hand with placement and on the other hand with color scheming. 


## Hi-fidelity Prototype

### Idea

Our prototype will be a block based coding environment that teaches core programming concepts to beginners by programming/modifying a rudimentary game. The prototype lets users interact with and modify the pipeline of the game which then can be simulated and played by the user.

### Core functionality

The use of the prototype starts with a guided intro that produces a rudimentary game. The intro lets the user see the effects of classes, functions, and variables and provides a foundation on which more functionality can be built on later. At the end of the intro, the game will be simulated to provide a direct visual feedback of the things that were implemented before. 
At the heart of the user interface are the code building blocks and the game pipeline. Each stage of the game pipeline can be inspected and modified by the user. Modifications will be performed by inserting and combining the code building blocks which can be inserted into code fields.
Should the user feel stuck, hints on what to do next and descriptions of the initially provided code blocks can be accessed. Through the code blocks the user can intuitively create pseudo-code that gets translated into real code in the back-end for the simulation of the game.
Because getting started is always a little bit daunting, we will provide the user with some initial task and game feature ideas to spark the imagination of the user.

### Core UI

The UI will be split into two panels. The left panel is for classes, functions, and variables and the right panel will display the game pipeline and later in the process contain an overlaid window where the block based coding will take place. 
The left panel is smaller and will contain a list of the predefined classes, functions, and variables, as well as the newly defined code blocks of the user. The right panel is larger and displays the game pipeline by default. Most of the user actions will take place in the right panel, hence it will take up most of the screen to capture the attention of the user. 
Coding blocks will be color schemed so that the user can easily distinguish between interactable and non-interactabe buttons. E.g. variables are not interactable because they get defined in other code blocks while functions are interactable because they have a body that can be filled with code. 
As soon as a button to modify a function or pipeline-step is clicked it will open a overlaid window over the right panel that will be used to define code. There will be a different visible presentation of the window for creating or modifying a function or class versus programming a game pipeline step. 
The interaction with the code will be through dragging and dropping the available variables and functions from the left panel into the coding window in the right panel. The coding window will have a clear visible distinction where new code blocks can be inserted and where not. 


### A/B Test

The main difference in the A/B test will be the procedure of inserting code blocks into the code. One version allows the drag-and-drop of blocks from the left panel into the window in the right panel and in the other version the user click-selects block locations in the window of the right panel and inserts code blocks by clicking again on a code block in the left panel. 
    
## User study

### Overall goal of the user study

After discussing with the TA we found that our previous A/B Test would only be a minimal change an thus based on some of the feedback we recieved -mainly the ambiguity between left and right side - we decided to test different implementations of the block selection interface. The first implementation will be a singel centerd window, where the code framework will be. Once a location is selected a second window appears to the left side where there are only the blocks that are eligible for that position. The second implementation will be a split screen with code blocks in the left window and the code framework in the right window. 
Our main interest is in testing whether the first implementation is more easy to use and if it has any effect on performance (time to copletion and number of clicks).

### Variables & Hypotheses

**Hypothesis 1:** There will be no effect of the block selection interface on the users perceived ease of use.  
**Hypothesis 2:** There will be no effect of the block selection interface on the task completion time.  
**Hypothesis 3:** There will be no effect of the block selection interface on the number of clicks the user does.  

### Experiment apparatus and task

The participant is seated at a table in front of a laptop. They interact with the program using the keyboard and touchpad for around 15 minutes. During that time the screen will be recorded. The task will be to complete one block of code using each of the interfaces, after which they can see the result in the simulation.

### Protocol

The preliminary study protocol is [here](/Deliverables/Study/User_study_protocol_prelim.pdf).

The study protocol is [here](/Deliverables/Study/User_study_protocol.pdf).

### Statistical Analysis Results

The statistical analysis showed that interface A allowed for both faster completion time (p=0.02) and fewer clicks (p=0.0008) with statistical significance at an alpha level of 0.05. However, the hypothesis 1 could not be rejected. This means that interface A allows for a faster work progress without any noticable loss in ease of use for the user. 

A more detailed study report can be found [here](/Deliverables/Study/User_study_report.pdf).

## Presentation and walkthrough of final prototype

A presentation summing up the interface and study results was done in person on 14 Dec 2022. [Link to pptx file](/Deliverables/Presentation%20final/group13.pptx)

A walkthrough video of the final prototype can be found [here](/Deliverables/Presentation%20final/Crux_v4_walkthrough.mp4).