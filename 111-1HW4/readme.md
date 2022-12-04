# 第4次作業題目-作業-HW4
[deadline 2022/12/14 00:00:00](#)
>撰寫前請注意

1. 請[點選](https://github.com/altoliaw3/111-1HW4.git)該連結連結至題目之倉庫，並對該倉庫進行fork
2. 再藉由上述所提供的連結，把該fork至自己帳號的倉庫clone至本機端，
再進行程式撰寫與文件撰寫

> 正題

請解決下面問題。請於該專案下新增一個Web表單(網頁表單)名稱為Test.aspx寫下以下功能：
在開始前，請打開「檢視」->「SQL Server 物件總管」於某資料庫機器下，手動建立一名稱為Test的資料庫
(若已經有的請先刪除)，並左鍵選擇該Test資料庫並右鍵打開選單，選取「新增查詢(Q)」，
在將專案的User.sql內容複製該查詢上「執行」，使其生成Users資料表。之後再進行以下動作：
1.  先於Test.aspx中插入一個按鈕，ID名稱為btn_Insert即可，Text名稱為「點我新增資料」
2. 請參考Topic 11的第30頁，以Dataset方法於btn_Insert的事件中寫入功能，其功能為插入一筆資料。
該資資料欄位對應內容為Name= N'阿貓阿狗', Birthday='2000/10/10'。
請注意連線字串需要放在Web.config檔案中，帳號需為sa，密碼必須要是'12345'。
2. 之後請於page_load中，使用Dataset將Users資料表資料抓出，並使用Grid view去承接結果使其
印出在畫面上；該Grid view 位置為於btn_Insert按鈕下方，Grid的Id為gd_View。


> 補充說明 (以下各項全需滿足，才會進行評分)

1. 請將完成程式後，撰寫書面內容寫於answer.md
2. 將將該answer.md檔藉由markdown editor 顯示部分，按右鍵進行列印成pdf檔案，
檔名需為answer.md.pdf
3. 將answer.md.pdf檔於[CleverPDF](https://www.cleverpdf.com/zh-tw/encrypt-pdf)進行**防拷貝**，
並將防拷貝後的answer.md.pdf放置至專案下並拖入VS community IDE內的「**方案總管**」
4. 將answer.md使用winrar加密打包，請自己記住密碼，
並於VS community IDE內的「**方案總管**」刪除answer.md檔案
5. 將專案執行git add、commit、push至github後，並於
[google sheet(點我)](https://docs.google.com/spreadsheets/d/1x_GfVISrublmnrn1S43wtEt_XPEKV2AqirTlMZPLCK4/edit#gid=345458270)中找尋相對應之試算表，
並於該位同學位置註記同學之倉庫的url

>該次作業完成預計所需時間 (實作與文件撰寫所需要完成時間) 

* 70 mins 以下：專精
* 介於 70 至 100 mins：熟練
* 介於 100 至 180 mins：平均
* 超過 180 mins：不熟，請多花心思在課業上

