# Cheat-sheet (notes): jQuery-focused — Labs 01 → 08
Scope: concise, exam-friendly notes with **actual code snippets** from lab files for easy copying. Pure jQuery (and Canvas API where required).

---

## General setup & quick reminders

### jQuery CDN (copy this first!)
```html
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
```

### jQuery UI CDN (for effects like shake, fold, explode)
```html
<link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css">
<script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
```

### Standard wrapper
```javascript
$(document).ready(function() {
    // Your code here
});
// Or shorthand:
$(function() {
    // Your code here
});
```

---

## Lab 01 — jQuery selectors & basic events

### Hide all elements on page (lab1_preparation)
```javascript
$("#button1").click(function() {
    $("body *").hide();
});
```

### Hide only the clicked element
```javascript
$("#button2").click(function() {
    $(this).hide();
});
```

### Hide elements by class
```javascript
$("#button3").click(function() {
    $(".myclass").hide();
});
```

### Click to hide, double-click to show
```javascript
$("#button4")
    .click(function() {
        $("#div1").hide();
    })
    .dblclick(function() {
        $("#div1").show();
    });
```

### Highlight table row on click
```javascript
$("#div2 table tr").click(function() {
    $(this).css("background-color", "#ffd54f");
});
```

### Live filter list items (keyup)
```javascript
$("#input1 input").keyup(function() {
    let val = $(this).val().toUpperCase().trim();
    if (val.length > 0) {
        $("#div3 ol li").each(function() {
            let text = $(this).text().toUpperCase();
            if (text.includes(val)) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });
    } else {
        // Reset heading and show all items if input is empty
        $("#div3 h3").text("Module Codes");
        $("#div3 ol li").show();
    }
});
```

### Basic events: click, dblclick, mouseenter, focus, blur
```javascript
// Click → alert
$("#button1").on("click", function() {
    alert("Welcome!");
});

// Double click → alert
$("#button2").on("dblclick", function() {
    alert("Good-bye!");
});

// Mouse enter → hide
$("#button3").on("mouseenter", function() {
    $(this).hide();
});

// Focus → green, Blur → red
$("#input1, #input2").on("focus", function() {
    $(this).css("background-color", "green");
});
$("#input1, #input2").on("blur", function() {
    $(this).css("background-color", "red");
});
```

### Input event for text changes
```javascript
$('#inputBox').on('input', function() {
    $(this).css('background-color', 'red');
});
```

### Show first/last N items using slice
```javascript
const items = $("div p");
// Show first 3
$("#button1").click(function() {
    items.hide();
    items.slice(0, 3).show();
});
// Show last 3
$("#button2").click(function() {
    items.hide();
    items.slice(-3).show();
});
```

### Tic-Tac-Toe color change
```javascript
$("button").click(function() {
    $(this).css("background-color", "red");
});
$("button").dblclick(function() {
    $(this).css("background-color", "blue");
});
```

---

## Lab 02 — attributes, image swapping, table interaction

### Login form with val() and text()
```javascript
$("#loginbtn").click(function() {
    var username = $("#username").val().trim();
    if (username !== "") {
        $("#welcome-message").text("You have logged in successfully, " + username);
        alert("Welcome " + username);
    } else {
        alert("Please enter a username.");
    }
});

$("#resetbtn").click(function() {
    $("#username").val("");
    $("#welcome-message").text("");
});
```

### Image swap with attr()
```javascript
$("#orangebtn").click(function() {
    $("#myimg").attr("src", "photo1.jpg");
});
$("#yellowbtn").click(function() {
    $("#myimg").attr("src", "photo2.jpg");
});
```

### Tic-Tac-Toe with text() and addClass()
```javascript
$("button").click(function() {
    $(this).text("X");
    $(this).addClass("cross");
});
$("button").dblclick(function() {
    $(this).text("O");
    $(this).addClass("circle");
});
```

### Zebra striping table rows (:odd selector)
```javascript
$("tr:odd").addClass("striped");

$("tr").mouseenter(function() {
    $(this).addClass("over");
});
$("tr").mouseleave(function() {
    $(this).removeClass("over");
});
```

