# DealerOn-Project

### Introduction
First off thank you for taking time to review the code 
test I completed for DealerOn. This is my first real swing
at both Selenium in C# and using any sort of BDD design.

In my career as a SDET I have worked in Java shops and currently
now a Scala environment so I have not really had the chance
to get my feet wet in C#. With that said I took the opportunity
to learn something new. Please make me aware of any feedback or ways
to improve, Im always open to feedback

### AboutUs.feature
This was probably the most challenging test for such a silly reason.
I had a ton of issues getting the text from an element in C#. Normally
I could use an implicit wait on the page to wait for it to load but couldnt get
it functioning with C#. I left in the implicit wait I tried, just commenting it out but
sadly was forced to use an ugly sleep timer to wait for the module to load with an even
uglier selector to find the element. With no sleep or wait it quickly returns `null`.

### SearchInventory.feature
Only issue I had with this at first was upon clicking 'Used'
radio button it would open a new window to display a coupon in the
previous window. Almost seems like a bug, but I did duplicate some code
to make this work. Just having it click used, move tabs, click again
was an easy work around. Test runs smoothly and asserts that the first title
contains "2017 Chevrolet Corvette". I attempted to count the number
of results and use a loop to validate each title but small differences
in Java and C# would not let that work.

### UsedInventory.feature
This simply goes to the Used Inventory page, counts how many vehicles
are shown and will match that to how many "Mileage: ###" responses it sees.
New vehicles do not show the mileage therefore I thought it was a good way
to quickly see that all responses are used and the test can scale to whatever
is returned.

### Additional Test Cases
There are a million additional test cases I could write for this website
however I wanted to make sure I have enough time as I was told getting this
delivered before Thursday would be optimal. Some other tests or tools that could
have been done include:

- Testing coupons such as the persistant $100 off coupon that shows on the homepage
- Testing email list signup
- Testing search with no year selected (Not sure why Make gets disabled when Year is unselected?)
- Visual tests of any sort
- API tests would be valuable if I was able to find API endpoints
- Any form within the site such as "Request an Appointment" to validate required fields and desired response
- And many many many more...

### Tools Used
- Selenium C#
- SpecFlow

### What I Could Improve
- Find a way to fix the AboutUs test. Ive tried every selector under the sun, every way to grab text  that StackOverflow, YouTube, and Google could find me. Nothing worked, would love to find a way.
- I was unable to setup my objects how I normally do. With Scala I can extend multiple classes, thus allowing to call multiple object classes. Not a big deal but would make things a ton cleaner and allow for a bit more reusability.
- I was also forced to duplicate a few features. Not 100% on BDD yet but I tried reusing features such as to setup the driver, or connect to a specific URL. Normally I would use TestNG or Junit annotations to setup `@Before` or `@After` classes for startup/ teardown reusability. Again just to clean things up.
