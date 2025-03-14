<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('equipement_ferry', function (Blueprint $table) {
            $table->id();
            $table->integer("nbEquipements");
            $table->timestamps();

            $table->foreignId("ferry_id")
                ->constrained()
                ->onUpdate('cascade')
                ->onDelete('cascade');

            $table->foreignId("equipement_id")
                ->constrained()
                ->onUpdate('cascade')
                ->onDelete('cascade');
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('equipement_ferry');
    }
};