### Live filter table rows
```javascript
$("#filter").on("keyup", function() {
    var phrase = $(this).val().toLowerCase();
    $("table tbody tr").filter(function() {
        $(this).toggle($(this).text().toLowerCase().includes(phrase));
    });
});
```

### Select dropdown change background color
```javascript
$("#color").change(function() {
    var selectedColor = $(this).val();
    $("#div1").css("background-color", selectedColor);
});
```

---

## Lab 03 — traversal & DOM manipulation

### Traversal methods: children, siblings, parent, prev
```javascript
// Add class to h1
$("h1").addClass("selected");

// Color all children of divs red
$("#div1, #div2").children().css("color", "red");

// Select by text content
$("li:contains('List item 3')").addClass("selected");

// Select all spans in ul
$("ul span").addClass("selected");

// Select children of p
$("p").children().addClass("selected");

// Select parents of spans
$("span").parent().addClass("selected");

// Select siblings of p
$("p").siblings().addClass("selected");

// Select previous sibling
$("#target").prev().addClass("selected");

// Bold previous of class
$(".c2").prev().css("font-weight", "bold");
```

### Using children() and siblings()
```javascript
// Turn list items red using children()
$("ul.red").children("li").addClass("selected_red");

// Turn other list items blue using siblings()
$("ul.red").siblings("ul.blue").children("li").addClass("selected_blue");
```

### Dynamic list with html()
```javascript
$('#appleBtn').click(function() {
    $('#itemList').html(`
        <li class="red">iPhone</li>
        <li class="red">iPad</li>
        <li class="red">iPod</li>
    `);
});
```

### Shopping cart - click to move items (event delegation)
```javascript
// Move item to cart when clicked
$("#items").on("click", ".div", function() {
    $(this).appendTo("#cart");
});

// Move item back when clicked
$("#cart").on("click", ".div", function() {
    $(this).appendTo("#items");
});

// Reset
$("#resetBtn").click(function() {
    location.reload();
});
```

### Append/Prepend from select dropdown
```javascript
$("#appendLast").click(function() {
    let selected = $("#product").val();
    if (selected !== "white") {
        $("#deviceList").append("<div>" + selected + "</div>");
    }
});

$("#appendTop").click(function() {
    let selected = $("#product").val();
    if (selected !== "white") {
        $("#deviceList").prepend("<div>" + selected + "</div>");
    }
});

$("#clearAll").click(function() {
    $("#deviceList").empty();
    $("#product").val("white");
});
```

### Clone items to shopping cart
```javascript
$("#putToCart").click(function() {
    let items = $("#deviceList").children().clone();
    $("#shoppingCart").append(items);
    $("#deviceList").empty();
});
```

---

## Lab 04 — loading fragments & JSON (AJAX)

### Load HTML fragment
```javascript
$("#loadButton").click(function() {
    $('#yellow').load('lib/results.html');
    $('#pink').load('lib/results.html');
});
```

### getJSON - array access
```javascript
$("#loadButton").click(function() {
    $.getJSON('lib/userData_array.json', function(jd) {
        $('#pink').append('<p>Name: ' + jd.name[1] + '</p>');
        $('#pink').append('<p>Age: ' + jd.age[1] + '</p>');
        $('#pink').append('<p>Sex: ' + jd.sex[1] + '</p>');
    });
});
```

### getJSON - loop through array of objects
```javascript
$("#driver").click(function() {
    $.getJSON('lib/studentRecord.json', function(jd) {
        $('#stage').empty();
        for (let i = 0; i < jd.length; i++) {
            let line = jd[i].Stud_ID + '\t' +
                       jd[i].Name + '\t\t' +
                       jd[i].LastName + '\t\t' +
                       jd[i].Age + '\t' +
                       jd[i].Sex + '\n';
            $('#stage').append(line);
        }
    });
});
```

