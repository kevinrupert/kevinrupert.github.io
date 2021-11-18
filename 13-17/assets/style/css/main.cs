@charset "UTF-8";
/* RESET http://meyerweb.com/eric/tools/css/reset/  v2.0 | 20110126 License: none (public domain) */
html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed,
figure, figcaption, footer, header, hgroup,
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline;
}

/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure,
footer, header, hgroup, menu, nav, section {
  display: block;
}

body {
  line-height: 1;
}

ol, ul {
  list-style: none;
}

blockquote, q {
  quotes: none;
}

blockquote:before, blockquote:after,
q:before, q:after {
  content: "";
  content: none;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

@font-face {
  font-family: "inter";
  font-style: normal;
  font-weight: 400;
  src: url("../fonts/UntitledSansWeb-Regular.eot?#iefix") format("embedded-opentype"), url("../fonts/UntitledSansWeb-Regular.woff2") format("woff2"), url("../fonts/UntitledSansWeb-Regular.woff") format("woff"), url("../fonts/UntitledSansWeb-Regular.ttf") format("truetype"), url("../fonts/UntitledSansWeb-Regular.svg#inter") format("svg");
}
@font-face {
  font-family: "inter";
  font-style: bold;
  font-weight: 600;
  src: url("../fonts/Inter-SemiBold.eot?#iefix") format("embedded-opentype"), url("../fonts/Inter-SemiBold.woff2") format("woff2"), url("../fonts/Inter-SemiBold.woff") format("woff"), url("../fonts/Inter-SemiBold.ttf") format("truetype"), url("../fonts/Inter-SemiBold.svg#inter") format("svg");
}
html {
  min-height: 100%;
  width: 100%;
}

body {
  width: 100%;
  height: 100%;
  min-height: 100vh;
  min-height: -webkit-fill-available;
  font-family: "inter", "Helvetica", "Roboto", "Arial", sans-serif;
  font-size: 16px;
  font-weight: normal;
  font-style: normal;
  line-height: 1;
  color: #0d0d0d;
  background: #F2F2F4;
  -webkit-font-smoothing: antialiased;
  position: relative;
  font-feature-settings: "cv10" on, "cv01" on;
}
body ::selection {
  background: #ffffff;
  color: #000000;
}
body.dark {
  background: #0d0d0d;
  color: #F2F2F4;
}
body.dark a {
  text-decoration: none;
  color: #F2F2F4;
  border-bottom: 1px solid rgba(123, 123, 123, 0.5);
  transition: all 0.3s ease;
}
body.dark a:hover {
  border-bottom: 1px solid #F2F2F4;
}

ul {
  list-style: none;
}
ul li {
  margin-bottom: 12px;
  display: flex;
}
ul.bullets li::before {
  content: "•";
  color: #7B7B7B;
  margin-right: 20px;
  height: 100%;
}

a {
  text-decoration: none;
  color: #0d0d0d;
  border-bottom: 1px solid rgba(123, 123, 123, 0.5);
  transition: all 0.3s ease;
}
a:hover {
  border-bottom: 1px solid #0d0d0d;
}

.title-1 {
  font-size: 60px;
  line-height: 0.9;
  letter-spacing: -0.05em;
}
@media (min-width: 1250px) {
  .title-1 {
    font-size: 200px;
  }
}
@media (min-width: 2200px) {
  .title-1 {
    font-size: 300px;
  }
}
.title-1.caps {
  line-height: 0.8;
}

.title-2 {
  font-size: 32px;
  line-height: 1;
  letter-spacing: -0.03em;
}
@media (min-width: 1250px) {
  .title-2 {
    font-size: 60px;
  }
}
@media (min-width: 2200px) {
  .title-2 {
    font-size: 80px;
  }
}

.title-3 {
  font-size: 20px;
  line-height: 28px;
  letter-spacing: -0.02em;
  color: #7B7B7B;
}
@media (min-width: 1250px) {
  .title-3 {
    font-size: 24px;
    line-height: 36px;
  }
}
@media (min-width: 2200px) {
  .title-3 {
    font-size: 32px;
    line-height: 52px;
  }
}

.paragraph {
  font-size: 20px;
  line-height: 28px;
  letter-spacing: -0.02em;
}
@media (min-width: 1250px) {
  .paragraph {
    font-size: 24px;
    line-height: 36px;
  }
}
@media (min-width: 2200px) {
  .paragraph {
    font-size: 32px;
    line-height: 52px;
  }
}

.menu-bar {
  position: fixed;
  z-index: 10;
  padding: 48px 0;
  box-sizing: border-box;
  right: 0;
  top: 0;
  height: 100vh;
  height: -webkit-fill-available;
  width: 64px;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: space-between;
}
.menu-bar .text-1, .menu-bar .text-2 {
  transform: rotate(-90deg);
}
.menu-bar .menu-icon {
  position: relative;
  height: 48px;
  width: 48px;
  display: flex;
  align-items: center;
  justify-content: center;
  border-radius: 100%;
  transition: all 0.3s ease;
}
.menu-bar .menu-icon .icon-container {
  transition: all 0.3s cubic-bezier(0.4, 0.01, 0.165, 0.99) 0.2s;
}
.menu-bar .menu-icon .icon-container .bar-1, .menu-bar .menu-icon .icon-container .bar-2 {
  background: #0d0d0d;
  height: 2px;
  width: 20px;
  transition: all 0.2s cubic-bezier(0.4, 0.01, 0.165, 0.99);
}
.menu-bar .menu-icon .icon-container .bar-1 {
  transform: translateY(4px) rotate(0deg);
}
.menu-bar .menu-icon .icon-container .bar-2 {
  transform: translateY(-4px) rotate(0deg);
}
.menu-bar .menu-icon .icon-container.open {
  transform: rotate(-90deg);
  display: block;
}
.menu-bar .menu-icon .icon-container.open .bar-1 {
  transform: translateY(2px) rotate(45deg);
}
.menu-bar .menu-icon .icon-container.open .bar-2 {
  transform: rotate(-45deg);
}
.menu-bar .menu-icon.highlight {
  background: rgba(123, 123, 123, 0.2);
}
@media (min-width: 1250px) {
  .menu-bar .menu-icon:hover {
    cursor: pointer;
    background: rgba(123, 123, 123, 0.2);
  }
}
.menu-bar.dark .menu-icon .icon-container .bar-1, .menu-bar.dark .menu-icon .icon-container .bar-2 {
  background: #F2F2F4;
}
@media (min-width: 1250px) {
  .menu-bar.dark .menu-icon:hover {
    background: rgba(242, 242, 244, 0.2);
  }
}

.menu {
  width: 83.4vw;
  height: 100vh;
  height: -webkit-fill-available;
  transform: translateX(calc(83.4vw + 2px));
  position: fixed;
  z-index: 9;
  right: 0;
  top: 0;
  background: #F2F2F4;
  border-left: 2px solid #0d0d0d;
  transition: all 0.3s cubic-bezier(0.4, 0.01, 0.165, 0.99);
  overflow-y: scroll;
}
.menu.dark {
  background: #0d0d0d;
  border-left: 2px solid #F2F2F4;
}
.menu.dark .menu-grid .menu-item {
  background: #F2F2F4;
}
.menu.dark .menu-grid .menu-item a {
  color: #0d0d0d;
}
.menu.dark .menu-grid .menu-item a .title {
  border-top: 2px solid #0d0d0d;
}
.menu .menu-grid {
  padding: 20px 64px 20px 20px;
}
@media (min-width: 800px) {
  .menu .menu-grid {
    padding: 64px;
    display: grid;
    gap: 40px;
    grid-template-columns: repeat(2, 1fr);
  }
}
@media (min-width: 2200px) {
  .menu .menu-grid {
    grid-template-columns: repeat(3, 1fr);
  }
}
.menu .menu-grid .menu-item {
  margin-bottom: 20px;
  opacity: 0;
  transition: all 0.5s cubic-bezier(0.4, 0.01, 0.165, 0.99);
  transform: translateX(20px);
  background: #0d0d0d;
  color: #F2F2F4;
}
.menu .menu-grid .menu-item:last-child {
  margin-bottom: 0;
}
@media (min-width: 800px) {
  .menu .menu-grid .menu-item {
    margin-bottom: 0;
  }
}
.menu .menu-grid .menu-item a {
  border: none;
  display: inline-block;
  height: 100%;
  width: 100%;
  color: #F2F2F4;
  overflow: hidden;
}
.menu .menu-grid .menu-item a .image {
  position: relative;
  padding: 20px;
  box-sizing: border-box;
  font-size: 14px;
}
@media (min-width: 800px) {
  .menu .menu-grid .menu-item a .image {
    font-size: 16px;
  }
}
.menu .menu-grid .menu-item a .image img {
  width: 100%;
  transition: all 0.5s cubic-bezier(0.4, 0.01, 0.165, 0.99);
}
.menu .menu-grid .menu-item a .image .project-type {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  padding: 20px;
  box-sizing: border-box;
  text-transform: uppercase;
  display: flex;
  justify-content: space-between;
  flex-wrap: wrap;
}
@media (min-width: 800px) {
  .menu .menu-grid .menu-item a .image .project-type {
    padding: 32px;
  }
}
.menu .menu-grid .menu-item a .image .project-year {
  position: absolute;
  bottom: 0;
  left: 0;
  width: 100%;
  padding: 20px;
  box-sizing: border-box;
  transition: all 0.5s cubic-bezier(0.4, 0.01, 0.165, 0.99);
}
@media (min-width: 800px) {
  .menu .menu-grid .menu-item a .image .project-year {
    padding: 32px;
  }
}
.menu .menu-grid .menu-item a .title {
  padding: 20px;
  box-sizing: border-box;
  border-top: 2px solid #F2F2F4;
  transition: all 0.5s cubic-bezier(0.4, 0.01, 0.165, 0.99);
}
@media (min-width: 800px) {
  .menu .menu-grid .menu-item a .title {
    padding: 32px;
  }
}
.menu .menu-grid .menu-item a:hover .image img {
  transform: scale(0.85);
  opacity: 0.5;
}
.menu .menu-grid .menu-item a:hover .image .project-year {
  transform: translateY(-40px);
}
.menu .menu-grid .menu-item a:hover .title {
  transform: translateY(-40px);
}
.menu.open {
  transform: translateX(0);
}
.menu.open .menu-grid .menu-item {
  opacity: 1;
  transform: translateX(0);
}
.menu.open .menu-grid .menu-item:nth-child(1) {
  transition-delay: 0.3s;
}
.menu.open .menu-grid .menu-item:nth-child(2) {
  transition-delay: 0.4s;
}
.menu.open .menu-grid .menu-item:nth-child(3) {
  transition-delay: 0.5s;
}

.screen {
  border-radius: 20px;
  overflow: hidden;
  box-shadow: 0px 4px 32px rgba(0, 0, 0, 0.16);
  line-height: 0;
}
@media (min-width: 2200px) {
  .screen {
    border-radius: 40px;
  }
}
.screen.small-radius {
  border-radius: 3px;
}
.screen.small-radius video {
  border-radius: 3px;
}

.section {
  box-sizing: border-box;
  padding-top: 40px;
  padding-left: 20px;
  padding-right: 64px;
}
@media (min-width: 800px) {
  .section {
    display: grid;
    padding-left: 0;
    grid-template-columns: repeat(12, 1fr);
  }
}
@media (min-width: 1250px) {
  .section {
    display: grid;
    padding-left: 0;
    padding-top: 80px;
    grid-template-columns: repeat(12, 1fr);
  }
}
@media (min-width: 2200px) {
  .section {
    padding-top: 140px;
  }
}
.section.bottom {
  padding-bottom: 40px;
}
@media (min-width: 1250px) {
  .section.bottom {
    padding-bottom: 80px;
  }
}
@media (min-width: 2200px) {
  .section.bottom {
    padding-bottom: 140px;
  }
}
.section .left {
  margin-bottom: 40px;
}
@media (min-width: 800px) {
  .section .left {
    grid-column: 2/5;
    margin-bottom: 0;
  }
}
.section .left img {
  width: 100%;
}
@media (min-width: 800px) {
  .section .right {
    grid-column: 6/12;
  }
}
@media (min-width: 2200px) {
  .section .right {
    grid-column: 6/10;
  }
}
.section .right img, .section .right video {
  width: 100%;
}
.section .right .title-2 {
  margin-bottom: 40px;
}
@media (min-width: 2200px) {
  .section .right .title-2 {
    margin-bottom: 80px;
  }
}
.section .right .title-2.middle {
  margin-top: 40px;
}
@media (min-width: 2200px) {
  .section .right .title-2.middle {
    margin-top: 80px;
  }
}
.section .right .title-3, .section .right .paragraph {
  margin-bottom: 12px;
}
@media (min-width: 2200px) {
  .section .right .title-3, .section .right .paragraph {
    margin-bottom: 20px;
  }
}
.section .right .image {
  margin: 12px 0;
}
@media (min-width: 1250px) {
  .section .right .image {
    margin: 20px 0;
  }
}
.section .right .image.first {
  margin-top: 0;
}
.section .right .title-3.middle {
  margin-top: 40px;
}
@media (min-width: 2200px) {
  .section .right .title-3.middle {
    margin-top: 80px;
  }
}
.section .right .paragraph.last, .section .right .image.last {
  margin-bottom: 0;
}
.section .text-grid .grid-item {
  margin-bottom: 40px;
}
.section .text-grid .grid-item.last {
  margin-bottom: 0;
}
@media (min-width: 800px) {
  .section .text-grid .grid-item {
    margin-bottom: 0;
  }
}
@media (min-width: 800px) {
  .section .text-grid {
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    gap: 20px;
    padding-right: 20px;
  }
}
@media (min-width: 800px) {
  .section .image-grid {
    grid-column: 3/12;
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 20px;
    padding-right: 20px;
  }
  .section .image-grid.two-column {
    grid-column: 6/12;
    grid-template-columns: repeat(2, 1fr);
  }
}
@media (min-width: 2200px) {
  .section .image-grid {
    gap: 32px;
    padding-right: 32px;
  }
}
.section .image-grid .image {
  margin-bottom: 20px;
}
@media (min-width: 800px) {
  .section .image-grid .image {
    margin-bottom: 0;
  }
}
.section .image-grid .image img {
  width: 100%;
}
.section .image-grid .image:last-child {
  margin-bottom: 0;
}
@media (min-width: 800px) {
  .section .image-inline {
    grid-column: 2/12;
    padding-right: 20px;
  }
}
.section .image-inline .image img {
  width: 100%;
}
.section.section-title {
  padding: 40px 0 40px 20px;
}
@media (min-width: 800px) {
  .section.section-title {
    padding: 80px 0;
  }
}
@media (min-width: 2200px) {
  .section.section-title {
    padding: 140px 0;
  }
}
.section.section-title .text .title-2 {
  margin-left: -0.06em;
}
.section.section-title .text .title-3 {
  color: #7B7B7B;
}
@media (min-width: 800px) {
  .section.section-title .text {
    grid-column: 2/12;
  }
}
@media (min-width: 1250px) {
  .section.section-title.about .text {
    display: flex;
  }
}
.section.full-width-image {
  padding: 0;
  display: block;
}
.section.full-width-image img {
  width: 100%;
}
.section.vertical-center {
  align-items: center;
}
.section.experience-model .left {
  margin-bottom: 0;
}
.section.experience-model .left .title-2 {
  margin-bottom: 40px;
}
.section.experience-model .layer-text {
  margin-bottom: 20px;
}
.section.experience-model .layer-text.last {
  margin-bottom: 0;
}
.section.experience-model .model {
  align-items: center;
  justify-content: center;
  position: relative;
  display: flex;
}
.section.experience-model .model .layers {
  position: relative;
  margin-top: 160px;
  margin-bottom: -64px;
}
@media (min-width: 800px) {
  .section.experience-model .model .layers {
    margin-top: 192px;
    margin-bottom: 0;
  }
}
.section.experience-model .model .layers .layer-1, .section.experience-model .model .layers .layer-2, .section.experience-model .model .layers .layer-3 {
  position: relative;
  width: 100px;
  position: relative;
}
.section.experience-model .model .layers .layer-1:before, .section.experience-model .model .layers .layer-2:before, .section.experience-model .model .layers .layer-3:before {
  display: inline-block;
  content: "";
  width: 100%;
  padding-top: 177.7777777778%;
}
.section.experience-model .model .layers .layer-1 > .content, .section.experience-model .model .layers .layer-2 > .content, .section.experience-model .model .layers .layer-3 > .content {
  position: absolute;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
}
@media (min-width: 800px) {
  .section.experience-model .model .layers .layer-1, .section.experience-model .model .layers .layer-2, .section.experience-model .model .layers .layer-3 {
    width: 300px;
  }
}
@media (min-width: 1250px) {
  .section.experience-model .model .layers .layer-1, .section.experience-model .model .layers .layer-2, .section.experience-model .model .layers .layer-3 {
    width: 300px;
  }
}
@media (min-width: 2200px) {
  .section.experience-model .model .layers .layer-1, .section.experience-model .model .layers .layer-2, .section.experience-model .model .layers .layer-3 {
    width: 400px;
  }
}
.section.experience-model .model .layers .layer-1 {
  border: 3px solid white;
  background: white;
  transform: rotateX(60deg) rotateZ(45deg);
}
.section.experience-model .model .layers .layer-2 {
  border: 3px solid #0d0d0d;
  top: 0;
  left: 0;
  position: absolute;
  animation: float 1.5s infinite cubic-bezier(0.4, 0.01, 0.165, 0.99) alternate;
  -webkit-animation: float 1.5s infinite cubic-bezier(0.4, 0.01, 0.165, 0.99) alternate;
}
.section.experience-model .model .layers .layer-3 {
  position: relative;
  background: #0d0d0d;
  border: 3px solid #0d0d0d;
  position: absolute;
  top: 0;
  left: 0;
  animation: float-2 1.5s infinite cubic-bezier(0.4, 0.01, 0.165, 0.99) alternate;
  -webkit-animation: float-2 1.5s infinite cubic-bezier(0.4, 0.01, 0.165, 0.99) alternate;
}
.section.experience-model .model .layers .layer-3:before {
  display: inline-block;
  content: "";
  width: 100%;
  padding-top: 177.7777777778%;
}
.section.experience-model .model .layers .layer-3 > .content {
  position: absolute;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
}

.archive-title {
  box-sizing: border-box;
  padding: 20px 64px 20px 20px;
  min-height: 50vh;
  display: flex;
  align-items: center;
  justify-content: center;
}
@media (min-width: 1250px) {
  .archive-title {
    padding: 0;
    height: 100vh;
    position: fixed;
    top: 0;
    left: 0;
    width: 100vw;
  }
}
.archive-title .archive-title-text {
  font-size: 50vw;
  line-height: 0.8;
  transition: all 0.5s ease;
}
@media (min-width: 800px) {
  .archive-title .archive-title-text {
    font-size: 40vw;
  }
}
.archive-title .archive-title-text.dark {
  opacity: 0.4;
}

.archive-grid {
  box-sizing: border-box;
  padding: 20px 64px 20px 20px;
}
@media (min-width: 800px) {
  .archive-grid {
    padding: 64px 64px 0 64px;
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    gap: 40px;
  }
}
@media (min-width: 1250px) {
  .archive-grid {
    margin-top: 100vh;
  }
}
@media (min-width: 2200px) {
  .archive-grid {
    grid-template-columns: repeat(3, 1fr);
  }
}
.archive-grid .item {
  margin-bottom: 20px;
  display: flex;
  align-items: center;
  justify-content: center;
  flex-direction: column;
  transition: all 0.5s cubic-bezier(0.4, 0.01, 0.165, 0.99);
}
.archive-grid .item:last-child {
  margin-bottom: 0;
}
.archive-grid .item.wide {
  grid-column: 1/3;
}
@media (min-width: 2200px) {
  .archive-grid .item.wide {
    grid-column: initial;
  }
}
@media (min-width: 800px) {
  .archive-grid .item {
    margin: 0;
    height: calc(100vh - 64px);
  }
}
.archive-grid .item .image {
  display: flex;
  align-items: center;
  justify-content: center;
  flex-direction: column;
  transition: all 0.5s cubic-bezier(0.4, 0.01, 0.165, 0.99);
}
@media (min-width: 800px) {
  .archive-grid .item .image {
    width: 60%;
  }
  .archive-grid .item .image.wide {
    width: 90%;
  }
  .archive-grid .item .image:hover img, .archive-grid .item .image:hover video, .archive-grid .item .image:hover .video {
    transform: translateY(-20px);
  }
  .archive-grid .item .image:hover .text {
    opacity: 1;
    margin-top: 6px;
    transform: translateY(-20px);
  }
}
.archive-grid .item .image .video-wrapper {
  height: 0;
  overflow: hidden;
  padding-bottom: 56.25%;
  position: relative;
}
.archive-grid .item .image .video-wrapper embed,
.archive-grid .item .image .video-wrapper object,
.archive-grid .item .image .video-wrapper iframe {
  position: absolute;
  top: 0;
  left: 0;
  height: 100%;
  width: 100%;
}
.archive-grid .item .image img, .archive-grid .item .image video, .archive-grid .item .image .video {
  width: 100%;
  position: relative;
  z-index: 2;
  transition: all 0.5s cubic-bezier(0.4, 0.01, 0.165, 0.99);
}
.archive-grid .item .image .text {
  margin-top: 6px;
  width: 100%;
  color: #7B7B7B;
  text-transform: uppercase;
  font-size: 14px;
  letter-spacing: 0.5px;
  line-height: 20px;
}
.archive-grid .item .image .text a {
  color: #7B7B7B;
}
@media (min-width: 800px) {
  .archive-grid .item .image .text {
    color: #F2F2F4;
    height: 40px;
    transform: translateY(-40px);
    position: relative;
    opacity: 0;
    transition: all 0.5s cubic-bezier(0.4, 0.01, 0.165, 0.99);
  }
  .archive-grid .item .image .text a {
    color: #F2F2F4;
  }
}

.animate-fade {
  opacity: 0;
  transition: all 1s ease 0.5s;
}
.animate-fade.delay-none {
  transition-delay: 0s;
}
.animate-fade.delay-1 {
  transition-delay: 0.5s;
}
.animate-fade.delay-2 {
  transition-delay: 0.75s;
}
.animate-fade.delay-3 {
  transition-delay: 1s;
}
.animate-fade.delay-4 {
  transition-delay: 1.25s;
}
.animate-fade.delay-5 {
  transition-delay: 1.5s;
}
.animate-fade.delay-6 {
  transition-delay: 1.75s;
}
@media (min-width: 1250px) {
  .animate-fade.delay-6-desk {
    transition-delay: 1.75s;
  }
}
.animate-fade.animated {
  opacity: 1;
}

.animate-width {
  width: 0px;
  transition: all 0.3s ease 0.75s;
}
.animate-width.animated {
  width: 32px;
}
@media (min-width: 1250px) {
  .animate-width {
    width: 0;
  }
  .animate-width.animated {
    width: 100%;
  }
}

.animate-fade-up {
  transform: translateY(48px);
  opacity: 0;
  transition: all 0.8s cubic-bezier(0.4, 0.01, 0.165, 0.99) 0.5s;
}
.animate-fade-up.delay-none {
  transition-delay: 0s;
}
.animate-fade-up.delay-1 {
  transition-delay: 0.5s;
}
.animate-fade-up.delay-2 {
  transition-delay: 0.75s;
}
.animate-fade-up.delay-3 {
  transition-delay: 1s;
}
.animate-fade-up.delay-4 {
  transition-delay: 1.25s;
}
.animate-fade-up.delay-5 {
  transition-delay: 1.5s;
}
.animate-fade-up.delay-6 {
  transition-delay: 1.75s;
}
.animate-fade-up.animated {
  transform: translateY(0px);
  opacity: 1;
}

@-webkit-keyframes float {
  0% {
    transform: rotateX(60deg) rotateZ(45deg) translate3d(0, 0, 0);
  }
  100% {
    transform: rotateX(60deg) rotateZ(45deg) translate3d(0, 0, 96px);
  }
}
@keyframes float {
  0% {
    transform: rotateX(60deg) rotateZ(45deg) translate3d(0, 0, 0);
  }
  100% {
    transform: rotateX(60deg) rotateZ(45deg) translate3d(0, 0, 96px);
  }
}
@-webkit-keyframes float-2 {
  0% {
    transform: rotateX(60deg) rotateZ(45deg) translate3d(0, 0, 0);
  }
  100% {
    transform: rotateX(60deg) rotateZ(45deg) translate3d(0, 0, 192px);
  }
}
@keyframes float-2 {
  0% {
    transform: rotateX(60deg) rotateZ(45deg) translate3d(0, 0, 0);
  }
  100% {
    transform: rotateX(60deg) rotateZ(45deg) translate3d(0, 0, 192px);
  }
}

/*# sourceMappingURL=main.cs.map */
