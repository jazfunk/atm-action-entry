Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.OleDb

Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.IO.Ports
Imports System.Net








Public Class clsAE_Utilities

	''' <summary>
	''' Checks login against Active Directory
	''' Use for Admin while on the network
	''' </summary>
	''' <param name="DomainName"></param>
	''' <param name="userName"></param>
	''' <param name="userPW"></param>
	''' <remarks></remarks>
	Public Shared Sub ATMnetworkLogin(ByVal DomainName As String, ByVal userName As String, ByVal userPW As String)

		Dim _adPath As String = "LDAP://DC=..,DC=.." 'Path to your LDAP directory server
		Dim _Ldap As New FormsAuth.LdapAuthentication(_adPath)

		If _Ldap.IsAuthenticated(DomainName, userName, userPW) Then
			MessageBox.Show("Logon Details are correct")
			' Do Stuff
		Else
			MessageBox.Show("Invalid logon details, please try again")
		End If



	End Sub




#Region " Methods"

	Public Shared Sub WriteDataSync(ByVal dt As DataTable, ByVal fileName As String)

		Try
			Select Case fileName.Substring(0, 3)
				Case "ae_", "uh_", "npi", "gr_"	' Daily Prouction
					dt.WriteXml(My.Settings.ae_DataSyncPath & fileName, XmlWriteMode.WriteSchema)
				Case "pl_"	' Debugging/Punch List
					dt.WriteXml(My.Settings.ae_DebugPath & fileName, XmlWriteMode.WriteSchema)
				Case "ts_" ' Time reporting
					dt.WriteXml(My.Settings.ae_TimeSheetTxtPath & fileName, XmlWriteMode.WriteSchema)
				Case "am_"	' ActionMessages
					dt.WriteXml(My.Settings.am_OutBox & fileName, XmlWriteMode.WriteSchema)
				Case "exp"	' Exposure Declaration

					'dt.WriteXml(My.Settings.expDeclPath & fileName, XmlWriteMode.WriteSchema)

					' Send XML file to the same directory as TimeSheets so that uploading and downloading
					' can be transparent
					dt.WriteXml(My.Settings.ae_TimeSheetTxtPath & fileName, XmlWriteMode.WriteSchema)

				Case Else
					MessageBox.Show("DataSync File Not Supported")
			End Select
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Utilities-WriteDataSync()")
		End Try

	End Sub