### getJSON - build HTML table from JSON
```javascript
$("#driver").click(function() {
    $.getJSON('lib/studentRecord.json', function(jd) {
        $('#stage').empty();
        
        let table = '<table border="1" style="width:100%; border-collapse:collapse;">';
        table += '<tr style="background-color:lightgreen;">';
        table += '<th>Stud_ID</th><th>Name</th><th>LastName</th><th>Age</th><th>Sex</th>';
        table += '</tr>';
        
        for (let i = 0; i < jd.length; i++) {
            table += '<tr style="background-color:pink;">';
            table += '<td>' + jd[i].Stud_ID + '</td>';
            table += '<td>' + jd[i].Name + '</td>';
            table += '<td>' + jd[i].LastName + '</td>';
            table += '<td>' + jd[i].Age + '</td>';
            table += '<td>' + jd[i].Sex + '</td>';
            table += '</tr>';
        }
        table += '</table>';
        
        $('#stage').append(table);
    });
});
```

### getJSON - nested object access
```javascript
$("#driver").click(function() {
    $.getJSON('lib/birthday.json', function(data) {
        $('#stage').empty();
        let output = '';
        for (let i = 0; i < data.name.length; i++) {
            output += 'Name: ' + data.name[i] + '\n\n';
            output += 'Day: ' + data.birthday[i].day + '\n\n';
            output += 'Month: ' + data.birthday[i].month + '\n\n';
            output += 'Year: ' + data.birthday[i].year + '\n\n';
            output += 'Sex: ' + data.sex[i] + '\n\n\n';
        }
        $('#stage').text(output);
    });
});
```

---

## Lab 05 — effects & animations (jQuery & jQuery UI)

### Show with timing
```javascript
$("#div1").hide();
$("#btn").click(function() {
    $("#div1").show(2000);
});
```

### Show and Hide chained
```javascript
$("#btn_showNhide").click(function() {
    $("#div1").show(1000).hide(1000);
});
```

### Toggle
```javascript
$("#btn_toggle").click(function() {
    $("#div2").toggle(2000);
});
```

### FadeIn/FadeOut
```javascript
// Fade out with different timings
$("#btn_fade").click(function() {
    $("#div3_1").fadeOut(1000);
    $("#div3_2").fadeOut(2000);
    $("#div3_3").fadeOut(3000);
});
// Fade in on double click
$("#btn_fade").dblclick(function() {
    $("#div3_1").fadeIn(1000);
    $("#div3_2").fadeIn(2000);
    $("#div3_3").fadeIn(3000);
});
```

### SlideUp/SlideDown with callback
```javascript
$("#btn_slide").click(function() {
    if ($("#content").is(":visible")) {
        $("#content").slideUp(2000, function() {
            alert("Content is now hidden!");
        });
    } else {
        $("#content").slideDown(400, function() {
            alert("Content is now visible!");
        });
    }
});
```

### Animate - relative positioning (+=)
```javascript
$("#btn_relative").click(function() {
    $("#box").animate({left: "+=100px"}, 1000, function() {
        updateStatus();
    });
});

$("#btn_absolute").click(function() {
    $("#box").animate({left: "0px"}, 1000, function() {
        updateStatus();
    });
});

function updateStatus() {
    var currentLeft = $("#box").css("left");
    $("#status").text("Current Position: " + currentLeft);
}
```

### Animate - dimensions and opacity
```javascript
$("#btn_dimensionVisibility").click(function() {
    $("#box2").animate({width:"150px", height:"50px", opacity:"0"}, 6000, "swing")
              .animate({width:"100px", height:"100px", opacity:"1"}, 6000, "linear");
});
```

### Chained animation
```javascript
$("#startBtn").click(function() {
    $("#box").animate(
        { left: "+=250px", width: "150px", height: "150px", opacity: "0" },
        2000,
        "swing"
    ).animate(
        { width: "50px", height: "50px", left: "10px", top: "100px", opacity: "1" },
        3000,
        "linear"
    );
});
```

### jQuery UI effects (shake, fold, explode)
```javascript
$("#btn2").click(function() {
    $("#box").effect("shake", 2000);
});

$("#btn3").click(function() {
    $("#box").effect("fold", 2000);
});

$("#btn4").click(function() {
    $("#box").effect("explode", 3000);
});
```

### Toggle text on click
```javascript
let toggled = false;
$("#div1").click(function() {
    if (toggled) {
        $(this).text("This is the first text.");
    } else {
        $(this).text("Change to the second text.");
    }
    toggled = !toggled;
});
```

---

## Lab 06 — Canvas drawing

