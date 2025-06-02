<style>
    /* customizable snowflake styling */
    .snowflake {
        color: #fff;
        font-size: 1em;
        font-family: Arial;
        text-shadow: 0 0 1px #000;
    }

    @-webkit-keyframes snowflakes-fall {
        0% {
            top: -10%
        }

        100% {
            top: 100%
        }
    }

    @-webkit-keyframes snowflakes-shake {
        0% {
            -webkit-transform: translateX(0px);
            transform: translateX(0px)
        }

        50% {
            -webkit-transform: translateX(80px);
            transform: translateX(80px)
        }

        100% {
            -webkit-transform: translateX(0px);
            transform: translateX(0px)
        }
    }

    @keyframes snowflakes-fall {
        0% {
            top: -10%
        }

        100% {
            top: 100%
        }
    }

    @keyframes snowflakes-shake {
        0% {
            transform: translateX(0px)
        }

        50% {
            transform: translateX(80px)
        }

        100% {
            transform: translateX(0px)
        }
    }

    .snowflake {
        position: fixed;
        top: -10%;
        z-index: 9999;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
        cursor: default;
        -webkit-animation-name: snowflakes-fall, snowflakes-shake;
        -webkit-animation-duration: 10s, 3s;
        -webkit-animation-timing-function: linear, ease-in-out;
        -webkit-animation-iteration-count: infinite, infinite;
        -webkit-animation-play-state: running, running;
        animation-name: snowflakes-fall, snowflakes-shake;
        animation-duration: 10s, 3s;
        animation-timing-function: linear, ease-in-out;
        animation-iteration-count: infinite, infinite;
        animation-play-state: running, running
    }

    .snowflake:nth-of-type(0) {
        left: 1%;
        -webkit-animation-delay: 0s, 0s;
        animation-delay: 0s, 0s
    }

    .snowflake:nth-of-type(1) {
        left: 10%;
        -webkit-animation-delay: 1s, 1s;
        animation-delay: 1s, 1s
    }

    .snowflake:nth-of-type(2) {
        left: 20%;
        -webkit-animation-delay: 6s, .5s;
        animation-delay: 6s, .5s
    }

    .snowflake:nth-of-type(3) {
        left: 30%;
        -webkit-animation-delay: 4s, 2s;
        animation-delay: 4s, 2s
    }

    .snowflake:nth-of-type(4) {
        left: 40%;
        -webkit-animation-delay: 2s, 2s;
        animation-delay: 2s, 2s
    }

    .snowflake:nth-of-type(5) {
        left: 50%;
        -webkit-animation-delay: 8s, 3s;
        animation-delay: 8s, 3s
    }

    .snowflake:nth-of-type(6) {
        left: 60%;
        -webkit-animation-delay: 6s, 2s;
        animation-delay: 6s, 2s
    }

    .snowflake:nth-of-type(7) {
        left: 70%;
        -webkit-animation-delay: 2.5s, 1s;
        animation-delay: 2.5s, 1s
    }

    .snowflake:nth-of-type(8) {
        left: 80%;
        -webkit-animation-delay: 1s, 0s;
        animation-delay: 1s, 0s
    }

    .snowflake:nth-of-type(9) {
        left: 90%;
        -webkit-animation-delay: 3s, 1.5s;
        animation-delay: 3s, 1.5s
    }

    /* Demo Purpose Only*/
    .demo {
        font-family: 'Raleway', sans-serif;
        color: #fff;
        display: block;
        margin: 0 auto;
        padding: 15px 0;
        text-align: center;
    }

    .demo a {
        font-family: 'Raleway', sans-serif;
        color: #000;
    }

    #banner {
        font-size: clamp(2.8rem, 1.5vw, 3rem);
        font-weight: bold;
        margin: 5px;
        background: linear-gradient(to right,
                #7953cd 20%,
                #00affa 30%,
                #0190cd 70%,
                #764ada 80%);
        -webkit-background-clip: text;
        background-clip: text;
        -webkit-text-fill-color: transparent;
        text-fill-color: transparent;
        background-size: 500% auto;
        animation: textShine 5s ease-in-out infinite alternate;
    }
    @keyframes textShine {
        0% {
            background-position: 0% 50%;
        }

        100% {
            background-position: 100% 50%;
        }
    }
</style>

# Cool Markdown

<span id="banner">Markdown is Cool</span>

