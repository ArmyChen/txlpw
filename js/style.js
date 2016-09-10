// JavaScript Document
/******文字滚动********/
function AutoScroll(obj){
$(obj).find("ul:first").animate({
marginTop:"-56px"
},500,function(){
$(this).css({marginTop:"0px"}).find("li:first").appendTo(this);
});
}
$(document).ready(function(){
setInterval('AutoScroll("#scrollDiv")',3000);
});

$(function(){
	$('.ul1 li').click(function(){
		$(this).addClass('hover1').siblings().removeClass('hover1');
		var index1=$(this).index();
		$('div.benBox >div').eq(index1).show().siblings().hide();
		});
	});