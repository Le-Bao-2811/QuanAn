using System;
using System.Collections.Generic;
using System.Text;

namespace QuanAnGiaDinh.Shared.Const
{
	public class DbConst
	{
		// 1
		// Bảng Article
		public const string ARTICLE_TABLE_NAME =						"Article";
		public const ushort ARTICLE_TITLE_MAX_LENGTH =					200;
		public const ushort ARTICLE_CONTENT_MAX_LENGTH =				500;
		public const ushort ARTICLE_THUMBNAIL_PATH_MAX_LENGTH =			300;
		public const ushort ARTICLE_URL_MAX_LENGTH =					200;
		
		// 2
		// Bảng ArticleComment
		public const string ARTICLE_COMMENT_TABLE_NAME =				"ArticleComment";
		public const ushort ARTICLE_COMMENT_EMAIL_MAX_LENGTH =			100;
		public const ushort ARTICLE_COMMENT_FULL_NAME_MAX_LENGTH =		50;
		public const ushort ARTICLE_COMMENT_CONTENT_MAX_LENGTH =		1000;

		// 3
		// Bảng ArticlePhoto
		public const string ARTICLE_PHOTO_TABLE_NAME =					"ArticlePhoto";
		public const ushort ARTICLE_PHOTO_PHOTO_PATH_MAX_LENGTH =		300;
		public const ushort ARTICLE_PHOTO_DESCRIPTION_MAX_LENGTH =		200;

		// 4
		// Bảng ArticleCategory
		public const string ARTICLE_CATEGORY_TABLE_NAME =				"ArticleCategory";
		public const ushort ARTICLE_CATEGORY_NAME_MAX_LENGTH =			200;

		// 5
		// Bảng ArticleUser
		public const string ARTICLE_USER_TABLE_NAME =					"ArticleUser";
		public const ushort ARTICLE_USER_USERNAME_MAX_LENGTH =			100;
		public const ushort ARTICLE_USER_PASSWORD_MAX_LENGTH =			200;
		public const ushort ARTICLE_USER_SALT_MAX_LENGTH =				200;
		public const ushort ARTICLE_USER_FULLNAME_MAX_LENGTH =			50;
		public const ushort ARTICLE_USER_AVATAR_PATH_MAX_LENGTH =		300;
		public const ushort ARTICLE_USER_ALILAS_MAX_LENGTH =			30;
		public const ushort ARTICLE_USER_EMAIL_MAX_LENGTH =				100;
		public const ushort ARTICLE_USER_PHONE_NUMBER_MAX_LENGTH =		20;
		public const ushort ARTICLE_USER_ID_CARDNUMBER_MAX_LENGTH =		30;
		public const ushort ARTICLE_USER_ADDRESS_MAX_LENGTH =			100;
		public const ushort ARTICLE_USER_SUMMARY_MAX_LENGTH =			300;

		// 6
		// Bảng ArticleKeyword
		public const string ARTICLE_KEYWORD_TABLE_NAME =				"ArticleKeyword";
		public const ushort ARTICLE_KEYWORD_UNICODE_MAX_LENGTH =		100;
		public const ushort ARTICLE_KEYWORD_ASCII_MAX_LENGTH =			100;

		// 7
		// Bảng SysArticleStatus
		public const string SYS_ARTICLE_STATUS_TABLE_NAME =				"SysArticleStatus";
		public const ushort SYS_ARTICLE_STATUS_NAME_MAX_LENGTH =		100;

		// 8
		// Bảng ReArticleKeyword
		public const string RE_ARTICLE_KEYWORD_TABLE_NAME =				"ReArticleKeyword";

		// 9
		// Bảng Policy
		public const string POLICY_TABLE_NAME =							"Policy";
		public const ushort POLICY_NAME_MAX_LENGTH =					50;
		public const ushort POLICY_DESCRIPTION_MAX_LENGTH =				200;
		// 10
		// Bảng Role
		public const string ROLE_TABLE_NAME =							"Role";
		public const ushort ROLE_NAME_MAX_LENGTH =						50;
		public const ushort ROLE_DESCRIPTION_MAX_LENGTH =				200;

		// 11
		// Bảng RePolicyRole
		public const string RE_POLICY_ROLE_TABLE_NAME =					"RePolicyRole";

	}
}