Original Draft: 2023-10-04  
Publication: N/A  
Source: [Github](https://github.com/TotalImagine-com/TotalImagine.com/blob/main/Resources/CoolMarkdown.md)

<svg version="1.1" id="L1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 100 100" enable-background="new 0 0 100 100" xml:space="preserve" width="50">
    <circle fill="none" stroke="#000" stroke-width="6" stroke-miterlimit="15" stroke-dasharray="14.2472,14.2472" cx="50" cy="50" r="47" >
      <animateTransform 
         attributeName="transform" 
         attributeType="XML" 
         type="rotate"
         dur="5s" 
         from="0 50 50"
         to="360 50 50" 
         repeatCount="indefinite" />
  </circle>
  <circle fill="none" stroke="#000" stroke-width="1" stroke-miterlimit="10" stroke-dasharray="10,10" cx="50" cy="50" r="39">
      <animateTransform 
         attributeName="transform" 
         attributeType="XML" 
         type="rotate"
         dur="5s" 
         from="0 50 50"
         to="-360 50 50" 
         repeatCount="indefinite" />
  </circle>
  <g fill="#fff">
  <rect x="30" y="35" width="5" height="30" fill="black">
    <animateTransform 
       attributeName="transform" 
       dur="1s" 
       type="translate" 
       values="0 5 ; 0 -5; 0 5" 
       repeatCount="indefinite" 
       begin="0.1"/>
  </rect>
  <rect x="40" y="35" width="5" height="30" fill="black">
    <animateTransform 
       attributeName="transform" 
       dur="1s" 
       type="translate" 
       values="0 5 ; 0 -5; 0 5" 
       repeatCount="indefinite" 
       begin="0.2"/>
  </rect>
  <rect x="50" y="35" width="5" height="30" fill="black">
    <animateTransform 
       attributeName="transform" 
       dur="1s" 
       type="translate" 
       values="0 5 ; 0 -5; 0 5" 
       repeatCount="indefinite" 
       begin="0.3"/>
  </rect>
  <rect x="60" y="35" width="5" height="30" fill="black">
    <animateTransform 
       attributeName="transform" 
       dur="1s" 
       type="translate" 
       values="0 5 ; 0 -5; 0 5"  
       repeatCount="indefinite" 
       begin="0.4"/>
  </rect>
  <rect x="70" y="35" width="5" height="30" fill="black">
    <animateTransform 
       attributeName="transform" 
       dur="1s" 
       type="translate" 
       values="0 5 ; 0 -5; 0 5" 
       repeatCount="indefinite" 
       begin="0.5"/>
  </rect>
  </g>
</svg>

This demo serves as an "attraction" to persuade people they should use Markdown instead of Microsoft Doc for note taking. It's rendered using Github Pages (Jekyll) with [Mermaid](https://github.com/TotalImagine-com/TotalImagine.com/commit/035a2731e5d3c12e21c03e8beb0bbde0391d9715) for Markdown. The additional support for Javascript (mostly for [Neko](https://webneko.net)) is optional and only for fun.

It uses a few notable features:

1. Github flavoured markdown
2. Mermaid diagrams
3. SVG (for animation and shapes)
4. Some HTML and CSS for additional styling
5. Use LaTex for equation rendering

TODO:

- [x] Basic demo setup
- [ ] Fix typos of texts
- [ ] Add more descriptive examples and show syntax of Markdown

## Why You Should Use Markdown

1. It supports **bold**, *italic*, ***bold italic***, and ~~strikethrough~~.
2. You can edit it in Visual Studio Code, with syntax highlight.
3. You can draw diagrams using mermaid.
4. You can use pandoc to output Markdown to various formats (or just use VS Code): HTML, Doc, PDF.
5. You can write LaTeX formulas: $E=mc^2$.
6. You can have tables and use emojis👍 and insert images.
7. Easy to parse, fully programmable.

|Markdown|Word Doc|Text|
|-|-|-|
|Light weight|Binary|Light Weight|
|Plain Text + HTML, CSS, SVG|XML and Indecipherable|Plain Text|

```mermaid
quadrantChart
    title Efficiency and Scalability Comparison
    x-axis Low Efficiency --> High Efficiency
    y-axis Low Scalability --> High Scalability
    quadrant-1 Least Usable
    quadrant-2 Ease to use
    quadrant-3 Hard to Use
    quadrant-4 Most Usable
    Markdown: [0.9, 0.9]
    Plain Text: [0.35, 0.23]
    HTML: [0.1, 0.65]
    Word Document: [0.55, 0.55]
    PowerPoint: [0.75, 0.34]
    Notion: [0.85, 0.62]
```

## Credits

* [Snowflake Animation](https://codepen.io/codeconvey/pen/xRzQay)
* [Gradient Text Animation](https://codepen.io/amit_merchant/pen/yLxgMGz)
* [SVG Animations](https://codepen.io/nikhil8krishnan/pen/rVoXJa)

## References
* [Github Flavour Markdown](https://gist.github.com/stevenyap/7038119)
* [Full Doc](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)
* [Methodox's Intro to GitHub Flavoured Markdown](https://wiki.methodox.io/en/KnowledgeBase/Markdown)

<!-- Render Elements -->
<div class="snowflakes" aria-hidden="true">
    <div class="snowflake">
        ❅
    </div>
    <div class="snowflake">
        ❅
    </div>
    <div class="snowflake">
        ❆
    </div>
    <div class="snowflake">
        ❄
    </div>
    <div class="snowflake">
        ❅
    </div>
    <div class="snowflake">
        ❆
    </div>
    <div class="snowflake">
        ❄
    </div>
    <div class="snowflake">
        ❅
    </div>
    <div class="snowflake">
        ❆
    </div>
    <div class="snowflake">
        ❄
    </div>
</div>

<script>NekoType="white"</script>
<h1 id=nl><script src="https://webneko.net/n20171213.js"></script><a 
href="https://webneko.net">Neko</a></h1>
