$(function() {
        $(".top").click(function() {
          $("body").animate({ scrollTop: 0 }, "slow");
          return false;
        });
    });
    
    var repeat=1 
    var title=document.title
    var leng=title.length
    var start=1
    function titlemove() 
    {
        titl=title.substring(start, leng) + title.substring(0, start)
        document.title=titl
        start++
        if (start==leng+1) 
        {
            start=0
            if (repeat==0)
            return
        }
        setTimeout("titlemove()",250)
    }
    if (document.title)
    titlemove()

$(document).ready(function(){
            $('.bxslider').bxSlider({
                infiniteLoop: true
            });
        });