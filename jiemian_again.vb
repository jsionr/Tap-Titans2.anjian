界面1:
{
	挂机设置:
	{
		文字框:
		{
			显示内容:"！！！使用辅助须知！！！",
			文字大小:25,
		},	
		文字框:
		{
			显示内容:"仅优化1080p，其他分辨率可能出错",
		},	
		文字框:
		{
			显示内容:"游戏设置语言必须为简体中文",
		},	
		文字框:
		{
			显示内容:"关卡切换设置为开启",
		},	
		文字框:
		{
			显示内容:"2019年1月21日16:09:17",
		},	
		多选框:
		{
			名称:"tapkill",
			提示内容:"仅无限点击（其他功能失效）",
			选中:false,
		},	
		水平布局:
		{
            		文字框:
            		{
                		显示内容:"自动部落使用钻石",
            		},	
			下拉框:
			{
				注释:"初始选项是可选属性，默认值为0。模版中设置了三个选项，您可以根据需要增加或减少，注意各选项之间用逗号分隔。",
				名称:"tribe_num",
				选项:
				[
                		"不部落",
				"0钻石",
				"5钻石",
				"20钻石",
				"50钻石",
				],
				初始选项:1
			},	
		},
		文字框:
		{
			显示内容:"****日常功能设置******",
		},	
		水平布局:
		{
			多选框:
			{
				名称:"competition",
				提示内容:"点击参加竞赛",
				
				选中:false,
			},	
			多选框:
			{
				名称:"daily_reward",
				提示内容:"点击每日奖励",
				
				选中:true,
			},	
			多选框:
			{
				名称:"achievement",
				提示内容:"点击成就",
				
				选中:true,
			},	
			多选框:
			{
				名称:"chest",
				提示内容:"点击宝箱",
				
				选中:true,
			},	
			多选框:
			{
				名称:"egg",
				提示内容:"点击宠物蛋",
				
				选中:true,
			},	
		},
		文字框:
		{
			显示内容:"****小仙女广告设置(挂机容易出错误)****",
		},
		水平布局:
		{
			多选框:
			{
				名称:"fairy_1",
				提示内容:"消费热潮",
				选中:false,				
			},
			多选框:
			{
				名称:"fairy_2",
				提示内容:"钻石",
				选中:false,				
			},	
			多选框:
			{
				名称:"fairy_3",
				提示内容:"金币",
				选中:false,				
			},
			多选框:
			{
				名称:"fairy_4",
				提示内容:"补充法力",
				选中:false,
			},	
		},
		文字框:
		{
			显示内容:"******修改设置（使用必须查看攻略）******",
		},	
		多选框:
		{
			名称:"GG_cd",
			提示内容:"修改cd",
			
			选中:false,
		},
		多选框:
		{
			名称:"GG_blue",
			提示内容:"修改锁蓝",
			
			选中:false,
		},	
		文字框:
		{
			显示内容:"***************一切来自chii****************",
			文字大小:15,
			高度:70,

		},
	},	
	升级蜕变:
	{
		文字框:
		{
			显示内容:"**********蜕变**********",
		},
		水平布局:
		{
			文字框:
			{
				显示内容:"∞|蜕变层数",
			},
			输入框:
			{
				名称:"layer_number_max",
				仅输入数字:true,
				最大输入长度:5,
				宽度:360
			},
			文字框:
			{
				显示内容:"层",
			},
		},

		多选框:
		{
			名称:"auto_prestige",
			提示内容:"自动蜕变(下列选项生效)",
			选中:true,
		},	
		水平布局:
		{
			文字框:
			{
				显示内容:"3|挑战头目失败强制蜕变次数：",
			},	
			输入框:
			{
				名称:"boss_maxnum",
				仅输入数字:true,
				最大输入长度:5,
				宽度:240
			},	
		},
		水平布局:
		{
			文字框:
			{
				显示内容:"600|卡层强制蜕变时间",
			},
			输入框:
			{
				名称:"prestige_maxtime",
				仅输入数字:true,
				最大输入长度:5,
				宽度:360
			},
			文字框:
			{
				显示内容:"秒",
			},
		},

		
		文字框:
		{
			显示内容:"**********神器红书**********",
		},	
		多选框:
		{
			名称:"artifact",
			提示内容:"蜕变后升级红书(必须在第一格)",
			选中:false,
		},	

		文字框:
		{
			显示内容:"**********升级**********",
		},	
		文字框:
		{
			显示内容:"优先升级的栏目",
		},	
		下拉框:
		{
			名称:"navbar_first",
			选项:
			[
			"佣兵栏",
			"英雄栏",
			],
			初始选项:0
		},	
			水平布局:
		{
			文字框:
			{
				显示内容:"360|检测升级时间",
			},
			输入框:
			{
				名称:"update_time",
				仅输入数字:true,
				最大输入长度:5,
				宽度:200
			},			
			文字框:
			{
				显示内容:"秒",
			},
		},
		文字框:
		{
			显示内容:"**********技能**********",
		},	
		水平布局:
		{
			多选框:
			{
				名称:"skill_1",
				提示内容:"天堂圣击",
				选中:false,
			},	
			多选框:
			{
				名称:"skill_2",
				提示内容:"致命打击",
				选中:false,
			},	
			多选框:
			{
				名称:"skill_3",
				提示内容:"米达斯之手",
				选中:false,
			},	
			多选框:
			{
				名称:"skill_4",
				提示内容:"火焰之剑",
				选中:false,
			},				
			多选框:
			{
				名称:"skill_5",
				提示内容:"战嚎         ",
				选中:false,
			},				
			多选框:
			{
				名称:"skill_6",
				提示内容:"影分身术",
				选中:false,
			},	
		},	
	},	
	杂项:
	{		
		水平布局:
		{
			多选框:
			{
				名称:"acenergy",
				选中:false,

			},	
			文字框:
			{
",
				显示内容:"7点到7点半暂停运行",

			},	
			
		},	
	
		水平布局:
		{
			文字框:
			{
				显示内容:"开启等待时间",
			},	
			输入框:
			{
				注释:"初始文本、文字大小、最大输入长度、高度、宽度是可选属性，如需使用默认值，可保持值为0或直接删除此属性",
				名称:"textedit_delay",
				提示内容:"延迟时间",
				初始文本:"0",
				仅输入数字:true,
				最大输入长度:3,
				宽度:200
			},	
			文字框:
			{
				显示内容:"分钟",
			},	
		},		

		水平布局:
		{
			文字框:
			{
				显示内容:"每",
			},	
			输入框:
			{
				注释:"初始文本、文字大小、最大输入长度、高度、宽度是可选属性，如需使用默认值，可保持值为0或直接删除此属性",
				名称:"textedit_reboot_delay",
				提示内容:"时间",
				初始文本:"0",
				仅输入数字:true,
				
				最大输入长度:3,
				
				宽度:200
			},	
			文字框:
			{
				显示内容:"分钟重启游戏",
			},	
		},
		文字框:
		{
			显示内容:"*******发送信息到邮箱*********",
		},	
		水平布局:
		{
			文字框:
			{
				显示内容:"发送邮箱账号",
			},	
			输入框:
			{
				名称:"mail_username",
				提示内容:"xxx@qq.com",
				仅输入数字:false,
				宽度:400
			},	
		},
		水平布局:
		{
			文字框:
			{
				显示内容:"发送邮箱密码",
			},	
			输入框:
			{
				名称:"mail_password",
				提示内容:"xxxxxx",
				仅输入数字:false,
				宽度:400
			},
		},
		水平布局:
		{
			文字框:
			{
				显示内容:"接收邮箱账号",
			},	
			输入框:
			{
				名称:"mail_tomail",
				提示内容:"xxx@xx.com",
				仅输入数字:false,
				宽度:400
			},
		},
		文字框:
		{
			显示内容:"只支持QQ邮箱smtp,注意smtp如何生成密码",
		},		
	},	
}
