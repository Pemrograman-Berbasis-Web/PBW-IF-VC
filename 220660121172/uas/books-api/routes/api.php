<?php

use App\Http\Controllers\Api\BookController; # Perhatikan 'Api' bukan 'API'
use Illuminate\Support\Facades\Route;

Route::prefix('v1')->group(function () {
    Route::apiResource('books', BookController::class);
});
