# What is this?
<p>There i will post my progress about getting information of rivel source code</p>

# SESSION 1 - START
23:12 - 10/21/2022
> Like 5 hours ago i found an tiktok with an information, about rivel free. "xratatuj" created an discord server with executable. Let's have a look.
<p align="center">Found Files: <br> <br>
	<img src="https://github.com/lemonekq/RivelFree/blob/main/md-files/files.png">
</p>

* download avalible here: [DL LINK](https://github.com/lemonekq/RivelFree/blob/main/md-files/rivel_sample.zip)

# SESSION 1 - EXPLORING RIVEL.EXE
> I found out that, the rivel.exe purpose is to mask the batch and run it, nothing around it. We can see it there ```C:\Windows\system32\cmd.exe /c ""C:\Users\Admin\AppData\Local\Temp\95FB.tmp\Rivel 2.0.bat""```
<br>
We can see later it checks for hwid license, This is an example of bad usage of license system. Someone can just create an almost same server which is giving every time the true value. *We're doing that!
<br> <br>
I wrote  an simple response server in expressjs

```javascript
const express = require("express"); const app = express();

app.get("*", (req, res) => {
    res.send("true");
    console.log("Somenthing connected! \n");
    console.log("User-Agent: " + req.get("User-Agent"));
});

app.listen(443, () => { console.log(`Spoofin!`) });
```