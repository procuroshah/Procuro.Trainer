using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LearningManagementSystem.ApiService.Infrastructure.EfCore.Migrations.Application
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "catalog");

            migrationBuilder.CreateTable(
                name: "courses",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    full_description = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_courses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "group",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_group", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "learning_paths",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_learning_paths", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    password_hash = table.Column<string>(type: "text", nullable: true),
                    role = table.Column<int>(type: "integer", nullable: false),
                    external_user_id = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sections",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    course_id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sections", x => x.id);
                    table.ForeignKey(
                        name: "fk_sections_courses_course_id",
                        column: x => x.course_id,
                        principalSchema: "catalog",
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "group_learning_path",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    group_id = table.Column<Guid>(type: "uuid", nullable: false),
                    learning_path_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_group_learning_path", x => x.id);
                    table.ForeignKey(
                        name: "fk_group_learning_path_group_group_id",
                        column: x => x.group_id,
                        principalSchema: "catalog",
                        principalTable: "group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_group_learning_path_learning_paths_learning_path_id",
                        column: x => x.learning_path_id,
                        principalSchema: "catalog",
                        principalTable: "learning_paths",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "learning_path_courses",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    learning_path_id = table.Column<Guid>(type: "uuid", nullable: false),
                    course_id = table.Column<Guid>(type: "uuid", nullable: false),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_learning_path_courses", x => x.id);
                    table.ForeignKey(
                        name: "fk_learning_path_courses_courses_course_id",
                        column: x => x.course_id,
                        principalSchema: "catalog",
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_learning_path_courses_learning_paths_learning_path_id",
                        column: x => x.learning_path_id,
                        principalSchema: "catalog",
                        principalTable: "learning_paths",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medias",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    file_name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    file_type = table.Column<int>(type: "integer", nullable: false),
                    url = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    uploaded_by_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_medias", x => x.id);
                    table.ForeignKey(
                        name: "fk_medias_user_uploaded_by_id",
                        column: x => x.uploaded_by_id,
                        principalSchema: "catalog",
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_group",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    group_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_group", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_group_group_group_id",
                        column: x => x.group_id,
                        principalSchema: "catalog",
                        principalTable: "group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_group_user_user_id",
                        column: x => x.user_id,
                        principalSchema: "catalog",
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "activities",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    section_id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    description_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    additional_info = table.Column<string>(type: "text", nullable: true),
                    additional_info_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    type = table.Column<int>(type: "integer", nullable: false),
                    milestone_id = table.Column<Guid>(type: "uuid", nullable: true),
                    order = table.Column<int>(type: "integer", nullable: false),
                    enabled = table.Column<bool>(type: "boolean", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_activities", x => x.id);
                    table.ForeignKey(
                        name: "fk_activities_sections_section_id",
                        column: x => x.section_id,
                        principalSchema: "catalog",
                        principalTable: "sections",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "activity_video_options",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    activity_id = table.Column<Guid>(type: "uuid", nullable: false),
                    media_id = table.Column<Guid>(type: "uuid", nullable: true),
                    width = table.Column<int>(type: "integer", nullable: false),
                    height = table.Column<int>(type: "integer", nullable: false),
                    auto_play = table.Column<bool>(type: "boolean", nullable: false),
                    maximize_content = table.Column<bool>(type: "boolean", nullable: false),
                    allow_fullscreen = table.Column<bool>(type: "boolean", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_activity_video_options", x => x.id);
                    table.ForeignKey(
                        name: "fk_activity_video_options_activities_activity_id",
                        column: x => x.activity_id,
                        principalSchema: "catalog",
                        principalTable: "activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_activity_video_options_medias_media_id",
                        column: x => x.media_id,
                        principalSchema: "catalog",
                        principalTable: "medias",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "milestone_requirement_types",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    activity_id = table.Column<Guid>(type: "uuid", nullable: false),
                    requirement_type = table.Column<int>(type: "integer", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_milestone_requirement_types", x => x.id);
                    table.ForeignKey(
                        name: "fk_milestone_requirement_types_activities_activity_id",
                        column: x => x.activity_id,
                        principalSchema: "catalog",
                        principalTable: "activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "quizzes",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    activity_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_quizzes", x => x.id);
                    table.ForeignKey(
                        name: "fk_quizzes_activities_activity_id",
                        column: x => x.activity_id,
                        principalSchema: "catalog",
                        principalTable: "activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_activity",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    learning_path_id = table.Column<Guid>(type: "uuid", nullable: false),
                    activity_id = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_activity", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_activity_activities_activity_id",
                        column: x => x.activity_id,
                        principalSchema: "catalog",
                        principalTable: "activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_activity_learning_paths_learning_path_id",
                        column: x => x.learning_path_id,
                        principalSchema: "catalog",
                        principalTable: "learning_paths",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_activity_user_user_id",
                        column: x => x.user_id,
                        principalSchema: "catalog",
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "milestone_prop",
                schema: "catalog",
                columns: table => new
                {
                    activity_milestone_requirements_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    minimum_pct = table.Column<int>(type: "integer", nullable: false),
                    media_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_milestone_prop", x => new { x.activity_milestone_requirements_id, x.id });
                    table.ForeignKey(
                        name: "fk_milestone_prop_medias_media_id",
                        column: x => x.media_id,
                        principalSchema: "catalog",
                        principalTable: "medias",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_milestone_prop_milestone_requirement_types_activity_milesto",
                        column: x => x.activity_milestone_requirements_id,
                        principalSchema: "catalog",
                        principalTable: "milestone_requirement_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "activity_quiz_options",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    activity_id = table.Column<Guid>(type: "uuid", nullable: false),
                    quiz_id = table.Column<Guid>(type: "uuid", nullable: true),
                    allow_retakes = table.Column<bool>(type: "boolean", nullable: false),
                    retake_amount = table.Column<int>(type: "integer", nullable: false),
                    retake_unlimited = table.Column<bool>(type: "boolean", nullable: false),
                    hide_correct_answers = table.Column<bool>(type: "boolean", nullable: false),
                    time_limit_minutes = table.Column<int>(type: "integer", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_activity_quiz_options", x => x.id);
                    table.ForeignKey(
                        name: "fk_activity_quiz_options_activities_activity_id",
                        column: x => x.activity_id,
                        principalSchema: "catalog",
                        principalTable: "activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_activity_quiz_options_quizzes_quiz_id",
                        column: x => x.quiz_id,
                        principalSchema: "catalog",
                        principalTable: "quizzes",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "quiz_questions",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    quiz_id = table.Column<Guid>(type: "uuid", nullable: false),
                    question_text = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_quiz_questions", x => x.id);
                    table.ForeignKey(
                        name: "fk_quiz_questions_quizzes_quiz_id",
                        column: x => x.quiz_id,
                        principalSchema: "catalog",
                        principalTable: "quizzes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "quiz_options",
                schema: "catalog",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    quiz_question_id = table.Column<Guid>(type: "uuid", nullable: false),
                    option_text = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    is_correct = table.Column<bool>(type: "boolean", nullable: false),
                    created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_modified = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    last_modified_by = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_quiz_options", x => x.id);
                    table.ForeignKey(
                        name: "fk_quiz_options_quiz_questions_quiz_question_id",
                        column: x => x.quiz_question_id,
                        principalSchema: "catalog",
                        principalTable: "quiz_questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_activities_section_id",
                schema: "catalog",
                table: "activities",
                column: "section_id");

            migrationBuilder.CreateIndex(
                name: "ix_activity_quiz_options_activity_id",
                schema: "catalog",
                table: "activity_quiz_options",
                column: "activity_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_activity_quiz_options_quiz_id",
                schema: "catalog",
                table: "activity_quiz_options",
                column: "quiz_id");

            migrationBuilder.CreateIndex(
                name: "ix_activity_video_options_activity_id",
                schema: "catalog",
                table: "activity_video_options",
                column: "activity_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_activity_video_options_media_id",
                schema: "catalog",
                table: "activity_video_options",
                column: "media_id");

            migrationBuilder.CreateIndex(
                name: "ix_group_learning_path_group_id",
                schema: "catalog",
                table: "group_learning_path",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "ix_group_learning_path_learning_path_id",
                schema: "catalog",
                table: "group_learning_path",
                column: "learning_path_id");

            migrationBuilder.CreateIndex(
                name: "ix_learning_path_courses_course_id",
                schema: "catalog",
                table: "learning_path_courses",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "ix_learning_path_courses_learning_path_id",
                schema: "catalog",
                table: "learning_path_courses",
                column: "learning_path_id");

            migrationBuilder.CreateIndex(
                name: "ix_medias_uploaded_by_id",
                schema: "catalog",
                table: "medias",
                column: "uploaded_by_id");

            migrationBuilder.CreateIndex(
                name: "ix_milestone_prop_media_id",
                schema: "catalog",
                table: "milestone_prop",
                column: "media_id");

            migrationBuilder.CreateIndex(
                name: "ix_milestone_requirement_types_activity_id",
                schema: "catalog",
                table: "milestone_requirement_types",
                column: "activity_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_quiz_options_quiz_question_id",
                schema: "catalog",
                table: "quiz_options",
                column: "quiz_question_id");

            migrationBuilder.CreateIndex(
                name: "ix_quiz_questions_quiz_id",
                schema: "catalog",
                table: "quiz_questions",
                column: "quiz_id");

            migrationBuilder.CreateIndex(
                name: "ix_quizzes_activity_id",
                schema: "catalog",
                table: "quizzes",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "ix_sections_course_id",
                schema: "catalog",
                table: "sections",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_activity_activity_id",
                schema: "catalog",
                table: "user_activity",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_activity_learning_path_id",
                schema: "catalog",
                table: "user_activity",
                column: "learning_path_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_activity_user_id",
                schema: "catalog",
                table: "user_activity",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_group_group_id",
                schema: "catalog",
                table: "user_group",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_group_user_id",
                schema: "catalog",
                table: "user_group",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "activity_quiz_options",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "activity_video_options",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "group_learning_path",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "learning_path_courses",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "milestone_prop",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "quiz_options",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "user_activity",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "user_group",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "medias",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "milestone_requirement_types",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "quiz_questions",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "learning_paths",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "group",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "user",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "quizzes",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "activities",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "sections",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "courses",
                schema: "catalog");
        }
    }
}