### Basic canvas setup
```javascript
var c = document.getElementById("myCanvas");
var ctx = c.getContext("2d");
```

### Fill background
```javascript
ctx.fillStyle = "yellow";
ctx.fillRect(0, 0, 400, 200);
```

### Draw arc/pie slice
```javascript
var centerX = 200;
var centerY = 100;
var radius = 100;

ctx.beginPath();
ctx.lineTo(centerX, centerY);
ctx.arc(centerX, centerY, radius, 0, 1 * Math.PI);  // half circle
ctx.lineTo(centerX, centerY);
ctx.fillStyle = "red";
ctx.fill();
```

### Draw full circle
```javascript
ctx.beginPath();
ctx.arc(centerX, centerY, radius, 0, 2 * Math.PI);  // full circle
ctx.fillStyle = "green";
ctx.fill();
```

### Draw rectangle
```javascript
ctx.fillStyle = "orange";
ctx.fillRect(100, 100, 800, 500);  // x, y, width, height
```

### Draw text
```javascript
ctx.font = "35px Arial";
ctx.fillStyle = "black";
ctx.strokeStyle = "white";
ctx.lineWidth = 3;
ctx.fillText("Welcome", 230, 80);
```

### Draw lines with loop
```javascript
ctx.strokeStyle = "red";
for (var a = 0; a < 200; a++) {
    ctx.beginPath();
    ctx.moveTo(a, 0);
    ctx.lineTo(600 - a, 300);
    ctx.stroke();
    ctx.closePath();
}
```

### Draw image (wait for load)
```javascript
window.onload = function() {
    var img = document.getElementById("vtclogo");
    img.style.display = "none";
    ctx.drawImage(img, 250, 100, 100, 100);  // img, x, y, width, height
};
```

### Draw triangle
```javascript
ctx.beginPath();
ctx.moveTo(300, 550);
ctx.lineTo(280, 610);
ctx.lineTo(320, 610);
ctx.fillStyle = "yellow";
ctx.fill();
```

---

## Lab 07 — input types, ranges, meters, interactions

### HTML5 pattern validation (HKID example)
```html
<input type="text" id="id_no" name="id_no" 
       pattern="[A-Z]{1}[0-9]{6}" 
       title="Format: A123456 (1 uppercase letter followed by 6 digits)" 
       maxlength="7" size="7" required>
```

### Range slider with output (inline oninput)
```html
<form id="simpleForm" oninput="pointValue.value = pointSlider.value">
    <input type="range" id="pointSlider" min="1" max="10" value="1">
    <input type="text" id="pointValue" value="1" readonly size="1">
</form>
```

### Meter with number input (inline oninput)
```html
<form id="simpleForm" oninput="m.value = t.value">
    <input type="number" id="t" min="-50" max="50" step="0.5">
    <meter id="m" value="0" min="-50" max="50" low="0" high="30" optimum="-10"></meter>
</form>
```

### Animate meter value with jQuery
```javascript
// Animate meter when range slider changes
$("#num").on("input", function() {
    var targetVal = $(this).val();
    $({ val: $("#meter1").val() }).animate(
        { val: targetVal },
        {
            duration: 500,
            step: function(now) {
                $("#meter1").val(now);
            }
        }
    );
});
```

### Weighted marks calculator (vanilla JS)
```javascript
function calculateWeighted() {
    let w1 = parseInt(document.getElementById("weight1").value) || 0;
    let m1 = parseInt(document.getElementById("mark1").value) || 0;
    let w2 = parseInt(document.getElementById("weight2").value) || 0;
    let m2 = parseInt(document.getElementById("mark2").value) || 0;
    let w3 = parseInt(document.getElementById("weight3").value) || 0;
    let m3 = parseInt(document.getElementById("mark3").value) || 0;

    // Check for duplicate weights
    let weights = [w1, w2, w3];
    if (new Set(weights).size < weights.length) {
        document.getElementById("result").innerText = "Error: Weightings must be different!";
        document.getElementById("meter").value = 0;
        return;
    }

    let totalWeight = w1 + w2 + w3;
    if (totalWeight === 0) return;

    let weightedMarks = ((w1 * m1) + (w2 * m2) + (w3 * m3)) / totalWeight;

    document.getElementById("result").innerText = "Weighted Marks = " + weightedMarks.toFixed(2);
    document.getElementById("meter").value = weightedMarks;
}
```

