(function(h){var a=function(){var c=function(b){b=-b.getTimezoneOffset();return null!==b?b:0},d=function(){return c(new Date(2010,0,1,0,0,0,0))},e=function(){return c(new Date(2010,5,1,0,0,0,0))},g=function(){var b=d(),f=e(),c=d()-e();return new a.TimeZone(a.olson.timezones[0>c?b+",1":0<c?f+",1,s":b+",0"])};return{determine_timezone:function(){"undefined"!==typeof console&&console.log("jstz.determine_timezone() is deprecated and will be removed in an upcoming version. Please use jstz.determine() instead.");
return g()},determine:g,date_is_dst:function(b){var a=5<b.getMonth()?e():d(),b=c(b);return 0!==a-b}}}();a.TimeZone=function(c){var d=null,d=c.tz,e=c.tzc;"undefined"!==typeof a.olson.ambiguity_list[d]&&function(){for(var c=a.olson.ambiguity_list[d],b=c.length,f=0,e=c[0];f<b;f+=1)if(e=c[f],a.date_is_dst(a.olson.dst_start_dates[e])){d=e;break}}();return{name:function(){return d},code:function(){return e}}};a.olson={};a.olson.timezones={1:{tz:"Africa/Cairo",tzc:0},"120,0":{tz:"Africa/Johannesburg",tzc:1},
"60,0":{tz:"Africa/Lagos",tzc:2},"60,1,s":{tz:"Africa/Windhoek",tzc:3},"-540,1":{tz:"America/Anchorage",tzc:4},"-180,0":{tz:"America/Argentina/Buenos_Aires",tzc:5},"-240,1,s":{tz:"America/Asuncion",tzc:6},"-300,0":{tz:"America/Bogota",tzc:7},"-270,0":{tz:"America/Caracas",tzc:8},"-360,1":{tz:"America/Chicago",tzc:9},"-420,1":{tz:"America/Denver",tzc:10},"-180,1":{tz:"America/Godthab",tzc:11},"-360,0":{tz:"America/Guatemala",tzc:12},"-240,1":{tz:"America/Halifax",tzc:13},"-480,0":{tz:"America/Los_Angeles",
tzc:14},"-480,1":{tz:"America/Los_Angeles",tzc:14},"-360,1,s":{tz:"America/Mexico_City",tzc:15},"-180,1,s":{tz:"America/Montevideo",tzc:16},"-300,1":{tz:"America/New_York",tzc:17},"-120,0":{tz:"America/Noronha",tzc:18},"-420,0":{tz:"America/Phoenix",tzc:19},2:{tz:"America/Santiago",tzc:20},"-240,0":{tz:"America/Santo_Domingo",tzc:21},3:{tz:"America/Sao_Paulo",tzc:22},"-210,1":{tz:"America/St_Johns",tzc:23},"180,0":{tz:"Asia/Baghdad",tzc:24},"120,1":{tz:"Asia/Beirut",tzc:25},4:{tz:"Asia/Damascus",
tzc:26},"360,0":{tz:"Asia/Dhaka",tzc:27},"240,0":{tz:"Asia/Dubai",tzc:28},"480,1":{tz:"Asia/Irkutsk",tzc:29},"420,0":{tz:"Asia/Jakarta",tzc:30},5:{tz:"Asia/Jerusalem",tzc:31},"270,0":{tz:"Asia/Kabul",tzc:32},"660,1":{tz:"Asia/Kamchatka",tzc:33},"300,0":{tz:"Asia/Karachi",tzc:34},"345,0":{tz:"Asia/Kathmandu",tzc:35},"330,0":{tz:"Asia/Kolkata",tzc:36},"420,1":{tz:"Asia/Krasnoyarsk",tzc:37},"360,1":{tz:"Asia/Omsk",tzc:38},"390,0":{tz:"Asia/Rangoon",tzc:39},"480,0":{tz:"Asia/Shanghai",tzc:40},"210,1":{tz:"Asia/Tehran",
tzc:41},"840,0":{tz:"Asia/Tokio",tzc:42},"-540,0":{tz:"Asia/Tokio",tzc:42},"540,0":{tz:"Asia/Tokyo",tzc:42},"-570,0":{tz:"Asia/Tokyo",tzc:42},"600,1":{tz:"Asia/Vladivostok",tzc:43},"540,1":{tz:"Asia/Yakutsk",tzc:44},"300,1":{tz:"Asia/Yekaterinburg",tzc:45},"240,1":{tz:"Asia/Yerevan",tzc:46},"-60,1":{tz:"Atlantic/Azores",tzc:47},"-60,0":{tz:"Atlantic/Cape_Verde",tzc:48},"570,1,s":{tz:"Australia/Adelaide",tzc:49},"690,0":{tz:"Australia/Brisbane",tzc:50},"600,0":{tz:"Australia/Brisbane",tzc:50},"630,1,s":{tz:"Australia/Brisbane",
tzc:50},"570,0":{tz:"Australia/Darwin",tzc:51},"525,1,s":{tz:"Australia/Eucla",tzc:52},"525,0":{tz:"Australia/Eucla",tzc:52},"600,1,s":{tz:"Australia/Sydney",tzc:53},"-720,0":{tz:"Etc/GMT+12",tzc:54},"-120,1":{tz:"Etc/GMT+2",tzc:55},"0,0":{tz:"Etc/UTC",tzc:56},"60,1":{tz:"Europe/Berlin",tzc:57},6:{tz:"Europe/Helsinki",tzc:58},7:{tz:"Europe/Istanbul",tzc:59},"0,1":{tz:"Europe/London",tzc:60},8:{tz:"Europe/Minsk",tzc:61},"180,1":{tz:"Europe/Moscow",tzc:62},"-660,0":{tz:"Pacific/Apia",tzc:63},"780,1,s":{tz:"Pacific/Apia",
tzc:63},"765,1,s":{tz:"Pacific/Auckland",tzc:64},"720,1,s":{tz:"Pacific/Auckland",tzc:64},9:{tz:"Pacific/Fiji",tzc:65},"-600,1":{tz:"Pacific/Honolulu",tzc:66},"-600,0":{tz:"Pacific/Honolulu",tzc:66},"660,0":{tz:"Pacific/Noumea",tzc:67},"720,0":{tz:"Pacific/Tarawa",tzc:68},"780,0":{tz:"Pacific/Tongatapu",tzc:69}};a.olson.dst_start_dates={"America/Denver":new Date(2011,2,13,3,0,0,0),"America/Mazatlan":new Date(2011,3,3,3,0,0,0),"America/Chicago":new Date(2011,2,13,3,0,0,0),"America/Mexico_City":new Date(2011,
3,3,3,0,0,0),"Atlantic/Stanley":new Date(2011,8,4,7,0,0,0),"America/Asuncion":new Date(2011,9,2,3,0,0,0),"America/Santiago":new Date(2011,9,9,3,0,0,0),"America/Campo_Grande":new Date(2011,9,16,5,0,0,0),"America/Montevideo":new Date(2011,9,2,3,0,0,0),"America/Sao_Paulo":new Date(2011,9,16,5,0,0,0),"America/Los_Angeles":new Date(2011,2,13,8,0,0,0),"America/Santa_Isabel":new Date(2011,3,5,8,0,0,0),"America/Havana":new Date(2011,2,13,2,0,0,0),"America/New_York":new Date(2011,2,13,7,0,0,0),"Asia/Gaza":new Date(2011,
2,26,23,0,0,0),"Asia/Beirut":new Date(2011,2,27,1,0,0,0),"Europe/Minsk":new Date(2011,2,27,2,0,0,0),"Europe/Helsinki":new Date(2011,2,27,4,0,0,0),"Europe/Istanbul":new Date(2011,2,28,5,0,0,0),"Asia/Damascus":new Date(2011,3,1,2,0,0,0),"Asia/Jerusalem":new Date(2011,3,1,6,0,0,0),"Africa/Cairo":new Date(2010,3,30,4,0,0,0),"Asia/Yerevan":new Date(2011,2,27,4,0,0,0),"Asia/Baku":new Date(2011,2,27,8,0,0,0),"Pacific/Auckland":new Date(2011,8,26,7,0,0,0),"Pacific/Fiji":new Date(2010,11,29,23,0,0,0),"America/Halifax":new Date(2011,
2,13,6,0,0,0),"America/Goose_Bay":new Date(2011,2,13,2,1,0,0),"America/Miquelon":new Date(2011,2,13,5,0,0,0),"America/Godthab":new Date(2011,2,27,1,0,0,0)};a.olson.ambiguity_list={"America/Chicago":["America/Chicago","America/Mexico_City"],"America/Asuncion":["America/Asuncion","America/Santiago"],"America/Montevideo":["America/Montevideo","America/Sao_Paulo"],"Asia/Beirut":"Asia/Beirut Europe/Minsk Europe/Helsinki Europe/Istanbul Asia/Damascus Asia/Jerusalem Africa/Cairo".split(" "),"Pacific/Auckland":["Pacific/Auckland",
"Pacific/Fiji"]};"undefined"!==typeof exports?exports.jstz=a:h.jstz=a})(this);