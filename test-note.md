# Cheat-sheet (notes): jQuery-focused — Labs 01 → 08
Scope: concise, exam-friendly notes in the same format as the earlier cheat-sheet. Pure jQuery (and Canvas API where required) — no vanilla DOM code. Suitable for editing in Phoenix. Focused on concepts, common patterns from your repo examples, and short one-line snippets where helpful.

---

## General setup & quick reminders
- Editor: Phoenix — open the lab HTML files and edit the <script> sections. No local server required for Phoenix preview unless external assets cause CORS.
- Always include jQuery before your script:
  - <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
- Standard wrapper:
  - $(document).ready(function(){ /* init */ });
  - Or shorthand: $(function(){ /* init */ });
- DevTools: Console (errors), Network (AJAX), Sources (breakpoints).

---

## Top jQuery methods you will use repeatedly
- Selection: $('#id'), $('.class'), $('tag'), $('parent > child')
- Read/update:
  - .val(), .text(), .html(), .attr(name), .attr(name, value), .prop(...)
- Class and style:
  - .addClass(), .removeClass(), .toggleClass(), .css(prop, val)
- Structure:
  - .append(htmlOrElem), .prepend(...), .empty(), .clone(), .remove()
- Events:
  - .on('click', fn), .click(fn), .dblclick(fn), .change(fn), .keyup(fn), .input equivalent: .on('input', fn)
  - Delegation: parent.on('click', '.child', handler)
- AJAX & loading:
  - $(selector).load(url)
  - $.getJSON(url, cb)
- Effects/animation (jQuery + jQuery UI in repo):
  - .show(), .hide(), .toggle(), .fadeIn(), .fadeOut(), .slideUp(), .slideDown(), .animate({props}, ms)
  - jQuery UI effects: .effect('shake'), .effect('fold'), .effect('explode')
- Forms & validation:
  - Use HTML attributes (required, pattern) and check values via .val()
- Canvas:
  - Use $("#canvasId")[0] to get element, then use 2D context (ctx = canvas.getContext('2d')) — drawing is Canvas API, keep selection in jQuery.

---

## Lab-by-lab condensed notes

Lab 01 — jQuery selectors & basic events
- Concepts: basic selectors, show/hide, click/dblclick/hover, input key events.
- Typical tasks: hide elements, change CSS on events, filter list items live.
- Useful patterns:
  - Hide/show a group: $('.myclass').hide();
  - Input filter: $('#input').keyup(() => { $('#list li').each(...toggle(...) ) });

Lab 02 — attributes, image swapping, table interaction
- Concepts: .attr() for image src, .css() for styling, :odd/:even selectors, live filtering rows.
- Typical tasks: image toggle, tic-tac-toe button states, dynamic row highlighting, select → change color.
- Quick note: .attr('src','photo2.jpg') to change images; $("tr:odd").addClass('striped') for zebra rows.

Lab 03 — traversal & DOM manipulation
- Concepts: children(), parent(), siblings(), closest(), find(), contains selector (li:contains('text')).
- Typical tasks: move items between lists (append/prepend/clone), use event delegation for dynamic elements.
- Pattern: $('#parent').on('click', '.item', function(){ $(this).appendTo('#cart') });

Lab 04 — loading fragments & JSON (AJAX)
- Concepts: load HTML fragments (.load), use $.getJSON to read JSON, build output (text or table).
- Typical tasks: fetch local JSON in lab04/lib and render to #stage, append multiple fields, loop arrays.
- Tips: check lib paths (lab04/lib/...), inspect Network tab if nothing appears.

Lab 05 — effects & animations (jQuery & jQuery UI)
- Concepts: show/hide/fade/slide and chaining, .animate for position/dimension changes, jQuery UI effects for extras.
- Typical tasks: animate a box, fade elements with different timings, use .animate callbacks to update state.
- Pattern: $("#box").animate({left:'+=100px'}, 1000).animate({...}, 500);

Lab 06 — Canvas drawing (select via jQuery)
- Concepts: Canvas API for shapes/text/images; selection via jQuery but drawing with ctx.
- Typical tasks: draw arcs, rectangles, text; drawImage after image load.
- Important: hide the <img> element and draw to canvas on load:
  - $("#vtclogo").hide().on('load', function(){ ctx.drawImage(this, x,y,w,h); }).each(...);

Lab 07 — input types, ranges, meters, interactions
- Concepts: new input types (range, date, meter, datalist), syncing controls and animating meter values via jQuery animate step.
- Typical tasks: animate meter when range changes, reflect slider value in an output, validate pattern attributes.
- Pattern to animate meter: $({val: current}).animate({val:target}, {duration:500, step: function(now){ $('#meter').val(now); }});

Lab 08 — forms & calculators
- Concepts: form inputs, live calculations, slider/number sync, using FormData or manual .val() reads.
- Typical tasks: live price*quantity calculations, slider sync with numeric input, delivery datalist usage.
- Tips:
  - Always parse numeric inputs with parseFloat() and default to 0.
  - Keep UI sync: slider.on('input', ...) set number and recalc.

---

## Exam practical strategy (jQuery-first)
1. Identify the lab example that matches the task — open corresponding lab*_preparation.html or lab*_#.html in the repo.
2. Reuse the jQuery pattern already present in that example — minimal edits required.
3. Build incrementally:
   - HTML skeleton (ids/classes)
   - jQuery events and handlers
   - AJAX/data rendering if needed
   - effects/animations last
4. Test inputs often (use .val() logs), use Network tab for AJAX.
5. For canvas tasks, re-use lab06 patterns; wrap drawing setup inside $(function(){...}) and wait for images to load.
6. If time limited: produce a working, unstyled version first, then add validation and UI polish.

---

## Common pitfalls & fixes
- Script before jQuery: ensure the jQuery CDN is loaded before your code.
- Wrong selector -> returns empty: inspect with console.log($('#id').length).
- AJAX path wrong: check lab folder and 'lib' subfolder paths.
- Form numbers treated as strings: use parseFloat()/parseInt() and handle NaN (default to 0).
- Canvas image not drawn: ensure image load event or trigger load if already cached.

---

If you want this saved into the repo as cheatsheet_lab01-08_jquery_notes.md I can add it for you. Or I can produce a one-page printable version tailored to which labs you expect to be on the test (e.g., focus on AJAX & forms). Which would you prefer next?