#Region " DataSync Transfer - XML/Images"

	Public Shared Sub DownloadSingleFile(ByVal LocalFile As String, ByVal RemoteLocation As Uri, ByVal RemoteServer As String)

		Try
			If My.Computer.Network.IsAvailable Then	  'AndAlso My.Computer.Network.Ping(RemoteServer)				
				My.Computer.Network.DownloadFile(RemoteLocation, _
				   LocalFile, _
				   My.Settings.ae_FTPuserName, _
				   My.Settings.ae_FTPuserCred, _
				   False, _
				   3000, _
				   True)
			Else
				MessageBox.Show("No available Networks.")
			End If

		Catch ex As Exception

			MessageBox.Show("Transfer was cancelled or has reported errors." & vbCrLf & _
			 "Details:" & vbCrLf & _
			 ex.Message, _
			 "Transfer Aborted!", _
			 MessageBoxButtons.OK, _
			 MessageBoxIcon.Question)

		End Try


	End Sub

	Public Shared Sub UploadSingleFile(ByVal LocalFile As String, ByVal RemoteLocation As Uri, ByVal RemoteServer As String)

		Try
			If My.Computer.Network.IsAvailable Then	  'AndAlso My.Computer.Network.Ping(RemoteServer) Then
				My.Computer.Network.UploadFile(LocalFile, _
				   RemoteLocation, _
				   My.Settings.ae_FTPuserName, _
				   My.Settings.ae_FTPuserCred, _
				   False, _
				   3000)
			Else
				MessageBox.Show("No available Networks.")
			End If

		Catch ex As Exception

			MessageBox.Show("Transfer was cancelled or has reported errors." & vbCrLf & _
			 "Details:" & vbCrLf & _
			 ex.Message, _
			 "Transfer Aborted!", _
			 MessageBoxButtons.OK, _
			 MessageBoxIcon.Question)

		End Try


	End Sub


	Public Shared Sub amXmlUpload(ByVal fileName As String)

		Try
			' Upload to user new message ftp dir
			My.Computer.Network.UploadFile(fileName, _
			 My.Settings.am_FTPNewMessage & Path.GetFileName(fileName), _
			 My.Settings.ae_FTPuserName, _
			 My.Settings.ae_FTPuserCred)

			' Upload copy to archive ftp dir
			My.Computer.Network.UploadFile(fileName, _
			 My.Settings.am_FTPArchive & Path.GetFileName(fileName), _
			 My.Settings.ae_FTPuserName, _
			 My.Settings.ae_FTPuserCred)

			My.Computer.FileSystem.MoveFile(fileName, My.Settings.am_Sent & Path.GetFileName(fileName), True)
		Catch ex As Exception
			MessageBox.Show(ex.Message, "amXmlUpload()")
		End Try



	End Sub

	Public Shared Sub amXmlDownload(ByVal fileName As String)

		Try
			My.Computer.Network.DownloadFile(My.Settings.am_FTPNewMessage & fileName, _
			My.Settings.am_InBox & fileName, _
			My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred, False, 100000, True)

			DeleteFile(My.Settings.am_FTPNewMessage & fileName)

		Catch ex As Exception
			MessageBox.Show(ex.Message, "XmlDownload()")
		End Try
	End Sub



	Public Shared Sub XmlUpload(ByVal fileName As String)

		Try
			My.Computer.Network.UploadFile(fileName, _
			 My.Settings.ae_FTPDataSyncURL & Path.GetFileName(fileName), _
			 My.Settings.ae_FTPuserName, _
			 My.Settings.ae_FTPuserCred)

			My.Computer.FileSystem.MoveFile(fileName, My.Settings.ae_WarehouseXml & Path.GetFileName(fileName), True)
		Catch ex As Exception
			MessageBox.Show(ex.Message, "XmlUpload()")
		End Try



	End Sub

	Public Shared Sub ExpDecXmlUpload(ByVal fileName As String)
		Try
			My.Computer.Network.UploadFile(fileName, _
			 My.Settings.ae_FTPexpDecl & Path.GetFileName(fileName), _
			 My.Settings.ae_FTPuserName, _
			 My.Settings.ae_FTPuserCred)

			My.Computer.FileSystem.MoveFile(fileName, My.Settings.expDeclWarehousePath & Path.GetFileName(fileName), True)

		Catch ex As Exception
			MessageBox.Show(ex.Message, "ExpDecXmlUpload()")
		End Try
	End Sub

	Public Shared Sub TimeXmlUpload(ByVal fileName As String)

		Try
			My.Computer.Network.UploadFile(fileName, _
				My.Settings.ae_FtpTime & Path.GetFileName(fileName), _
				My.Settings.ae_FTPuserName, _
				My.Settings.ae_FTPuserCred)

			My.Computer.FileSystem.MoveFile(fileName, My.Settings.ae_WarehouseTimeSheet & Path.GetFileName(fileName), True)

		Catch ex As Exception
			MessageBox.Show(ex.Message, "TimeXmlUpload()")
		End Try

	End Sub

	' Example Only
	Public Shared Sub XmlUploadExample()

		Dim filePath As String = "C:\myUploadExample.txt"
		Dim fileName As String = Path.GetFileName(filePath)
		Dim myFtpServerAddress As String = "ftp://myFTPserver.com"
		Dim myFtpUserName As String = "FtpUserName"
		Dim myFtpPassword As String = "pASsWorD"


		Try
			' Basic
			My.Computer.Network.UploadFile(filePath, _
			 myFtpServerAddress, _
			 myFtpUserName, _
			 myFtpPassword)


			' Advanced
			My.Computer.Network.UploadFile(filePath, _
			 myFtpServerAddress, _
			 myFtpUserName, _
			 myFtpPassword, _
			 True, _
			 100000, _
			 FileIO.UICancelOption.ThrowException)


		Catch ex As Exception
			MessageBox.Show(ex.Message, "Upload Error!")
		End Try



	End Sub

	Public Shared Sub XmlDownload(ByVal fileName As String)

		Try
			My.Computer.Network.DownloadFile(My.Settings.ae_FTPDataSyncURL & fileName, _
			My.Settings.ae_TransferDataSyncPath & fileName, _
			My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred, False, 100000, True)



		Catch ex As Exception
			MessageBox.Show(ex.Message, "XmlDownload()")
		End Try
	End Sub

	Public Shared Sub ImageUpload(ByVal fileName As String)

		Try
			'MessageBox.Show(My.Settings.ae_ImageDateFolder & fileName)
			'Changed the first variable to just the filename rather then name and directory
			'Was my.settings.ae_ImageFilePath & filename

			'MessageBox.Show(fileName & vbCrLf & My.Settings.ae_ImageDateFolder & Path.GetFileName(fileName))

			My.Computer.Network.UploadFile(fileName, _
			 My.Settings.ae_FTPImageSyncURL & Path.GetFileName(fileName), _
			 My.Settings.ae_FTPuserName, _
			 My.Settings.ae_FTPuserCred)

		Catch ex As Exception
			MessageBox.Show(ex.Message, "ImageUpload()")
		End Try

	End Sub

	Public Shared Sub ImageDownload(ByVal fileName As String)

		Try
			Dim astr() As String = fileName.Split(New Char() {"_"c})

			If Not Directory.Exists(My.Settings.ae_DownloadImagePath & astr(2) & "\Images\Pic_" & astr(4) & "\") Then
				Directory.CreateDirectory(My.Settings.ae_DownloadImagePath & astr(2) & "\Images\Pic_" & astr(4) & "\")
			End If

			'my.settings.ae_FTPImageSyncURL\jobNumber\Images\Pic_date\filename
			My.Computer.Network.DownloadFile(My.Settings.ae_FTPImageSyncURL & fileName, _
			My.Settings.ae_DownloadImagePath & astr(2) & "\Images\Pic_" & astr(4) & "\" & fileName, _
			My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred, False, 100000, True)

		Catch ex As Exception
			MessageBox.Show(ex.Message, "ImageDownload()")
		End Try


	End Sub

	Public Shared Sub DeleteFile(ByVal fileName As String)
		Try
			Dim deleteFile As System.Net.FtpWebRequest = DirectCast(System.Net.FtpWebRequest.Create(fileName), System.Net.FtpWebRequest)

			With deleteFile
				.Credentials = New System.Net.NetworkCredential(My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred)
				.KeepAlive = False
				.UseBinary = True
				.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
			End With

			Dim response As System.Net.FtpWebResponse = CType(deleteFile.GetResponse, System.Net.FtpWebResponse)
			Dim responseStream As IO.Stream = response.GetResponseStream


		Catch ex As Exception
			MessageBox.Show(ex.Message, "DeleteFile()")
		End Try
	End Sub

	Public Shared Sub MoveXmlFtp(ByVal filename As String)
		'	Try
		'		MessageBox.Show(My.Settings.ae_FTPDataSyncURL & filename)
		'		Dim moveXml As System.Net.FtpWebRequest = DirectCast(System.Net.FtpWebRequest.Create(My.Settings.ae_FTPDataSyncURL & filename), System.Net.FtpWebRequest)
		'		With moveXml
		'			.Credentials = New System.Net.NetworkCredential(My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred)
		'			.KeepAlive = False
		'			.UseBinary = True
		'			.Method = System.Net.WebRequestMethods.Ftp.Rename
		'			.RenameTo = "ftp://03294ad.netsolhost.com/htdocs/ActionEntry/dpDataSync/WareHouse/" & filename
		'		End With

		'		Dim response As System.Net.FtpWebResponse = CType(moveXml.GetResponse, System.Net.FtpWebResponse)
		'		'Dim responseStream As IO.Stream = response.GetResponseStream
		'	Catch ex As Exception
		'		MessageBox.Show(ex.Message, "MoveXmlFtp()")
		'	End Try


	End Sub


#End Region

	''' <summary>
	''' Send list of employees submitting time to Shelia
	''' </summary>
	''' <param name="subj">Email Subject</param>
	''' <param name="msgBody">Email Message</param>
	''' <remarks></remarks>
	Public Shared Sub SubmitTimeReported(ByVal subj As String, ByVal msgBody As String)

		Try
			Dim smtpServer As New System.Net.Mail.SmtpClient()
			Dim mail As New System.Net.Mail.MailMessage
			smtpServer.Credentials = New Net.NetworkCredential("actionentry@gmail.com", "actionentry5182")
			smtpServer.Port = 587
			smtpServer.EnableSsl = True
			smtpServer.Host = "smtp.gmail.com"
			mail = New System.Net.Mail.MailMessage()
			mail.From = New System.Net.Mail.MailAddress("actionentry@gmail.com")
			mail.To.Add("mpeake@actiontraffic.net")
			mail.CC.Add("jeff@actiontraffic.net")
			mail.Subject = "Time Report - " & subj
			mail.Body = msgBody
			smtpServer.Send(mail)

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub


	''' <summary>
	''' Send email reporting system info
	''' </summary>
	''' <param name="subj">Email Subject</param>
	''' <param name="msgBody">Email Message</param>
	''' <remarks></remarks>
	Public Shared Sub SubmitSystemInfo(ByVal subj As String, ByVal msgBody As String)
		Try
			Dim smtpServer As New System.Net.Mail.SmtpClient()
			Dim mail As New System.Net.Mail.MailMessage
			smtpServer.Credentials = New Net.NetworkCredential("actionentry@gmail.com", "actionentry5182")
			smtpServer.Port = 587
			smtpServer.EnableSsl = True
			smtpServer.Host = "smtp.gmail.com"
			mail = New System.Net.Mail.MailMessage()
			mail.From = New System.Net.Mail.MailAddress("actionentry@gmail.com")
			mail.To.Add("jeff@actiontraffic.net")
			mail.To.Add("paul@actiontraffic.net")
			mail.Subject = subj & " - " & Now.ToString("MM.dd.yyyy")
			mail.Body = msgBody
			smtpServer.Send(mail)

			My.Settings.ae_SubmitSysInfo = False

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub


	Public Shared Sub SendEmailToShelia(ByVal subj As String, ByVal msgBody As String)

		Try
			Dim smtpServer As New System.Net.Mail.SmtpClient()
			Dim mail As New System.Net.Mail.MailMessage
			smtpServer.Credentials = New Net.NetworkCredential("actionentry@gmail.com", "actionentry5182")
			smtpServer.Port = 587
			smtpServer.EnableSsl = True
			smtpServer.Host = "smtp.gmail.com"
			mail = New System.Net.Mail.MailMessage()
			mail.From = New System.Net.Mail.MailAddress("actionentry@gmail.com")
			mail.To.Add("shelia@actiontraffic.net")
			mail.CC.Add("mpeake@actiontraffic.net")
			mail.Bcc.Add("jeff@actiontraffic.net")
			mail.Subject = subj
			mail.Body = msgBody
			smtpServer.Send(mail)

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub


	Public Shared Sub SendEmailReportEquipProblem(ByVal subj As String, ByVal msgBody As String)

		Try
			Dim smtpServer As New System.Net.Mail.SmtpClient()
			Dim mail As New System.Net.Mail.MailMessage
			smtpServer.Credentials = New Net.NetworkCredential("actionentry@gmail.com", "actionentry5182")
			smtpServer.Port = 587
			smtpServer.EnableSsl = True
			smtpServer.Host = "smtp.gmail.com"
			mail = New System.Net.Mail.MailMessage()
			mail.From = New System.Net.Mail.MailAddress("actionentry@gmail.com")
			mail.To.Add("mpeake@actiontraffic.net")
			mail.CC.Add("jirvin@actiontraffic.net")
			mail.Bcc.Add("jeff@actiontraffic.net")
			mail.Subject = subj
			mail.Body = msgBody
			smtpServer.Send(mail)

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try




	End Sub




#Region " No longer used - Colossal waste of time!"

	'Public Shared Sub DataSyncUpload(ByVal fileName As String)

	'	Try
	'		' Variables
	'		Dim local_file As String = Nothing
	'		Dim remote_file As String = Nothing
	'		Dim cls_request As System.Net.FtpWebRequest

	'		local_file = My.Settings.ae_DataSyncPath & fileName
	'		remote_file = My.Settings.ae_FTPDataSyncURL & fileName

	'		cls_request = DirectCast(System.Net.WebRequest.Create(remote_file), System.Net.FtpWebRequest)

	'		With cls_request
	'			.Credentials = New System.Net.NetworkCredential(My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred)
	'			' Set properties
	'			.KeepAlive = False
	'			.Proxy = Nothing
	'			.Method = System.Net.WebRequestMethods.Ftp.UploadFile
	'			.UseBinary = True

	'		End With

	'		' Read in the file
	'		Dim b_file() As Byte = System.IO.File.ReadAllBytes(local_file)

	'		' Upload the file
	'		Dim cls_stream As System.IO.Stream = cls_request.GetRequestStream()
	'		cls_stream.Write(b_file, 0, b_file.Length)
	'		cls_stream.Close()
	'		cls_stream.Dispose()

	'		'My.Settings.ae_DataSyncComplete = True

	'	Catch ex As Exception
	'		MessageBox.Show(ex.Message, "Utilities - DataSyncUpload()")

	'	End Try

	'End Sub


#End Region



	Public Shared Sub CreateDataSyncDirectories()
		Try
			Dim DataSyncPaths() As String = {My.Settings.ae_AppPath, _
			   My.Settings.ae_ImagePath, _
			   My.Settings.ae_DataSyncPath, _
			   My.Settings.ae_DebugPath, _
			   My.Settings.ae_DownloadImagePath, _
			   My.Settings.ae_TransferImagePath, _
			   My.Settings.ae_TimeSheetTxtPath, _
			   My.Settings.ae_WarehouseTimeSheet, _
			   My.Settings.ae_WarehouseXml, _
			   My.Settings.am_NewMessagePath, _
			   My.Settings.am_InBox, _
			   My.Settings.am_OutBox, _
			   My.Settings.am_Deleted, _
			   My.Settings.am_Sent, _
			   My.Settings.expDeclWarehousePath, _
			   My.Settings.aeDocumentsPath}

			For Each p As String In DataSyncPaths
				If Not My.Computer.FileSystem.DirectoryExists(p) Then
					My.Computer.FileSystem.CreateDirectory(p)
				End If
			Next
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Utilities - CreateDataSyncDirectories()")
		End Try
	End Sub

	Public Shared Function GetFileNameStringArrayFromFTP(ByVal remoteDirectory As String) As String()

		' This function returns a String() Array of all files in given remoteDirectory
		' Used to send to frmDataSyncProgress for Transferring (up/down) of files (xml, images, etc.)

		Try
			'Dim tempDirectory As String = localDirectory
			Dim getDirectory As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(remoteDirectory), System.Net.FtpWebRequest)

			With getDirectory
				.Credentials = New System.Net.NetworkCredential(My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred)
				.KeepAlive = False
				.UseBinary = True
				.Method = System.Net.WebRequestMethods.Ftp.ListDirectory
			End With

			Dim sr As New System.IO.StreamReader(getDirectory.GetResponse().GetResponseStream())
			Dim line = sr.ReadLine()
			Dim lines As New List(Of String)


			Do Until line Is Nothing
				lines.Add(line)
				line = sr.ReadLine()
			Loop

			Return lines.ToArray()

		Catch ex As Exception
			Return Nothing
			MessageBox.Show(ex.Message, "GetFilesFromFtp()")

		End Try


	End Function

	'Public Shared Sub GetImageFromFTP(ByVal remoteDirectory As String, ByVal thisFileName As String, ByVal localdirectory As String)

	'	Try
	'		Dim tempDirectory As String = localdirectory
	'		Dim ext As String = Path.GetExtension(thisFileName)
	'		If (ext = ".jpg" Or ext = ".gif" Or ext = ".png" Or ext = ".bmp" Or ext = ".JPG" Or ext = ".GIF" Or ext = ".PNG" Or ext = ".BMP") Then
	'			Dim astr() As String = thisFileName.Split(New Char() {"_"c})
	'			Dim jobNumber As String = astr(2)
	'			Dim picDate As String = astr(4)
	'			localdirectory = tempDirectory & jobNumber & "/Images/Pic_" & picDate & "/"
	'			If Not Directory.Exists(localdirectory) Then
	'				Directory.CreateDirectory(localdirectory)
	'			End If
	'		End If

	'		' Call Method to Download Images
	'		aeGetFiles(remoteDirectory, thisFileName, localdirectory)

	'	Catch ex As Exception
	'		MessageBox.Show(ex.Message, "GetImageFromFtp()")
	'	End Try
	'End Sub

	'Public Shared Sub GetFilesFromFtp(ByVal remoteDirectory As String, ByVal localDirectory As String)
	'	Try
	'		Dim tempDirectory As String = localDirectory
	'		Dim getDirectory As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(remoteDirectory), System.Net.FtpWebRequest)

	'		With getDirectory
	'			.Credentials = New System.Net.NetworkCredential(My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred)
	'			.KeepAlive = False
	'			.UseBinary = True
	'			.Method = System.Net.WebRequestMethods.Ftp.ListDirectory
	'		End With

	'		Dim sr As New System.IO.StreamReader(getDirectory.GetResponse().GetResponseStream())
	'		Dim fileArray() As String = Split(sr.ReadToEnd, vbCrLf)
	'		Dim i As Integer = -1
	'		For Each file In fileArray
	'			Dim ext As String = Path.GetExtension(file)
	'			If (ext = ".jpg" Or ext = ".gif" Or ext = ".png" Or ext = ".bmp" Or ext = ".JPG" Or ext = ".GIF" Or ext = ".PNG" Or ext = ".BMP") Then
	'				Dim astr() As String = file.Split(New Char() {"_"c})
	'				Dim jobNumber As String = astr(2)
	'				Dim picDate As String = astr(4)
	'				localDirectory = tempDirectory & jobNumber & "/Images/Pic_" & picDate & "/"
	'				If Not Directory.Exists(localDirectory) Then
	'					Directory.CreateDirectory(localDirectory)
	'				End If
	'			End If
	'			aeGetFiles(remoteDirectory, file, localDirectory)
	'			If file IsNot Nothing Then i += 1
	'			'moveFile(remoteDirectory, file.ToString)
	'		Next
	'		sr.Close()
	'		MessageBox.Show("Number of files transferred: " & i.ToString)

	'	Catch ex As Exception
	'		MessageBox.Show(ex.Message, "GetFilesFromFtp()")
	'	End Try
	'End Sub


	' Had to change this Method name becuase the Framework alread has a Method called GetFiles in the Directory Class  -jk 07.20.2011

	'Private Shared Sub aeGetFiles(ByVal remoteDirectory As String, ByVal filename As String, ByVal localDirectory As String)
	'	Try
	'		Dim getFile As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(remoteDirectory & filename), System.Net.FtpWebRequest)

	'		With getFile
	'			.Credentials = New System.Net.NetworkCredential(My.Settings.ae_FTPuserName, My.Settings.ae_FTPuserCred)
	'			.KeepAlive = False
	'			.UseBinary = True
	'			.Method = System.Net.WebRequestMethods.Ftp.DownloadFile
	'		End With

	'		'?
	'		Dim pathToUse As String = Nothing

	'		Using response As System.Net.FtpWebResponse = CType(getFile.GetResponse, System.Net.FtpWebResponse)
	'			Using responseStream As IO.Stream = response.GetResponseStream

	'				Using fs As New IO.FileStream(localDirectory & filename, IO.FileMode.Create)
	'					Dim buffer(2047) As Byte
	'					Dim read As Integer = 0
	'					Do
	'						read = responseStream.Read(buffer, 0, buffer.Length)
	'						fs.Write(buffer, 0, read)
	'					Loop Until read = 0

	'					'responseStream.Close()
	'					'fs.Flush()
	'					'fs.Close()

	'				End Using
	'				'responseStream.Close()
	'			End Using
	'			'response.Close()
	'		End Using

	'	Catch ex As Exception
	'		'MessageBox.Show(ex.Message, "GetFiles()")

	'	End Try
	'End Sub

	Public Shared Sub InitializeMySettings()

		' Main Local Application Path
		My.Settings.ae_AppPath = "c:\ActionEntry\"

		My.Settings.ae_ColumnLeftMin = 80
		My.Settings.ae_ColumnRightMin = 44

		My.Settings.ae_DataSyncComplete = False
		My.Settings.ae_SubmitSysInfo = True


		' Local Application Path for DailyProduction/NPI's XML DataSync File locations
		My.Settings.ae_DataSyncPath = "C:\ActionEntry\DataSync\DataFiles\XML_dP\"

		' Path for storing in the Warehouse
		My.Settings.ae_WarehouseXml = "C:\ActionEntry\Warehouse\Xml\"

		' PunchList/DeBug XML DataSync File Location
		My.Settings.ae_DebugPath = "C:\ActionEntry\DataSync\DataFiles\XML_deBug\"


		'ActionMessages
		My.Settings.am_NewMessagePath = "C:\ActionEntry\ActionMessages\amNew\"
		My.Settings.am_InBox = "C:\ActionEntry\ActionMessages\amInBox\"
		My.Settings.am_OutBox = "C:\ActionEntry\ActionMessages\amOutBox\"
		My.Settings.am_Deleted = "C:\ActionEntry\ActionMessages\amDeleted\"
		My.Settings.am_Sent = "C:\ActionEntry\ActionMessages\amSent\"

		My.Settings.am_FTPNewMessage = "ftp://03294ad.netsolhost.com/www/ActionEntry/ActionMessages/amFTPNew/"
		My.Settings.am_FTPArchive = "ftp://03294ad.netsolhost.com/www/ActionEntry/ActionMessages/amFTPArchive/"



		My.Settings.ae_FTPDataSyncURL = "ftp://03294ad.netsolhost.com/www/ActionEntry/dpdatasync/Foreign/Xml/"
		My.Settings.ae_FTPdeBugPath = "ftp://03294ad.netsolhost.com/www/ActionEntry/dpdatasync/deBug/"
		My.Settings.ae_FTPImageSyncURL = "ftp://03294ad.netsolhost.com/www/ActionEntry/dpdatasync/Foreign/Images/"
		My.Settings.ae_FTPuserCred = "J0hns0n5182"
		My.Settings.ae_FTPuserName = "jazfunkftp"
		My.Settings.ae_ImagePath = "C:\ActionEntry\signImages\"

		My.Settings.ae_signHeightMin = 80

		My.Settings.atmLocalDataSync = "C:\ActionEntry\DataSync\LocalDataSync\"
		My.Settings.atmServerDataSync = "\\attermserv01\company data\Action\aeDataSync\"
		My.Settings.ae_ProductionConStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=\\attermserv01\company data\Action\ActionEntry.mdb"
		My.Settings.atmServerWarehouseXmlPath = "\\attermserv01\Company Data\Action\aeDataSync\Warehouse\"
		My.Settings.atmProductionConStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=\\attermserv01\company data\Action\Action Traffic.mdb"

		'My.settings.ae_TransferDataSyncPath is used so we do not have to find and change where the settings need to be changed 
		'depending on if the computer is connected to the server
		My.Settings.ae_TransferDataSyncPath = My.Settings.atmLocalDataSync

		My.Settings.localImagesPath = "C:\ActionEntry\FTP\Images\"
		My.Settings.atmImagesPath = "\\attermserv01\company data\jobs\"

		'My.settings.ae_TransferImagesPath is used so we do not have to find and change where the settings need to be changed 
		'depending on if the computer is connected to the server
		My.Settings.ae_DownloadImagePath = My.Settings.localImagesPath

		My.Settings.ae_TransferImagePath = "C:\ActionEntry\picUpload\"

		My.Settings.ae_TimeSheetTxtPath = "C:\ActionEntry\DataSync\DataFiles\TXT_TimeSheet\"
		My.Settings.ae_WarehouseTimeSheet = "C:\ActionEntry\Warehouse\TimeSheetTxt\"

		My.Settings.ae_MailUserName = "ActionEntry@gmail.com"
		My.Settings.ae_MailCred = "actionentry5182"

		My.Settings.ae_FTProotSync = "ftp://03294ad.netsolhost.com/www/ActionEntry/RootSync/ActionEntry.mdb"
		My.Settings.ae_FtpTime = "ftp://03294ad.netsolhost.com/www/ActionEntry/dpdatasync/Foreign/TimeSheet/"

		My.Settings.ae_SilicaExposure = False
		My.Settings.ae_100AirMile = False

		My.Settings.expDeclWarehousePath = "C:\ActionEntry\Warehouse\expDecl\"
		My.Settings.expDeclPath = "C:\ActionEntry\DataSync\DataFiles\XML_ExpDeclaration\"
		My.Settings.ae_FTPexpDecl = "ftp://03294ad.netsolhost.com/www/ActionEntry/dpdatasync/Foreign/ExpDeclaration/"

		My.Settings.aeDocumentsPath = "c:\ActionEntry\aeDocuments\"


		' I've disabled "Save My.Settings on Shutdown" and doing so manually
		' to hopefully resolve an error on all the netbooks (Atom processors)
		My.Settings.Save()



	End Sub

	Public Shared Sub InitializeUserAccess(ByVal i As Integer)

		Select Case i

			Case Is <= 6, 113, 142, 174

				AE_mdiMain.ToolStripDropDownButtonTesting.Enabled = True

				frmAE_Home.btnReviewDP.Enabled = True
				frmAE_Home.btnRecieveImages.Enabled = True
				'frmAE_Home.btnViewImages.Enabled = True
				frmAE_Home.btnTime.Enabled = True

				frmAE_Home.btnDeBugging.Visible = True
				frmAE_Home.btnUploadDeBug.Visible = True

				frmAE_Home.btnSync.Enabled = True

			Case 49	 ' HSC

				'My.Settings.ae_CurrentJob = "1338b"

				AE_mdiMain.ToolStripDropDownButtonTesting.Enabled = False
				frmAE_Home.Panel3.Enabled = False
				frmAE_Home.btnUtilityHits.Enabled = False
				frmAE_Home.btnTransferImages.Enabled = False
				frmAE_Home.btnUploadImages.Enabled = False


				frmAE_Home.btnReviewDP.Enabled = False
				frmAE_Home.btnRecieveImages.Enabled = False
				frmAE_Home.btnViewImages.Enabled = False
				frmAE_Home.btnTime.Enabled = False

				frmAE_Home.btnDeBugging.Visible = False
				frmAE_Home.btnUploadDeBug.Visible = False

				frmAE_Home.btnSync.Enabled = False




			Case 50, 51	 ' J&J

				'My.Settings.ae_CurrentJob = "1338a"

				AE_mdiMain.ToolStripDropDownButtonTesting.Enabled = False
				frmAE_Home.Panel3.Enabled = False
				frmAE_Home.btnUtilityHits.Enabled = False
				frmAE_Home.btnTransferImages.Enabled = False
				frmAE_Home.btnUploadImages.Enabled = False


				frmAE_Home.btnReviewDP.Enabled = False
				frmAE_Home.btnRecieveImages.Enabled = False
				frmAE_Home.btnViewImages.Enabled = False
				frmAE_Home.btnTime.Enabled = False

				frmAE_Home.btnDeBugging.Visible = False
				frmAE_Home.btnUploadDeBug.Visible = False

				frmAE_Home.btnSync.Enabled = False



			Case Else

				AE_mdiMain.ToolStripDropDownButtonTesting.Enabled = False
				frmAE_Home.Panel3.Enabled = False

				frmAE_Home.btnReviewDP.Enabled = False
				frmAE_Home.btnRecieveImages.Enabled = False
				'frmAE_Home.btnViewImages.Enabled = True
				frmAE_Home.btnTime.Enabled = False

				frmAE_Home.btnDeBugging.Visible = False
				frmAE_Home.btnUploadDeBug.Visible = False

				frmAE_Home.btnSync.Enabled = False

		End Select

	End Sub

	Public Shared Function AtWorkOrNot() As Boolean

		Dim x As String = Nothing

		Try
			If My.Computer.Network.IsAvailable AndAlso My.Computer.Network.Ping("attermserv01") Then

				My.Settings.ae_TransferDataSyncPath = My.Settings.atmServerDataSync
				My.Settings.ae_DownloadImagePath = My.Settings.atmImagesPath

				Return True
			Else
				Return False

			End If

		Catch ex As Exception

			My.Settings.ae_TransferDataSyncPath = My.Settings.atmLocalDataSync
			My.Settings.ae_DownloadImagePath = My.Settings.localImagesPath

			' I've disabled "Save My.Settings on Shutdown" and doing so manually
			' to hopefully resolve an error on all the netbooks (Atom processors)
			My.Settings.Save()

			Return False
		End Try

		' I've disabled "Save My.Settings on Shutdown" and doing so manually
		' to hopefully resolve an error on all the netbooks (Atom processors)
		My.Settings.Save()


	End Function

	Public Shared Function InitializeForemanDictionary() As Dictionary(Of Integer, String)

		Dim dct As New Dictionary(Of Integer, String)

		With dct
			.Add(1, "Jeff")
			.Add(2, "Michael")
			.Add(7, "Donny")
			.Add(8, "Branden")
			.Add(9, "Mike")
			.Add(14, "Fred")
			.Add(25, "Gabe")
			.Add(22, "Tommy")
			.Add(10, "Jimmy")
			.Add(3, "Paul")
			.Add(20, "Ryan")
			.Add(6, "Luke")
			.Add(29, "Russ")
			.Add(11, "Bo")
			.Add(34, "Mario")
			.Add(49, "HSC")
			.Add(50, "JNJ")
			.Add(51, "JNJ2")
			.Add(23, "Tony")
			.Add(28, "Andy")
			.Add(58, "Mike J")
			.Add(46, "Paul V")
			.Add(30, "Adam")
			.Add(15, "Sean")
			.Add(31, "Jay")
			.Add(75, "Dewayne")
			.Add(43, "Andy P")
			.Add(35, "Mitch")
			.Add(88, "Alvin")
			.Add(85, "James Pattan")
			.Add(86, "Jay Ladd")
			.Add(94, "Dan M")
			.Add(112, "HSC")
			.Add(114, "Joel P")
			.Add(73, "Tracy B")
			.Add(83, "Colton")
			.Add(120, "Patsy")
			.Add(36, "Trevor")
			.Add(72, "Rob")
			.Add(104, "Bob S Jr")
			.Add(115, "David Knight")
			.Add(130, "Stephen Humphries")
			.Add(142, "TJ")
			.Add(47, "Greg Waldron")
			.Add(167, "Brenden")
			.Add(40, "Mac")
			.Add(174, "Bryce")
			.Add(192, "Chris")
			.Add(79, "Paul Charest")
			.Add(143, "Kevin Monzo")
			.Add(214, "Edward Wickham")
			.Add(64, "Michael Siagkris")
			.Add(117, "Matt Criner")
			.Add(199, "Mario Hernandez")
			.Add(244, "Ed Trombley")
			.Add(245, "James Chinvavare")

			.Add(223, "Foreman-Z1")
			.Add(224, "Foreman-Z2")
			.Add(225, "Foreman-Z3")
			.Add(226, "Foreman-Z4")
			.Add(227, "Foreman-Z5")
			.Add(228, "Foreman-Z6")
			.Add(229, "Foreman-Z7")
			.Add(230, "Foreman-Z8")
			.Add(231, "Foreman-Z9")

			

		End With

		Return dct

	End Function

	''' <summary>
	''' Determines which Home Page to show based on userID
	''' </summary>
	''' <param name="userID"></param>
	''' <remarks></remarks>
	Public Shared Sub ShowHome(ByVal userID As Integer)


		Dim x As Integer = 0


		'' Testing
		'For Each f As Form In AE_mdiMain.MdiChildren
		'	If f.Name = "frmAE_HomeExpress" Then
		'		x += 1
		'		f.Show()
		'	End If
		'Next
		'' No Home form currently exists, so create one.
		'If Not x > 0 Then
		'	Dim showHome As New frmAE_HomeExpress
		'	showHome.MdiParent = AE_mdiMain
		'	showHome.Show()
		'End If


		' LIVE CODE
		Select Case userID
			Case 0 To 2222	'  6, 7, 9, 14, 22 - This used to limit based on specific users, not anymore.
				For Each f As Form In AE_mdiMain.MdiChildren
					'If f.Name = "frmAE_Home" Then f.Show()
					If f.Name = "frmAE_Home" Then
						x += 1
						f.Show()
					End If
				Next
				' No Home form currently exists, so create one.
				If Not x > 0 Then
					Dim showHome As New frmAE_Home
					showHome.MdiParent = AE_mdiMain
					showHome.Show()
				End If

			Case Else
				For Each f As Form In AE_mdiMain.MdiChildren
					'If f.Name = "frmAE_HomeExpress" Then f.Show()
					If f.Name = "frmAE_HomeExpress" Then
						x += 1
						f.Show()
					End If
				Next
				' No Home form currently exists, so create one.
				If Not x > 0 Then
					Dim showHome As New frmAE_HomeExpress
					showHome.MdiParent = AE_mdiMain
					showHome.Show()
				End If

		End Select



	End Sub

#End Region



#Region " Functions"


	' Function returns a DataSet based on xml file provided
	Public Shared Function ReadDataSyncToDataSet(ByVal DataSyncToClean As String) As DataSet
		Dim cleanDS As DataSet
		Try
			cleanDS = New DataSet(Path.GetFileName(DataSyncToClean))
			cleanDS.ReadXml(DataSyncToClean)
		Catch ex As Exception
			cleanDS = Nothing
		End Try
		Return cleanDS
	End Function


	Public Shared Function UsingNumericTryParseMyWay(ByVal objInput As Object) As Integer

		Dim intOutput As Integer = Nothing
		' Double.TryParse Method returns a Boolean Value
		' indicating whether the String passed to the 
		' Method successfully converted to an Integer Value
		If Not Integer.TryParse(objInput.ToString, intOutput) Then
			' False indicates the Object.TosTring Value did
			' not convert to an Integer Value
			Return 0
		Else
			' Trude indicates the Object.Tostring Value did
			' successfully convert to an Integer Value
			Return intOutput
		End If

	End Function



	''' <summary>
	''' Split the words in string on non-word characters.
	''' This means commas and periods are handled correctly.
	''' </summary>
	Public Shared Function SplitWords(ByVal s As String) As String()
		'
		' Call Regex.Split function from the imported namespace.
		' Return the result array.
		'
		Return Regex.Split(s, "\W+")
	End Function




	Public Shared Function FileNameOnly(ByVal thePath As String) As String
		Dim result As String
		Try
			result = Path.GetFileName(thePath)
			Return result
		Catch ex As Exception
			result = Nothing
		End Try
		Return result
	End Function

	Public Shared Function BuildXmlName(ByVal prefix As String, ByVal jobNum As String, ByVal d8 As String) As String

		Dim filename As String = prefix & "_" & _
		 My.Settings.ae_UserID.ToString & "_" & _
		 jobNum & "_" & _
		 d8 & ".xml"

		Return filename

	End Function


	''' <summary>
	''' used for xml file that need to contain the station number i.e. utility hit
	''' </summary>
	''' <param name="prefix">String</param>
	''' <param name="jobNum">String</param>
	''' <param name="stationNo">String</param>
	''' <param name="d8">String</param>
	''' <returns>Filename as string with extension</returns>
	''' <remarks>Used for filenames containing station number UH</remarks>
	Public Shared Function BuildXmlName(ByVal prefix As String, ByVal jobNum As String, ByVal stationNo As String, ByVal d8 As String) As String

		Dim filename As String = prefix & "_" & _
		My.Settings.ae_UserID & "_" & _
		jobNum & "_" & _
		stationNo & "_" & _
		d8 & ".xml"

		Return filename

	End Function






	' Integer value if Internet connection is currently configured
	Public Const InternetConnectionIsConfigured As Integer = &H40S

	''' <summary>
	''' Found this on the internet, checks for an internet connection
	''' </summary>
	''' <param name="lpdwFlags">I have no idea</param>
	''' <param name="dwReserved">No clue</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Declare Function InternetGetConnectedState Lib "wininet.dll" (ByRef lpdwFlags As Integer, ByVal dwReserved As Integer) As Integer


#End Region





#Region " Testing, Misc, Sample Code and Errant Code, etc."

	Private Sub DemonstrateReadWriteXMLDocumentWithStreamReader()
		' Create a DataSet with one table and two columns.
		Dim OriginalDataSet As New DataSet("dataSet")
		OriginalDataSet.Namespace = "NetFrameWork"
		Dim table As New DataTable("table")
		Dim idColumn As New DataColumn("id", _
		 Type.GetType("System.Int32"))
		idColumn.AutoIncrement = True

		Dim itemColumn As New DataColumn("item")
		table.Columns.Add(idColumn)
		table.Columns.Add(itemColumn)
		OriginalDataSet.Tables.Add(table)

		' Add ten rows.
		Dim newRow As DataRow
		Dim i As Integer
		For i = 0 To 9
			newRow = table.NewRow()
			newRow("item") = "item " & i.ToString()
			table.Rows.Add(newRow)
		Next i
		OriginalDataSet.AcceptChanges()

		' Print out values of each table in the DataSet 
		' using the function defined below.
		PrintValues(OriginalDataSet, "Original DataSet")

		' Write the schema and data to an XML file.
		Dim xmlFilename As String = "XmlDocument.xml"

		' Use WriteXml to write the document.
		OriginalDataSet.WriteXml(xmlFilename)

		' Dispose of the original DataSet.
		OriginalDataSet.Dispose()

		' Create a new DataSet.
		Dim newDataSet As New DataSet("New DataSet")

		' Read the XML document into the DataSet.
		newDataSet.ReadXml(xmlFilename)

		' Print out values of each table in the DataSet 
		' using the function defined below.
		PrintValues(newDataSet, "New DataSet")
	End Sub

	Private Sub PrintValues(ByVal dataSet As DataSet, ByVal label As String)
		Console.WriteLine(ControlChars.Cr & label)
		Dim table As DataTable
		For Each table In dataSet.Tables
			Console.WriteLine("TableName: " & table.TableName)
			Dim row As DataRow
			For Each row In table.Rows
				Dim column As DataColumn
				For Each column In table.Columns
					Console.Write(ControlChars.Tab & " " & _
					 row(column).ToString())
				Next column
				Console.WriteLine()
			Next row
		Next table
	End Sub


	Private Sub fuckYou(ByVal fileName As String)
		Dim driveNames As New List(Of String)
		For Each drive As DriveInfo In My.Computer.FileSystem.Drives
			driveNames.Add(drive.Name)
		Next




		Try
			My.Computer.Network.DownloadFile(My.Settings.ae_FTPDataSyncURL & _
			fileName, My.Settings.ae_DataSyncPath & fileName, _
			My.Settings.ae_FTPuserName, _
			My.Settings.ae_FTPuserCred, True, 30000, False)

		Catch ex As Exception
			MessageBox.Show(ex.Message, "XmlUpload()")
		End Try




	End Sub


	Public Shared Function GenerateHash(ByVal SourceText As String) As String
		'***********************************************************************************************
		'	\\Vitals:
		'***********************************************************************************************
		'****************All Code, Logic, Concepts And DBMS Developed For And Owned By:****************'
		'	Action Traffic Maintenance, Inc.
		'	Michigan Highway Signs, Inc.
		'	Jeff King......:  Lead Software Engineer/DBMS Manager
		'	Luke McClain...:  Software Developer/Hardware Technician
		'	Michael Peake..:  Systems Consultant/End User-Administrative
		'	Paul Roth......:  Systems Consultant/End User-Administrative
		'***********************************************************************************************
		'	\\Keys:
		'***********************************************************************************************
		'	Purpose....:  Generates an MD5-Hash (One-Way Direct Encryption) String to Authenticate Strings.  
		'				  -(i.e. Passwords, Connection Strings, etc.)
		'	Input......:  String to Hash (Encrypt)
		'	Output.....:  Encrypted (MD5-Hash) String
		'	Issues.....:  -Untested
		'				  -Where/How to use/call/run is TBD
		'				  -Validity of claims unproven in ActionEntry
		'				  -I found a hack for the MD5 hash in 1 minute - Google!
		'				  -Should we consider another encryption/hashing method?
		'	Sample Use.:  Dim myString As String = GenerateHash.Md5(txtInput.Text)
		'***********************************************************************************************


		Try
			' Create an encoding object to ensure the encoding standard for the source text
			Dim Ue As New UnicodeEncoding()
			' Retrieve a byte array based on the source text
			Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
			' Instantiate an MD5 Provider object
			Dim Md5 As New MD5CryptoServiceProvider()
			' Compute the hash value from the source
			Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
			' And convert it to String format for return
			Return Convert.ToBase64String(ByteHash)
		Catch ex As Exception
			Return Nothing
		End Try
	End Function



	Private Sub TestingGAC_CodeBase()

		'' Is this useful to us?
		'' ClickOnce installs to a generic, per-user/session location.
		'' This should allow us to obtain info/data/files  in that location

		''System.Reflection.Assembly.GetExecutingAssembly().CodeBase


	End Sub





	'Public Shared Function CreateDailyDataSync(ByVal fileName As String) As Boolean

	'	'Try
	'	'	If Not File.Exists(My.Settings.ae_DataSyncPath & fileName) Then
	'	'		MessageBox.Show("'OK' to create your daily DataSync File", "Utilities - CreateDailyDataSync()")
	'	'		File.Create(My.Settings.ae_DataSyncPath & fileName)

	'	'		Return False

	'	'	Else
	'	'		MessageBox.Show("DataSync File detected.", "DataSync")

	'	'		Return True

	'	'	End If
	'	'Catch ex As Exception
	'	'	MessageBox.Show(ex.Message, "CreateDailyDataSync()")

	'	'	Return False

	'	'End Try


	'	' '' This line of code does basically the same thing as the code above
	'	''MessageBox.Show(If(File.Exists(fileName), "File exists.", "File does not exist."), "CreateDailyDataSync()")




	'End Function


	' String Encryption








#End Region


























End Class
