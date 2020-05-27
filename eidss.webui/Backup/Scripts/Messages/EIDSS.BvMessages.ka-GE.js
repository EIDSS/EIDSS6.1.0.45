(function () {

	EIDSS = {};

	var resources = {'bntShowSearch': 'ძებნის ჩვენება'
, 'ErrDataValidation': 'ზოგიერთ უჯრაში არასწორი მონაცემებია'
, 'errUnknownError': 'პროგრამაში შეცდომაა'
, 'ErrPost': ' შეცდომა მონაცემთა ბაზაში მონაცემთა დამახსოვრებისას'
, 'ErrFillDataset': ' შეცდომა მონაცემთა ბაზიდან მონაცემთა ამოღებისას'
, 'bntHideSearch': 'ძებნის დამალვა'
, 'btnClear': 'ველში ჩაწერილი ტექსტის გასუფთავება'
, 'ErrMandatoryFieldRequired': '{0}\' ველის შევსება სავალდებულოა. ამ ველში მონაცემები უნდა შეიყვანოთ ფორმის დამახსოვრებამდე.'
, 'btnHideErrDetail': 'დეტალების დამალვა'
, 'btnShowErrDetail': 'დეტალების ჩვენება'
, 'ErrUnprocessedError': 'პროგრამაში შეცდომაა. გთხოვთ გაუგზავნოთ ამ შეცდომის შესახებ ინფორმაცია პროგრამის ავტორთა ჯგუფს'
, 'ErrInvalidLogin': 'არასწორი სისტემაში შესვლის სახელი/პაროლი'
, 'ErrUserNotFound': 'მომხმარებლის სახელი არ მოიძებნა.'
, 'ErrStoredProcedure': 'მონაცემთა ბაზაში შენახვის პროცედურის შესრულების დროს დაფიქსირდა შეცდომა'
, 'ErrUndefinedStdError': 'პროგრამაში შეცდომაა. გთხოვთ გაუგზავნოთ ამ შეცდმომის შესახებ ინფორმაცია პროგრამის ავტორთა ჯგუფს'
, 'ErrOldPassword': 'მომხმარებლის ძველი (მიმდინარე) პაროლი არასწორია. პაროლი არ შეუცვლიათ.'
, 'ErrInvalidParameter': 'sql ოპერატორს  არასწორი მაჩვენებელი გაეგზავნა'
, 'Delete Record': 'ჩანაწარის წაშლა'
, 'ErrInvalidFieldFormat': '\'{0}\' ველისთვის მონაცემების ფორმატი არასწორია .'
, 'msgConfimation': 'დადასტურება'
, 'btnSelect': 'არჩევა'
, 'Confirmation': 'დადასტურება'
, 'errNoFreeLocation': 'ამ საცავში არ არის თავისუფალი ადგილი'
, 'Save data?': 'გსურთ მონაცემების შენახვა?'
, 'msgDeletePrompt': 'ობიექტი იქნება ამოღებული. ამოღებულ იქნას ობიექტი?'
, 'msgMessage': 'შეტყობინება'
, 'ErrEmptyUserLogin': 'მომხმარებლის სახელი უნდა შეივსოს'
, 'ErrIncorrectDatabaseVersion': 'მონაცემთა ბაზა არ არსებობს ან არაკორექტულია. გთხოვთ განაახლოთ მონაცემთა ბაზა'
, 'ErrLowClientVersion': 'პროგრამის ვერსია არ ეთანხმება მონაცემთა ბაზის ერსიას.გთხოვთ განაახლოთ პროგრამა.'
, 'ErrLowDatabaseVersion': 'პროგრამა ითხოვს უახლეს მონაცემთა ბაზას. გთხოვთ განაახლოთ.'
, 'msgCantDeleteRecord': 'ჩანაწერის წაშლა შეუძლებელია.'
, 'msgEIDSSRunning': 'დზეის-ის ერთდროულად რამდენიმეჯერ გაშვება შეუძლებელია. დზეის ერთხელ უკვე არის გაშვებული.'
, 'msgNoRecordsFound': 'ძებნის მოცემული კრიტერიუმების მიხედვით ჩანაწერი არ მოიპოვება.'
, 'msgParameterAlreadyExists': 'ველი უკვე არსებობს'
, 'msgCancel': 'ყველა შეყვანილი მონაცემი დაიკარგება. გააგრძელებთ?'
, 'msgConfirmClearFlexForm': 'გავასუფთავო პანელის შიგთავსი?'
, 'msgPasswordNotTheSame': 'პაროლის დადასტურება არასწორია.'
, 'msgREplicationPromptCaption': 'დაადასტურეთ რეპლიკაცია '
, 'btnView': 'ნახვა'
, 'ErrDatabase': 'შეცდომა მონაცემთა ბაზასთან მუშაობის დროს. '
, 'ErrSqlQuery': 'შეცდომა  sql მოთხოვნის შესრულებისას.'
, 'errDatabaseNotFound': 'შეუძლებელია \'{0}\' მონაცემთა ბაზის გახსნა \'{1}\'  სერვერზე. შეამოწმეთ მონაცემთა ბაზის დასახელების სისწორე.'
, 'errSqlServerNotFound': 'შეუძლებელია \'{0}\' SQL სერვერთან დაკავშირება. შეამოწმეთ SQL სერვერის დასახელების სისწორე ან SQL სერვერის მისაწვდომობა.'
, 'errSQLLoginError': 'შეუძლებელია SQL სერვერთან დაკავშირება. შეამოწმეთ SQL სერვერთან დაკავშირების პარამეტრების სისწორე SQL სერვერის ჩანართზე ან SQL სერვერის მისაწვდომობა.'
, 'msgNoFreeSpace': 'ამ ადგილმდებარეობაზე თავისუფალი ადგილი აღარ არის '
, 'msgLocked': 'ობიექტი დაბლოკილია სხვა მომხმარებლის მიერ. '
, 'msgLockedByAonotherOperation': 'ობიექტი დაბლოკილია სხვა ოპერაციით.'
, 'errSampleInTransfer': 'ნიმუში "{0}" უკვე შეტანილია გადატანის სიაში "{1}"'
, 'msgReplicationPrompt': 'დაიწყოს რეპლიკაცია სხვა ობიექტების გადასახემ მონაცემებზე?'
, 'msgNoSelectPermission': 'ამ ფორმის ნახვის უფლება არ გაქვთ'
, 'ErrLoginIsLocked': 'სისტემაში შესვლა დაიბლოკა.  სცადეთ ხელახლა გარკვეული დროის შემდეგ.'
, 'errInvailidSiteID': 'ობიექტის არასწორი ID  კოდი ან სერიული ნომერი'
, 'errInvailidSiteType': 'ობიექტის არასწორი ტიპი ან სერიული ნომერი'
, 'msgEmptyLogin': 'სისტემაში შესვლა არ არის განსაზღვრული'
, 'msgNoInsertPermission': 'თქვენ არ გაქვთ ამ ობიექტის შექმნის უფლებ'
, 'msgNoDeletePermission': 'თქვენ არა გაქვთ ამ ობიექტის წაშლის უფლება'
, 'msgClearControl': 'მნიშვნელობის წასაშლელად დააწექით Ctrl-Del კლავიშს.'
, 'msgConfirmClearLookup': 'გავასუფთავო შიგთავსი?'
, 'msgReasonEmpty': 'შეიყვანეთ ცვლილების შეტანის მიზეზი'
, 'msgDeleteRecordPrompt': 'ჩანაწერი იქნება ამოღებული. გსურთ ჩანაწერის ამოღება?'
, 'ErrFilterValidatioError': 'ფილტრის კრიტერიუმების მნიშვნელობა [{0}] ველისთვის არ შეიძლება იყოს შეუვსებელი.'
, 'tooltipClose_Id': 'დახურვა'
, 'strClose_Id': 'დახურვა'
, 'strRefresh_Id': 'განახლება'
, 'tooltipRefresh_Id': 'განახლება'
, 'strCreate_Id': 'შექმნა'
, 'tooltipCreate_Id': 'შექმნა'
, 'strEdit_Id': 'რედაქტირება'
, 'tooltipEdit_Id': 'რედაქტირება'
, 'strDelete_Id': 'წაშლა'
, 'tooltipDelete_Id': 'წაშლა'
, 'strOK_Id': 'დიახ'
, 'tooltipOK_Id': 'დიახ'
, 'strCancel_Id': 'გაუქმება'
, 'tooltipCancel_Id': 'გაუქმება'
, 'strSave_Id': 'დამახსოვრება'
, 'tooltipSave_Id': 'დამახსოვრება'
, 'errSqlServerDoesntExist': 'შეუძლებელია SQLსერვერთან დაკავშირება. გთხოვთ. შეამოწმეთ, რომ ქსელთან კავშირი ჩართულია, SQL სერვერი არ არის გათიშული და კვლავ სცადეთ ამ ფორმის გახსნა.'
, 'errGeneralNetworkError': 'შეუძლებელია SQLსერვერთან დაკავშირება. გთხოვთ, შეამოწმეთ, რომ ქსელთან კავშირი ჩართულია და კვლავ სცადეთ ამ ფორმის გახსნა.'
, 'Error': 'შეცდომა'
, 'SecurityLog_EIDSS_finished_successfully': 'დზეის-ი დასრულდა წარმატებით'
, 'SecurityLog_EIDSS_started_abnormaly': 'დზეის-ი დაიწყო არასწორად'
, 'SecurityLog_EIDSS_started_successfully': 'დზეის-ი დაიწყო წარმატებით'
, 'errInvalidSearchCriteria': 'ძებნის არასწორი კრიტერიუმები.'
, 'msgWaitFormCaption': 'გთხოვთ მოითმინოთ'
, 'msgWaitFormLoading': 'ფორმა იტვირთება'
, 'ErrPasswordPolicy': 'შეუძლებელია პაროლის განახლება. ახალი პაროლის მნიშვნელობები არ აკმაყოფილებს სიგრძის, სირთულის ან ისტორიის მოთხოვნას.'
, 'ErrPasswordExpired': 'თქვენი პაროლის მოქმედების ვადა ამოიწურა. გთხოვთ, შეცვალეთ პაროლი.'
, 'msgPasswordChanged': 'თქვენი პაროლი წარმატებით შეიცვალა.'
, 'msgEIDSSCopyright': 'საავტორო უფლება © 2005-2011 Black && Veatch Special Projects Corp'
, 'msgCancelPrompt': 'Do you want to cancel all the changes and close the form?'
, 'msgSavePrompt': 'Do you want to save changes?'
, 'msgOKPrompt': 'Do you want to save changes and close the form?'
, 'Warning': 'Warning'
, 'Message': 'Message'
};

	EIDSS.BvMessages = resources;

})();