### Form with optgroup select
```html
<select name="product" id="product">
    <optgroup label="Mobile">
        <option value="mobile-phone">Mobile Phone</option>
    </optgroup>
    <optgroup label="PC">
        <option value="desktop">Desktop (PC)</option>
        <option value="notebook">Notebook</option>
        <option value="tablet">Tablet</option>
    </optgroup>
</select>
```

### Range slider with dollar output
```html
<form oninput="output.value = '$' + income.value">
    <input type="range" id="income" min="0" max="100000" value="0">
    <output id="output">$0</output>
</form>
```

---

## Lab 08 — forms & calculators

### Live price calculation (jQuery)
```javascript
$(document).ready(function() {
    function calculateTotal() {
        var price = parseFloat($("#price").val()) || 0;
        var quantity = parseFloat($("#quantity").val()) || 0;
        var discount = parseFloat($("#discount").val()) || 0;

        var total = price * quantity * (1 - discount / 100);
        $("#amount").text(total);
    }

    // Trigger calculation whenever inputs change
    $("#price, #quantity, #discount").on("input", calculateTotal);
});
```

### BMI Calculator with radio buttons
```javascript
$(document).ready(function() {
    $("#div2").hide();
    $("#div3").hide();

    $(":radio").click(function() {
        if ($(this).hasClass("radio1")) {
            $("#div3").hide();
            $("#div2").show();

            function calculateTotal() {
                var weight = parseFloat($("#weight1").val()) || 0;
                var height = parseFloat($("#height1").val()) || 0;
                var result = 0;
                if (height > 0) {
                    result = weight / ((height / 100) * (height / 100));
                }
                $("#result1").text(result);
            }
            $("#weight1, #height1").on("input", calculateTotal);

        } else if ($(this).hasClass("radio2")) {
            $("#div2").hide();
            $("#div3").show();

            function calculateTotal() {
                var weight = parseFloat($("#weight2").val()) || 0;
                var height = parseFloat($("#height2").val()) || 0;
                var result = 0;
                if (height > 0) {
                    result = (weight / 2.2) / ((height / 100) * (height / 100));
                }
                $("#result2").text(result);
            }
            $("#weight2, #height2").on("input", calculateTotal);
        }
    });
});
```

### Sync slider with number input + datalist (vanilla JS)
Note: This example uses vanilla JS as shown in lab8_3.html. For jQuery version, see the BMI calculator above.
```javascript
$(document).ready(function() {
    function calculateTotal() {
        const p = parseFloat($("#price").val()) || 0;
        const q = parseFloat($("#quantity").val()) || 0;
        const d = parseFloat($("#delivery").val()) || 0;
        $("#total").val((p * q + d).toFixed(2));
    }

    // Sync slider and number box
    $("#slider").on("input", function() {
        $("#quantity").val($(this).val());
        calculateTotal();
    });

    $("#quantity").on("input", function() {
        $("#slider").val($(this).val());
        calculateTotal();
    });

    $("#price, #delivery").on("input", calculateTotal);

    calculateTotal();
});
```

### Datalist HTML
```html
<input list="deliverylist" id="delivery" name="delivery" placeholder="Select">
<datalist id="deliverylist">
    <option label="Hong Kong" value="10"></option>
    <option label="Kowloon" value="15"></option>
    <option label="New Territories" value="20"></option>
</datalist>
```

---

## Quick Reference - Common Patterns

### parseFloat with default 0
```javascript
var value = parseFloat($("#input").val()) || 0;
```

### Event delegation for dynamic elements
```javascript
$("#parent").on("click", ".dynamicChild", function() {
    $(this).appendTo("#target");
});
```

### Get/Set form values
```javascript
// Get value
var val = $("#input").val();
// Set value
$("#input").val("new value");
// Get text
var txt = $("#element").text();
// Set text
$("#element").text("new text");
// Get/Set HTML
var html = $("#element").html();
$("#element").html("<p>new content</p>");
```

### Check visibility
```javascript
if ($("#element").is(":visible")) {
    // element is visible
}
```

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